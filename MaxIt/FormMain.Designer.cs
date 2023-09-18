namespace MaxIt
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            timerLogo = new System.Windows.Forms.Timer(components);
            labelLogo = new Label();
            panelSettings = new Panel();
            SuspendLayout();
            // 
            // timerLogo
            // 
            timerLogo.Interval = 1000;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogo.ForeColor = Color.White;
            labelLogo.Location = new Point(12, 339);
            labelLogo.Name = "labelLogo";
            labelLogo.Padding = new Padding(8, 0, 0, 0);
            labelLogo.Size = new Size(469, 117);
            labelLogo.TabIndex = 3;
            labelLogo.Text = "WEBCHEST";
            // 
            // panelSettings
            // 
            panelSettings.Location = new Point(12, 481);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(593, 68);
            panelSettings.TabIndex = 1;
            panelSettings.Resize += PanelLogoResize;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1184, 561);
            Controls.Add(labelLogo);
            Controls.Add(panelSettings);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1200, 600);
            MinimumSize = new Size(1200, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAX IT";
            Load += FormMainLoad;
            Shown += FormMainShown;
            Resize += FormMainResize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timerLogo;
        private Label labelLogo;
        private Panel panelSettings;
    }
}