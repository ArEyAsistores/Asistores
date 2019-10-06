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
    public partial class Welcome : Form
    {
       
        public Welcome()
        {
            InitializeComponent();
            //This is the Welcome form
            //Two methods na kung saan, pag nag start ang Program mag
            //r-run na ang dalawang method sa baba, na ang Function ay mag
            //ADD ng data sa Multple and sa Games
            AddCollection_Multiple();
            AddCollection_Games();
            //Paano sya nag add??
            // meron tayo gnwa na Class ang name nya is dataHolder
            //tawag dyan Encapsulation naka PUBLIC si dataHOlder kaya pwede natin sya magamit kahit saang Form 
            //pero dapat nasa loob lang sya ng file ng Project neto
        }

        private void Welcome_Load(object sender, EventArgs e)

        {
        }
        public void AddCollection_Multiple() {
            // Name_Ng_Class/Property_Name/Property_Method : ganyan ang format pang tawag sa Class
            //EX: dataHolder.getQuestion.Add("ArEy"); or .Count() etc..

            //Multiple Choice
            //q1
            dataHolder.getQuestion.Add("Each of the following numbers is composite EXCEPT: \n 30, 31, 32, 33, 34, 35, 36, 37, 38, 39");
            dataHolder.getAnswer.Add("32 and 39~30 and 34~31 and 37~All numbers and Composite");
            dataHolder.getCorrectAnswer.Add("31 and 37");
            //q2
            dataHolder.getQuestion.Add("The Prime numbers between 40 and 49 are:");
            dataHolder.getAnswer.Add("42,43 and 47~41, 43 and 47~43, 45 and 47~None of the above");
            dataHolder.getCorrectAnswer.Add("41, 43 and 47");
            //q3
            dataHolder.getQuestion.Add("Which statement is NOT True?");
            dataHolder.getAnswer.Add("Every Rational number is a Real number~Every Integer is a Rational number~Every Counting number is a Whole number~Every Decimal number is an Irrational number");
            dataHolder.getCorrectAnswer.Add("Every Decimal number is an Irrational number");
            //q4
            dataHolder.getQuestion.Add("28x2 - 4x");
            dataHolder.getAnswer.Add("2x(14x - 2x)~4(7x2 - x)~4x(7x - x)~4x(7x - 1)");
            dataHolder.getCorrectAnswer.Add("4x(7x - 1)");
            //q5
            dataHolder.getQuestion.Add("Find the 17 th term of the Arithmetic sequence\n –5, 1, 7, 13,...");
            dataHolder.getAnswer.Add("91~97~87~81");
            dataHolder.getCorrectAnswer.Add("91");

        }
        public void AddCollection_Games() {
            //Games
            //q1
            dataHolder.getQuestionGame.Add("Term given to a poset which all its sunset have a join and a meet?");
            dataHolder.getAnswerGame.Add("Complete Lattice");
            //q2
            dataHolder.getQuestionGame.Add("Subset of Real Numbers does not contain the Number 1?");
            dataHolder.getAnswerGame.Add("Irrational Numbers");
            //q3
            dataHolder.getQuestionGame.Add("An equation where in a variable is inside a square root symbol.");
            dataHolder.getAnswerGame.Add("Radical Equation");
            //q4
            dataHolder.getQuestionGame.Add("It is an Algebraic expression made up of two or more terms. ");
            dataHolder.getAnswerGame.Add("Polynomials");
        }

    

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();//Create a contructor to perform a Show(). Method and this./current Form will be Hide();
            form.Show();
            this.Hide();
        }
    }
}

