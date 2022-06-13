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
        private CustomerService service = new CustomerService();
        public int? Id { get; }

        public FormCustomer(int? id = null)
        {
           InitializeComponent();
           Id  = id;            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = GetCustomer();
            service.Create(customer);
            MessageBox.Show("Customer Created🎉");
        }

        private void btnSaveSP_Click(object sender, EventArgs e)
        {
            Customer customer = GetCustomer();
            if (Id.HasValue)
            {
                service.Update(Id.Value ,customer) ;
                MessageBox.Show("Customer Updated");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                service.CreateSP(customer);
                MessageBox.Show("Customer Created🎉");
            }
        }

        private Customer GetCustomer()
        {
            return new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                NationalCode = txtNationlCode.Text,
                DOB = dateTimePickerDOB.Value,
                IsActive = checkBoxActive.Checked,
            };
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                //edit
                var customer = service.FindById(Id.Value);
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtAddress.Text = customer.Address;
                txtEmail.Text = customer.Email;
                txtNationlCode.Text = customer.NationalCode;
                dateTimePickerDOB.Value = customer.DOB;
                checkBoxActive.Checked = customer.IsActive;
            }
        }
    }
}
