using EFDatabaseFirst.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDatabaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(var db = new Northwind2Entities())
            {
                //.Include(x=>x.Category) needs -> using System.Data.Entity;
                dataGridView1.DataSource = db.Products.Include(x => x.Category).Where(x=>x.UnitPrice > 10).ToList();

                comboBoxCategory.DisplayMember = "CategoryName";
                comboBoxCategory.ValueMember = "CategoryId";
                comboBoxCategory.DataSource = db.Categories.ToArray();
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Northwind2Entities())
            {
                var catId = Convert.ToInt32(comboBoxCategory.SelectedValue);

                //linq lazy
                var query = db.Products.AsQueryable();
                query = query.Where(x => x.UnitPrice > 10);                                
                query = query.Where(x => x.CategoryID == catId);

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
