using Session03.Model;
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

        private List<Product> Products = new List<Product> {
            new Product {Id= 1, Name ="PC 1", Date = DateTime.Now.Subtract(TimeSpan.FromDays(-2)), Price= 1000, InStock = false},
            new Product {Id= 1, Name ="PC 2", Date = DateTime.Now.Subtract(TimeSpan.FromDays(-5)), Price= 1800, InStock = true},
            new Product {Id= 1, Name ="Monitor 1", Date = DateTime.Now.Subtract(TimeSpan.FromDays(-1)), Price= 1300, InStock = true},
            new Product {Id= 1, Name ="Monitor 2", Date = DateTime.Now.Subtract(TimeSpan.FromDays(-10)), Price= 200, InStock = true},
            new Product {Id= 1, Name ="Mouse", Date = DateTime.Now.Subtract(TimeSpan.FromDays(-200)), Price= 330, InStock = true},
        };

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

            //listBox1.Items.Clear();
            ////foreach (var n in evens)
            ////{
            ////    listBox1.Items.Add(n);
            ////}
            //listBox1.Items.AddRange(evens.Cast<object>().ToArray());

            addToListBox(evens);

            /*
             * 1. zoj
             * 2. fard
             * 3. between 10 va 50
             * 4. ham be 3 va ham be 5 bakhshpazir hastand
             * 5. fard -> be tavan 3
             */

            var answer2 = from n in numbers
                          where n % 2 != 0
                          select n;

            var answer3 = from n in numbers
                          where n> 10 && n<50
                          select n;

            var answer4 = from n in numbers
                          //where n % 3 == 0 && n % 5 == 0
                          where n % 15 == 0
                          select n;

            var answer5 = from n in numbers
                          where n % 2 != 0
                          select Math.Pow(n, 3);

            //var arr = new int[100];
            //arr.Select((a, b) => a + 1);

            //listBox1.Items.Clear();
            //listBox1.Items.AddRange(arr.Cast<object>().ToArray());
        }

        private void FornLinq_Load(object sender, EventArgs e)
        {

        }

        private void btnLinqLambda_Click(object sender, EventArgs e)
        {
            int[] numbers = { 2, 5, 3, 34, 56, 66, 23, 22, 12, 17, 6, 20, 15 };

            var evens = numbers.Where(x => x % 2 == 0);
            //.Skip(10).Take(10);
            //.OrderBy .OrderByDescending
            //
            addToListBox(evens);
        }

        private void addToListBox(IEnumerable<int> list)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(list.Cast<object>().ToArray());
        }

        private void btnLinqProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Products.Where(p => p.InStock).ToList();

            /**
             * 1. sort by date
             * 2. sort instock, date
             * 3. sort price
             * 4. price < 1000
             * 5. select name, price
             * 
             */

            //1
            dataGridView1.DataSource = Products.OrderBy(x=>x.Date).ToList();

            //2
            dataGridView1.DataSource = Products.OrderBy(x=>x.InStock).OrderBy(x => x.Date).ToList();

            //3
            dataGridView1.DataSource = Products.OrderBy(x => x.Price).ToList();

            //4
            dataGridView1.DataSource = Products.Where(x=>x.Price<=1000).ToList();

            //5
            dataGridView1.DataSource = Products.Select(x => new {Name = x.Name, Price = x.Price }).ToList();


            //https://linqsamples.com/
        }
    }
}
