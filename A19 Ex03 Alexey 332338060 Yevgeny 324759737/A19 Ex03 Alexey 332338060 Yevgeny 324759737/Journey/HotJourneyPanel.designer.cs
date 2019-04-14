namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    partial class HotJourneyPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sexTrip = new System.Windows.Forms.Panel();
            this.preferenceLabel = new System.Windows.Forms.Label();
            this.preferenceComboBox = new System.Windows.Forms.ComboBox();
            this.drugsCheckBox = new System.Windows.Forms.CheckBox();
            this.sexTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sexTrip
            // 
            this.sexTrip.Controls.Add(this.drugsCheckBox);
            this.sexTrip.Controls.Add(this.preferenceComboBox);
            this.sexTrip.Controls.Add(this.preferenceLabel);
            this.sexTrip.Location = new System.Drawing.Point(59, 52);
            this.sexTrip.Name = "sexTrip";
            this.sexTrip.Size = new System.Drawing.Size(231, 195);
            this.sexTrip.TabIndex = 0;
            // 
            // preferenceLabel
            // 
            this.preferenceLabel.AutoSize = true;
            this.preferenceLabel.Location = new System.Drawing.Point(13, 21);
            this.preferenceLabel.Name = "preferenceLabel";
            this.preferenceLabel.Size = new System.Drawing.Size(100, 13);
            this.preferenceLabel.TabIndex = 0;
            this.preferenceLabel.Text = "Sexual Preference :";
            // 
            // preferenceComboBox
            // 
            this.preferenceComboBox.FormattingEnabled = true;
            this.preferenceComboBox.Items.AddRange(new object[] {
            "Men",
            "Women",
            "Bisexual"});
            this.preferenceComboBox.Location = new System.Drawing.Point(120, 21);
            this.preferenceComboBox.Name = "preferenceComboBox";
            this.preferenceComboBox.Size = new System.Drawing.Size(73, 21);
            this.preferenceComboBox.TabIndex = 1;
            this.preferenceComboBox.Text = "Choose preference";
            // 
            // drugsCheckBox
            // 
            this.drugsCheckBox.AutoSize = true;
            this.drugsCheckBox.Location = new System.Drawing.Point(16, 72);
            this.drugsCheckBox.Name = "drugsCheckBox";
            this.drugsCheckBox.Size = new System.Drawing.Size(87, 17);
            this.drugsCheckBox.TabIndex = 2;
            this.drugsCheckBox.Text = "Takes Drugs";
            this.drugsCheckBox.UseVisualStyleBackColor = true;
            // 
            // HotJourneyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sexTrip);
            this.Name = "HotJourneyPanel";
            this.Size = new System.Drawing.Size(302, 250);
            this.sexTrip.ResumeLayout(false);
            this.sexTrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sexTrip;
        private System.Windows.Forms.CheckBox drugsCheckBox;
        private System.Windows.Forms.ComboBox preferenceComboBox;
        private System.Windows.Forms.Label preferenceLabel;
    }
}
