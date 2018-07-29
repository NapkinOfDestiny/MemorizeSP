using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<string> errors { get; set; }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //Constructor
        public TestQuestion(
            string nam, 
            int know,
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
        // configures the this to match everything found in rawData
        public void compile()
        {
            for (int i = 0; i < rawData.Length; i++) //for each line 
            {
                if (i == 0) //if first of file then get name and known
                {
                    name = rawData[i]; 
                    i++;

                    known = Convert.ToInt32(rawData[i]);
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


        }



    }
}
