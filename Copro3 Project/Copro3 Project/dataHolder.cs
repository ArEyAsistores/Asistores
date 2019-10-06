using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copro3_Project
{
    class dataHolder
    {
        //Form Multiple Choice
        private static List<string> getQuestions = new List<string>();//Stock of Question
        private static List<string> getAnswers = new List<string>();//Stock of Answer
        private static List<string> getCorrectAnswers = new List<string>();// Ans Stock of Correct Answer from List of Answer

        //Form Games
        private static List<string> getScoreGame = new List<string>();
        private static List<string> getAnswerGames = new List<string>();
        private static List<string> getQuestionGames = new List<string>();

        public static string getLastForm { get; set; }
        public static List<string> getScoreGames
        {
           
            get { return getScoreGame; }
            set { getScoreGame = value; }
        }
        public static List<string> getQuestion
        {
            get { return getQuestions; }
            set { getQuestions = value; }
        }
        public static List<string> getAnswer
        {
            get { return getAnswers; }
            set { getAnswers = value; }
        }
        public static List<string> getCorrectAnswer
        {
            get { return getCorrectAnswers; }
            set { getCorrectAnswers = value; }
        }
        public static List<string> getAnswerGame
        {
            get { return getAnswerGames; }
            set { getAnswerGames = value; }
        }
        public static List<string> getQuestionGame
        {
            get { return getQuestionGames; }
            set { getQuestionGames = value; }
        }

    }
}
