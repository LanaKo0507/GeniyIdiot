﻿using GeniyIdiotCommonClassLibrary;
using System.Windows.Forms;

namespace GeniyIdiotFormsApp
{
    public partial class UserInfoForm : Form
    {
        private User user;
        public UserInfoForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            if (inputTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите имя");
                Application.Restart();
            }
            else
            {
                if (!User.IsValid(inputTextBox.Text))
                {
                    MessageBox.Show("Недопустимое имя. Оно должно содержать только буквы и/или цифры");
                    Application.Restart();
                }
                else
                {
                    user.Name = inputTextBox.Text;
                    Close();
                }
            }
        }
    }
}
