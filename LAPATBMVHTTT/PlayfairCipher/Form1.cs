using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayfairCipher
{
    public partial class Form1 : Form
    {
        private const char PaddingChar = 'x';

        private char[,] _matrix = new char[5, 5];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            string plaintext =txtPlaintext.Text.ToLower().Replace(" ", "");
            string key = txtKey.Text.ToLower().Replace(" ", "");
            string ciphertext = "";

            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần mã hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập khóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo ma trận Playfair từ key
            GenerateMatrix(key);

            // Chèn thêm 'x' vào giữa 2 kí tự trùng nhau
            for (int i = 0; i < plaintext.Length - 1; i += 2)
            {
                if (plaintext[i] == plaintext[i + 1])
                {
                    plaintext = plaintext.Insert(i + 1, "x");
                }
            }

            // Thêm 'x' vào cuối plaintext nếu ổng số kí tự lẻ cho đủ cặp
            if (plaintext.Length % 2 != 0)
            {
                plaintext += PaddingChar;
            }

            // Mã hóa Plaintext dùng thuật toán Playfair
            for (int i = 0; i < plaintext.Length; i += 2)
            {
                int row1 = 0, col1 = 0, row2 = 0, col2 = 0;

                // Tìm vị trí của 2 kí tự cho từng cắp kí tự trong ma trận
                FindPosition(plaintext[i], ref row1, ref col1);
                FindPosition(plaintext[i + 1], ref row2, ref col2);

                // MÃ hóa các kí tự theo thuật toán Playfair
                if (row1 == row2)
                {
                    ciphertext += _matrix[row1, (col1 + 1) % 5];
                    ciphertext += _matrix[row2, (col2 + 1) % 5];
                }
                else if (col1 == col2)
                {
                    ciphertext += _matrix[(row1 + 1) % 5, col1];
                    ciphertext += _matrix[(row2 + 1) % 5, col2];
                }
                else
                {
                    ciphertext += _matrix[row1, col2];
                    ciphertext += _matrix[row2, col1];
                }
            }

            txtCipher.Text = ciphertext;

        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            string ciphertext = txtCipher.Text.ToLower().Replace(" ", "");
            string key = txtKey.Text.ToLower().Replace(" ", "");
            string plaintext = "";

            if (string.IsNullOrEmpty(ciphertext))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần giải mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập khóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo ma trận Playfair từ key
            GenerateMatrix(key);

            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                int row1=0, col1 = 0, row2 = 0, col2 = 0;
                FindPosition(ciphertext[i], ref row1, ref col1);
                FindPosition(ciphertext[i + 1], ref row2, ref col2);

                // Giải mã các kí tự
                if (row1 == row2)
                {
                    plaintext += _matrix[row1, (col1 + 4) % 5];
                    plaintext += _matrix[row2, (col2 + 4) % 5];
                }
                else if (col1 == col2)
                {
                    plaintext += _matrix[(row1 + 4) % 5, col1];
                    plaintext += _matrix[(row2 + 4) % 5, col2];
                }
                else
                {
                    plaintext += _matrix[row1, col2];
                    plaintext += _matrix[row2, col1];
                }
            }

            // Remove any padding characters from the plaintext
            plaintext = plaintext.Replace(PaddingChar.ToString(), "");

           txtPlaintext.Text = plaintext;
        }

        private void GenerateMatrix(string key)
        {
            // Xóa 2 kí tự trùng nhau trong key
            string distinctChars = new string(key.Distinct().ToArray());

            // THêm các kí tự còn lại trong bảng chữ cái, nếu là j thì bỏ qua do chỉ lấy i
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (c == 'j') continue;
                if (!distinctChars.Contains(c))
                {
                    distinctChars += c;
                }
            }

            // Điền các kí tự vào ma trận
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    _matrix[i, j] = distinctChars[k++];
                }
            }
        }

        private void FindPosition(char letter, ref int row, ref int col)
        {
            // Tìm vị trí của kí tự trong ma trận Playfair
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (_matrix[i, j] == letter)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
