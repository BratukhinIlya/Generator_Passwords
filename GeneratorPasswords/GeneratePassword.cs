using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace GeneratorPasswords
{
    public partial class GeneratePassword : Form
    {
        public GeneratePassword()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (lengthPass.Value == 0)
            {
                MessageBox.Show("Введите длину пароля!");
            }
            if (string.IsNullOrEmpty(textLogin.Text))
            {
                MessageBox.Show("Сначала введите логин!");
            }
            else
            {
                int length = (int)lengthPass.Value;

                bool excludeSimilar = IsclPohozh.Checked; 
                bool excludeNonAlphanumeric = IsclNonBukv.Checked; 

                string password = PassGenerator.GeneratePassword(length, excludeSimilar, excludeNonAlphanumeric);

                textPass.Text = password;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string password = textPass.Text;
            string login = textLogin.Text;

            if (!string.IsNullOrEmpty(password) || !IsPasswordUnique(password))
            {
                SavePasswordToFile(password, login);
                MessageBox.Show("Логин и пароль сохранены в файл");
            }
            else
            {
                MessageBox.Show("Логин или пароль не введен или пароль слишком простой");
            }
        }

        public bool IsPasswordUnique(string password)
        {
            string fileName = "rockyou.txt";
            if (File.Exists(fileName))
            {
                string[] passwords = File.ReadAllLines(fileName);

                foreach (string savedPassword in passwords)
                {
                    if (password == savedPassword)
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }

        public void SavePasswordToFile(string password, string login)
        {
            string log_par = $"{login} - {password}\n";

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Сохранить логин и пароль";
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                if (File.Exists(filePath))
                { 
                    if (result == DialogResult.No)
                    {
                        return; 
                    }
                }
                try
                {
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine(log_par);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении пароля: {ex.Message}");
                }
            }
        }
    }
}
