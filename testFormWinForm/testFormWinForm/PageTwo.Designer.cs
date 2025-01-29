using System.Windows.Forms;

namespace testFormWinForm
{
    partial class PageTwo
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
            footerPanel = new FlowLayoutPanel();
            prevButton = new Button();
            nextButton = new Button();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // footerPanel
            // 
            footerPanel.Anchor = AnchorStyles.None;
            footerPanel.BackColor = Color.FromArgb(24, 30, 54);
            footerPanel.Controls.Add(prevButton);
            footerPanel.Controls.Add(nextButton);
            footerPanel.Location = new Point(0, 766);
            footerPanel.Margin = new Padding(0);
            footerPanel.Name = "footerPanel";
            footerPanel.Padding = new Padding(400, 0, 400, 0);
            footerPanel.Size = new Size(1000, 34);
            footerPanel.TabIndex = 1;
            // 
            // prevButton
            // 
            prevButton.Anchor = AnchorStyles.None;
            prevButton.BackColor = Color.FromArgb(255, 192, 192);
            prevButton.FlatStyle = FlatStyle.Flat;
            prevButton.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            prevButton.Location = new Point(400, 5);
            prevButton.Margin = new Padding(0, 5, 25, 5);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(75, 23);
            prevButton.TabIndex = 0;
            prevButton.Text = "<- Previous";
            prevButton.UseVisualStyleBackColor = false;
            prevButton.Click += this.PrevButton_Click;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.None;
            nextButton.BackColor = Color.FromArgb(192, 255, 192);
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            nextButton.Location = new Point(525, 5);
            nextButton.Margin = new Padding(25, 5, 0, 5);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 1;
            nextButton.Text = "->";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += this.NextButton_Click;
            // 
            // basicTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1000, 800);
            Controls.Add(footerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "basicTemplate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel footerPanel;
        private Button prevButton;
        private Button nextButton;
    }
}
