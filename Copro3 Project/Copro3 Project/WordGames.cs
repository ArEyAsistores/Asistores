using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Copro3_Project
{

    public partial class WordGames : Form
    {
        int ms, s, m, h;
        string nice = "";
        int wrongAns = 0;
        int counter = 0;
       
        TextBox tb;
    
        public WordGames()
        {

            InitializeComponent();
            lvl(counter);

        }
      
        private void WordGames_Load(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
           
            this.Hide();
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {

        }
        //Letters
        private void Btn_5_Click(object sender, EventArgs e)
        {
            collection(btn_5.Text);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {


        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInForm lf = new logInForm();
            dataHolder.getLastForm = "games";
            lf.Show();
            this.Hide();
        }

        private void Lbl_Time_Click(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {

            
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            collection(btn_6.Text);
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            collection(btn_7.Text);
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            collection(btn_8.Text);
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            collection(btn_9.Text);
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            collection(btn_4.Text);
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            collection(btn_3.Text);
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            collection(btn_2.Text);
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            collection(btn_1.Text);

        }

        

        private void Button6_Click(object sender, EventArgs e)
        {
            collection(button6.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            collection(button2.Text);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            collection(button11.Text);
        }
        

        private void Button4_Click(object sender, EventArgs e)
        {
            collection(button4.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            collection(button3.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            collection(button1.Text);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            collection(button17.Text);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            collection(button14.Text);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            collection(button15.Text);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            collection(button12.Text);
        }

        private void Button13_Click_1(object sender, EventArgs e)
        {
            collection(button13.Text);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            collection(button16.Text);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            collection(button9.Text);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            collection(button10.Text);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            collection(button8.Text);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            collection(button7.Text);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            collection(button5.Text);
        }
        public string Complete() {
            nice = "";
            try
            {
                for (int x = 0; x < dataHolder.getAnswerGame[counter].Length; x++)
                {
                    nice += ((TextBox)flowPanel.Controls["tb" + x]).Text;
                   
                }
            }
            catch (Exception e)
            {
                flowPanel.Controls.Clear();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            return nice;
        }
        TextBox textBox(int i)
        {
            TextBox tb = new TextBox();

            tb.Name = "tb" + i.ToString();
            tb.Text = "";
            tb.Font = new Font("Arial", 25, FontStyle.Regular);
            tb.Margin = new Padding(5);
            tb.Size = new System.Drawing.Size(50, 50);
            tb.Top = 20;
            tb.ReadOnly = true;
            tb.TextAlign = HorizontalAlignment.Center;
            tb.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            return tb;
        }
        public void lvl(int counter)
        {

            try
            {
                timer1.Enabled = true;
                for (int x = 0; x <= dataHolder.getAnswerGame.Count; x++)
                {
                    if (counter == x)
                    {

                        label12.Text = dataHolder.getQuestionGame[counter];

                        for (int i = 0; i < dataHolder.getAnswerGame[counter].Length; i++)
                        {
                            tb = textBox(i); 
                            flowPanel.Controls.Add(tb);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                flowPanel.Controls.Clear();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }

        }
        public void lvl()//overloading method 
        {
            dataHolder.getScoreGames.Add(": Time " + h + ":" + m + ":" + s);
            counter++;
            flowPanel.Controls.Clear();
            lvl(counter);
            resetTimer();
           
            label2.Text = "O"; label2.ForeColor = System.Drawing.Color.FromArgb(56, 239, 125);
            label3.Text = "O"; label3.ForeColor = System.Drawing.Color.FromArgb(56, 239, 125);
            label4.Text = "O"; label4.ForeColor = System.Drawing.Color.FromArgb(56, 239, 125);
            wrongAns = 0;

        }
        public string checkAns(string ans, string btnName)
        {
            
            char[] a = ans.ToCharArray();

            for (int x = 0; x < ans.Length; x++) { 

                if (a[x].ToString().ToUpper().Equals(btnName))
                {
                    ((TextBox)flowPanel.Controls["tb" + x]).Text = a[x].ToString();
                }
                if (a[x].ToString().ToUpper().Equals(" "))
                {
                    ((TextBox)flowPanel.Controls["tb" + x]).Text = "-";
                }
            }

            if (!dataHolder.getAnswerGame[counter].ToUpper().ToString().Contains(btnName)) { return null; }
            return btnName;
        }

        public void collection(string btnName)
        {
            try
            {
                if (checkAns(dataHolder.getAnswerGame[counter], btnName) == null)
                {

                    if (wrongAns == 1)
                    { MessageBox.Show("Wrong again, Read the Question ^^"); }
                    else if (wrongAns == 0) { MessageBox.Show("Oops, Try Again"); }
                    wrongAns++;

                    switch (wrongAns)
                    {
                        case 1: label2.Text = "X"; label2.ForeColor = System.Drawing.Color.FromArgb(194, 19, 50);break;
                        case 2: label3.Text = "X"; label3.ForeColor = System.Drawing.Color.FromArgb(194, 19, 50); break;
                        case 3:
                            label4.Text = "X";
                            label4.ForeColor = System.Drawing.Color.FromArgb(194, 19, 50);
                            MessageBox.Show("ohh No, Game Over");
                         
                            dataHolder.getScoreGames.Add(": Time " + h + ":" + m + ":" + s);
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                            break;

                    }
                }
                else
                { checkAns(dataHolder.getAnswerGame[counter], btnName); }

                if (Complete().Replace('-', ' ') == dataHolder.getAnswerGame[counter])
                {
                   
                    MessageBox.Show("Nice Work");
                    lvl();
                    timer1.Enabled = true;
                }
            }
            catch (Exception e) {
                flowPanel.Controls.Clear();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ms = ms + 1;
            if (ms == 9)
            {
                ms = 0;
                s = s + 1;
                lblsecond.Text = s.ToString();
                if (s == 59)
                {
                    s = 0;
                    m = m + 1;
                    lblmin.Text = m.ToString();
                    if (m == 59)
                    {
                        m = 0;
                        h = h + 1;
                        lblhur.Text = h.ToString();
                        {
                            lblmsec.Text = ms.ToString();
                        }
                    }
                }
            }
        }
        public void resetTimer() {
            ms = 0;
            h = 0;
            s = 0;
            m = 0;
            timer1.Enabled = false;
            lblhur.Text = "00";
            lblmin.Text = "00";
            lblsecond.Text = "00";
            lblmsec.Text = "00";
        }
    }
}
