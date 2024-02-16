namespace aarons_wood_cc5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.patientInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.patientInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.bttnHeight = new System.Windows.Forms.Button();
            this.bttnWeight200 = new System.Windows.Forms.Button();
            this.bttnWeight100 = new System.Windows.Forms.Button();
            this.bttnAlc = new System.Windows.Forms.Button();
            this.bttnAge = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._aarons_woodMedicalDataSet = new aarons_wood_cc5._aarons_woodMedicalDataSet();
            this.patientInfoTableAdapter = new aarons_wood_cc5._aarons_woodMedicalDataSetTableAdapters.patientInfoTableAdapter();
            this.tableAdapterManager = new aarons_wood_cc5._aarons_woodMedicalDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingNavigator)).BeginInit();
            this.patientInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._aarons_woodMedicalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // patientInfoBindingNavigator
            // 
            this.patientInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientInfoBindingNavigator.BindingSource = this.patientInfoBindingSource;
            this.patientInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patientInfoBindingNavigatorSaveItem});
            this.patientInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientInfoBindingNavigator.Name = "patientInfoBindingNavigator";
            this.patientInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientInfoBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.patientInfoBindingNavigator.TabIndex = 0;
            this.patientInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // patientInfoBindingNavigatorSaveItem
            // 
            this.patientInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientInfoBindingNavigatorSaveItem.Image")));
            this.patientInfoBindingNavigatorSaveItem.Name = "patientInfoBindingNavigatorSaveItem";
            this.patientInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.patientInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientInfoBindingNavigatorSaveItem_Click);
            // 
            // patientInfoDataGridView
            // 
            this.patientInfoDataGridView.AllowUserToAddRows = false;
            this.patientInfoDataGridView.AllowUserToDeleteRows = false;
            this.patientInfoDataGridView.AutoGenerateColumns = false;
            this.patientInfoDataGridView.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.patientInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.patientInfoDataGridView.DataSource = this.patientInfoBindingSource;
            this.patientInfoDataGridView.GridColor = System.Drawing.Color.Gray;
            this.patientInfoDataGridView.Location = new System.Drawing.Point(0, 28);
            this.patientInfoDataGridView.Name = "patientInfoDataGridView";
            this.patientInfoDataGridView.ReadOnly = true;
            this.patientInfoDataGridView.Size = new System.Drawing.Size(644, 220);
            this.patientInfoDataGridView.TabIndex = 1;
            // 
            // bttnHeight
            // 
            this.bttnHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnHeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnHeight.Location = new System.Drawing.Point(0, 268);
            this.bttnHeight.Name = "bttnHeight";
            this.bttnHeight.Size = new System.Drawing.Size(89, 41);
            this.bttnHeight.TabIndex = 2;
            this.bttnHeight.Text = "Height in descending order";
            this.bttnHeight.UseVisualStyleBackColor = false;
            this.bttnHeight.Click += new System.EventHandler(this.bttnHeight_Click);
            // 
            // bttnWeight200
            // 
            this.bttnWeight200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnWeight200.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnWeight200.Location = new System.Drawing.Point(139, 268);
            this.bttnWeight200.Name = "bttnWeight200";
            this.bttnWeight200.Size = new System.Drawing.Size(89, 41);
            this.bttnWeight200.TabIndex = 3;
            this.bttnWeight200.Text = "Weight above 200";
            this.bttnWeight200.UseVisualStyleBackColor = false;
            this.bttnWeight200.Click += new System.EventHandler(this.bttnWeight200_Click);
            // 
            // bttnWeight100
            // 
            this.bttnWeight100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bttnWeight100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnWeight100.Location = new System.Drawing.Point(278, 268);
            this.bttnWeight100.Name = "bttnWeight100";
            this.bttnWeight100.Size = new System.Drawing.Size(89, 41);
            this.bttnWeight100.TabIndex = 4;
            this.bttnWeight100.Text = "Weight under 100";
            this.bttnWeight100.UseVisualStyleBackColor = false;
            this.bttnWeight100.Click += new System.EventHandler(this.bttnWeight100_Click);
            // 
            // bttnAlc
            // 
            this.bttnAlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttnAlc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnAlc.Location = new System.Drawing.Point(409, 268);
            this.bttnAlc.Name = "bttnAlc";
            this.bttnAlc.Size = new System.Drawing.Size(89, 41);
            this.bttnAlc.TabIndex = 5;
            this.bttnAlc.Text = "A1c value over 5.7";
            this.bttnAlc.UseVisualStyleBackColor = false;
            this.bttnAlc.Click += new System.EventHandler(this.bttnAlc_Click);
            // 
            // bttnAge
            // 
            this.bttnAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bttnAge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnAge.Location = new System.Drawing.Point(543, 268);
            this.bttnAge.Name = "bttnAge";
            this.bttnAge.Size = new System.Drawing.Size(89, 41);
            this.bttnAge.TabIndex = 6;
            this.bttnAge.Text = "Age over 70";
            this.bttnAge.UseVisualStyleBackColor = false;
            this.bttnAge.Click += new System.EventHandler(this.bttnAge_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "patientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "patientID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "height";
            this.dataGridViewTextBoxColumn3.HeaderText = "height";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "weight";
            this.dataGridViewTextBoxColumn4.HeaderText = "weight";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "alcvalue";
            this.dataGridViewTextBoxColumn5.HeaderText = "alcvalue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn6.HeaderText = "age";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // patientInfoBindingSource
            // 
            this.patientInfoBindingSource.DataMember = "patientInfo";
            this.patientInfoBindingSource.DataSource = this._aarons_woodMedicalDataSet;
            // 
            // _aarons_woodMedicalDataSet
            // 
            this._aarons_woodMedicalDataSet.DataSetName = "_aarons_woodMedicalDataSet";
            this._aarons_woodMedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientInfoTableAdapter
            // 
            this.patientInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.patientInfoTableAdapter = this.patientInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = aarons_wood_cc5._aarons_woodMedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(650, 316);
            this.Controls.Add(this.bttnAge);
            this.Controls.Add(this.bttnAlc);
            this.Controls.Add(this.bttnWeight100);
            this.Controls.Add(this.bttnWeight200);
            this.Controls.Add(this.bttnHeight);
            this.Controls.Add(this.patientInfoDataGridView);
            this.Controls.Add(this.patientInfoBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingNavigator)).EndInit();
            this.patientInfoBindingNavigator.ResumeLayout(false);
            this.patientInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._aarons_woodMedicalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _aarons_woodMedicalDataSet _aarons_woodMedicalDataSet;
        private System.Windows.Forms.BindingSource patientInfoBindingSource;
        private _aarons_woodMedicalDataSetTableAdapters.patientInfoTableAdapter patientInfoTableAdapter;
        private _aarons_woodMedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patientInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView patientInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button bttnHeight;
        private System.Windows.Forms.Button bttnWeight200;
        private System.Windows.Forms.Button bttnWeight100;
        private System.Windows.Forms.Button bttnAlc;
        private System.Windows.Forms.Button bttnAge;
    }
}

