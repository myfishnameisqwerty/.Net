namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    partial class ProgramMenu
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
            this.comboBoxDateRange = new System.Windows.Forms.ComboBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonShowTop5 = new System.Windows.Forms.Button();
            this.labelSlash = new System.Windows.Forms.Label();
            this.richTextBoxShowText = new System.Windows.Forms.Label();
            this.comboBoxPostOrPhoto = new System.Windows.Forms.ComboBox();
            this.radioButtonFilterMyTopContent = new System.Windows.Forms.RadioButton();
            this.radioButtonShowMyFollowers = new System.Windows.Forms.RadioButton();
            this.labelMaxItemsToDisplay = new System.Windows.Forms.Label();
            this.labelCurrentItemNumber = new System.Windows.Forms.Label();
            this.pictureBoxForPhotos = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebookLogout = new System.Windows.Forms.PictureBox();
            this.richTextShowText = new System.Windows.Forms.RichTextBox();
            this.toolTipForVocation = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDateRange
            // 
            this.comboBoxDateRange.FormattingEnabled = true;
            this.comboBoxDateRange.Location = new System.Drawing.Point(12, 100);
            this.comboBoxDateRange.Name = "comboBoxDateRange";
            this.comboBoxDateRange.Size = new System.Drawing.Size(114, 21);
            this.comboBoxDateRange.TabIndex = 2;
            this.comboBoxDateRange.Text = "Select date range";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(95, 26);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(31, 13);
            this.labelHello.TabIndex = 6;
            this.labelHello.Text = "Hello";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(95, 42);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 13);
            this.labelUserName.TabIndex = 7;
            // 
            // buttonShowTop5
            // 
            this.buttonShowTop5.Location = new System.Drawing.Point(12, 146);
            this.buttonShowTop5.Name = "buttonShowTop5";
            this.buttonShowTop5.Size = new System.Drawing.Size(114, 23);
            this.buttonShowTop5.TabIndex = 12;
            this.buttonShowTop5.Text = "Show my Top 5";
            this.buttonShowTop5.UseVisualStyleBackColor = true;
            this.buttonShowTop5.Click += new System.EventHandler(this.buttonShowTop5_Click);
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.Location = new System.Drawing.Point(183, 681);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(12, 13);
            this.labelSlash.TabIndex = 16;
            this.labelSlash.Text = "/";
            this.labelSlash.Visible = false;
            // 
            // richTextBoxShowText
            // 
            this.richTextBoxShowText.AutoSize = true;
            this.richTextBoxShowText.Location = new System.Drawing.Point(201, 53);
            this.richTextBoxShowText.Name = "richTextBoxShowText";
            this.richTextBoxShowText.Size = new System.Drawing.Size(0, 13);
            this.richTextBoxShowText.TabIndex = 17;
            // 
            // comboBoxPostOrPhoto
            // 
            this.comboBoxPostOrPhoto.FormattingEnabled = true;
            this.comboBoxPostOrPhoto.Location = new System.Drawing.Point(256, 104);
            this.comboBoxPostOrPhoto.Name = "comboBoxPostOrPhoto";
            this.comboBoxPostOrPhoto.Size = new System.Drawing.Size(101, 21);
            this.comboBoxPostOrPhoto.TabIndex = 18;
            this.comboBoxPostOrPhoto.Text = "posts or photos";
            // 
            // radioButtonFilterMyTopContent
            // 
            this.radioButtonFilterMyTopContent.AutoSize = true;
            this.radioButtonFilterMyTopContent.Location = new System.Drawing.Point(132, 104);
            this.radioButtonFilterMyTopContent.Name = "radioButtonFilterMyTopContent";
            this.radioButtonFilterMyTopContent.Size = new System.Drawing.Size(118, 17);
            this.radioButtonFilterMyTopContent.TabIndex = 19;
            this.radioButtonFilterMyTopContent.TabStop = true;
            this.radioButtonFilterMyTopContent.Text = "Show my most liked";
            this.radioButtonFilterMyTopContent.UseVisualStyleBackColor = true;
            this.radioButtonFilterMyTopContent.CheckedChanged += new System.EventHandler(this.radioButtonFilterMyTopContent_CheckedChanged);
            // 
            // radioButtonShowMyFollowers
            // 
            this.radioButtonShowMyFollowers.AutoSize = true;
            this.radioButtonShowMyFollowers.Location = new System.Drawing.Point(132, 149);
            this.radioButtonShowMyFollowers.Name = "radioButtonShowMyFollowers";
            this.radioButtonShowMyFollowers.Size = new System.Drawing.Size(137, 17);
            this.radioButtonShowMyFollowers.TabIndex = 20;
            this.radioButtonShowMyFollowers.TabStop = true;
            this.radioButtonShowMyFollowers.Text = "Show my top 5 folowers";
            this.radioButtonShowMyFollowers.UseVisualStyleBackColor = true;
            // 
            // labelMaxItemsToDisplay
            // 
            this.labelMaxItemsToDisplay.AutoSize = true;
            this.labelMaxItemsToDisplay.Location = new System.Drawing.Point(201, 681);
            this.labelMaxItemsToDisplay.Name = "labelMaxItemsToDisplay";
            this.labelMaxItemsToDisplay.Size = new System.Drawing.Size(0, 13);
            this.labelMaxItemsToDisplay.TabIndex = 21;
            // 
            // labelCurrentItemNumber
            // 
            this.labelCurrentItemNumber.AutoSize = true;
            this.labelCurrentItemNumber.Location = new System.Drawing.Point(164, 681);
            this.labelCurrentItemNumber.Name = "labelCurrentItemNumber";
            this.labelCurrentItemNumber.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentItemNumber.TabIndex = 22;
            // 
            // pictureBoxForPhotos
            // 
            this.pictureBoxForPhotos.Location = new System.Drawing.Point(15, 351);
            this.pictureBoxForPhotos.Name = "pictureBoxForPhotos";
            this.pictureBoxForPhotos.Size = new System.Drawing.Size(345, 237);
            this.pictureBoxForPhotos.TabIndex = 15;
            this.pictureBoxForPhotos.TabStop = false;
            this.pictureBoxForPhotos.Visible = false;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLeft.Location = new System.Drawing.Point(12, 613);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(50, 35);
            this.pictureBoxLeft.TabIndex = 14;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.Visible = false;
            this.pictureBoxLeft.Click += new System.EventHandler(this.pictureBoxLeft_Click);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRight.Location = new System.Drawing.Point(306, 613);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(50, 34);
            this.pictureBoxRight.TabIndex = 13;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.Visible = false;
            this.pictureBoxRight.Click += new System.EventHandler(this.pictureBoxRight_Click);
            // 
            // pictureBoxProfilePhoto
            // 
            this.pictureBoxProfilePhoto.Location = new System.Drawing.Point(12, 1);
            this.pictureBoxProfilePhoto.Name = "pictureBoxProfilePhoto";
            this.pictureBoxProfilePhoto.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxProfilePhoto.TabIndex = 5;
            this.pictureBoxProfilePhoto.TabStop = false;
            // 
            // pictureBoxFacebookLogout
            // 
            this.pictureBoxFacebookLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFacebookLogout.Location = new System.Drawing.Point(158, 1);
            this.pictureBoxFacebookLogout.Name = "pictureBoxFacebookLogout";
            this.pictureBoxFacebookLogout.Size = new System.Drawing.Size(199, 38);
            this.pictureBoxFacebookLogout.TabIndex = 0;
            this.pictureBoxFacebookLogout.TabStop = false;
            this.pictureBoxFacebookLogout.Click += new System.EventHandler(this.pictureBoxFacebookLogout_Click);
            // 
            // richTextShowText
            // 
            this.richTextShowText.Location = new System.Drawing.Point(12, 249);
            this.richTextShowText.Name = "richTextShowText";
            this.richTextShowText.Size = new System.Drawing.Size(348, 96);
            this.richTextShowText.TabIndex = 23;
            this.richTextShowText.Text = "";
            this.richTextShowText.Validating += new System.ComponentModel.CancelEventHandler(this.richTextShowText_Validating);
            // 
            // ProgramMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.richTextShowText);
            this.Controls.Add(this.labelCurrentItemNumber);
            this.Controls.Add(this.labelMaxItemsToDisplay);
            this.Controls.Add(this.radioButtonShowMyFollowers);
            this.Controls.Add(this.radioButtonFilterMyTopContent);
            this.Controls.Add(this.comboBoxPostOrPhoto);
            this.Controls.Add(this.richTextBoxShowText);
            this.Controls.Add(this.labelSlash);
            this.Controls.Add(this.pictureBoxForPhotos);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.buttonShowTop5);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBoxProfilePhoto);
            this.Controls.Add(this.comboBoxDateRange);
            this.Controls.Add(this.pictureBoxFacebookLogout);
            this.Name = "ProgramMenu";
            this.Size = new System.Drawing.Size(369, 652);
            this.Load += new System.EventHandler(this.ProgramMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFacebookLogout;
        private System.Windows.Forms.ComboBox comboBoxDateRange;
        private System.Windows.Forms.PictureBox pictureBoxProfilePhoto;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonShowTop5;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxForPhotos;
        private System.Windows.Forms.Label labelSlash;
        private System.Windows.Forms.Label richTextBoxShowText;
        private System.Windows.Forms.Label labelMaxItemsToDisplay;
        private System.Windows.Forms.Label labelCurrentItemNumber;
        private System.Windows.Forms.RichTextBox richTextShowText;
        private System.Windows.Forms.ToolTip toolTipForVocation;
        public System.Windows.Forms.ComboBox comboBoxPostOrPhoto;
        public System.Windows.Forms.RadioButton radioButtonFilterMyTopContent;
        public System.Windows.Forms.RadioButton radioButtonShowMyFollowers;
    }
}