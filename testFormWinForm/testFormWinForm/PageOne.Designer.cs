using System.Windows.Forms;

namespace testFormWinForm
{
    partial class PageOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageOne));
            footerPanel = new FlowLayoutPanel();
            prevButton = new Button();
            nextButton = new Button();
            headerPicture = new PictureBox();
            clientViewPanel = new FlowLayoutPanel();
            productPanel = new Panel();
            label1 = new Label();
            contactHeaderPanel = new Panel();
            pageNumBox = new RichTextBox();
            custPartNumTextBox = new TextBox();
            custPartNumLabel = new Label();
            contactHeaderLabel = new Label();
            contactInformationPanel = new Panel();
            advancedAddressPanel = new Panel();
            phoneNumLabel = new Label();
            addressDropDown = new ComboBox();
            addressesLabel = new Label();
            refreshButton = new Button();
            accountDropDown = new ComboBox();
            accountLabel = new Label();
            meterPoPanel = new TableLayoutPanel();
            purchaseOrderPanel = new Panel();
            meterSpecPanel = new Panel();
            documentEditPanel = new Panel();
            specialReqPanel = new Panel();
            addressLine1Label = new Label();
            addressLine2Label = new Label();
            addressLine3Label = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)headerPicture).BeginInit();
            clientViewPanel.SuspendLayout();
            productPanel.SuspendLayout();
            contactHeaderPanel.SuspendLayout();
            contactInformationPanel.SuspendLayout();
            advancedAddressPanel.SuspendLayout();
            meterPoPanel.SuspendLayout();
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
            prevButton.Click += PrevButton_Click;
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
            nextButton.Click += NextButton_Click;
            // 
            // headerPicture
            // 
            headerPicture.Dock = DockStyle.Top;
            headerPicture.Image = (Image)resources.GetObject("headerPicture.Image");
            headerPicture.Location = new Point(0, 0);
            headerPicture.Name = "headerPicture";
            headerPicture.Size = new Size(1000, 50);
            headerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            headerPicture.TabIndex = 2;
            headerPicture.TabStop = false;
            // 
            // clientViewPanel
            // 
            clientViewPanel.AutoScroll = true;
            clientViewPanel.BackColor = Color.Silver;
            clientViewPanel.Controls.Add(productPanel);
            clientViewPanel.Controls.Add(contactHeaderPanel);
            clientViewPanel.Controls.Add(contactInformationPanel);
            clientViewPanel.Controls.Add(meterPoPanel);
            clientViewPanel.Controls.Add(documentEditPanel);
            clientViewPanel.Controls.Add(specialReqPanel);
            clientViewPanel.Location = new Point(0, 50);
            clientViewPanel.Name = "clientViewPanel";
            clientViewPanel.Size = new Size(1000, 713);
            clientViewPanel.TabIndex = 3;
            // 
            // productPanel
            // 
            productPanel.Anchor = AnchorStyles.None;
            productPanel.BackColor = Color.LightGray;
            productPanel.Controls.Add(label1);
            productPanel.Location = new Point(0, 0);
            productPanel.Margin = new Padding(0);
            productPanel.Name = "productPanel";
            productPanel.Size = new Size(1000, 37);
            productPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(1000, 37);
            label1.TabIndex = 0;
            label1.Text = "Product: Test Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contactHeaderPanel
            // 
            contactHeaderPanel.Anchor = AnchorStyles.None;
            contactHeaderPanel.BackColor = Color.WhiteSmoke;
            contactHeaderPanel.Controls.Add(pageNumBox);
            contactHeaderPanel.Controls.Add(custPartNumTextBox);
            contactHeaderPanel.Controls.Add(custPartNumLabel);
            contactHeaderPanel.Controls.Add(contactHeaderLabel);
            contactHeaderPanel.Location = new Point(0, 37);
            contactHeaderPanel.Margin = new Padding(0);
            contactHeaderPanel.Name = "contactHeaderPanel";
            contactHeaderPanel.Size = new Size(1000, 97);
            contactHeaderPanel.TabIndex = 1;
            // 
            // pageNumBox
            // 
            pageNumBox.DetectUrls = false;
            pageNumBox.Enabled = false;
            pageNumBox.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNumBox.Location = new Point(863, 42);
            pageNumBox.Name = "pageNumBox";
            pageNumBox.ReadOnly = true;
            pageNumBox.Size = new Size(105, 31);
            pageNumBox.TabIndex = 0;
            pageNumBox.Text = "";
            pageNumBox.WordWrap = false;
            // 
            // custPartNumTextBox
            // 
            custPartNumTextBox.Location = new Point(830, 13);
            custPartNumTextBox.Name = "custPartNumTextBox";
            custPartNumTextBox.Size = new Size(147, 23);
            custPartNumTextBox.TabIndex = 2;
            // 
            // custPartNumLabel
            // 
            custPartNumLabel.AutoSize = true;
            custPartNumLabel.Location = new Point(691, 21);
            custPartNumLabel.Name = "custPartNumLabel";
            custPartNumLabel.Size = new Size(133, 15);
            custPartNumLabel.TabIndex = 1;
            custPartNumLabel.Text = "Customer Part Number:";
            // 
            // contactHeaderLabel
            // 
            contactHeaderLabel.Anchor = AnchorStyles.None;
            contactHeaderLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactHeaderLabel.Location = new Point(380, 46);
            contactHeaderLabel.Name = "contactHeaderLabel";
            contactHeaderLabel.Size = new Size(254, 40);
            contactHeaderLabel.TabIndex = 0;
            contactHeaderLabel.Text = "Contact Information";
            contactHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contactInformationPanel
            // 
            contactInformationPanel.Anchor = AnchorStyles.None;
            contactInformationPanel.BackColor = Color.WhiteSmoke;
            contactInformationPanel.Controls.Add(advancedAddressPanel);
            contactInformationPanel.Controls.Add(addressDropDown);
            contactInformationPanel.Controls.Add(addressesLabel);
            contactInformationPanel.Controls.Add(refreshButton);
            contactInformationPanel.Controls.Add(accountDropDown);
            contactInformationPanel.Controls.Add(accountLabel);
            contactInformationPanel.Location = new Point(0, 134);
            contactInformationPanel.Margin = new Padding(0);
            contactInformationPanel.Name = "contactInformationPanel";
            contactInformationPanel.Size = new Size(1000, 354);
            contactInformationPanel.TabIndex = 2;
            // 
            // advancedAddressPanel
            // 
            advancedAddressPanel.BackColor = Color.Gainsboro;
            advancedAddressPanel.Controls.Add(textBox5);
            advancedAddressPanel.Controls.Add(textBox4);
            advancedAddressPanel.Controls.Add(textBox3);
            advancedAddressPanel.Controls.Add(textBox2);
            advancedAddressPanel.Controls.Add(textBox1);
            advancedAddressPanel.Controls.Add(label5);
            advancedAddressPanel.Controls.Add(addressLine3Label);
            advancedAddressPanel.Controls.Add(addressLine2Label);
            advancedAddressPanel.Controls.Add(addressLine1Label);
            advancedAddressPanel.Controls.Add(phoneNumLabel);
            advancedAddressPanel.Location = new Point(12, 122);
            advancedAddressPanel.Name = "advancedAddressPanel";
            advancedAddressPanel.Size = new Size(956, 214);
            advancedAddressPanel.TabIndex = 5;
            advancedAddressPanel.Visible = false;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new Point(48, 29);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(91, 15);
            phoneNumLabel.TabIndex = 0;
            phoneNumLabel.Text = "Phone Number:";
            // 
            // addressDropDown
            // 
            addressDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            addressDropDown.FormattingEnabled = true;
            addressDropDown.Location = new Point(296, 69);
            addressDropDown.Name = "addressDropDown";
            addressDropDown.Size = new Size(121, 23);
            addressDropDown.TabIndex = 4;
            addressDropDown.SelectionChangeCommitted += addressDropDown_SelectionChangeCommitted;
            // 
            // addressesLabel
            // 
            addressesLabel.AutoSize = true;
            addressesLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressesLabel.Location = new Point(206, 73);
            addressesLabel.Name = "addressesLabel";
            addressesLabel.Size = new Size(84, 19);
            addressesLabel.TabIndex = 3;
            addressesLabel.Text = "Addresses: ";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(437, 22);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 2;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += RefreshButton_Click;
            // 
            // accountDropDown
            // 
            accountDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            accountDropDown.FormattingEnabled = true;
            accountDropDown.Location = new Point(296, 22);
            accountDropDown.Name = "accountDropDown";
            accountDropDown.Size = new Size(121, 23);
            accountDropDown.TabIndex = 1;
            accountDropDown.SelectionChangeCommitted += AccountDropDown_SelectionChangeCommitted;
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountLabel.Location = new Point(221, 22);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(69, 19);
            accountLabel.TabIndex = 0;
            accountLabel.Text = "Account: ";
            // 
            // meterPoPanel
            // 
            meterPoPanel.ColumnCount = 2;
            meterPoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            meterPoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            meterPoPanel.Controls.Add(purchaseOrderPanel, 1, 0);
            meterPoPanel.Controls.Add(meterSpecPanel, 0, 0);
            meterPoPanel.Location = new Point(0, 488);
            meterPoPanel.Margin = new Padding(0);
            meterPoPanel.Name = "meterPoPanel";
            meterPoPanel.RowCount = 1;
            meterPoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            meterPoPanel.Size = new Size(1000, 121);
            meterPoPanel.TabIndex = 3;
            // 
            // purchaseOrderPanel
            // 
            purchaseOrderPanel.BackColor = Color.WhiteSmoke;
            purchaseOrderPanel.Location = new Point(503, 3);
            purchaseOrderPanel.Name = "purchaseOrderPanel";
            purchaseOrderPanel.Size = new Size(494, 115);
            purchaseOrderPanel.TabIndex = 1;
            // 
            // meterSpecPanel
            // 
            meterSpecPanel.BackColor = Color.WhiteSmoke;
            meterSpecPanel.Location = new Point(3, 3);
            meterSpecPanel.Name = "meterSpecPanel";
            meterSpecPanel.Size = new Size(494, 115);
            meterSpecPanel.TabIndex = 0;
            // 
            // documentEditPanel
            // 
            documentEditPanel.Anchor = AnchorStyles.None;
            documentEditPanel.BackColor = Color.WhiteSmoke;
            documentEditPanel.Location = new Point(0, 609);
            documentEditPanel.Margin = new Padding(0);
            documentEditPanel.Name = "documentEditPanel";
            documentEditPanel.Size = new Size(1000, 55);
            documentEditPanel.TabIndex = 3;
            // 
            // specialReqPanel
            // 
            specialReqPanel.Anchor = AnchorStyles.None;
            specialReqPanel.BackColor = Color.WhiteSmoke;
            specialReqPanel.Location = new Point(0, 664);
            specialReqPanel.Margin = new Padding(0);
            specialReqPanel.Name = "specialReqPanel";
            specialReqPanel.Size = new Size(1000, 49);
            specialReqPanel.TabIndex = 4;
            // 
            // addressLine1Label
            // 
            addressLine1Label.AutoSize = true;
            addressLine1Label.Location = new Point(48, 58);
            addressLine1Label.Name = "addressLine1Label";
            addressLine1Label.Size = new Size(91, 15);
            addressLine1Label.TabIndex = 1;
            addressLine1Label.Text = "Phone Number:";
            // 
            // addressLine2Label
            // 
            addressLine2Label.AutoSize = true;
            addressLine2Label.Location = new Point(48, 87);
            addressLine2Label.Name = "addressLine2Label";
            addressLine2Label.Size = new Size(91, 15);
            addressLine2Label.TabIndex = 2;
            addressLine2Label.Text = "Phone Number:";
            // 
            // addressLine3Label
            // 
            addressLine3Label.AutoSize = true;
            addressLine3Label.Location = new Point(48, 116);
            addressLine3Label.Name = "addressLine3Label";
            addressLine3Label.Size = new Size(91, 15);
            addressLine3Label.TabIndex = 3;
            addressLine3Label.Text = "Phone Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 145);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone Number:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(145, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(145, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(145, 108);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(234, 23);
            textBox5.TabIndex = 9;
            // 
            // PageOne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1000, 800);
            Controls.Add(headerPicture);
            Controls.Add(clientViewPanel);
            Controls.Add(footerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PageOne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)headerPicture).EndInit();
            clientViewPanel.ResumeLayout(false);
            productPanel.ResumeLayout(false);
            contactHeaderPanel.ResumeLayout(false);
            contactHeaderPanel.PerformLayout();
            contactInformationPanel.ResumeLayout(false);
            contactInformationPanel.PerformLayout();
            advancedAddressPanel.ResumeLayout(false);
            advancedAddressPanel.PerformLayout();
            meterPoPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel footerPanel;
        private Button prevButton;
        private Button nextButton;
        private PictureBox headerPicture;
        private FlowLayoutPanel clientViewPanel;
        private Panel productPanel;
        private Label label1;
        private Panel contactHeaderPanel;
        private Panel contactInformationPanel;
        private TableLayoutPanel meterPoPanel;
        private Panel purchaseOrderPanel;
        private Panel meterSpecPanel;
        private Panel documentEditPanel;
        private Panel specialReqPanel;
        private Label contactHeaderLabel;
        private TextBox custPartNumTextBox;
        private Label custPartNumLabel;
        private RichTextBox pageNumBox;
        private Label accountLabel;
        private Button refreshButton;
        private ComboBox accountDropDown;
        private ComboBox addressDropDown;
        private Label addressesLabel;
        private Panel advancedAddressPanel;
        private Label phoneNumLabel;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label addressLine3Label;
        private Label addressLine2Label;
        private Label addressLine1Label;
    }
}
