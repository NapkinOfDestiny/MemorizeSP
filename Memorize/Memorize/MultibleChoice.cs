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
        // Sets up var userInput to have questions stuff
        public void setup()
        {


         

                 

            //Configure Answer Portion
         



        }



        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // adds a button that has text
        private void setupButtonWithText(FlowLayoutPanel location, string info, bool sAnswer)
        {
            
            System.Windows.Forms.Button newButtonX = new System.Windows.Forms.Button();
            newButtonX.Text = info;            // give it the text
          //  newButtonX.Size = new System.Drawing.Size(questions[0].questionImages[0].Width, questions[0].questionImages[0].Height);
          // newButtonX.Image = questions[0].questionImages[0];

            if (sAnswer == true)
            newButtonX.Click += new EventHandler(correct);


           // newButtonX.Tag = 1;

            //add button to UI
            location.Controls.Add(newButtonX);
           
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // add a buton that has imag
        private void setupButtonWithImage(FlowLayoutPanel location, string info, bool correct)
        {

        }


        private void correct(object sender, EventArgs e)
        {


        }

        private void wrong(object sender, EventArgs e)
        {

        }



    }
}
