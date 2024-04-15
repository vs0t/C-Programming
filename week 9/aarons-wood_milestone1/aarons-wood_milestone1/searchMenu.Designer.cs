namespace aarons_wood_milestone1
{
    partial class searchMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchMenu));
            this.menuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new aarons_wood_milestone1.UsersDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceSearchBox = new System.Windows.Forms.TextBox();
            this.descriptionSearchBox = new System.Windows.Forms.TextBox();
            this.searchNameBttn = new System.Windows.Forms.Button();
            this.searchPriceBttn = new System.Windows.Forms.Button();
            this.searchDescBttn = new System.Windows.Forms.Button();
            this.menuTableAdapter = new aarons_wood_milestone1.UsersDataSetTableAdapters.MenuTableAdapter();
            this.tableAdapterManager = new aarons_wood_milestone1.UsersDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingNavigator)).BeginInit();
            this.menuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBindingNavigator
            // 
            this.menuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.menuBindingNavigator.BindingSource = this.menuBindingSource;
            this.menuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.menuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.menuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.menuBindingNavigatorSaveItem});
            this.menuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.menuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.menuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.menuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.menuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.menuBindingNavigator.Name = "menuBindingNavigator";
            this.menuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.menuBindingNavigator.Size = new System.Drawing.Size(970, 25);
            this.menuBindingNavigator.TabIndex = 0;
            this.menuBindingNavigator.Text = "bindingNavigator1";
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
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuBindingNavigatorSaveItem
            // 
            this.menuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("menuBindingNavigatorSaveItem.Image")));
            this.menuBindingNavigatorSaveItem.Name = "menuBindingNavigatorSaveItem";
            this.menuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.menuBindingNavigatorSaveItem.Text = "Save Data";
            this.menuBindingNavigatorSaveItem.Click += new System.EventHandler(this.menuBindingNavigatorSaveItem_Click);
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AllowUserToAddRows = false;
            this.menuDataGridView.AllowUserToDeleteRows = false;
            this.menuDataGridView.AutoGenerateColumns = false;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.menuDataGridView.DataSource = this.menuBindingSource;
            this.menuDataGridView.Enabled = false;
            this.menuDataGridView.Location = new System.Drawing.Point(0, 28);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.Size = new System.Drawing.Size(944, 220);
            this.menuDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MenuID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MenuID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InventoryID";
            this.dataGridViewTextBoxColumn2.HeaderText = "InventoryID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MenuName";
            this.dataGridViewTextBoxColumn3.HeaderText = "MenuName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MenuPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "MenuPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MenuQuantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "MenuQuantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MenuDescription";
            this.dataGridViewTextBoxColumn6.HeaderText = "MenuDescription";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // menuSearchBox
            // 
            this.menuSearchBox.Location = new System.Drawing.Point(87, 254);
            this.menuSearchBox.Name = "menuSearchBox";
            this.menuSearchBox.Size = new System.Drawing.Size(208, 20);
            this.menuSearchBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menu Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menu Description:";
            // 
            // priceSearchBox
            // 
            this.priceSearchBox.Location = new System.Drawing.Point(387, 253);
            this.priceSearchBox.Name = "priceSearchBox";
            this.priceSearchBox.Size = new System.Drawing.Size(208, 20);
            this.priceSearchBox.TabIndex = 6;
            // 
            // descriptionSearchBox
            // 
            this.descriptionSearchBox.Location = new System.Drawing.Point(739, 254);
            this.descriptionSearchBox.Name = "descriptionSearchBox";
            this.descriptionSearchBox.Size = new System.Drawing.Size(208, 20);
            this.descriptionSearchBox.TabIndex = 7;
            // 
            // searchNameBttn
            // 
            this.searchNameBttn.BackColor = System.Drawing.Color.Orange;
            this.searchNameBttn.Location = new System.Drawing.Point(87, 292);
            this.searchNameBttn.Name = "searchNameBttn";
            this.searchNameBttn.Size = new System.Drawing.Size(164, 64);
            this.searchNameBttn.TabIndex = 8;
            this.searchNameBttn.Text = "Search Menu Name";
            this.searchNameBttn.UseVisualStyleBackColor = false;
            this.searchNameBttn.Click += new System.EventHandler(this.searchNameBttn_Click);
            // 
            // searchPriceBttn
            // 
            this.searchPriceBttn.BackColor = System.Drawing.Color.Orange;
            this.searchPriceBttn.Location = new System.Drawing.Point(401, 292);
            this.searchPriceBttn.Name = "searchPriceBttn";
            this.searchPriceBttn.Size = new System.Drawing.Size(164, 64);
            this.searchPriceBttn.TabIndex = 9;
            this.searchPriceBttn.Text = "Search Menu Price";
            this.searchPriceBttn.UseVisualStyleBackColor = false;
            this.searchPriceBttn.Click += new System.EventHandler(this.searchPriceBttn_Click);
            // 
            // searchDescBttn
            // 
            this.searchDescBttn.BackColor = System.Drawing.Color.Orange;
            this.searchDescBttn.Location = new System.Drawing.Point(725, 292);
            this.searchDescBttn.Name = "searchDescBttn";
            this.searchDescBttn.Size = new System.Drawing.Size(164, 64);
            this.searchDescBttn.TabIndex = 10;
            this.searchDescBttn.Text = "Search Menu Description";
            this.searchDescBttn.UseVisualStyleBackColor = false;
            this.searchDescBttn.Click += new System.EventHandler(this.searchDescBttn_Click);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = this.menuTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aarons_wood_milestone1.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // searchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 363);
            this.Controls.Add(this.searchDescBttn);
            this.Controls.Add(this.searchPriceBttn);
            this.Controls.Add(this.searchNameBttn);
            this.Controls.Add(this.descriptionSearchBox);
            this.Controls.Add(this.priceSearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuSearchBox);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.menuBindingNavigator);
            this.Name = "searchMenu";
            this.Text = "searchMenu";
            this.Load += new System.EventHandler(this.searchMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingNavigator)).EndInit();
            this.menuBindingNavigator.ResumeLayout(false);
            this.menuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private UsersDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private UsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator menuBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton menuBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox menuSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceSearchBox;
        private System.Windows.Forms.TextBox descriptionSearchBox;
        private System.Windows.Forms.Button searchNameBttn;
        private System.Windows.Forms.Button searchPriceBttn;
        private System.Windows.Forms.Button searchDescBttn;
    }
}