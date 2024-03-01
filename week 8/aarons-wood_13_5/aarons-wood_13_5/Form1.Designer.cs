namespace aarons_wood_13_5
{
    partial class Form1
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
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.firstDateBox = new System.Windows.Forms.TextBox();
            this.allDatesBox = new System.Windows.Forms.TextBox();
            this.firstDateBttn = new System.Windows.Forms.Button();
            this.allDatesBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberListBox
            // 
            this.numberListBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(25, 12);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(651, 329);
            this.numberListBox.TabIndex = 0;
            // 
            // firstDateBox
            // 
            this.firstDateBox.Location = new System.Drawing.Point(95, 362);
            this.firstDateBox.Name = "firstDateBox";
            this.firstDateBox.Size = new System.Drawing.Size(112, 20);
            this.firstDateBox.TabIndex = 1;
            // 
            // allDatesBox
            // 
            this.allDatesBox.Location = new System.Drawing.Point(454, 362);
            this.allDatesBox.Name = "allDatesBox";
            this.allDatesBox.Size = new System.Drawing.Size(112, 20);
            this.allDatesBox.TabIndex = 2;
            // 
            // firstDateBttn
            // 
            this.firstDateBttn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.firstDateBttn.Location = new System.Drawing.Point(81, 388);
            this.firstDateBttn.Name = "firstDateBttn";
            this.firstDateBttn.Size = new System.Drawing.Size(139, 50);
            this.firstDateBttn.TabIndex = 3;
            this.firstDateBttn.Text = "Search By First Date with value Higher than entered";
            this.firstDateBttn.UseVisualStyleBackColor = false;
            this.firstDateBttn.Click += new System.EventHandler(this.firstDateBttn_Click);
            // 
            // allDatesBttn
            // 
            this.allDatesBttn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.allDatesBttn.Location = new System.Drawing.Point(439, 388);
            this.allDatesBttn.Name = "allDatesBttn";
            this.allDatesBttn.Size = new System.Drawing.Size(139, 50);
            this.allDatesBttn.TabIndex = 4;
            this.allDatesBttn.Text = "Search by all dates with value greater than what\'s entered";
            this.allDatesBttn.UseVisualStyleBackColor = false;
            this.allDatesBttn.Click += new System.EventHandler(this.allDatesBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(706, 444);
            this.Controls.Add(this.allDatesBttn);
            this.Controls.Add(this.firstDateBttn);
            this.Controls.Add(this.allDatesBox);
            this.Controls.Add(this.firstDateBox);
            this.Controls.Add(this.numberListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.TextBox firstDateBox;
        private System.Windows.Forms.TextBox allDatesBox;
        private System.Windows.Forms.Button firstDateBttn;
        private System.Windows.Forms.Button allDatesBttn;
    }
}

