namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    partial class DealDetails
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
            this.ComboboxOrigin = new System.Windows.Forms.ComboBox();
            this.citiesLabel = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.arrivalDateTextBox = new System.Windows.Forms.TextBox();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.departureDateTextBox = new System.Windows.Forms.TextBox();
            this.panelRadioButtons = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.ComboboxDestination = new System.Windows.Forms.ComboBox();
            this.checkBoxInviteFriend = new System.Windows.Forms.CheckBox();
            this.comboBoxFriendsList = new System.Windows.Forms.ComboBox();
            this.panelRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboboxOrigin
            // 
            this.ComboboxOrigin.FormattingEnabled = true;
            this.ComboboxOrigin.Location = new System.Drawing.Point(13, 87);
            this.ComboboxOrigin.Name = "ComboboxOrigin";
            this.ComboboxOrigin.Size = new System.Drawing.Size(121, 21);
            this.ComboboxOrigin.TabIndex = 0;
            // 
            // citiesLabel
            // 
            this.citiesLabel.AutoSize = true;
            this.citiesLabel.Location = new System.Drawing.Point(12, 71);
            this.citiesLabel.Name = "citiesLabel";
            this.citiesLabel.Size = new System.Drawing.Size(37, 13);
            this.citiesLabel.TabIndex = 2;
            this.citiesLabel.Text = "Origin:";
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(12, 160);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(68, 13);
            this.labelArrivalDate.TabIndex = 11;
            this.labelArrivalDate.Text = "Arrival Date :\r\n";
            // 
            // arrivalDateTextBox
            // 
            this.arrivalDateTextBox.Location = new System.Drawing.Point(137, 153);
            this.arrivalDateTextBox.Name = "arrivalDateTextBox";
            this.arrivalDateTextBox.Size = new System.Drawing.Size(67, 20);
            this.arrivalDateTextBox.TabIndex = 12;
            this.arrivalDateTextBox.Text = "  /  /";
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(10, 207);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(86, 13);
            this.labelDepartureDate.TabIndex = 13;
            this.labelDepartureDate.Text = "Departure Date :";
            // 
            // departureDateTextBox
            // 
            this.departureDateTextBox.Location = new System.Drawing.Point(137, 200);
            this.departureDateTextBox.Name = "departureDateTextBox";
            this.departureDateTextBox.Size = new System.Drawing.Size(67, 20);
            this.departureDateTextBox.TabIndex = 14;
            this.departureDateTextBox.Text = "  /  /";
            // 
            // panelRadioButtons
            // 
            this.panelRadioButtons.Controls.Add(this.applyButton);
            this.panelRadioButtons.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelRadioButtons.Location = new System.Drawing.Point(21, 285);
            this.panelRadioButtons.Name = "panelRadioButtons";
            this.panelRadioButtons.Size = new System.Drawing.Size(271, 87);
            this.panelRadioButtons.TabIndex = 15;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(198, 52);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(59, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Visible = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(107, 433);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 16;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(168, 71);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(63, 13);
            this.destinationLabel.TabIndex = 17;
            this.destinationLabel.Text = "Destination:";
            // 
            // ComboboxDestination
            // 
            this.ComboboxDestination.FormattingEnabled = true;
            this.ComboboxDestination.Location = new System.Drawing.Point(171, 87);
            this.ComboboxDestination.Name = "ComboboxDestination";
            this.ComboboxDestination.Size = new System.Drawing.Size(121, 21);
            this.ComboboxDestination.TabIndex = 18;
            // 
            // checkBoxInviteFriend
            // 
            this.checkBoxInviteFriend.AutoSize = true;
            this.checkBoxInviteFriend.Location = new System.Drawing.Point(21, 403);
            this.checkBoxInviteFriend.Name = "checkBoxInviteFriend";
            this.checkBoxInviteFriend.Size = new System.Drawing.Size(80, 17);
            this.checkBoxInviteFriend.TabIndex = 19;
            this.checkBoxInviteFriend.Text = "invite friend";
            this.checkBoxInviteFriend.UseVisualStyleBackColor = true;
            this.checkBoxInviteFriend.CheckedChanged += new System.EventHandler(this.checkBoxInviteFriend_CheckedChanged);
            // 
            // comboBoxFriendsList
            // 
            this.comboBoxFriendsList.FormattingEnabled = true;
            this.comboBoxFriendsList.Location = new System.Drawing.Point(107, 403);
            this.comboBoxFriendsList.Name = "comboBoxFriendsList";
            this.comboBoxFriendsList.Size = new System.Drawing.Size(185, 21);
            this.comboBoxFriendsList.TabIndex = 20;
            this.comboBoxFriendsList.Visible = false;
            // 
            // DealDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 468);
            this.Controls.Add(this.comboBoxFriendsList);
            this.Controls.Add(this.checkBoxInviteFriend);
            this.Controls.Add(this.ComboboxDestination);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.panelRadioButtons);
            this.Controls.Add(this.departureDateTextBox);
            this.Controls.Add(this.labelDepartureDate);
            this.Controls.Add(this.arrivalDateTextBox);
            this.Controls.Add(this.labelArrivalDate);
            this.Controls.Add(this.citiesLabel);
            this.Controls.Add(this.ComboboxOrigin);
            this.Name = "DealDetails";
            this.Text = "BirthdayFlight";
            this.panelRadioButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboboxOrigin;
        private System.Windows.Forms.Label citiesLabel;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.TextBox arrivalDateTextBox;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.TextBox departureDateTextBox;
        private System.Windows.Forms.Panel panelRadioButtons;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.ComboBox ComboboxDestination;
        private System.Windows.Forms.CheckBox checkBoxInviteFriend;
        private System.Windows.Forms.ComboBox comboBoxFriendsList;
    }
}