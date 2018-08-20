using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize
{
    class Tester
    {

        //all lessons user wants to go over
        List<Lesson> lessons = new List<Lesson>();

        // questions from lessons that fit requirments
        List<TestQuestion> questions = new List<TestQuestion>();


        public bool allowImgs { get; set; }
        public bool allowText { get; set; }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // Constructor
        public Tester(List<Lesson> les)
        {
            lessons = les;
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // starts the lesson
        public void start(
            System.Windows.Forms.FlowLayoutPanel MC_input, 
            System.Windows.Forms.RichTextBox MC_Quest
            )
        {
            gatherQuestions(allowImgs, allowText);
            test(MC_input, MC_Quest);
           
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // gathers questions that fit requirments into var questions
        private void gatherQuestions(bool alImg, bool alText)
        {
            questions = new List<TestQuestion>();//clear questions


            foreach (var lesson in lessons)
            {
                foreach (var question in lesson.testQuestions)//foreach test question of all of the lessons
                {


                    //check requirments if matches then add it to test roster (var questions)
                    if (question.containsImg() == alImg && question.containsText() == alText)
                    {
                        questions.Add(question);
                    }

                }
            }

        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // where the testing magic happens
        private void test(System.Windows.Forms.FlowLayoutPanel MC_input, System.Windows.Forms.RichTextBox MC_Quest)
        {


            foreach (var question in questions)
            {
                MultibleChoice mc = new MultibleChoice(MC_input, MC_Quest, question);
                mc.setup();
            }
         
          








        }



       


    }
}
