using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BizContacts
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void tblContactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblContactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bizContactsDataSet);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bizContactsDataSet.tblContacts' table. You can move, or remove it, as needed.
            this.tblContactsTableAdapter.Fill(this.bizContactsDataSet.tblContacts);

        }
    }
}
