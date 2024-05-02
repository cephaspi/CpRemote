namespace RemoteTools.Presentation.WinForms
{
    partial class SettingsForm
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
            groupBoxMainForm = new GroupBox();
            labelAWPositionX = new Label();
            labelAWPositionY = new Label();
            labelAWPositionW = new Label();
            labelAWPositionH = new Label();
            textBoxAWPositionX = new TextBox();
            textBoxAWPositionY = new TextBox();
            textBoxAWWidth = new TextBox();
            textBoxAWHeight = new TextBox();
            groupBoxMainForm.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMainForm
            // 
            groupBoxMainForm.Controls.Add(textBoxAWHeight);
            groupBoxMainForm.Controls.Add(textBoxAWWidth);
            groupBoxMainForm.Controls.Add(textBoxAWPositionY);
            groupBoxMainForm.Controls.Add(textBoxAWPositionX);
            groupBoxMainForm.Controls.Add(labelAWPositionH);
            groupBoxMainForm.Controls.Add(labelAWPositionW);
            groupBoxMainForm.Controls.Add(labelAWPositionY);
            groupBoxMainForm.Controls.Add(labelAWPositionX);
            groupBoxMainForm.Location = new Point(12, 12);
            groupBoxMainForm.Name = "groupBoxMainForm";
            groupBoxMainForm.Size = new Size(189, 138);
            groupBoxMainForm.TabIndex = 0;
            groupBoxMainForm.TabStop = false;
            groupBoxMainForm.Text = "Application window";
            // 
            // labelAWPositionX
            // 
            labelAWPositionX.AutoSize = true;
            labelAWPositionX.Location = new Point(41, 17);
            labelAWPositionX.Name = "labelAWPositionX";
            labelAWPositionX.Size = new Size(14, 15);
            labelAWPositionX.TabIndex = 0;
            labelAWPositionX.Text = "X";
            // 
            // labelAWPositionY
            // 
            labelAWPositionY.AutoSize = true;
            labelAWPositionY.Location = new Point(41, 45);
            labelAWPositionY.Name = "labelAWPositionY";
            labelAWPositionY.Size = new Size(14, 15);
            labelAWPositionY.TabIndex = 0;
            labelAWPositionY.Text = "Y";
            // 
            // labelAWPositionW
            // 
            labelAWPositionW.AutoSize = true;
            labelAWPositionW.Location = new Point(16, 73);
            labelAWPositionW.Name = "labelAWPositionW";
            labelAWPositionW.Size = new Size(39, 15);
            labelAWPositionW.TabIndex = 0;
            labelAWPositionW.Text = "Width";
            // 
            // labelAWPositionH
            // 
            labelAWPositionH.AutoSize = true;
            labelAWPositionH.Location = new Point(12, 101);
            labelAWPositionH.Name = "labelAWPositionH";
            labelAWPositionH.Size = new Size(43, 15);
            labelAWPositionH.TabIndex = 0;
            labelAWPositionH.Text = "Height";
            labelAWPositionH.Click += labelAWPositionH_Click;
            // 
            // textBoxAWPositionX
            // 
            textBoxAWPositionX.Location = new Point(72, 14);
            textBoxAWPositionX.Name = "textBoxAWPositionX";
            textBoxAWPositionX.Size = new Size(100, 23);
            textBoxAWPositionX.TabIndex = 1;
            // 
            // textBoxAWPositionY
            // 
            textBoxAWPositionY.Location = new Point(72, 42);
            textBoxAWPositionY.Name = "textBoxAWPositionY";
            textBoxAWPositionY.Size = new Size(100, 23);
            textBoxAWPositionY.TabIndex = 1;
            // 
            // textBoxAWWidth
            // 
            textBoxAWWidth.Location = new Point(72, 70);
            textBoxAWWidth.Name = "textBoxAWWidth";
            textBoxAWWidth.Size = new Size(100, 23);
            textBoxAWWidth.TabIndex = 1;
            // 
            // textBoxAWHeight
            // 
            textBoxAWHeight.Location = new Point(72, 98);
            textBoxAWHeight.Name = "textBoxAWHeight";
            textBoxAWHeight.Size = new Size(100, 23);
            textBoxAWHeight.TabIndex = 1;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxMainForm);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            groupBoxMainForm.ResumeLayout(false);
            groupBoxMainForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMainForm;
        private Label labelAWPositionY;
        private Label labelAWPositionX;
        private TextBox textBoxAWHeight;
        private TextBox textBoxAWWidth;
        private TextBox textBoxAWPositionY;
        private TextBox textBoxAWPositionX;
        private Label labelAWPositionH;
        private Label labelAWPositionW;
    }
}