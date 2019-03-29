using ProgInOperSus.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgInOperSus
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            InitializeComponent();
            usernameTextBox.Focus();
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                passwordTextBox.Focus();
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
              
                    openNewForm();
                
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            openNewForm();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openNewForm()
        {
            LoginClass LC = new LoginClass();
            LC.Username= usernameTextBox.Text.Trim();
            LC.Password= passwordTextBox.Text.Trim();


            //TODO if provera sa bazom

            if (LC.PostojiLiZapis(LC.Username, LC.Password))
            {
                MainForms.Main mainForm = new MainForms.Main();
                mainForm.Show();
                this.Hide();
            }
        }

       
    }
}
