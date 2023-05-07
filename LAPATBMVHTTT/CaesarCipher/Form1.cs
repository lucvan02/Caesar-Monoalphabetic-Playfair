using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            int key = 0;
            string plaintext = txtPlaintext.Text;
            string ciphertext = "";

            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần mã hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                key = Convert.ToInt32(txtKey.Text);
            }
            catch
            {
                MessageBox.Show("Khóa phải là một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char newChar = char.IsUpper(c) ? 'A' : 'a';
                    int asciiValue = (int)c;
                    asciiValue -= char.IsUpper(c) ? 65 : 97;
                    asciiValue = (asciiValue + key) % 26;
                    ciphertext += (char)(asciiValue + newChar);
                }
                else
                {
                    ciphertext += c;
                }
            }

            txtCipher.Text = ciphertext;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbPlaintext_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            int key = 0;
            string ciphertext =txtCipher.Text;
            string plaintext = "";

            if (string.IsNullOrEmpty(ciphertext))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần giải mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                key = Convert.ToInt32(txtKey.Text);
            }
            catch
            {
                MessageBox.Show("Khóa phải là một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (char c in ciphertext)
            {
                if (char.IsLetter(c))
                {
                    char newChar = char.IsUpper(c) ? 'A' : 'a';
                    int asciiValue = (int)c;
                    asciiValue -= char.IsUpper(c) ? 65 : 97;
                    asciiValue = (asciiValue - key) % 26;
                    if (asciiValue < 0)
                    {
                        asciiValue += 26;
                    }
                    plaintext += (char)(asciiValue + newChar);
                }
                else
                {
                    plaintext += c;
                }
            }

            txtPlaintext.Text = plaintext;
        }

        private void txtPlaintext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
