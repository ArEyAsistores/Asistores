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
    public partial class addWords : Form
    {
        int lvlCount = dataHolder.getQuestionGame.Count + 1;
        public addWords()
        {
            InitializeComponent();
            label4.Text = lvlCount.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_addWords.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Complete the Text Field ^^");
            }
            else {
                dataHolder.getQuestionGame.Add(tb_addWords.Text.Trim());
                dataHolder.getAnswerGame.Add(textBox1.Text.Trim().ToUpper());
                MessageBox.Show("Added Complete ^^");
                tb_addWords.Text = "";
                textBox1.Text = "";
            }
        }
     
        private void Tb_addWords_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            questionList wg = new questionList();
            wg.Show();
            this.Hide();
        }
    }
}
