using Session03.UI;

namespace Session03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            ShowForm(new FormCustomer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm(new FormCustomerList());
        }

        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

        private void btnLinqExamples_Click(object sender, EventArgs e)
        {
            ShowForm(new FormLinq());
        }
    }
}