namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    partial class PilgrimagePanel
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
            this.religionPanel = new System.Windows.Forms.Panel();
            this.faithLabel = new System.Windows.Forms.Label();
            this.faithCombo = new System.Windows.Forms.ComboBox();
            this.religionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // religionPanel
            // 
            this.religionPanel.Controls.Add(this.faithCombo);
            this.religionPanel.Controls.Add(this.faithLabel);
            this.religionPanel.Location = new System.Drawing.Point(35, 26);
            this.religionPanel.Name = "religionPanel";
            this.religionPanel.Size = new System.Drawing.Size(115, 100);
            this.religionPanel.TabIndex = 0;
            // 
            // faithLabel
            // 
            this.faithLabel.AutoSize = true;
            this.faithLabel.Location = new System.Drawing.Point(3, 20);
            this.faithLabel.Name = "faithLabel";
            this.faithLabel.Size = new System.Drawing.Size(36, 13);
            this.faithLabel.TabIndex = 0;
            this.faithLabel.Text = "Faith :";
            // 
            // faithCombo
            // 
            this.faithCombo.FormattingEnabled = true;
            this.faithCombo.Items.AddRange(new object[] {
            "Buddhism",
            "Christianity",
            "Islam",
            "Judaism"});
            this.faithCombo.Location = new System.Drawing.Point(43, 17);
            this.faithCombo.Name = "faithCombo";
            this.faithCombo.Size = new System.Drawing.Size(69, 21);
            this.faithCombo.TabIndex = 1;
            this.faithCombo.Text = "Choose faith :";
            // 
            // PilgrimagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.religionPanel);
            this.Name = "PilgrimagePanel";
            this.religionPanel.ResumeLayout(false);
            this.religionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel religionPanel;
        private System.Windows.Forms.ComboBox faithCombo;
        private System.Windows.Forms.Label faithLabel;
    }
}
