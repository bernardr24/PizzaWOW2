namespace PizzaWOW2
{
    partial class PizzaWOW2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.choosePizza = new System.Windows.Forms.ComboBox();
            this.PizzaQty = new System.Windows.Forms.NumericUpDown();
            this.AddQty = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "choose your PIZZA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 27);
            this.textBox1.TabIndex = 3;
            // 
            // choosePizza
            // 
            this.choosePizza.FormattingEnabled = true;
            this.choosePizza.Location = new System.Drawing.Point(200, 93);
            this.choosePizza.Margin = new System.Windows.Forms.Padding(4);
            this.choosePizza.Name = "choosePizza";
            this.choosePizza.Size = new System.Drawing.Size(160, 27);
            this.choosePizza.TabIndex = 4;
            // 
            // PizzaQty
            // 
            this.PizzaQty.Location = new System.Drawing.Point(200, 145);
            this.PizzaQty.Margin = new System.Windows.Forms.Padding(4);
            this.PizzaQty.Name = "PizzaQty";
            this.PizzaQty.Size = new System.Drawing.Size(160, 27);
            this.PizzaQty.TabIndex = 5;
            // 
            // AddQty
            // 
            this.AddQty.Location = new System.Drawing.Point(45, 238);
            this.AddQty.Margin = new System.Windows.Forms.Padding(4);
            this.AddQty.Name = "AddQty";
            this.AddQty.Size = new System.Drawing.Size(100, 34);
            this.AddQty.TabIndex = 6;
            this.AddQty.Text = "Add";
            this.AddQty.UseVisualStyleBackColor = true;
            this.AddQty.Click += new System.EventHandler(this.AddQty_Click);
            // 
            // OrderList
            // 
            this.OrderList.HideSelection = false;
            this.OrderList.Location = new System.Drawing.Point(13, 342);
            this.OrderList.Margin = new System.Windows.Forms.Padding(4);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(522, 140);
            this.OrderList.TabIndex = 7;
            this.OrderList.UseCompatibleStateImageBehavior = false;
            this.OrderList.View = System.Windows.Forms.View.Details;
            // 
            // PizzaWOW2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 658);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.AddQty);
            this.Controls.Add(this.PizzaQty);
            this.Controls.Add(this.choosePizza);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PizzaWOW2";
            this.ShowIcon = false;
            this.Text = "PizzaWOW2";
            this.Load += new System.EventHandler(this.PizzaWOW2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PizzaQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox choosePizza;
        private System.Windows.Forms.NumericUpDown PizzaQty;
        private System.Windows.Forms.Button AddQty;
        private System.Windows.Forms.ListView OrderList;
    }
}

