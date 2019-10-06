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
    public partial class questionList : Form
    {
      
        public questionList()
        {
            InitializeComponent();
            getMultiple();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            getMultiple();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            getGames();
        }
        public void getMultiple() {

            int counter = 1 ;
            for (int x = 0 ; x < dataHolder.getQuestion.Count;x++){

                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = counter.ToString();
                dataGridView1.Rows[index].Cells[1].Value = dataHolder.getQuestion[x].ToString();
                dataGridView1.Rows[index].Cells[2].Value = dataHolder.getAnswer[x].ToString().Replace('~', ':') ;
                dataGridView1.Rows[index].Cells[3].Value = dataHolder.getCorrectAnswer[x].ToString();
                counter++;
                label1.Text = "Multiple Choice";
            }
        }

        public void getGames()
        {

            int counter = 1;
            for (int x = 0; x < dataHolder.getQuestionGame.Count; x++)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = counter.ToString();
                dataGridView1.Rows[index].Cells[1].Value = dataHolder.getQuestionGame[x].ToString();
                dataGridView1.Rows[index].Cells[2].Value = "Letters:Ex(A,B,C,D ...)";
                dataGridView1.Rows[index].Cells[3].Value = dataHolder.getAnswerGame[x].ToString();

                counter++;
                label1.Text = "Word Games";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
