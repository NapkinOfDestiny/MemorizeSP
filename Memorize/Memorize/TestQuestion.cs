using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorize
{
    class TestQuestion
    {
        public int known { get; set; }
        public string name { get; set; }
       

        //Questions 
        List<System.Drawing.Bitmap> questionImages = new List<System.Drawing.Bitmap>();
        List<string> questionText = new List<string>(); // (this seems a bit odd because text doesnt need a list)

        //Answers 
        List<System.Drawing.Bitmap> answerImages = new List<System.Drawing.Bitmap>();
        List<string> answerText = new List<string>();


        //for compiling/decompiling
        public string[] rawData { get; set; }

        //this is to record errors in synax
        public List<string> qErrors { get; set; }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //Constructor
        public TestQuestion(
            string nam, 
            int know = 0,
            List<System.Drawing.Bitmap> quesImages = null,
            List<string> quesText = null,
            List<System.Drawing.Bitmap> answImages = null, 
            List<string> answText = null)
        {

            name = nam;
            known = know;
            questionImages  = quesImages;
            questionText = quesText;
            answerImages = answImages;
            answerText = answText;

            qErrors = new List<string>();



        }




        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // adds string to var rawdata
        public void addToRawData(string line)
        {
            List<string> newArrayThatsAlsoAList = new List<string>();

            if (rawData != null)//if raw data isn't empty then copy it and add line
            newArrayThatsAlsoAList = rawData.ToList<string>();
            newArrayThatsAlsoAList.Add(line);

            rawData = newArrayThatsAlsoAList.ToArray();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // configures the .this to match everything found in rawData
        public void compile()
        {

            //these keep track of where we are         
            bool Q = false;
            bool A = false;
            bool SA = false;
           

            for (int i = 0; i < rawData.Length; i++) //for each line 
            {
               


                
                //this first if segment updates location
                if (rawData[i].Contains("<Q>"))
                {
                    Q = true;
                    A = false;
                    SA = false;                    
                }
                else if (rawData[i].Contains("<A>"))
                {
                    Q = false;
                    A = true;
                    SA = false;                 
                }
                else if (rawData[i].Contains("<*A>"))
                {
                    Q = false;
                    A = false;
                    SA = true;                 
                }



                //this segment of if saves the data
                if (i == 0) //if first of file then get name and known
                {
                    name = rawData[i];
                    i++;//next line


                    try
                    {
                        known = Convert.ToInt32(rawData[i]);
                    }
                    catch (Exception)
                    {

                        addError($"Compile: known amount didn't show as int instead it was \"{rawData[i]}\"");
                    }

                }
                else if (removeWhitespace(rawData[i]) != "")// if not first line and isn't blank
                {
                    if (Q == true)
                    {

                    }
                    else if (A == true)
                    {

                    }
                    else if (SA == true)
                    {

                    }
                }
               
                
             


            }

           


        }

      

        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // Adds new error to qError with questions name
        private void addError(string errorMessage)
        {
            this.qErrors.Add("Question" + ellip(name) + ":" + errorMessage);
        }


        


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //  adds ellip onto inputed string if greater than allowed length
        private string ellip(string inputString, int allowedLength = 10)
        {
            string outputString = "";
             //must be greater than three also -1 because arrays

            if (inputString.Length > allowedLength)
            {
                for (int i = 0; i < allowedLength -3; i++)//removes excess and adds ellipse if over allowed length
                {
                    outputString += inputString[i];
                }
                outputString += "...";
            }

            return outputString;
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // returns the input but without any white space
        private string removeWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }



    }
}
