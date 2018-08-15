using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize
{
    class Lesson
    {
        // fileing
        public string fileName { get; set; }

        //Personal Lesson Data (these are the first two lines of each lessonfile)
        public string name { get; set; }
        public string description { get; set; }



       
        public string[] rawData {get; set;}//this is the raw text 
        //      \/         /\
        //   COMPILE    DECOMPILE
        //      \/         /\
        List<TestQuestion> testQuestions = new List<TestQuestion>();



        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // convert/parse the raw data into fully declared TestQuestion objs
        public void compile()
        {
            gatherCompileDataIntoQuestions(); //get compile data
            compileQuestions(testQuestions); // compile
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // fills var testquestions with questions with their corresponding raw data 
        private void gatherCompileDataIntoQuestions()
        {

            testQuestions.Clear(); // delete old compiled content

            TestQuestion tempQuestion = new TestQuestion("TEMP_QUESTION");
            bool first = true; // allows us to ignore any white space between title/descrip of lesson and the first question


            for (int i = 0; i < rawData.Length; i++) //for each line 
            {
                if (i == 0) //if first of file then get name and descrip of lessonFile
                {
                    name = rawData[i]; //first line is name second is description
                    i++;
                    description = rawData[i];
                }
                else if (rawData[i].Contains("<?>"))
                {
                    if (first == true)
                    {
                        first = false;
                    }
                    else
                    {

                        testQuestions.Add(tempQuestion);
                        tempQuestion = new TestQuestion("TEMP_QUESTION"); // reset temp
                    }
                }
                else if (first != true)
                {
                    tempQuestion.addToRawData(rawData[i]);

                }
            }


          
                //because it only adds a new tempquestion when it finds the next question the last question of the lesson is added here \/ 
                testQuestions.Add(tempQuestion);
               
            


        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // tells each testquestion to compile the raw data it has
        private void compileQuestions(List<TestQuestion> testQuestions)
        {         

            for (int i = 0; i < testQuestions.Count; i++)
            {
                testQuestions[i].compile();
            }

        }
 
  


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // load the rawData from a file
        public void loadFromFile()
        {
         
            using (System.IO.StreamReader sr = new System.IO.StreamReader("FILEPATH"))
            {
                while (sr.EndOfStream != true)
                {                   
                    addToRawData(sr.ReadLine()); 
                }
            }
             

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



        //returns a list of all the testquestion errors
        public List<string> getError(int allowedLength)
        {
            List<string> allErrors = new List<string>();

            foreach (var question in testQuestions)
            {
                foreach (var error in question.qErrors)
                {
                    allErrors.Add(error);
                }
                
            }

            return allErrors;
        }


    }
}
