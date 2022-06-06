using Session03.Model;
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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                NationalCode = txtNationlCode.Text,
                DOB = dateTimePickerDOB.Value,
                IsActive = checkBoxActive.Checked,
            };
            var service = new CustomerService();
            service.Create(customer);
            MessageBox.Show("Customer Created🎉");
        }

        private void btnSaveSP_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                NationalCode = txtNationlCode.Text,
                DOB = dateTimePickerDOB.Value,
                IsActive = checkBoxActive.Checked,
            };
            var service = new CustomerService();
            service.CreateSP(customer);
            MessageBox.Show("Customer Created🎉");
        }
    }
}
