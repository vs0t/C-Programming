namespace aarons_wood_13_1
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
            this.integerListBox = new System.Windows.Forms.ListBox();
            this.negativeBttn = new System.Windows.Forms.Button();
            this.findallBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // integerListBox
            // 
            this.integerListBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.integerListBox.FormattingEnabled = true;
            this.integerListBox.Location = new System.Drawing.Point(78, 12);
            this.integerListBox.Name = "integerListBox";
            this.integerListBox.Size = new System.Drawing.Size(225, 290);
            this.integerListBox.TabIndex = 0;
            // 
            // negativeBttn
            // 
            this.negativeBttn.BackColor = System.Drawing.Color.Salmon;
            this.negativeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.negativeBttn.Location = new System.Drawing.Point(48, 324);
            this.negativeBttn.Name = "negativeBttn";
            this.negativeBttn.Size = new System.Drawing.Size(125, 47);
            this.negativeBttn.TabIndex = 1;
            this.negativeBttn.Text = "Remove Negative Numbers";
            this.negativeBttn.UseVisualStyleBackColor = false;
            this.negativeBttn.Click += new System.EventHandler(this.negativeBttn_Click);
            // 
            // findallBttn
            // 
            this.findallBttn.BackColor = System.Drawing.Color.Salmon;
            this.findallBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findallBttn.Location = new System.Drawing.Point(209, 324);
            this.findallBttn.Name = "findallBttn";
            this.findallBttn.Size = new System.Drawing.Size(125, 47);
            this.findallBttn.TabIndex = 2;
            this.findallBttn.Text = "Display Remaing Values Between 1 - 10";
            this.findallBttn.UseVisualStyleBackColor = false;
            this.findallBttn.Click += new System.EventHandler(this.findallBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(404, 392);
            this.Controls.Add(this.findallBttn);
            this.Controls.Add(this.negativeBttn);
            this.Controls.Add(this.integerListBox);
            this.Name = "Form1";
            this.Text = "Integer List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox integerListBox;
        private System.Windows.Forms.Button negativeBttn;
        private System.Windows.Forms.Button findallBttn;
    }
}

