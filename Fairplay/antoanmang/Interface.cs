using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antoanmang
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void btnPlayFair_Click_1(object sender, EventArgs e)
        {
            Playfair playfair = new Playfair();
            playfair.Show();
        }
    }
}
