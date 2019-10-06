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
    public partial class MulC_Add_Q : Form
    {

        public MulC_Add_Q()
        {
            InitializeComponent();

        }

        private void MulC_Add_Q_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_A.Text) || string.IsNullOrEmpty(tb_B.Text) ||
                string.IsNullOrEmpty(tb_C.Text) || string.IsNullOrEmpty(tb_D.Text))
            {
                MessageBox.Show("Fill the Answer Field");
            }
            else if (string.IsNullOrEmpty(tb_Q.Text)) { MessageBox.Show("Fill the Question Field"); }
            else { 

               
                if (rbA.Checked || rbB.Checked ||
                    rbC.Checked || rbD.Checked)
                {
                   
                    dataHolder.getQuestion.Add(tb_Q.Text);
                    dataHolder.getAnswer.Add(tb_A.Text.Trim() + "~" + tb_B.Text.Trim() + "~" + tb_C.Text.Trim() + "~" + tb_D.Text.Trim());
                    if (rbA.Checked) { dataHolder.getCorrectAnswer.Add(tb_A.Text.Trim()); }
                    if (rbB.Checked) { dataHolder.getCorrectAnswer.Add(tb_B.Text.Trim()); }
                    if (rbC.Checked) { dataHolder.getCorrectAnswer.Add(tb_C.Text.Trim()); }
                    if (rbD.Checked) { dataHolder.getCorrectAnswer.Add(tb_D.Text.Trim()); }


                    MessageBox.Show("Question Added Successfuly");

                    tb_Q.Text = "";
                    tb_A.Text = "";
                    tb_B.Text = "";
                    tb_C.Text = "";
                    tb_D.Text = "";
                }
                else {
                    MessageBox.Show("Choose the Correct Answer");
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            questionList questionList1 = new questionList();
            questionList1.Show();
            this.Hide();
        }
    }
}
