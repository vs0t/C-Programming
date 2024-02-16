namespace aarons_wood_cc3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label medIDLabel;
            System.Windows.Forms.Label medNameLabel;
            System.Windows.Forms.Label medSizeLabel;
            System.Windows.Forms.Label medQtyLabel;
            System.Windows.Forms.Label medEffectsLabel;
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
            this.medIDTextBox = new System.Windows.Forms.TextBox();
            this.medNameTextBox = new System.Windows.Forms.TextBox();
            this.medSizeTextBox = new System.Windows.Forms.TextBox();
            this.medQtyTextBox = new System.Windows.Forms.TextBox();
            this.medEffectsTextBox = new System.Windows.Forms.TextBox();
            medIDLabel = new System.Windows.Forms.Label();
            medNameLabel = new System.Windows.Forms.Label();
            medSizeLabel = new System.Windows.Forms.Label();
            medQtyLabel = new System.Windows.Forms.Label();
            medEffectsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._aarons_woodMedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingNavigator)).BeginInit();
            this.medicationsBindingNavigator.SuspendLayout();
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
            this.medicationsBindingNavigator.Size = new System.Drawing.Size(287, 25);
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // medicationsBindingNavigatorSaveItem
            // 
            this.medicationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicationsBindingNavigatorSaveItem.Image")));
            this.medicationsBindingNavigatorSaveItem.Name = "medicationsBindingNavigatorSaveItem";
            this.medicationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.medicationsBindingNavigatorSaveItem.Text = "Save Data";
            this.medicationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicationsBindingNavigatorSaveItem_Click);
            // 
            // medIDLabel
            // 
            medIDLabel.AutoSize = true;
            medIDLabel.Location = new System.Drawing.Point(12, 35);
            medIDLabel.Name = "medIDLabel";
            medIDLabel.Size = new System.Drawing.Size(44, 13);
            medIDLabel.TabIndex = 1;
            medIDLabel.Text = "med ID:";
            // 
            // medIDTextBox
            // 
            this.medIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medID", true));
            this.medIDTextBox.Location = new System.Drawing.Point(84, 32);
            this.medIDTextBox.Name = "medIDTextBox";
            this.medIDTextBox.Size = new System.Drawing.Size(191, 20);
            this.medIDTextBox.TabIndex = 2;
            // 
            // medNameLabel
            // 
            medNameLabel.AutoSize = true;
            medNameLabel.Location = new System.Drawing.Point(12, 61);
            medNameLabel.Name = "medNameLabel";
            medNameLabel.Size = new System.Drawing.Size(61, 13);
            medNameLabel.TabIndex = 3;
            medNameLabel.Text = "med Name:";
            // 
            // medNameTextBox
            // 
            this.medNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medName", true));
            this.medNameTextBox.Location = new System.Drawing.Point(84, 58);
            this.medNameTextBox.Name = "medNameTextBox";
            this.medNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.medNameTextBox.TabIndex = 4;
            // 
            // medSizeLabel
            // 
            medSizeLabel.AutoSize = true;
            medSizeLabel.Location = new System.Drawing.Point(12, 87);
            medSizeLabel.Name = "medSizeLabel";
            medSizeLabel.Size = new System.Drawing.Size(53, 13);
            medSizeLabel.TabIndex = 5;
            medSizeLabel.Text = "med Size:";
            // 
            // medSizeTextBox
            // 
            this.medSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medSize", true));
            this.medSizeTextBox.Location = new System.Drawing.Point(84, 84);
            this.medSizeTextBox.Name = "medSizeTextBox";
            this.medSizeTextBox.Size = new System.Drawing.Size(191, 20);
            this.medSizeTextBox.TabIndex = 6;
            // 
            // medQtyLabel
            // 
            medQtyLabel.AutoSize = true;
            medQtyLabel.Location = new System.Drawing.Point(12, 113);
            medQtyLabel.Name = "medQtyLabel";
            medQtyLabel.Size = new System.Drawing.Size(49, 13);
            medQtyLabel.TabIndex = 7;
            medQtyLabel.Text = "med Qty:";
            // 
            // medQtyTextBox
            // 
            this.medQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medQty", true));
            this.medQtyTextBox.Location = new System.Drawing.Point(84, 110);
            this.medQtyTextBox.Name = "medQtyTextBox";
            this.medQtyTextBox.Size = new System.Drawing.Size(191, 20);
            this.medQtyTextBox.TabIndex = 8;
            // 
            // medEffectsLabel
            // 
            medEffectsLabel.AutoSize = true;
            medEffectsLabel.Location = new System.Drawing.Point(12, 139);
            medEffectsLabel.Name = "medEffectsLabel";
            medEffectsLabel.Size = new System.Drawing.Size(66, 13);
            medEffectsLabel.TabIndex = 9;
            medEffectsLabel.Text = "med Effects:";
            // 
            // medEffectsTextBox
            // 
            this.medEffectsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medEffects", true));
            this.medEffectsTextBox.Location = new System.Drawing.Point(84, 136);
            this.medEffectsTextBox.Name = "medEffectsTextBox";
            this.medEffectsTextBox.Size = new System.Drawing.Size(191, 20);
            this.medEffectsTextBox.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(287, 160);
            this.Controls.Add(medIDLabel);
            this.Controls.Add(this.medIDTextBox);
            this.Controls.Add(medNameLabel);
            this.Controls.Add(this.medNameTextBox);
            this.Controls.Add(medSizeLabel);
            this.Controls.Add(this.medSizeTextBox);
            this.Controls.Add(medQtyLabel);
            this.Controls.Add(this.medQtyTextBox);
            this.Controls.Add(medEffectsLabel);
            this.Controls.Add(this.medEffectsTextBox);
            this.Controls.Add(this.medicationsBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._aarons_woodMedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingNavigator)).EndInit();
            this.medicationsBindingNavigator.ResumeLayout(false);
            this.medicationsBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox medIDTextBox;
        private System.Windows.Forms.TextBox medNameTextBox;
        private System.Windows.Forms.TextBox medSizeTextBox;
        private System.Windows.Forms.TextBox medQtyTextBox;
        private System.Windows.Forms.TextBox medEffectsTextBox;
    }
}