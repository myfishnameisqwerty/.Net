namespace Ex05_FourinRow_GUI
{
    partial class GameSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUDRows = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUDColumns = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player1:";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(91, 64);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(223, 20);
            this.textBoxPlayer1.TabIndex = 2;
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.checkBoxPlayer2.Location = new System.Drawing.Point(16, 108);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(70, 19);
            this.checkBoxPlayer2.TabIndex = 3;
            this.checkBoxPlayer2.Text = "Player2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(91, 106);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(223, 20);
            this.textBoxPlayer2.TabIndex = 4;
            this.textBoxPlayer2.Text = "Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "BoardSize:";
            // 
            // numericUDRows
            // 
            this.numericUDRows.AutoSize = true;
            this.numericUDRows.Location = new System.Drawing.Point(70, 188);
            this.numericUDRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUDRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUDRows.Name = "numericUDRows";
            this.numericUDRows.Size = new System.Drawing.Size(35, 20);
            this.numericUDRows.TabIndex = 6;
            this.numericUDRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(23, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rows:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label5.Location = new System.Drawing.Point(131, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Columns:";
            // 
            // numericUDColumns
            // 
            this.numericUDColumns.AutoSize = true;
            this.numericUDColumns.Location = new System.Drawing.Point(215, 188);
            this.numericUDColumns.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUDColumns.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUDColumns.Name = "numericUDColumns";
            this.numericUDColumns.Size = new System.Drawing.Size(35, 20);
            this.numericUDColumns.TabIndex = 9;
            this.numericUDColumns.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.buttonStart.Location = new System.Drawing.Point(91, 249);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(144, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUDColumns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUDRows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.Text = "GameSettings";
            this.Load += new System.EventHandler(this.GameSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUDRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUDRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUDColumns;
        private System.Windows.Forms.Button buttonStart;
    }
}