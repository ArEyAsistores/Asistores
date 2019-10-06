using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copro3_Project
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {InitializeComponent();}

        private void BtnMultipleChoice_Click(object sender, EventArgs e)//Event to ng Button pag na CLICK
        {
            MulChoice_Form mulChoice_Form = new MulChoice_Form();//To Form Mulitple choice Quiz
            mulChoice_Form.Show();
            this.Hide();
        }

        private void BtnDragAndDrop_Click(object sender, EventArgs e)//Event to ng Button pag na CLICK
        {
            WordGames wordGames = new WordGames();//To Form Games
            wordGames.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
        
    }
}
