using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorize
{
    class MultibleChoice
    {

        public FlowLayoutPanel userInputPanel { get; set; }// these are what the application sets up for user to see
      

        public TestQuestion question { get; set; }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //Constructor
        public MultibleChoice(FlowLayoutPanel inputPanel, TestQuestion aQuestion)
        {
            userInputPanel = inputPanel;
            question = aQuestion;

        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // Configures the user answers portion
        public void setup()
        {





            //setup false answer stuff
            foreach (var img in question.answerImages)
            {
                setupButtonWithImage(userInputPanel, img, false);
            }
            foreach (var text in question.answerText)
            {
                setupButtonWithText(userInputPanel, text, false);
            }


            //setup real answer stuff (sAnswer/Correct)
            foreach (var img in question.sAnswerImages)
            {
                setupButtonWithImage(userInputPanel, img, true);
            }
            foreach (var text in question.sAnswerText)
            {
                setupButtonWithText(userInputPanel, text, true);
            }



        }



        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // adds a button that has text
        private void setupButtonWithText(FlowLayoutPanel location, string info, bool sAnswer)
        {
            
            System.Windows.Forms.Button newAnswer = new System.Windows.Forms.Button();
            newAnswer.Text = info;            // give it the text
          //  newButtonX.Size = new System.Drawing.Size(questions[0].questionImages[0].Width, questions[0].questionImages[0].Height);
          // newButtonX.Image = questions[0].questionImages[0];

            if (sAnswer == true)
                newAnswer.Click += new EventHandler(correct);
            else
                newAnswer.Click += new EventHandler(wrong);

            // newButtonX.Tag = 1;

            //add button to UI
            location.Controls.Add(newAnswer);
           
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // add a buton that has imag
        private void setupButtonWithImage(FlowLayoutPanel location, System.Drawing.Image img, bool sAnswer)
        {
            System.Windows.Forms.Button newAnswer = new System.Windows.Forms.Button();


            newAnswer.Size = new System.Drawing.Size(img.Width, img.Height);
            newAnswer.Image = img;


            if (sAnswer == true)
                newAnswer.Click += new EventHandler(correct);
            else
                newAnswer.Click += new EventHandler(wrong);


            //add button to UI
            location.Controls.Add(newAnswer);

        }


        private void correct(object sender, EventArgs e)
        {


        }

        private void wrong(object sender, EventArgs e)
        {


        }



    }
}
