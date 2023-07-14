namespace C_Sharp_Read_Excel_File_12_07_2023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Butt_CreateNewFiles = new Button();
            Butt_LoadFiles = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Butt_CreateNewFiles
            // 
            Butt_CreateNewFiles.Location = new System.Drawing.Point(12, 386);
            Butt_CreateNewFiles.Name = "Butt_CreateNewFiles";
            Butt_CreateNewFiles.Size = new System.Drawing.Size(175, 23);
            Butt_CreateNewFiles.TabIndex = 0;
            Butt_CreateNewFiles.Text = "Создание нового файла";
            Butt_CreateNewFiles.UseVisualStyleBackColor = true;
            Butt_CreateNewFiles.Click += Butt_CreateNewFiles_Click;
            // 
            // Butt_LoadFiles
            // 
            Butt_LoadFiles.Location = new System.Drawing.Point(270, 386);
            Butt_LoadFiles.Name = "Butt_LoadFiles";
            Butt_LoadFiles.Size = new System.Drawing.Size(178, 23);
            Butt_LoadFiles.TabIndex = 1;
            Butt_LoadFiles.Text = "Загрузка файла";
            Butt_LoadFiles.UseVisualStyleBackColor = true;
            Butt_LoadFiles.Click += Butt_LoadFiles_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(426, 274);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(460, 421);
            Controls.Add(listBox1);
            Controls.Add(Butt_LoadFiles);
            Controls.Add(Butt_CreateNewFiles);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Butt_CreateNewFiles;
        private Button Butt_LoadFiles;
        private ListBox listBox1;
    }
}