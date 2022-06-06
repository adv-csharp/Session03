using Session03.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session03.UI
{
    public partial class FormCustomerList : Form
    {
        CustomerService service = new CustomerService();
        public FormCustomerList()
        {
            InitializeComponent();
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            dataGridView1.DataSource = service.ReadDataSqlReader();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "Delete")
            {
                if (MessageBox.Show("مطمئنی؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    service.Delete(id);
                    refreshGrid();
                    MessageBox.Show("🤷");                    
                }
            }
        }
    }
}
