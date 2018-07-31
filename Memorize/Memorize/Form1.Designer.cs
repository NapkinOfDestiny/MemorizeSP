namespace Memorize
{
    partial class MemorizeMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemorizeMenu));
            this.panel1_control = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip_controls = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_openLesson = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox_filePath = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_compileLessonFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1_startLesson = new System.Windows.Forms.ToolStripButton();
            this.tabPage_multibleChoice = new System.Windows.Forms.TabPage();
            this.tabControl1_data = new System.Windows.Forms.TabControl();
            this.tabPage_lessonEditor = new System.Windows.Forms.TabPage();
            this.textBox_errors = new System.Windows.Forms.TextBox();
            this.textBox_lessonEditor = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage_textInput = new System.Windows.Forms.TabPage();
            this.panel_selectLesson = new System.Windows.Forms.Panel();
            this.checkedListBox_lessonsChecked = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_featuresInLesson = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon_Output = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1_control.SuspendLayout();
            this.toolStrip_controls.SuspendLayout();
            this.tabControl1_data.SuspendLayout();
            this.tabPage_lessonEditor.SuspendLayout();
            this.panel_selectLesson.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_control
            // 
            this.panel1_control.Controls.Add(this.listBox1);
            this.panel1_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1_control.Location = new System.Drawing.Point(0, 554);
            this.panel1_control.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1_control.MaximumSize = new System.Drawing.Size(267, 0);
            this.panel1_control.Name = "panel1_control";
            this.panel1_control.Size = new System.Drawing.Size(267, 0);
            this.panel1_control.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 2);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 68);
            this.listBox1.TabIndex = 0;
            // 
            // toolStrip_controls
            // 
            this.toolStrip_controls.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip_controls.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_controls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_openLesson,
            this.toolStripTextBox_filePath,
            this.toolStripButton_compileLessonFile,
            this.toolStripSeparator2,
            this.toolStripButton1_startLesson});
            this.toolStrip_controls.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_controls.MaximumSize = new System.Drawing.Size(0, 215);
            this.toolStrip_controls.Name = "toolStrip_controls";
            this.toolStrip_controls.Size = new System.Drawing.Size(1067, 30);
            this.toolStrip_controls.TabIndex = 2;
            this.toolStrip_controls.Text = "toolStrip1";
            // 
            // toolStripButton_openLesson
            // 
            this.toolStripButton_openLesson.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.toolStripButton_openLesson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_openLesson.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_openLesson.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_openLesson.Image")));
            this.toolStripButton_openLesson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_openLesson.Name = "toolStripButton_openLesson";
            this.toolStripButton_openLesson.Size = new System.Drawing.Size(160, 27);
            this.toolStripButton_openLesson.Text = "Open Lesson File";
            this.toolStripButton_openLesson.Click += new System.EventHandler(this.toolStripButton1_openFolder_Click);
            // 
            // toolStripTextBox_filePath
            // 
            this.toolStripTextBox_filePath.Name = "toolStripTextBox_filePath";
            this.toolStripTextBox_filePath.Size = new System.Drawing.Size(399, 30);
            // 
            // toolStripButton_compileLessonFile
            // 
            this.toolStripButton_compileLessonFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStripButton_compileLessonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_compileLessonFile.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_compileLessonFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton_compileLessonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_compileLessonFile.Image")));
            this.toolStripButton_compileLessonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_compileLessonFile.Name = "toolStripButton_compileLessonFile";
            this.toolStripButton_compileLessonFile.Size = new System.Drawing.Size(85, 27);
            this.toolStripButton_compileLessonFile.Text = "Compile";
            this.toolStripButton_compileLessonFile.Click += new System.EventHandler(this.toolStripButton_compileLessonFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripButton1_startLesson
            // 
            this.toolStripButton1_startLesson.BackColor = System.Drawing.Color.Chartreuse;
            this.toolStripButton1_startLesson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1_startLesson.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1_startLesson.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1_startLesson.Image")));
            this.toolStripButton1_startLesson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1_startLesson.Name = "toolStripButton1_startLesson";
            this.toolStripButton1_startLesson.Size = new System.Drawing.Size(121, 27);
            this.toolStripButton1_startLesson.Text = "Start Lesson";
            this.toolStripButton1_startLesson.ToolTipText = "Start Lesson";
            this.toolStripButton1_startLesson.Click += new System.EventHandler(this.toolStripButton1_startLesson_Click);
            // 
            // tabPage_multibleChoice
            // 
            this.tabPage_multibleChoice.Location = new System.Drawing.Point(4, 25);
            this.tabPage_multibleChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_multibleChoice.Name = "tabPage_multibleChoice";
            this.tabPage_multibleChoice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_multibleChoice.Size = new System.Drawing.Size(1059, 525);
            this.tabPage_multibleChoice.TabIndex = 1;
            this.tabPage_multibleChoice.Text = "Multible Choice";
            this.tabPage_multibleChoice.UseVisualStyleBackColor = true;
            this.tabPage_multibleChoice.Click += new System.EventHandler(this.tabPage2_multibleChoice_Click);
            // 
            // tabControl1_data
            // 
            this.tabControl1_data.Controls.Add(this.tabPage_lessonEditor);
            this.tabControl1_data.Controls.Add(this.tabPage_multibleChoice);
            this.tabControl1_data.Controls.Add(this.tabPage_textInput);
            this.tabControl1_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1_data.Location = new System.Drawing.Point(0, 0);
            this.tabControl1_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1_data.Name = "tabControl1_data";
            this.tabControl1_data.SelectedIndex = 0;
            this.tabControl1_data.Size = new System.Drawing.Size(1067, 554);
            this.tabControl1_data.TabIndex = 0;
            // 
            // tabPage_lessonEditor
            // 
            this.tabPage_lessonEditor.Controls.Add(this.textBox_errors);
            this.tabPage_lessonEditor.Controls.Add(this.textBox_lessonEditor);
            this.tabPage_lessonEditor.Controls.Add(this.menuStrip1);
            this.tabPage_lessonEditor.Location = new System.Drawing.Point(4, 25);
            this.tabPage_lessonEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_lessonEditor.Name = "tabPage_lessonEditor";
            this.tabPage_lessonEditor.Size = new System.Drawing.Size(1059, 525);
            this.tabPage_lessonEditor.TabIndex = 3;
            this.tabPage_lessonEditor.Text = "Lesson Editor";
            this.tabPage_lessonEditor.UseVisualStyleBackColor = true;
            // 
            // textBox_errors
            // 
            this.textBox_errors.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_errors.Location = new System.Drawing.Point(844, 0);
            this.textBox_errors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_errors.Multiline = true;
            this.textBox_errors.Name = "textBox_errors";
            this.textBox_errors.ReadOnly = true;
            this.textBox_errors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_errors.Size = new System.Drawing.Size(215, 525);
            this.textBox_errors.TabIndex = 2;
            this.textBox_errors.Text = "ERRORS:(N/A)";
            this.textBox_errors.WordWrap = false;
            // 
            // textBox_lessonEditor
            // 
            this.textBox_lessonEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_lessonEditor.Location = new System.Drawing.Point(0, 0);
            this.textBox_lessonEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_lessonEditor.Multiline = true;
            this.textBox_lessonEditor.Name = "textBox_lessonEditor";
            this.textBox_lessonEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_lessonEditor.Size = new System.Drawing.Size(831, 525);
            this.textBox_lessonEditor.TabIndex = 0;
            this.textBox_lessonEditor.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1059, 525);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage_textInput
            // 
            this.tabPage_textInput.Location = new System.Drawing.Point(4, 25);
            this.tabPage_textInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_textInput.Name = "tabPage_textInput";
            this.tabPage_textInput.Size = new System.Drawing.Size(1059, 525);
            this.tabPage_textInput.TabIndex = 2;
            this.tabPage_textInput.Text = "Text Input";
            this.tabPage_textInput.UseVisualStyleBackColor = true;
            // 
            // panel_selectLesson
            // 
            this.panel_selectLesson.Controls.Add(this.checkedListBox_lessonsChecked);
            this.panel_selectLesson.Controls.Add(this.toolStrip_controls);
            this.panel_selectLesson.Controls.Add(this.checkedListBox_featuresInLesson);
            this.panel_selectLesson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_selectLesson.Location = new System.Drawing.Point(0, 409);
            this.panel_selectLesson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_selectLesson.Name = "panel_selectLesson";
            this.panel_selectLesson.Size = new System.Drawing.Size(1067, 145);
            this.panel_selectLesson.TabIndex = 4;
            // 
            // checkedListBox_lessonsChecked
            // 
            this.checkedListBox_lessonsChecked.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkedListBox_lessonsChecked.FormattingEnabled = true;
            this.checkedListBox_lessonsChecked.Location = new System.Drawing.Point(0, 30);
            this.checkedListBox_lessonsChecked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox_lessonsChecked.Name = "checkedListBox_lessonsChecked";
            this.checkedListBox_lessonsChecked.ScrollAlwaysVisible = true;
            this.checkedListBox_lessonsChecked.Size = new System.Drawing.Size(863, 115);
            this.checkedListBox_lessonsChecked.TabIndex = 3;
            // 
            // checkedListBox_featuresInLesson
            // 
            this.checkedListBox_featuresInLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox_featuresInLesson.FormattingEnabled = true;
            this.checkedListBox_featuresInLesson.Items.AddRange(new object[] {
            "Images",
            "Text",
            "Multible Choice",
            "Text Input"});
            this.checkedListBox_featuresInLesson.Location = new System.Drawing.Point(864, 32);
            this.checkedListBox_featuresInLesson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox_featuresInLesson.Name = "checkedListBox_featuresInLesson";
            this.checkedListBox_featuresInLesson.Size = new System.Drawing.Size(201, 106);
            this.checkedListBox_featuresInLesson.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "a file";
            // 
            // notifyIcon_Output
            // 
            this.notifyIcon_Output.Text = "Memorize Ouput";
            this.notifyIcon_Output.Visible = true;
            // 
            // MemorizeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel_selectLesson);
            this.Controls.Add(this.panel1_control);
            this.Controls.Add(this.tabControl1_data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MemorizeMenu";
            this.Text = "Memorize";
            this.Load += new System.EventHandler(this.MemorizeMenu_Load);
            this.panel1_control.ResumeLayout(false);
            this.toolStrip_controls.ResumeLayout(false);
            this.toolStrip_controls.PerformLayout();
            this.tabControl1_data.ResumeLayout(false);
            this.tabPage_lessonEditor.ResumeLayout(false);
            this.tabPage_lessonEditor.PerformLayout();
            this.panel_selectLesson.ResumeLayout(false);
            this.panel_selectLesson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1_control;
        private System.Windows.Forms.ToolStrip toolStrip_controls;
        private System.Windows.Forms.ToolStripButton toolStripButton_openLesson;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1_startLesson;
        private System.Windows.Forms.TabPage tabPage_multibleChoice;
        private System.Windows.Forms.TabControl tabControl1_data;
        private System.Windows.Forms.TabPage tabPage_textInput;
        private System.Windows.Forms.Panel panel_selectLesson;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_filePath;
        private System.Windows.Forms.CheckedListBox checkedListBox_featuresInLesson;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon_Output;
        private System.Windows.Forms.TabPage tabPage_lessonEditor;
        private System.Windows.Forms.TextBox textBox_lessonEditor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_compileLessonFile;
        private System.Windows.Forms.CheckedListBox checkedListBox_lessonsChecked;
        private System.Windows.Forms.TextBox textBox_errors;
    }
}

