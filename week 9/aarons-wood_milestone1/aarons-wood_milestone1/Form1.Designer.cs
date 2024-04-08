namespace aarons_wood_milestone1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuBttn = new System.Windows.Forms.Button();
            this.usersBttn = new System.Windows.Forms.Button();
            this.inventoryBttn = new System.Windows.Forms.Button();
            this.orderBttn = new System.Windows.Forms.Button();
            this.placeOrderBttn = new System.Windows.Forms.Button();
            this.reportsBttn = new System.Windows.Forms.Button();
            this.tablesBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the TCTG Application! Select an option below to open that program.";
            // 
            // menuBttn
            // 
            this.menuBttn.BackColor = System.Drawing.Color.Salmon;
            this.menuBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBttn.Location = new System.Drawing.Point(62, 216);
            this.menuBttn.Name = "menuBttn";
            this.menuBttn.Size = new System.Drawing.Size(127, 59);
            this.menuBttn.TabIndex = 1;
            this.menuBttn.Text = "View Menu";
            this.menuBttn.UseVisualStyleBackColor = false;
            this.menuBttn.Click += new System.EventHandler(this.menuBttn_Click);
            // 
            // usersBttn
            // 
            this.usersBttn.BackColor = System.Drawing.Color.Orange;
            this.usersBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usersBttn.Location = new System.Drawing.Point(195, 216);
            this.usersBttn.Name = "usersBttn";
            this.usersBttn.Size = new System.Drawing.Size(127, 59);
            this.usersBttn.TabIndex = 2;
            this.usersBttn.Text = "View Users";
            this.usersBttn.UseVisualStyleBackColor = false;
            this.usersBttn.Click += new System.EventHandler(this.usersBttn_Click);
            // 
            // inventoryBttn
            // 
            this.inventoryBttn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.inventoryBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inventoryBttn.Location = new System.Drawing.Point(328, 216);
            this.inventoryBttn.Name = "inventoryBttn";
            this.inventoryBttn.Size = new System.Drawing.Size(127, 59);
            this.inventoryBttn.TabIndex = 3;
            this.inventoryBttn.Text = "View Inventory";
            this.inventoryBttn.UseVisualStyleBackColor = false;
            this.inventoryBttn.Click += new System.EventHandler(this.inventoryBttn_Click);
            // 
            // orderBttn
            // 
            this.orderBttn.BackColor = System.Drawing.Color.MediumPurple;
            this.orderBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderBttn.Location = new System.Drawing.Point(461, 216);
            this.orderBttn.Name = "orderBttn";
            this.orderBttn.Size = new System.Drawing.Size(127, 59);
            this.orderBttn.TabIndex = 4;
            this.orderBttn.Text = "View Orders";
            this.orderBttn.UseVisualStyleBackColor = false;
            this.orderBttn.Click += new System.EventHandler(this.orderBttn_Click);
            // 
            // placeOrderBttn
            // 
            this.placeOrderBttn.BackColor = System.Drawing.Color.MediumPurple;
            this.placeOrderBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.placeOrderBttn.Location = new System.Drawing.Point(461, 281);
            this.placeOrderBttn.Name = "placeOrderBttn";
            this.placeOrderBttn.Size = new System.Drawing.Size(127, 59);
            this.placeOrderBttn.TabIndex = 5;
            this.placeOrderBttn.Text = "Place Order";
            this.placeOrderBttn.UseVisualStyleBackColor = false;
            this.placeOrderBttn.Click += new System.EventHandler(this.placeOrderBttn_Click);
            // 
            // reportsBttn
            // 
            this.reportsBttn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.reportsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportsBttn.Location = new System.Drawing.Point(594, 216);
            this.reportsBttn.Name = "reportsBttn";
            this.reportsBttn.Size = new System.Drawing.Size(127, 59);
            this.reportsBttn.TabIndex = 6;
            this.reportsBttn.Text = "Generate Report(s)";
            this.reportsBttn.UseVisualStyleBackColor = false;
            this.reportsBttn.Click += new System.EventHandler(this.reportsBttn_Click);
            // 
            // tablesBttn
            // 
            this.tablesBttn.BackColor = System.Drawing.Color.MediumPurple;
            this.tablesBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tablesBttn.Location = new System.Drawing.Point(461, 346);
            this.tablesBttn.Name = "tablesBttn";
            this.tablesBttn.Size = new System.Drawing.Size(127, 59);
            this.tablesBttn.TabIndex = 7;
            this.tablesBttn.Text = "View Tables";
            this.tablesBttn.UseVisualStyleBackColor = false;
            this.tablesBttn.Click += new System.EventHandler(this.tablesBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablesBttn);
            this.Controls.Add(this.reportsBttn);
            this.Controls.Add(this.placeOrderBttn);
            this.Controls.Add(this.orderBttn);
            this.Controls.Add(this.inventoryBttn);
            this.Controls.Add(this.usersBttn);
            this.Controls.Add(this.menuBttn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menuBttn;
        private System.Windows.Forms.Button usersBttn;
        private System.Windows.Forms.Button inventoryBttn;
        private System.Windows.Forms.Button orderBttn;
        private System.Windows.Forms.Button placeOrderBttn;
        private System.Windows.Forms.Button reportsBttn;
        private System.Windows.Forms.Button tablesBttn;
    }
}

