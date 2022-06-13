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
    public partial class FormLinq : Form
    {
        public FormLinq()
        {
            InitializeComponent();
        }

        private void btnLinqSample1_Click(object sender, EventArgs e)
        {
            /**
             * Linq Syntax
             *  1. query
             *      sql -> c#
             *  2. function
             *      lambda expression
             */
            int[] numbers = { 2, 5,  3, 34, 56, 66, 23, 22, 12, 17, 6, 20, 15};
            var evens = from n in numbers
                        where n % 2 == 0
                        select n;

            listBox1.Items.Clear();
            //foreach (var n in evens)
            //{
            //    listBox1.Items.Add(n);
            //}
            listBox1.Items.AddRange(evens.Cast<object>().ToArray());

            /*
             * 1. zoj
             * 2. fard
             * 3. between 10 va 50
             * 4. ham be 3 va ham be 5 bakhshpazir hastand
             * 5. fard -> bet tavan 3
             */ 

        }

        private void FornLinq_Load(object sender, EventArgs e)
        {

        }
    }
}
