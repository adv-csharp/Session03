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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(128, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 0;
            // 
            // btnLinqSample1
            // 
            this.btnLinqSample1.Location = new System.Drawing.Point(22, 37);
            this.btnLinqSample1.Name = "btnLinqSample1";
            this.btnLinqSample1.Size = new System.Drawing.Size(75, 23);
            this.btnLinqSample1.TabIndex = 1;
            this.btnLinqSample1.Text = "Linq Sample 1";
            this.btnLinqSample1.UseVisualStyleBackColor = true;
            this.btnLinqSample1.Click += new System.EventHandler(this.btnLinqSample1_Click);
            // 
            // FornLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 534);
            this.Controls.Add(this.btnLinqSample1);
            this.Controls.Add(this.listBox1);
            this.Name = "FornLinq";
            this.Text = "FornLinq";
            this.Load += new System.EventHandler(this.FornLinq_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button btnLinqSample1;
    }
}