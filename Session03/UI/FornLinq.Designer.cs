namespace Session03.UI
{
    partial class FormLinq
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLinqSample1 = new System.Windows.Forms.Button();
            this.btnLinqLambda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLinqProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(144, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 0;
            // 
            // btnLinqSample1
            // 
            this.btnLinqSample1.Location = new System.Drawing.Point(22, 37);
            this.btnLinqSample1.Name = "btnLinqSample1";
            this.btnLinqSample1.Size = new System.Drawing.Size(100, 23);
            this.btnLinqSample1.TabIndex = 1;
            this.btnLinqSample1.Text = "Linq Query";
            this.btnLinqSample1.UseVisualStyleBackColor = true;
            this.btnLinqSample1.Click += new System.EventHandler(this.btnLinqSample1_Click);
            // 
            // btnLinqLambda
            // 
            this.btnLinqLambda.Location = new System.Drawing.Point(22, 66);
            this.btnLinqLambda.Name = "btnLinqLambda";
            this.btnLinqLambda.Size = new System.Drawing.Size(100, 23);
            this.btnLinqLambda.TabIndex = 2;
            this.btnLinqLambda.Text = "Linq Lambda";
            this.btnLinqLambda.UseVisualStyleBackColor = true;
            this.btnLinqLambda.Click += new System.EventHandler(this.btnLinqLambda_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(959, 255);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnLinqProducts
            // 
            this.btnLinqProducts.Location = new System.Drawing.Point(22, 267);
            this.btnLinqProducts.Name = "btnLinqProducts";
            this.btnLinqProducts.Size = new System.Drawing.Size(100, 23);
            this.btnLinqProducts.TabIndex = 4;
            this.btnLinqProducts.Text = "Linq Products";
            this.btnLinqProducts.UseVisualStyleBackColor = true;
            this.btnLinqProducts.Click += new System.EventHandler(this.btnLinqProducts_Click);
            // 
            // FormLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 534);
            this.Controls.Add(this.btnLinqProducts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLinqLambda);
            this.Controls.Add(this.btnLinqSample1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormLinq";
            this.Text = "FornLinq";
            this.Load += new System.EventHandler(this.FornLinq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button btnLinqSample1;
        private Button btnLinqLambda;
        private DataGridView dataGridView1;
        private Button btnLinqProducts;
    }
}