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

        // questions from lessons that fit filter
        List<TestQuestion> questions = new List<TestQuestion>();



        // Content Filter
        public bool allowImgs { get; set; }
        public bool allowText { get; set; }

        // Question Style Filter
        public bool allowMultibleChoice { get; set; }
        public bool allowTextInput { get; set; }


        // Where to desplay question
        System.Windows.Forms.ImageList questionImgPanel;
        System.Windows.Forms.RichTextBox questionTextPanel;




        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // Constructor
        public Tester
            (
            List<Lesson> les,
            System.Windows.Forms.RichTextBox questTextPanel,
            System.Windows.Forms.ImageList questImgPanel
            )
        {
            lessons = les;
            questionImgPanel = questImgPanel;
            questionTextPanel = questTextPanel;



            //default filters
            allowImgs = false;
            allowText = false;

            allowMultibleChoice = false;
            allowTextInput = false;
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // starts the lesson
        public void start
            (                        
            System.Windows.Forms.FlowLayoutPanel MC_inputPanel
            )
        {
            gatherQuestions(allowImgs, allowText);
            test(MC_inputPanel);
           
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // filters questions from lesson into var questions
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
        // test user 
        private void test(System.Windows.Forms.FlowLayoutPanel MC_input)
        {


            foreach (var question in questions)
            {

                //Configure Question Portion
                foreach (var item in question.questionImages)//add images
                {



                    /*  for (int j = 0; j < question.questionImages.Count; j++)
                      {

                          System.Windows.Forms.ListViewItem itema = new System.Windows.Forms.ListViewItem();

                          itema.ImageIndex = j;


                          questionImgPanel.Items.Add(itema);

                      }*/

                    for (int j = 0; j < question.questionImages.Count; j++)
                    {

                        questionImgPanel.Images.Add(question.questionImages[j]);

                    }



                }

                foreach (var item in question.questionText)//add text
                {

                        questionTextPanel.Text += item + "\r\r";

                }







                MultibleChoice mc = new MultibleChoice(MC_input, question);
                mc.setup();
            }
         
          








        }



       


    }
}
