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
            buttonClose_AAN = new Button();
            labelUserManual_AAN = new Label();
            SuspendLayout();
            // 
            // buttonClose_AAN
            // 
            buttonClose_AAN.BackColor = SystemColors.Window;
            buttonClose_AAN.FlatStyle = FlatStyle.Popup;
            buttonClose_AAN.Location = new Point(675, 324);
            buttonClose_AAN.Name = "buttonClose_AAN";
            buttonClose_AAN.Size = new Size(97, 25);
            buttonClose_AAN.TabIndex = 1;
            buttonClose_AAN.Text = "Закрыть";
            buttonClose_AAN.UseVisualStyleBackColor = false;
            buttonClose_AAN.Click += buttonClose_AAN_Click;
            // 
            // labelUserManual_AAN
            // 
            labelUserManual_AAN.Font = new Font("Segoe UI", 13F);
            labelUserManual_AAN.Location = new Point(12, 25);
            labelUserManual_AAN.Name = "labelUserManual_AAN";
            labelUserManual_AAN.Size = new Size(760, 286);
            labelUserManual_AAN.TabIndex = 2;
            labelUserManual_AAN.Text = resources.GetString("labelUserManual_AAN.Text");
            // 
            // FormUserManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(labelUserManual_AAN);
            Controls.Add(buttonClose_AAN);
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "FormUserManual";
            Text = "Руководство пользователя";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonClose_AAN;
        private Label labelUserManual_AAN;
    }
}