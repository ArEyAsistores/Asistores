using System;
using System.Collections;
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
    public partial class MulChoice_Form : Form
    {
        int no = 1;
        int counter = 0;
        int score = 0;
       
        public MulChoice_Form()
        {
            InitializeComponent();
            try
            {
                splitAns(counter);
            }
            catch (Exception e) { } 
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInForm lf = new logInForm();
            dataHolder.getLastForm = "quiz";
            lf.Show();
            this.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            if (rb_Ans1.Checked)
            {
                if (rb_Ans1.Text == dataHolder.getCorrectAnswer[counter])
                {
                    MessageBox.Show("Your Answer is Correct");
                    score++;
                    dataHolder.getScoreGames.Add(": Correct: 1");
                }
                else { MessageBox.Show("Your Answer is Wrong"); dataHolder.getScoreGames.Add(": Wrong: 0"); }
            }
            else if (rb_Ans2.Checked) {
                if (rb_Ans2.Text == dataHolder.getCorrectAnswer[counter])
                {
                    MessageBox.Show("Your Answer is Correct");
                    score++;
                    dataHolder.getScoreGames.Add( ": Correct: 1");
                }
                else { MessageBox.Show("Your Answer is Wrong"); dataHolder.getScoreGames.Add(": Wrong: 0"); }
            }
            else if (rb_Ans3.Checked)
            {
                if (rb_Ans3.Text == dataHolder.getCorrectAnswer[counter])
                {
                    MessageBox.Show("Your Answer is Correct");
                    score++;
                    dataHolder.getScoreGames.Add(": Correct: 1");
                }
                else { MessageBox.Show("Your Answer is Wrong"); dataHolder.getScoreGames.Add(": Wrong: 0"); }
            }
            else if (rb_Ans4.Checked)
            {
                if (rb_Ans4.Text == dataHolder.getCorrectAnswer[counter])
                {
                    MessageBox.Show("Your Answer is Correct");
                    score++;
                    dataHolder.getScoreGames.Add(": Correct: 1");
                }
                else { MessageBox.Show("Your Answer is Wrong"); dataHolder.getScoreGames.Add(": Wrong: o"); }
            }
            

            counter++;
            splitAns(counter);
            no++;
            label1.Text = "Question No."+no;

        }
        public void splitAns(int counter) {
            
            try
            {
                for (int x = 0; 0 <= dataHolder.getAnswer.Count; x++){
                    string getAns;
                
                    if (counter == x){
                        


                        lbl_Q.Text = dataHolder.getQuestion[x].ToString();
                        getAns = dataHolder.getAnswer[x].ToString();
                        string[] split = getAns.Split('~');
                       

                        rb_Ans1.Text = (string)split[randomNum()[0]];
                        rb_Ans2.Text = (string)split[randomNum()[1]];
                        rb_Ans3.Text = (string)split[randomNum()[2]];
                        rb_Ans4.Text = (string)split[randomNum()[3]];

                        break;
                    }
                   
                    }

            }
            catch (Exception aor)
            {
                dataHolder.getScoreGames.Add("Total SCORES: " + score + "/" + dataHolder.getQuestion.Count());
                Form2 Form2 = new Form2();
                Form2.Show();
                this.Hide();

                MessageBox.Show("Well DONE !, Check your Scores ^^");
               
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
        public List<int> randomNum() {
            List<int> lst = new List<int>();
            for (int i = 0; i <= 3; i += 1) lst.Add(i);
            List<int> lstRandom = new List<int>();

            // Randomize
            Random rnd = new Random();
            lstRandom.AddRange(from s in lst orderby rnd.Next(0, 4) select s);
            return lstRandom;
        }
    }
}
