namespace aarons_wood_cc3
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
            this._aarons_woodMedicalDataSet = new aarons_wood_cc3._aarons_woodMedicalDataSet();
            this.medicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicationsTableAdapter = new aarons_wood_cc3._aarons_woodMedicalDataSetTableAdapters.MedicationsTableAdapter();
            this.tableAdapterManager = new aarons_wood_cc3._aarons_woodMedicalDataSetTableAdapters.TableAdapterManager();
            this.medicationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.medicationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._aarons_woodMedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingNavigator)).BeginInit();
            this.medicationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _aarons_woodMedicalDataSet
            // 
            this._aarons_woodMedicalDataSet.DataSetName = "_aarons_woodMedicalDataSet";
            this._aarons_woodMedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicationsBindingSource
            // 
            this.medicationsBindingSource.DataMember = "Medications";
            this.medicationsBindingSource.DataSource = this._aarons_woodMedicalDataSet;
            // 
            // medicationsTableAdapter
            // 
            this.medicationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MedicationsTableAdapter = this.medicationsTableAdapter;
            this.tableAdapterManager.UpdateOrder = aarons_wood_cc3._aarons_woodMedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicationsBindingNavigator
            // 
            this.medicationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicationsBindingNavigator.BindingSource = this.medicationsBindingSource;
            this.medicationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medicationsBindingNavigatorSaveItem});
            this.medicationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicationsBindingNavigator.Name = "medicationsBindingNavigator";
            this.medicationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicationsBindingNavigator.Size = new System.Drawing.Size(554, 25);
            this.medicationsBindingNavigator.TabIndex = 0;
            this.medicationsBindingNavigator.Text = "bindingNavigator1";
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
            // medicationsBindingNavigatorSaveItem
            // 
            this.medicationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicationsBindingNavigatorSaveItem.Image")));
            this.medicationsBindingNavigatorSaveItem.Name = "medicationsBindingNavigatorSaveItem";
            this.medicationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicationsBindingNavigatorSaveItem.Text = "Save Data";
            this.medicationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicationsBindingNavigatorSaveItem_Click);
            // 
            // medicationsDataGridView
            // 
            this.medicationsDataGridView.AutoGenerateColumns = false;
            this.medicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.medicationsDataGridView.DataSource = this.medicationsBindingSource;
            this.medicationsDataGridView.Location = new System.Drawing.Point(4, 28);
            this.medicationsDataGridView.Name = "medicationsDataGridView";
            this.medicationsDataGridView.Size = new System.Drawing.Size(547, 156);
            this.medicationsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "medID";
            this.dataGridViewTextBoxColumn1.HeaderText = "medID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "medName";
            this.dataGridViewTextBoxColumn2.HeaderText = "medName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "medSize";
            this.dataGridViewTextBoxColumn3.HeaderText = "medSize";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "medQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "medQty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "medEffects";
            this.dataGridViewTextBoxColumn5.HeaderText = "medEffects";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // pageBttn
            // 
            this.pageBttn.BackColor = System.Drawing.Color.DarkRed;
            this.pageBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pageBttn.Location = new System.Drawing.Point(193, 190);
            this.pageBttn.Name = "pageBttn";
            this.pageBttn.Size = new System.Drawing.Size(183, 74);
            this.pageBttn.TabIndex = 2;
            this.pageBttn.Text = "DETAILS VIEW";
            this.pageBttn.UseVisualStyleBackColor = false;
            this.pageBttn.Click += new System.EventHandler(this.pageBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(554, 266);
            this.Controls.Add(this.pageBttn);
            this.Controls.Add(this.medicationsDataGridView);
            this.Controls.Add(this.medicationsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._aarons_woodMedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingNavigator)).EndInit();
            this.medicationsBindingNavigator.ResumeLayout(false);
            this.medicationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _aarons_woodMedicalDataSet _aarons_woodMedicalDataSet;
        private System.Windows.Forms.BindingSource medicationsBindingSource;
        private _aarons_woodMedicalDataSetTableAdapters.MedicationsTableAdapter medicationsTableAdapter;
        private _aarons_woodMedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicationsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton medicationsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView medicationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button pageBttn;
    }
}

