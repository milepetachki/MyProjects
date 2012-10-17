namespace BizContacts
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.Label lastCallLabel;
            System.Windows.Forms.Label clienttLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telePhoneLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label contactIDLabel;
            this.bizContactsDataSet = new BizContacts.BizContactsDataSet();
            this.tblContactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblContactsTableAdapter = new BizContacts.BizContactsDataSetTableAdapters.tblContactsTableAdapter();
            this.tableAdapterManager = new BizContacts.BizContactsDataSetTableAdapters.TableAdapterManager();
            this.tblContactsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblContactsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lastCallDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contactIDTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telePhoneTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            lastCallLabel = new System.Windows.Forms.Label();
            clienttLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telePhoneLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            contactIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bizContactsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingNavigator)).BeginInit();
            this.tblContactsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bizContactsDataSet
            // 
            this.bizContactsDataSet.DataSetName = "BizContactsDataSet";
            this.bizContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblContactsBindingSource
            // 
            this.tblContactsBindingSource.DataMember = "tblContacts";
            this.tblContactsBindingSource.DataSource = this.bizContactsDataSet;
            // 
            // tblContactsTableAdapter
            // 
            this.tblContactsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblContactsTableAdapter = this.tblContactsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BizContacts.BizContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblContactsBindingNavigator
            // 
            this.tblContactsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblContactsBindingNavigator.BindingSource = this.tblContactsBindingSource;
            this.tblContactsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblContactsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblContactsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblContactsBindingNavigatorSaveItem});
            this.tblContactsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblContactsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblContactsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblContactsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblContactsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblContactsBindingNavigator.Name = "tblContactsBindingNavigator";
            this.tblContactsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblContactsBindingNavigator.Size = new System.Drawing.Size(370, 25);
            this.tblContactsBindingNavigator.TabIndex = 0;
            this.tblContactsBindingNavigator.Text = "bindingNavigator1";
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
            // tblContactsBindingNavigatorSaveItem
            // 
            this.tblContactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblContactsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblContactsBindingNavigatorSaveItem.Image")));
            this.tblContactsBindingNavigatorSaveItem.Name = "tblContactsBindingNavigatorSaveItem";
            this.tblContactsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblContactsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblContactsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblContactsBindingNavigatorSaveItem_Click);
            // 
            // lastCallDateTimePicker
            // 
            this.lastCallDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblContactsBindingSource, "LastCall", true));
            this.lastCallDateTimePicker.Location = new System.Drawing.Point(150, 215);
            this.lastCallDateTimePicker.Name = "lastCallDateTimePicker";
            this.lastCallDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastCallDateTimePicker.TabIndex = 14;
            // 
            // lastCallLabel
            // 
            lastCallLabel.AutoSize = true;
            lastCallLabel.Location = new System.Drawing.Point(79, 219);
            lastCallLabel.Name = "lastCallLabel";
            lastCallLabel.Size = new System.Drawing.Size(50, 13);
            lastCallLabel.TabIndex = 13;
            lastCallLabel.Text = "Last Call:";
            // 
            // contactIDTextBox
            // 
            this.contactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "ContactID", true));
            this.contactIDTextBox.Location = new System.Drawing.Point(150, 55);
            this.contactIDTextBox.Name = "contactIDTextBox";
            this.contactIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactIDTextBox.TabIndex = 2;
            // 
            // clienttLabel
            // 
            clienttLabel.AutoSize = true;
            clienttLabel.Location = new System.Drawing.Point(79, 190);
            clienttLabel.Name = "clienttLabel";
            clienttLabel.Size = new System.Drawing.Size(39, 13);
            clienttLabel.TabIndex = 11;
            clienttLabel.Text = "Clientt:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(150, 159);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(79, 162);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // telePhoneTextBox
            // 
            this.telePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "TelePhone", true));
            this.telePhoneTextBox.Location = new System.Drawing.Point(150, 133);
            this.telePhoneTextBox.Name = "telePhoneTextBox";
            this.telePhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telePhoneTextBox.TabIndex = 8;
            // 
            // telePhoneLabel
            // 
            telePhoneLabel.AutoSize = true;
            telePhoneLabel.Location = new System.Drawing.Point(79, 136);
            telePhoneLabel.Name = "telePhoneLabel";
            telePhoneLabel.Size = new System.Drawing.Size(65, 13);
            telePhoneLabel.TabIndex = 7;
            telePhoneLabel.Text = "Tele Phone:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(150, 107);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(200, 20);
            this.companyTextBox.TabIndex = 6;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(79, 110);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 5;
            companyLabel.Text = "Company:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(150, 81);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(79, 84);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // contactIDLabel
            // 
            contactIDLabel.AutoSize = true;
            contactIDLabel.Location = new System.Drawing.Point(79, 58);
            contactIDLabel.Name = "contactIDLabel";
            contactIDLabel.Size = new System.Drawing.Size(61, 13);
            contactIDLabel.TabIndex = 1;
            contactIDLabel.Text = "Contact ID:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 262);
            this.Controls.Add(contactIDLabel);
            this.Controls.Add(this.contactIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(telePhoneLabel);
            this.Controls.Add(this.telePhoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(clienttLabel);
            this.Controls.Add(lastCallLabel);
            this.Controls.Add(this.lastCallDateTimePicker);
            this.Controls.Add(this.tblContactsBindingNavigator);
            this.Name = "FormMain";
            this.Text = "Busines Contacts 1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bizContactsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingNavigator)).EndInit();
            this.tblContactsBindingNavigator.ResumeLayout(false);
            this.tblContactsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BizContactsDataSet bizContactsDataSet;
        private System.Windows.Forms.BindingSource tblContactsBindingSource;
        private BizContactsDataSetTableAdapters.tblContactsTableAdapter tblContactsTableAdapter;
        private BizContactsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblContactsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblContactsBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker lastCallDateTimePicker;
        private System.Windows.Forms.TextBox contactIDTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telePhoneTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

