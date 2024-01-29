using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;

namespace PasswordManager
{
    using BCrypt.Net;
    public partial class Form1 : Form
    {
        public Form1()
        {
            ReadFromFile();
            InitializeComponent();
        }

        string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/sites.txt";
        string selectedCellValue = "";

        string GetMD5Hash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            string hashString = Convert.ToBase64String(hash);
            return hashString.Remove(hashString.Length - 2, 2);
        }

        string GetSHA256Hash(string input)
        {
            HashAlgorithm sha = SHA256.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] result = sha.ComputeHash(inputBytes);
            return Convert.ToBase64String(result);
        }

        string GetBCryptKey(string input)
        {
            string passwordHash = BCrypt.HashPassword(input);
            passwordHash = passwordHash.Substring(7, passwordHash.Length-7); //первые 7 символов в bcrypt всегда одинаковые
            return passwordHash;
        }

        string ClearSpaces(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c)) //удаление из строки пробелов
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        string ClearSymbols(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (c != '=' && c != '+') //удаление из строки символов пунктуации, арифметических знаков и пробелов
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        void GeneratePassword()
        {
            int waitTime = 30; //столько секунд держим пароль в буфере
            string output = "";

            if (MD5selector.Checked)
            {
                output = ClearSymbols(GetMD5Hash(ClearSpaces(selectedCellValue + loginTextBox.Text + masterPasswordTextBox.Text)));
            }
            else if (SHA256selector.Checked)
            {
                output = ClearSymbols(GetSHA256Hash(ClearSpaces(selectedCellValue + loginTextBox.Text + masterPasswordTextBox.Text)));
            }
            else if (bcryptselector.Checked)
            {
                output = ClearSymbols(GetBCryptKey(ClearSpaces(selectedCellValue + loginTextBox.Text + masterPasswordTextBox.Text)));
            }

            if (symbols10selector.Checked)
            {
                output = output.Substring(0,10);
            }
            else if (symbols20selector.Checked)
            {
                output = output.Substring(0, 20);
            }
            else if (symbols40selector.Checked)
            {
                output = output.Substring(0, 40);
            }

            MessageBox.Show("Ваш пароль:" + '\n' + output + '\n' + "После закрытия окна пароль будет помещён в буфер обмена на " + waitTime + " секунд."); 
            Clipboard.SetText(output);
            WaitAndClearClipboard(waitTime);
        }

        public async void WaitAndClearClipboard(int waitTime)
        {
            await Task.Delay(waitTime * 1000);
            Clipboard.Clear();
        }

        void GetCellValue()
        {
            if (dataGridView1.SelectedCells[0].Value != null)
            {
                selectedCellValue = dataGridView1.SelectedCells[0].Value.ToString();
            }
            else
            {
                selectedCellValue = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errors = "";

            if (ClearSpaces(selectedCellValue) == "")
            {
                errors += "Выберите сайт!" + '\n';
            }
            if (ClearSpaces(loginTextBox.Text) == "")
            {
                errors += "Впишите логин!" + '\n';
            }
            if (ClearSpaces(masterPasswordTextBox.Text) == "")
            {
                errors += "Впишите мастер-пароль!" + '\n';
            }

            if (errors == "")
            {
                GeneratePassword();
            }
            else
            {
                MessageBox.Show(errors);
            }
        }

        void WriteToFile()
        {
            using (StreamWriter writer = new StreamWriter(SavePath, false))
            {
                foreach (DataGridViewRow table in dataGridView1.Rows)
                {
                    if (table.Cells[0].Value != null)
                        writer.WriteLine(table.Cells[0].Value.ToString());

                }
            }
        }

        async void ReadFromFile()
        {
            if (File.Exists(SavePath))
            {
                using (StreamReader reader = new StreamReader(SavePath))
                {
                    string text = await reader.ReadToEndAsync();
                    string[] sites = text.Split('\n');
                    for (int i = 0; i < sites.Length-1; i++)
                    {
                        dataGridView1.Rows.Add(new object[] { sites[i] });
                    }
                    

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetCellValue();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GetCellValue();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            GetCellValue();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteToFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedCellValue != "")
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить сайт из списка?", "Внимание", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                }
            }

        }

        private void MD5selector_CheckedChanged(object sender, EventArgs e)
        {
            symbols10selector.Checked = true;
            symbols40selector.Enabled = false;
        }

        private void SHA256selector_CheckedChanged(object sender, EventArgs e)
        {
            symbols40selector.Enabled = true;
        }

        private void bcryptselector_CheckedChanged(object sender, EventArgs e)
        {
            symbols40selector.Enabled = true;
        }
    }

}
