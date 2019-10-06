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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            int count = 1;
            foreach (string score in dataHolder.getScoreGames)
            {
                listBox1.Items.Add("Q" + count + score);
                count++;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            dataHolder.getScoreGames.Clear();
        }
    }
}
