﻿namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4
{
    partial class FormAboutProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutProgram));
            textBoxAboutProgram_AAN = new TextBox();
            pictureBoxDeveloper_AAN = new PictureBox();
            buttonClose_AAN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeveloper_AAN).BeginInit();
            SuspendLayout();
            // 
            // textBoxAboutProgram_AAN
            // 
            textBoxAboutProgram_AAN.BackColor = SystemColors.Control;
            textBoxAboutProgram_AAN.BorderStyle = BorderStyle.None;
            textBoxAboutProgram_AAN.Font = new Font("Segoe UI", 14F);
            textBoxAboutProgram_AAN.Location = new Point(246, 12);
            textBoxAboutProgram_AAN.Multiline = true;
            textBoxAboutProgram_AAN.Name = "textBoxAboutProgram_AAN";
            textBoxAboutProgram_AAN.ReadOnly = true;
            textBoxAboutProgram_AAN.Size = new Size(526, 294);
            textBoxAboutProgram_AAN.TabIndex = 0;
            textBoxAboutProgram_AAN.Text = resources.GetString("textBoxAboutProgram_AAN.Text");
            // 
            // pictureBoxDeveloper_AAN
            // 
            pictureBoxDeveloper_AAN.Image = (Image)resources.GetObject("pictureBoxDeveloper_AAN.Image");
            pictureBoxDeveloper_AAN.Location = new Point(12, 12);
            pictureBoxDeveloper_AAN.Name = "pictureBoxDeveloper_AAN";
            pictureBoxDeveloper_AAN.Size = new Size(228, 337);
            pictureBoxDeveloper_AAN.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDeveloper_AAN.TabIndex = 1;
            pictureBoxDeveloper_AAN.TabStop = false;
            // 
            // buttonClose_AAN
            // 
            buttonClose_AAN.BackColor = SystemColors.Window;
            buttonClose_AAN.FlatStyle = FlatStyle.Popup;
            buttonClose_AAN.Location = new Point(678, 322);
            buttonClose_AAN.Name = "buttonClose_AAN";
            buttonClose_AAN.Size = new Size(94, 27);
            buttonClose_AAN.TabIndex = 2;
            buttonClose_AAN.Text = "Закрыть";
            buttonClose_AAN.UseVisualStyleBackColor = false;
            buttonClose_AAN.Click += button1_Click;
            // 
            // FormAboutProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(buttonClose_AAN);
            Controls.Add(pictureBoxDeveloper_AAN);
            Controls.Add(textBoxAboutProgram_AAN);
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "FormAboutProgram";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeveloper_AAN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAboutProgram_AAN;
        private PictureBox pictureBoxDeveloper_AAN;
        private Button buttonClose_AAN;
    }
}