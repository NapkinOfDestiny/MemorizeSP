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
        // configures the this to match everything found in rawData
        public void compile()
        {

            //these keep track of where we are 
            bool first = true;
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
                    first = false;
                }
                else if (rawData[i].Contains("<A>"))
                {
                    Q = false;
                    A = true;
                    SA = false;
                    first = false;
                }
                else if (rawData[i].Contains("<*A>"))
                {
                    Q = false;
                    A = false;
                    SA = true;
                    first = false;
                }



                //this segment of if saves the data
                if (i == 0) //if first of file then get name and known
                {
                    name = removeComments(rawData[i]);
                    i++;


                    try
                    {
                        known = Convert.ToInt32(removeComments(rawData[i]));
                    }
                    catch (Exception)
                    {
                        this.qErrors.Add("Question" + getNameWithEllip() + $":Compile: raw data didn't show as int instead it was \"{removeComments(rawData[i])}\"");
                    }

                }
                else if (Q == true)
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



        private string removeComments(string line)
        {
            char[] commentCharacter = {';'};
            string res = line.Split(commentCharacter)[0];

            return res;
        }

        private string getNameWithEllip(int allowedLength = 5)
        {
            string aName = "";
             //must be greater than three also -1 because arrays

            if (name.Length > allowedLength)
            {
                for (int i = 0; i < allowedLength -3; i++)//removes excess and adds ellipse if over allowed length
                {
                    aName += name[i];
                }
                aName += "...";
            }

            return aName;
        }


    }
}
