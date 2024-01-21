using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Text.RegularExpressions;
using System.IO;

namespace Do_An_ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            txtP.Enabled = false;
            txtPhi.Enabled = false;
            txtQ.Enabled = false;
            txtN.Enabled = false;

            tbCiphertext.ReadOnly = true;
            tbPrivateKey.ReadOnly = true;
            tbPublicKey.ReadOnly = true;
            tbPlaintextDecryption.ReadOnly = true;
            tbCipherUploaded.ReadOnly = true;

            this.MaximizeBox = false; 
        }
        private BigInteger publicKey;
        private BigInteger privateKey;
        private BigInteger modulus;


        private void Form1_Load(object sender, EventArgs e)
        {
           
        
        }
       
        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            tbCiphertext.Clear();
            tbCipherUploaded.Clear();
            tbPlaintext.Clear();
            tbPlaintextDecryption.Clear();


            BigInteger p = GeneratePrimeNumber();
            BigInteger q = GeneratePrimeNumber();

            txtP.Text = p.ToString();
            txtQ.Text = q.ToString();   

            modulus = p * q;
            txtN.Text = modulus.ToString();
            BigInteger phiN = (p - 1) * (q - 1);
            txtPhi.Text = phiN.ToString();

            publicKey = ChooseE(phiN);
            privateKey = ModInverse(publicKey, phiN);
            tbPublicKey.Text = publicKey.ToString();
            tbPrivateKey.Text = privateKey.ToString();
            MessageBox.Show("Keys generated successfully!");
        }



        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (publicKey == 0 || modulus == 0)
                {
                    MessageBox.Show("Please generate key before!");
                    return;
                }

                string plaintext = tbPlaintext.Text;
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
                string base64Encrypted = Convert.ToBase64String(plaintextBytes);

                tbCiphertext.Text = base64Encrypted;
            }
            catch(Exception ex) { }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (privateKey == 0 || modulus == 0)
                {
                    MessageBox.Show("Please generate key before!");
                    return;
                }

                string base64Encrypted = tbCipherUploaded.Text;
                byte[] encryptedBytes = Convert.FromBase64String(base64Encrypted);
                string plaintext = Encoding.UTF8.GetString(encryptedBytes);

                tbPlaintextDecryption.Text = plaintext;
            }
            catch (Exception ex)
            {
            }
        }

        private BigInteger GeneratePrimeNumber()
        {
            Random random = new Random();

            while (true)
            {
                BigInteger number = random.Next(100, 10000);
                if (IsPrime(number))
                {
                    return number;
                }
            }
            
        }

        private bool IsPrime(BigInteger number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (BigInteger i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private BigInteger ChooseE(BigInteger phiN)
        {
            Random random = new Random();
            BigInteger e;

            do
            {
                e = GenerateRandomBigInteger(phiN, random);
            } while (BigInteger.GreatestCommonDivisor(e, phiN) != 1);

            return e;
        }

        private BigInteger GenerateRandomBigInteger(BigInteger maxValue, Random random)
        {
            byte[] bytes = maxValue.ToByteArray();
            random.NextBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F;
            return new BigInteger(bytes);
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0;
            BigInteger x = 1;

            if (m == 1)
            {
                return 0;
            }

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
            {
                x += m0;
            }

            return x;
        }

        private void btnUploadFilePlaintext_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                if (IsTextFile(selectedFilePath))
                {
                    string fileContent = ReadTextFile(selectedFilePath);
                    tbPlaintext.Text = fileContent;
                }
                else
                {
                    MessageBox.Show("The selected file is not a text file.");
                }
            }
        }

        private bool IsTextFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);

            return string.Equals(extension, ".txt", StringComparison.OrdinalIgnoreCase);
        }

        private string ReadTextFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }

        private void btnDownloadCiphertext_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.FileName = "output.txt"; // Đặt tên file mặc định

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = saveFileDialog.FileName;
                string textToWrite = tbCiphertext.Text;

                WriteTextToFile(textToWrite, selectedFilePath);

                MessageBox.Show("File downloaded successfully!");
            }
        }

        private void btnUploadFileCipher_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                if (IsTextFile(selectedFilePath))
                {
                    string fileContent = ReadTextFile(selectedFilePath);
                    tbCipherUploaded.Text = fileContent;
                }
                else
                {
                    MessageBox.Show("The selected file is not a text file.");
                }
            }
        }

        private void WriteTextToFile(string text, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(text);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbCiphertext.Clear();
            tbCipherUploaded.Clear();
            tbPlaintext.Clear();
            tbPlaintextDecryption.Clear();
            txtPhi.Clear();
            txtP.Clear();
            txtN.Clear();
            txtQ.Clear();
            tbPrivateKey.Clear();
            tbPublicKey.Clear();    
        }
    }
}
