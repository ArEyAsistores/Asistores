using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copro3_Project
{
    public partial class logInForm : Form
    {
        // Static account
        string user = "admin";
        string pass = "admin123";
        string lastForm = "";
        public logInForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(user) && textBox2.Text.Equals(pass))
            {
                lastForm = dataHolder.getLastForm;
                if (lastForm.Equals("games")) {
                    addWords addWords = new addWords();
                    addWords.Show();
                    this.Hide();
                } else if (lastForm.Equals("quiz")) {
                    MulC_Add_Q mulC_Add_Q = new MulC_Add_Q();
                    mulC_Add_Q.Show();
                    this.Hide();
                }
              
            }
            else {

                MessageBox.Show("Incorrect Username or Password");
            }
        }
    }
}
