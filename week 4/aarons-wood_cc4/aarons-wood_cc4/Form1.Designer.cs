namespace aarons_wood_cc4
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
            System.Windows.Forms.Label apptIDLabel;
            System.Windows.Forms.Label apptpatientnameLabel;
            System.Windows.Forms.Label apptdateLabel;
            System.Windows.Forms.Label appttimeLabel;
            System.Windows.Forms.Label apptdoctornameLabel;
            this._aarons_woodMedicalDataSet = new aarons_wood_cc4._aarons_woodMedicalDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new aarons_wood_cc4._aarons_woodMedicalDataSetTableAdapters.appointmentsTableAdapter();
            this.tableAdapterManager = new aarons_wood_cc4._aarons_woodMedicalDataSetTableAdapters.TableAdapterManager();
            this.appointmentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.appointmentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.apptIDListBox = new System.Windows.Forms.ListBox();
            this.apptpatientnameTextBox = new System.Windows.Forms.TextBox();
            this.apptdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appttimeTextBox = new System.Windows.Forms.TextBox();
            this.apptdoctornameTextBox = new System.Windows.Forms.TextBox();
            apptIDLabel = new System.Windows.Forms.Label();
            apptpatientnameLabel = new System.Windows.Forms.Label();
            apptdateLabel = new System.Windows.Forms.Label();
            appttimeLabel = new System.Windows.Forms.Label();
            apptdoctornameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._aarons_woodMedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingNavigator)).BeginInit();
            this.appointmentsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // _aarons_woodMedicalDataSet
            // 
            this._aarons_woodMedicalDataSet.DataSetName = "_aarons_woodMedicalDataSet";
            this._aarons_woodMedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "appointments";
            this.appointmentsBindingSource.DataSource = this._aarons_woodMedicalDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appointmentsTableAdapter = this.appointmentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = aarons_wood_cc4._aarons_woodMedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appointmentsBindingNavigator
            // 
            this.appointmentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.appointmentsBindingNavigator.BindingSource = this.appointmentsBindingSource;
            this.appointmentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appointmentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.appointmentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.appointmentsBindingNavigatorSaveItem});
            this.appointmentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.appointmentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appointmentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appointmentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appointmentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appointmentsBindingNavigator.Name = "appointmentsBindingNavigator";
            this.appointmentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appointmentsBindingNavigator.Size = new System.Drawing.Size(501, 25);
            this.appointmentsBindingNavigator.TabIndex = 0;
            this.appointmentsBindingNavigator.Text = "bindingNavigator1";
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
            // appointmentsBindingNavigatorSaveItem
            // 
            this.appointmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.appointmentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("appointmentsBindingNavigatorSaveItem.Image")));
            this.appointmentsBindingNavigatorSaveItem.Name = "appointmentsBindingNavigatorSaveItem";
            this.appointmentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.appointmentsBindingNavigatorSaveItem.Text = "Save Data";
            this.appointmentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.appointmentsBindingNavigatorSaveItem_Click);
            // 
            // apptIDLabel
            // 
            apptIDLabel.AutoSize = true;
            apptIDLabel.Location = new System.Drawing.Point(5, 49);
            apptIDLabel.Name = "apptIDLabel";
            apptIDLabel.Size = new System.Drawing.Size(45, 13);
            apptIDLabel.TabIndex = 1;
            apptIDLabel.Text = "appt ID:";
            // 
            // apptIDListBox
            // 
            this.apptIDListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.apptIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.appointmentsBindingSource, "apptID", true));
            this.apptIDListBox.DataSource = this.appointmentsBindingSource;
            this.apptIDListBox.DisplayMember = "apptID";
            this.apptIDListBox.FormattingEnabled = true;
            this.apptIDListBox.Location = new System.Drawing.Point(56, 49);
            this.apptIDListBox.Name = "apptIDListBox";
            this.apptIDListBox.Size = new System.Drawing.Size(120, 277);
            this.apptIDListBox.TabIndex = 2;
            // 
            // apptpatientnameLabel
            // 
            apptpatientnameLabel.AutoSize = true;
            apptpatientnameLabel.Location = new System.Drawing.Point(235, 59);
            apptpatientnameLabel.Name = "apptpatientnameLabel";
            apptpatientnameLabel.Size = new System.Drawing.Size(89, 13);
            apptpatientnameLabel.TabIndex = 3;
            apptpatientnameLabel.Text = "apptpatientname:";
            // 
            // apptpatientnameTextBox
            // 
            this.apptpatientnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "apptpatientname", true));
            this.apptpatientnameTextBox.Location = new System.Drawing.Point(330, 56);
            this.apptpatientnameTextBox.Name = "apptpatientnameTextBox";
            this.apptpatientnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.apptpatientnameTextBox.TabIndex = 4;
            // 
            // apptdateLabel
            // 
            apptdateLabel.AutoSize = true;
            apptdateLabel.Location = new System.Drawing.Point(235, 92);
            apptdateLabel.Name = "apptdateLabel";
            apptdateLabel.Size = new System.Drawing.Size(52, 13);
            apptdateLabel.TabIndex = 5;
            apptdateLabel.Text = "apptdate:";
            // 
            // apptdateDateTimePicker
            // 
            this.apptdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentsBindingSource, "apptdate", true));
            this.apptdateDateTimePicker.Location = new System.Drawing.Point(293, 88);
            this.apptdateDateTimePicker.Name = "apptdateDateTimePicker";
            this.apptdateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.apptdateDateTimePicker.TabIndex = 6;
            // 
            // appttimeLabel
            // 
            appttimeLabel.AutoSize = true;
            appttimeLabel.Location = new System.Drawing.Point(237, 129);
            appttimeLabel.Name = "appttimeLabel";
            appttimeLabel.Size = new System.Drawing.Size(50, 13);
            appttimeLabel.TabIndex = 7;
            appttimeLabel.Text = "appttime:";
            // 
            // appttimeTextBox
            // 
            this.appttimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "appttime", true));
            this.appttimeTextBox.Location = new System.Drawing.Point(293, 126);
            this.appttimeTextBox.Name = "appttimeTextBox";
            this.appttimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.appttimeTextBox.TabIndex = 8;
            // 
            // apptdoctornameLabel
            // 
            apptdoctornameLabel.AutoSize = true;
            apptdoctornameLabel.Location = new System.Drawing.Point(235, 165);
            apptdoctornameLabel.Name = "apptdoctornameLabel";
            apptdoctornameLabel.Size = new System.Drawing.Size(87, 13);
            apptdoctornameLabel.TabIndex = 9;
            apptdoctornameLabel.Text = "apptdoctorname:";
            // 
            // apptdoctornameTextBox
            // 
            this.apptdoctornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "apptdoctorname", true));
            this.apptdoctornameTextBox.Location = new System.Drawing.Point(328, 162);
            this.apptdoctornameTextBox.Name = "apptdoctornameTextBox";
            this.apptdoctornameTextBox.Size = new System.Drawing.Size(100, 20);
            this.apptdoctornameTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(501, 341);
            this.Controls.Add(apptdoctornameLabel);
            this.Controls.Add(this.apptdoctornameTextBox);
            this.Controls.Add(appttimeLabel);
            this.Controls.Add(this.appttimeTextBox);
            this.Controls.Add(apptdateLabel);
            this.Controls.Add(this.apptdateDateTimePicker);
            this.Controls.Add(apptpatientnameLabel);
            this.Controls.Add(this.apptpatientnameTextBox);
            this.Controls.Add(apptIDLabel);
            this.Controls.Add(this.apptIDListBox);
            this.Controls.Add(this.appointmentsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._aarons_woodMedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingNavigator)).EndInit();
            this.appointmentsBindingNavigator.ResumeLayout(false);
            this.appointmentsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _aarons_woodMedicalDataSet _aarons_woodMedicalDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private _aarons_woodMedicalDataSetTableAdapters.appointmentsTableAdapter appointmentsTableAdapter;
        private _aarons_woodMedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator appointmentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton appointmentsBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox apptIDListBox;
        private System.Windows.Forms.TextBox apptpatientnameTextBox;
        private System.Windows.Forms.DateTimePicker apptdateDateTimePicker;
        private System.Windows.Forms.TextBox appttimeTextBox;
        private System.Windows.Forms.TextBox apptdoctornameTextBox;
    }
}

