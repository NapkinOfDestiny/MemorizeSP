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
        public List<System.Drawing.Image> questionImages = new List<System.Drawing.Image>();
        public List<string> questionText = new List<string>(); // (this seems a bit odd because text doesnt need a list)

        //Answers 
        public List<System.Drawing.Image> answerImages = new List<System.Drawing.Image>();
        public List<string> answerText = new List<string>();

        //*Answers 
        public List<System.Drawing.Image> sAnswerImages = new List<System.Drawing.Image>();
        public List<string> sAnswerText = new List<string>();



        //for compiling/decompiling
        public string[] rawData { get; set; }

        //this is to record errors in synax
        public List<string> qErrors { get; set; }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //Constructor
        public TestQuestion(
            string nam, 
            int know = 0
         )
        {
            name = nam;
            known = know;

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

            char linkChar = '@';
           
           

            for (int i = 0; i < rawData.Length; i++) //for each line 
            {
               


                
                //this first if segment updates location
                if (rawData[i].Contains("<Q>"))
                {
                    Q = true;
                    A = false;
                    SA = false;
                    i++;//get off <> line
                }
                else if (rawData[i].Contains("<A>"))
                {
                    Q = false;
                    A = true;
                    SA = false;
                    i++;//get off <> line
                }
                else if (rawData[i].Contains("<*A>"))
                {
                    Q = false;
                    A = false;
                    SA = true;
                    i++;//get off <> line
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

                       if (rawData[i][0] == linkChar)// if its a link 
                        {                        
                            questionImages.Add(getImage(rawData[i]));
                        }
                        else// if its text
                        {
                            questionText.Add(rawData[i]);
                        }

                    }
                    else if (A == true)
                    {

                        if (rawData[i][0] == linkChar)// if its a link 
                        {
                            answerImages.Add(getImage(rawData[i]));
                        }
                        else// if its text
                        {
                            answerText.Add(rawData[i]);
                        }

                    }
                    else if (SA == true)
                    {

                        if (rawData[i][0] == linkChar)// if its a link 
                        {
                            sAnswerImages.Add(getImage(rawData[i]));
                        }
                        else// if its text
                        {
                            sAnswerText.Add(rawData[i]);
                        }


                    }


                }
               
                
             


            }

           


        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // gets image from path after formating it to nothave @ at the beginning
        private System.Drawing.Image getImage(string unformatedPath)
        {

            List<char> path = unformatedPath.ToList<char>();//convert to list so we can remove the @ symbol
            path.RemoveAt(0);

            string finalPath = "";
            foreach (var item in path)// turn it backinto string format
            {
                finalPath += item;
            }

            try
            {
                return System.Drawing.Image.FromFile(finalPath);
            }
            catch (Exception)
            {
                addError($"Unable To Find Img At \"{unformatedPath}\"");

                //return blank img
                var b = new System.Drawing.Bitmap(1, 1);
                b.SetPixel(0, 0, System.Drawing.Color.White);
                return new System.Drawing.Bitmap(b, 200, 200); ;
            }
           
        }



        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // Adds new error to qError with questions name
        private void addError(string errorMessage)
        {
            this.qErrors.Add("Question(" + ellip(name) + "): " + errorMessage);
        }


        


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //  adds ellip onto inputed string if greater than allowed length
        private string ellip(string inputString, int allowedLength = 15)
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


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // returns if .this contains text question oriented stuff
        public bool containsText()
        {
            bool hasText = false;
            if (questionText.Count > 0 || answerText.Count > 0 || sAnswerText.Count > 0)
            {
                hasText = true;
            }

            return hasText;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // returns if .this contains img question oriented stuff
        public bool containsImg()
        {
            bool hasImg = false;
            if (questionImages.Count > 0 || answerImages.Count > 0 || sAnswerImages.Count > 0)
            {
                hasImg = true;
            }

            return hasImg;
        }


    }
}
