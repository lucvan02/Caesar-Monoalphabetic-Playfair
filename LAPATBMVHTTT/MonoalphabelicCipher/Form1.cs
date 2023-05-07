using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoalphabelicCipher
{
    public partial class Form1 : Form
    {
        private string key = "";
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string cipher = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khóa");
                return;
            }

            key = txtKey.Text.ToUpper();
            cipher = "";

            // Tạo bảng chữ cái cipher
            foreach (char c in alphabet)
            {
                if (!key.Contains(c))
                {
                    cipher += c;
                }
            }
            cipher = key + cipher;

            // Mã hóa plaintext
            string plaintext = txtPlaintext.Text.ToUpper();
            string ciphertext = "";
            foreach (char c in plaintext)
            {
                if (Char.IsLetter(c))
                {
                    int index = alphabet.IndexOf(c);
                    ciphertext += cipher[index];
                }
                else
                {
                    ciphertext += c;
                }
            }
            txtCipher.Text = ciphertext;
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khóa");
                return;
            }

            key = txtKey.Text.ToUpper();
            cipher = "";

            // Tạo bảng chữ cái cipher
            foreach (char c in alphabet)
            {
                if (!key.Contains(c))
                {
                    cipher += c;
                }
            }
            cipher = key + cipher;

            // Giải mã ciphertext
            string ciphertext = txtCipher.Text.ToUpper();
            string plaintext = "";
            foreach (char c in ciphertext)
            {
                if (Char.IsLetter(c))
                {
                    int index = cipher.IndexOf(c);
                    plaintext += alphabet[index];
                }
                else
                {
                    plaintext += c;
                }
            }
            txtPlaintext.Text = plaintext;
        }
    }
}
