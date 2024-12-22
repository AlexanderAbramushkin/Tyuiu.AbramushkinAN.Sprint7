namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4
{
    partial class FormUserManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserManual));
            textBoxUserManual_AAN = new TextBox();
            buttonClose_AAN = new Button();
            SuspendLayout();
            // 
            // textBoxUserManual_AAN
            // 
            textBoxUserManual_AAN.BackColor = SystemColors.Control;
            textBoxUserManual_AAN.BorderStyle = BorderStyle.None;
            textBoxUserManual_AAN.Font = new Font("Segoe UI", 14F);
            textBoxUserManual_AAN.Location = new Point(12, 12);
            textBoxUserManual_AAN.Multiline = true;
            textBoxUserManual_AAN.Name = "textBoxUserManual_AAN";
            textBoxUserManual_AAN.ReadOnly = true;
            textBoxUserManual_AAN.Size = new Size(760, 306);
            textBoxUserManual_AAN.TabIndex = 0;
            textBoxUserManual_AAN.Text = resources.GetString("textBoxUserManual_AAN.Text");
            textBoxUserManual_AAN.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonClose_AAN
            // 
            buttonClose_AAN.Location = new Point(675, 324);
            buttonClose_AAN.Name = "buttonClose_AAN";
            buttonClose_AAN.Size = new Size(97, 25);
            buttonClose_AAN.TabIndex = 1;
            buttonClose_AAN.Text = "Закрыть";
            buttonClose_AAN.UseVisualStyleBackColor = true;
            buttonClose_AAN.Click += buttonClose_AAN_Click;
            // 
            // FormUserManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(buttonClose_AAN);
            Controls.Add(textBoxUserManual_AAN);
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "FormUserManual";
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserManual_AAN;
        private Button buttonClose_AAN;
    }
}