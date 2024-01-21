using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace antoanmang
{
    public partial class Playfair : Form
    {
        int sizeMatrix = 5;
        private List<TextBox> cellText;
        private List<List<char>> matrix_2d;
        //kiểm tra xem người dùng có nhấn ctrl V vào textbox hay không
        private bool isPaste = false;
        char storeIorJ = '\0';
        public Playfair()
        {
            InitializeComponent();

            txtCiphertext.Enabled = false;
            txtSpText.Enabled = false;
            txtDecryptCipher.Enabled = false;

            matrix_2d = new List<List<char>>();

            List<TextBox> textBoxList = new List<TextBox>();
            cellText = new List<TextBox>();
            this.MaximizeBox = false; // Ẩn nút phóng to
            cb55.Checked = true; 
            cb66.Checked = false;


            // Duyệt qua tất cả các Control trong Form
            foreach (Control control in options.Controls)
            {
                // Kiểm tra nếu Control là TextBox
                if (control is TextBox textBox)
                {
                    // Thêm TextBox vào danh sách
                    textBoxList.Add(textBox);
                }
            }
            foreach (TextBox textBox in textBoxList)
            {
                if (textBox.Name.ToString().Contains("textBox"))
                {
                    cellText.Add(textBox);
                    textBox.Enabled = false;
                }
            }
            
            //hoán đổi lại vị trí của các textbox theo thứ tự tăng dần
            for(int i = 0; i < cellText.Count - 1; i++)
            {
                for(int j = i + 1; j < cellText.Count; j++) {
                    string eliminateText1 = cellText[i].Name.ToString().Substring(7);
                    string eliminateText2 = cellText[j].Name.ToString().Substring (7);

                    int firstNumber = int.Parse(eliminateText1);
                    int secondNumber = int.Parse(eliminateText2);

                    if(firstNumber > secondNumber)
                    {
                        TextBox temp = cellText[i];
                        cellText[i] = cellText[j];
                        cellText[j] = temp;
                    }
                }
            }


            initialMatrix(5);
        }

        public string playfair_algorithm_encryption(string plaintext)
        {
            //kiem tra xem xuat hien 2 ky tu lien tiep khong
            plaintext = insert_X_duplicate_chars(plaintext.Replace(" ", "")).Trim();
            string splitText = "", textEncoded = "";


            for (int index = 0; index < plaintext.Length; index += 2)
            {
                string pairOfCharacters = plaintext.Substring(index, 2);
                splitText += pairOfCharacters + ' ';
                textEncoded += find_new_characters(pairOfCharacters) + " ";
            }
            txtSpText.Text = splitText;

            return textEncoded;
        }

        public string playfair_algorithm_decryption(string cipherText)
        {
            string textDecoded = "";


            for (int index = 0; index < cipherText.Length; index += 3)
            {
                string pairOfCharacters = "";
                if (index + 3 < cipherText.Length)
                {
                    pairOfCharacters = cipherText.Substring(index, 3);
                }else
                {
                    pairOfCharacters = cipherText.Substring(index, 2);
                }
                textDecoded += convert_pairOf_Characters(pairOfCharacters) + " ";
            }
            return textDecoded;
        }
        public void initialMatrix(int size)
        {
            clearTextInCells();
            //gán mặc định A-Z cho ma trận 5*5 giao diện đầu tiên
            int letter = 65;
            int number = 0;
            foreach (TextBox cell in cellText)
            {
                string eliminateText = cell.Name.ToString().Substring(7);
                int cellNumber = int.Parse(eliminateText);

                if (size == 5)
                {
                    if (cellNumber % 6 != 0 && cellNumber < 31)
                    {
                        if (Convert.ToChar(letter) == 'J')
                        {
                            cell.Text = Convert.ToChar(++letter).ToString();
                            letter++;
                        }
                        else
                        {
                            cell.Text = Convert.ToChar(letter++).ToString();
                        }
                    }
                } else
                {
                    if (cellNumber < 27)
                    {
                        cell.Text = Convert.ToChar(letter++).ToString();
                    }
                    else
                    {
                        cell.Text = number++.ToString();
                    }
                }
            }

            //khởi tạo ma trận 2 chiều
            int index = 0;
            List<char> temp = new List<char>(); 
            foreach(TextBox cell in cellText)
            {
                if (cell.Text.ToString().Equals("")) continue;
                if(index == sizeMatrix)
                {
                    index = 0;
                    matrix_2d.Add(temp);
                    temp = new List<char>();
                }
                temp.Add(cell.Text.ToString()[0]);
                index++;
            }
        }
        public void clearTextInCells()
        {
            foreach(TextBox cell in cellText)
            {
                cell.Clear();
            }
        }

        //hàm chuyển đổi cặp ký tự khi thực hiện mã hóa
        public string find_new_characters(string pairOfCharacters)
        {
            //lấy ra ma trận khóa
            matrix_2d = new List<List<char>>();
            List<char> matrix_1d = create_matrix_key(txtKey.Text.Trim());
            int index = 0;
            for(int i = 0; i < sizeMatrix; i++)
            {
                List<char> matrix_1d_temp = new List<char>();
                for(int j = 0; j < sizeMatrix; j++)
                {
                    matrix_1d_temp.Add(matrix_1d[index++]);
                }
                matrix_2d.Add(matrix_1d_temp);
            }
            //lấy ra col và row của từng kí tự trong ma trận
            int rowFirstChar = 0, colFirstChar = 0, rowSecondChar = 0, colSecondChar = 0;
            for (int i = 0; i < matrix_2d.Count; i++)
            {
                for (int j = 0; j < matrix_2d[i].Count; j++)
                {
                    bool checkExistIOrJ = (pairOfCharacters[0] == 'I' && matrix_2d[i][j] == 'J') || (pairOfCharacters[0] == 'J' && matrix_2d[i][j] == 'I');
                    if (matrix_2d[i][j] == pairOfCharacters[0] || checkExistIOrJ)
                    {
                        rowFirstChar = i;
                        colFirstChar = j;
                        break;
                    }
                }
            }
            for (int i = 0; i < matrix_2d.Count; i++)
            {
                for (int j = 0; j < matrix_2d[i].Count; j++)
                {
                    bool checkExistIOrJ = (pairOfCharacters[1] == 'I' && matrix_2d[i][j] == 'J') || (pairOfCharacters[1] == 'J' && matrix_2d[i][j] == 'I');
                    if (matrix_2d[i][j] == pairOfCharacters[1] || checkExistIOrJ)
                    {
                        rowSecondChar = i;
                        colSecondChar = j;
                        break;
                    }
                }
            }
            string newPairOfCharacters = "";
            if (rowFirstChar == rowSecondChar)
            {
                newPairOfCharacters += (colFirstChar + 1 > matrix_2d.Count - 1) ? matrix_2d[rowFirstChar][0].ToString() : matrix_2d[rowFirstChar][colFirstChar + 1].ToString();
                newPairOfCharacters += (colSecondChar + 1 > matrix_2d.Count - 1) ? matrix_2d[rowSecondChar][0].ToString() : matrix_2d[rowSecondChar][colSecondChar + 1].ToString();
            }
            else if (colFirstChar == colSecondChar)
            {
                newPairOfCharacters += (rowFirstChar + 1 > matrix_2d.Count - 1) ? matrix_2d[0][colFirstChar].ToString() : matrix_2d[rowFirstChar + 1][colFirstChar].ToString();
                newPairOfCharacters += (rowSecondChar + 1 > matrix_2d.Count - 1) ? matrix_2d[0][colSecondChar].ToString() : matrix_2d[rowSecondChar + 1][colSecondChar].ToString();
            }
            else
            {
                newPairOfCharacters = matrix_2d[rowFirstChar][colSecondChar].ToString() + matrix_2d[rowSecondChar][colFirstChar].ToString();
            }
            return newPairOfCharacters;
        }

        //sử dụng để trả về cặp ký tự cũ trước khi thực hiện giải mã
        public string convert_pairOf_Characters(string pairOfCharacters)
        {
            //lấy ra col và row của từng kí tự trong ma trận
            int rowFirstChar = 0, colFirstChar = 0, rowSecondChar = 0, colSecondChar = 0;
            for (int i = 0; i < matrix_2d.Count; i++)
            {
                for (int j = 0; j < matrix_2d[i].Count; j++)
                {
                    bool checkExistIOrJ = (pairOfCharacters[0] == 'I' && matrix_2d[i][j] == 'J') || (pairOfCharacters[0] == 'J' && matrix_2d[i][j] == 'I');
                    if (matrix_2d[i][j] == pairOfCharacters[0] || checkExistIOrJ)
                    {
                        rowFirstChar = i;
                        colFirstChar = j;
                        break;
                    }
                }
            }
            for (int i = 0; i < matrix_2d.Count; i++)
            {
                for (int j = 0; j < matrix_2d[i].Count; j++)
                {
                    bool checkExistIOrJ = (pairOfCharacters[1] == 'I' && matrix_2d[i][j] == 'J') || (pairOfCharacters[1] == 'J' && matrix_2d[i][j] == 'I');
                    if (matrix_2d[i][j] == pairOfCharacters[1] || checkExistIOrJ)
                    {
                        rowSecondChar = i;
                        colSecondChar = j;
                        break;
                    }
                }
            }
            string oldPairOfCharacters = "";
            if (rowFirstChar == rowSecondChar)
            {
                oldPairOfCharacters += (colFirstChar - 1 < 0) ? matrix_2d[rowFirstChar][matrix_2d[0].Count - 1].ToString() : matrix_2d[rowFirstChar][colFirstChar - 1].ToString();
                oldPairOfCharacters += (colSecondChar - 1 < 0) ? matrix_2d[rowSecondChar][matrix_2d[0].Count - 1].ToString() : matrix_2d[rowSecondChar][colSecondChar - 1].ToString();
            }
            else if (colFirstChar == colSecondChar)
            {
                oldPairOfCharacters += (rowFirstChar - 1 < 0) ? matrix_2d[matrix_2d[0].Count - 1][colFirstChar].ToString() : matrix_2d[rowFirstChar - 1][colFirstChar].ToString();
                oldPairOfCharacters += (rowSecondChar - 1 < 0) ? matrix_2d[matrix_2d[0].Count - 1][colSecondChar].ToString() : matrix_2d[rowSecondChar - 1][colSecondChar].ToString();
            }
            else
            {
                oldPairOfCharacters = matrix_2d[rowFirstChar][colSecondChar].ToString() + matrix_2d[rowSecondChar][colFirstChar].ToString();
            }
            return oldPairOfCharacters;
        }

        public string insert_X_duplicate_chars(string plaintext)
        {
            string textTemp = "";
            //loại bỏ các ký tự đặc biệt, số nếu ma trận 5*5, 6*6 giữ số lại
            for (int i = 0; i < plaintext.Length; i++)
            {
                if(sizeMatrix == 6)
                {
                    if ((int)plaintext[i] >= 48 && (int)plaintext[i] <= 57)
                    {
                        textTemp += plaintext[i];
                    }
                }
                if ((int)Convert.ToChar(plaintext[i]) >= 65 && (int)Convert.ToChar(plaintext[i]) <= 90)
                {
                    textTemp += plaintext[i];
                }
            }
            plaintext = textTemp;
            bool checkDuplicate = false;
            while (true)
            {
                for(int index = 0; index < plaintext.Length; index += 2) 
                {
                    if (index + 2 < plaintext.Length)
                    {
                        string pairOfCharacters = plaintext.Substring(index, 2);
                        if (pairOfCharacters[0] == pairOfCharacters[1])
                        {
                            plaintext = plaintext.Substring(0, index) + pairOfCharacters[0] + "X" + pairOfCharacters[0] + plaintext.Substring(index+2);
                            checkDuplicate = true;
                            break;
                        }
                        else
                        {
                            checkDuplicate = false;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (!checkDuplicate) break;
            }
                
            if (plaintext.Length % 2 != 0) {
                plaintext += 'X';
            }else
            {
                if (plaintext[plaintext.Length - 1].Equals(plaintext[plaintext.Length - 2]))
                {
                    plaintext = plaintext.Substring(0, plaintext.Length - 1) + "X" + plaintext[plaintext.Length - 1] + "X";
                }
            }
            return plaintext;
        }
    

        private List<char> create_matrix_key(string key)
        {
            clearTextInCells();
            int size = sizeMatrix;
            List<char> create_matrix = new List<char>();
            foreach (char c in key)
            {
                bool check = (c == 'I' && create_matrix.Contains('J')) || (c == 'J' && create_matrix.Contains('I'));
                if (create_matrix.Count == 0)
                {
                    create_matrix.Add(c);
                }
                else
                {
                    if (check && sizeMatrix == 5)
                    {
                        continue;
                    }
                    if (!create_matrix.Contains(c))
                    {
                        create_matrix.Add(c);
                    }    
                }
            }

            for (int value = 65; value < 91; value++)
            {
                bool check = (Convert.ToChar(value) == 'I' && create_matrix.Contains('J')) || (Convert.ToChar(value) == 'J' && create_matrix.Contains('I'));
                if (check && sizeMatrix == 5) continue;
                if (!create_matrix.Contains(Convert.ToChar(value)))
                {
                    create_matrix.Add(Convert.ToChar(value));
                }
            }
            //kiểm tra xem có phải ma trận 6*6 hay không
            if (size == 6)
            {
                for(int i = 0; i < 10; i++)
                {
                    if(!create_matrix.Contains(Convert.ToChar(i.ToString()))) {
                        create_matrix.Add(Convert.ToChar(i.ToString()));
                    }
                }
            }

            //chuyển ma trận 2 chiều thành ma trận 1 chiều
            int index = 0;

            //gán ma trận vào kích thước tương ứng

            if (size == 5)
            {
                for(int i = 0; i < cellText.Count; i++)
                {
                    string eliminateText = cellText[i].Name.ToString().Substring(7);
                    int cellNumber = int.Parse(eliminateText);
                    if (cellNumber % 6 != 0 && cellNumber < 31)
                    {
                        if (index > 25) break;
                        cellText[i].Text = create_matrix[index++].ToString();
                    }
                }
            }
            else
            {
                for (int i = 0; i < cellText.Count; i++)
                {
                    cellText[i].Text = create_matrix[i].ToString();
                }
            }

            return create_matrix;
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            string text = txtKey.Text.ToUpper();
            if(isPaste)
            {
                string temp = "";
                //kiểm tra và xóa hết các số trong text
                foreach (char s in txtKey.Text)
                {
                    if ((int)s >= 65 && (int)s <= 90)
                    {
                        temp += s;
                    }
                    if (sizeMatrix == 6)
                    {
                        if ((int)s >= 48 && (int)s <= 57)
                        {
                            temp += s;
                        }
                    }
                }
                txtKey.Text = temp;
                isPaste = false;
            }
            else
            {
                if (text.Length >= 1)
                {
                    //lấy ra kí tự cuối cùng để kiểm tra
                    if (!((int)text[text.Length - 1] >= 65 && (int)text[text.Length - 1] <= 90))
                    {
                        if (sizeMatrix == 5)
                        {
                            // Tạo một StringBuilder từ văn bản trong TextBox
                            StringBuilder sb = new StringBuilder(text);

                            // Loại bỏ ký tự cuối cùng
                            sb.Remove(sb.Length - 1, 1);

                            txtKey.Text = text.Substring(0, text.Length - 1);
                        }
                        else
                        {
                            txtKey.Text = text;
                        }
                    }
                    else
                    {
                        txtKey.Text = text.ToUpper();
                    }

                    
                }
                if (sizeMatrix == 5)
                {
                    create_matrix_key(txtKey.Text);
                }
                else
                {
                    create_matrix_key(txtKey.Text);
                }
            }
            txtKey.Select(txtKey.Text.Length, 0);
            txtKey.ScrollToCaret();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            sizeMatrix = 5;
            cb55.Checked = true;
            cb66.Checked = false;
            clearTextInCells();

            string temp = "";
            //kiểm tra và xóa hết các số trong text
            foreach(char s in  txtKey.Text)
            {
                if((int)s >= 65 && (int)s <= 90)
                {
                    temp += s;
                }
            }

            txtKey.Text = temp;

            if(txtKey.Text.Length == 0)
            {
                initialMatrix(5);
            }else
            {
                create_matrix_key(txtKey.Text);
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            cb55.Checked = false;
            sizeMatrix = 6;
            cb66.Checked = true;
            clearTextInCells();
            if (txtKey.Text.Length == 0)
            {
                initialMatrix(6);
            }
            else
            {
                create_matrix_key(txtKey.Text);
            }
        }

        private void btnEncryte_Click(object sender, EventArgs e)
        {
            if (txtPlaintext.Text.Trim() != "")
            {
                if (txtKey.Text.Trim() != "")
                {
                    bool isEnglish = IsEnglishText(txtPlaintext.Text);
                    if (isEnglish)
                    {
                        txtCiphertext.Text = playfair_algorithm_encryption(txtPlaintext.Text.ToUpper().Trim());
                    }
                    else
                    {
                        txtCiphertext.Clear();
                        MessageBox.Show("This tool only supports encryption for English text.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the key matrix before encryption");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter the string to encode");
                return;
            }
        }

        public static bool IsEnglishText(string input)
        {
            foreach (char c in input)
            {
                int number = (int) c;
                if (!((number >= 65 && number <= 90) || (number >= 97 && number <= 122) || (number >= 48 && number <= 57) || c == ' '))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtCiphertext.Text.Trim() != "")
            {
                txtDecryptCipher.Text = playfair_algorithm_decryption(txtCiphertext.Text.ToUpper().Trim());
            }
            else
            {
                MessageBox.Show("Please encrypt before using decryption");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCiphertext.Clear();
            txtDecryptCipher.Clear();
            txtKey.Clear();
            txtPlaintext.Clear();
            txtSpText.Clear();
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem có văn bản được bôi đen không
            if (txtKey.SelectionLength > 0)
            {
                // Ngăn không cho paste tự động của TextBox xảy ra
                e.Handled = true;
            }
        }

        private void txtKey_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra phím Ctrl + V (paste)
            if (e.KeyCode == Keys.V && e.Control)
            {
                if (Clipboard.ContainsText())
                {
                    isPaste = true;
                    e.Handled = true; // Ngăn không cho paste tự động của TextBox xảy ra
                }
            }
        }

        
    }
    
    
}
