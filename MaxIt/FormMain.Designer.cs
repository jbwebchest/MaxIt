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
            labelTitle = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(319, 50);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(330, 117);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "MAX IT!";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(984, 561);
            Controls.Add(labelTitle);
            DoubleBuffered = true;
            MinimumSize = new Size(1000, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAX IT!";
            Load += FormMainLoad;
            Resize += FormMainResize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
    }
}