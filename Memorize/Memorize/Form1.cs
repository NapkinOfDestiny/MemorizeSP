using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorize
{
    public partial class MemorizeMenu : Form
    {

        string lessonFilePath = "NO_SELECTED_LESSON_FILE"; //this refers to the openlesson

        Lesson lesson = new Lesson();

        int allowedNameLength = 5;


        public MemorizeMenu()
        {
            InitializeComponent();
        }

        private void MemorizeMenu_Load(object sender, EventArgs e)
        {

        }

       
        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // This opens a lesson file
        private void toolStripButton1_openFolder_Click(object sender, EventArgs e)
        {
            string tempLessonFilePath = "NO_SELECTED_LESSON_FILE";

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {


                    //get path
                    tempLessonFilePath = System.IO.Path.GetFullPath(openFileDialog.FileName);



                    //this bit here is because it doesn't always like some of the files (linux spacing probably) and desplays them badly so this will fix that
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName))
                    {
                        //reset rawXml so we don't just append the next file to it
                        string tempLessonFile = "";

                        while (sr.EndOfStream != true)
                        {
                            tempLessonFile += sr.ReadLine() + "\r\n";
                        }


                        //past the danger of exceptions so update
                        textBox_lessonEditor.Text = tempLessonFile; 
                        lessonFilePath = tempLessonFilePath;
                        toolStripTextBox_filePath.Text = lessonFilePath;
                        focusTab(0); // focus on the edit tab

                        notifyOutputGood("Succesfully Imported:" + openFileDialog.FileName, "From:" + lessonFilePath);
                    }

                }

            }
            catch (Exception)
            {
                //exception error
                notifyOutputBad("FAILED To Import Lesson File (Exception)", openFileDialog.FileName);

            }
 
        }



        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //Tests User On the TestQuestions in the LessonFile IMPROVE:(it would be good if we could do multible lesson files at once
        private void toolStripButton1_startLesson_Click(object sender, EventArgs e)
        {
            List<Lesson> lessons = new List<Lesson>();//put lesson into a list
            lessons.Add(lesson);



            System.Windows.Forms.FlowLayoutPanel MC_Input = this.flowLayoutPanel_MC_answerPanel;//configure magic constructs (which has broken my brain making me wonder how I have gotten anything to work up to this point)

            System.Windows.Forms.RichTextBox questTextPanel = this.richTextBox_questionTextPanel;

            System.Windows.Forms.ImageList questImgPanel = this.imageList_questionImgPanel;
            System.Windows.Forms.ListView questImgDesplay = this.listView_questionImgDesplay;



            Tester tester = new Tester(lessons, questTextPanel, questImgPanel, questImgDesplay);// get tester object

            tester.allowImgs = checkedListBox_featuresInLesson.GetItemChecked(0);//confgure test filter
            tester.allowText = checkedListBox_featuresInLesson.GetItemChecked(1);


            
         

            tester.start(MC_Input);




       

          
            

        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // Parse/Convert the open lesson file into corresponding TestQuestion objects to be used in the lesson
        private void toolStripButton_compileLessonFile_Click(object sender, EventArgs e)
        {

            lesson.rawData = textBox_lessonEditor.Lines;
            lesson.compile();
            desplayErrors(lesson);






        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        // desplays the inputed lesson's testquestions's synax errors while compiling
        private void desplayErrors(Lesson le)
        {

            //if there is more than 0 errors then desplay them
            if (le.getError().Count > 0)
            {
                textBox_errors.Text = "Errors(" + le.getError().Count + ")" + "\r\n";

                foreach (var item in le.getError())
                {
                    textBox_errors.Text += item + "\r\n";
                }


                 
            }
            else
            {
                textBox_errors.Text = "No Errors :)";
            }

        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //focuses the tabControl to the desired tab index
        private void focusTab(int i)
        {
            tabControl1_data.SelectedIndex = i;
        }








        private void notifyOutputGood(string title, string text)
        {

            notifyIcon_Output.Visible = true;
            notifyIcon_Output.Icon = SystemIcons.Information;
            notifyIcon_Output.BalloonTipTitle = title;
            notifyIcon_Output.BalloonTipText = text;
            notifyIcon_Output.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon_Output.ShowBalloonTip(1000);
        }
        private void notifyOutputBad(string title, string text)
        {

            notifyIcon_Output.Visible = true;
            notifyIcon_Output.Icon = SystemIcons.Exclamation;
            notifyIcon_Output.BalloonTipTitle = title;
            notifyIcon_Output.BalloonTipText = text;
            notifyIcon_Output.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon_Output.ShowBalloonTip(1000);
        }
        private void notifyOutputWarning(string title, string text)
        {

            notifyIcon_Output.Visible = true;
            notifyIcon_Output.Icon = SystemIcons.Warning;
            notifyIcon_Output.BalloonTipTitle = title;
            notifyIcon_Output.BalloonTipText = text;
            notifyIcon_Output.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon_Output.ShowBalloonTip(1000);
        }



//------------------------------------------------------------///////// STUFF THAT ISN't NEEDED BUT I CAN'T EASILY REMOVE //////////////----------------------------------------------------------------------------------------------
        private void tabPage2_multibleChoice_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer_MC_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void trackBar_MC_scaling_Scroll(object sender, EventArgs e)
        {
            richTextBox_questionTextPanel.ZoomFactor = trackBar_MC_scaling.Value + 1;
        }
    }
}
