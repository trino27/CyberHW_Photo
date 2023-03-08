
namespace CyberHW_Photo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_size = new System.Windows.Forms.GroupBox();
            this.radioButton_18_24 = new System.Windows.Forms.RadioButton();
            this.radioButton_12_15 = new System.Windows.Forms.RadioButton();
            this.radioButton_9_12 = new System.Windows.Forms.RadioButton();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.label_num = new System.Windows.Forms.Label();
            this.label_buy = new System.Windows.Forms.Label();
            this.groupBox_num = new System.Windows.Forms.GroupBox();
            this.groupBox_bill = new System.Windows.Forms.GroupBox();
            this.label_bill = new System.Windows.Forms.Label();
            this.groupBox_prices = new System.Windows.Forms.GroupBox();
            this.label_18_24 = new System.Windows.Forms.Label();
            this.label_12_15 = new System.Windows.Forms.Label();
            this.label_9_12 = new System.Windows.Forms.Label();
            this.groupBox_size.SuspendLayout();
            this.groupBox_num.SuspendLayout();
            this.groupBox_bill.SuspendLayout();
            this.groupBox_prices.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_size
            // 
            this.groupBox_size.Controls.Add(this.radioButton_18_24);
            this.groupBox_size.Controls.Add(this.radioButton_12_15);
            this.groupBox_size.Controls.Add(this.radioButton_9_12);
            this.groupBox_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_size.Location = new System.Drawing.Point(27, 24);
            this.groupBox_size.Name = "groupBox_size";
            this.groupBox_size.Size = new System.Drawing.Size(130, 125);
            this.groupBox_size.TabIndex = 0;
            this.groupBox_size.TabStop = false;
            this.groupBox_size.Text = "Розмір";
            // 
            // radioButton_18_24
            // 
            this.radioButton_18_24.AutoSize = true;
            this.radioButton_18_24.Location = new System.Drawing.Point(19, 87);
            this.radioButton_18_24.Name = "radioButton_18_24";
            this.radioButton_18_24.Size = new System.Drawing.Size(86, 32);
            this.radioButton_18_24.TabIndex = 2;
            this.radioButton_18_24.Text = "18x24";
            this.radioButton_18_24.UseVisualStyleBackColor = true;
            this.radioButton_18_24.CheckedChanged += new System.EventHandler(this.radioButton_18_24_CheckedChanged);
            // 
            // radioButton_12_15
            // 
            this.radioButton_12_15.AutoSize = true;
            this.radioButton_12_15.Location = new System.Drawing.Point(19, 57);
            this.radioButton_12_15.Name = "radioButton_12_15";
            this.radioButton_12_15.Size = new System.Drawing.Size(86, 32);
            this.radioButton_12_15.TabIndex = 1;
            this.radioButton_12_15.Text = "12x15";
            this.radioButton_12_15.UseVisualStyleBackColor = true;
            this.radioButton_12_15.CheckedChanged += new System.EventHandler(this.radioButton_12_15_CheckedChanged);
            // 
            // radioButton_9_12
            // 
            this.radioButton_9_12.AutoSize = true;
            this.radioButton_9_12.Location = new System.Drawing.Point(19, 27);
            this.radioButton_9_12.Name = "radioButton_9_12";
            this.radioButton_9_12.Size = new System.Drawing.Size(75, 32);
            this.radioButton_9_12.TabIndex = 0;
            this.radioButton_9_12.Text = "9x12";
            this.radioButton_9_12.UseVisualStyleBackColor = true;
            this.radioButton_9_12.CheckedChanged += new System.EventHandler(this.radioButton_9_12_CheckedChanged);
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(117, 40);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(107, 27);
            this.textBox_num.TabIndex = 1;
            this.textBox_num.Text = "0";
            this.textBox_num.TextChanged += new System.EventHandler(this.textBox_num_TextChanged);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_num.Location = new System.Drawing.Point(19, 36);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(92, 28);
            this.label_num.TabIndex = 2;
            this.label_num.Text = "Кількість";
            // 
            // label_buy
            // 
            this.label_buy.AutoSize = true;
            this.label_buy.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_buy.Location = new System.Drawing.Point(45, 23);
            this.label_buy.Name = "label_buy";
            this.label_buy.Size = new System.Drawing.Size(154, 38);
            this.label_buy.TabIndex = 3;
            this.label_buy.Text = "До оплати:";
            // 
            // groupBox_num
            // 
            this.groupBox_num.Controls.Add(this.label_num);
            this.groupBox_num.Controls.Add(this.textBox_num);
            this.groupBox_num.Location = new System.Drawing.Point(27, 155);
            this.groupBox_num.Name = "groupBox_num";
            this.groupBox_num.Size = new System.Drawing.Size(250, 93);
            this.groupBox_num.TabIndex = 4;
            this.groupBox_num.TabStop = false;
            // 
            // groupBox_bill
            // 
            this.groupBox_bill.Controls.Add(this.label_bill);
            this.groupBox_bill.Controls.Add(this.label_buy);
            this.groupBox_bill.Location = new System.Drawing.Point(27, 254);
            this.groupBox_bill.Name = "groupBox_bill";
            this.groupBox_bill.Size = new System.Drawing.Size(250, 125);
            this.groupBox_bill.TabIndex = 5;
            this.groupBox_bill.TabStop = false;
            // 
            // label_bill
            // 
            this.label_bill.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_bill.Location = new System.Drawing.Point(19, 61);
            this.label_bill.Name = "label_bill";
            this.label_bill.Size = new System.Drawing.Size(205, 39);
            this.label_bill.TabIndex = 4;
            this.label_bill.Text = "0";
            this.label_bill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_prices
            // 
            this.groupBox_prices.Controls.Add(this.label_18_24);
            this.groupBox_prices.Controls.Add(this.label_12_15);
            this.groupBox_prices.Controls.Add(this.label_9_12);
            this.groupBox_prices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_prices.Location = new System.Drawing.Point(163, 24);
            this.groupBox_prices.Name = "groupBox_prices";
            this.groupBox_prices.Size = new System.Drawing.Size(114, 125);
            this.groupBox_prices.TabIndex = 6;
            this.groupBox_prices.TabStop = false;
            this.groupBox_prices.Text = "Ціни";
            // 
            // label_18_24
            // 
            this.label_18_24.AutoSize = true;
            this.label_18_24.Location = new System.Drawing.Point(6, 89);
            this.label_18_24.Name = "label_18_24";
            this.label_18_24.Size = new System.Drawing.Size(23, 28);
            this.label_18_24.TabIndex = 2;
            this.label_18_24.Text = "0";
            // 
            // label_12_15
            // 
            this.label_12_15.AutoSize = true;
            this.label_12_15.Location = new System.Drawing.Point(6, 59);
            this.label_12_15.Name = "label_12_15";
            this.label_12_15.Size = new System.Drawing.Size(23, 28);
            this.label_12_15.TabIndex = 1;
            this.label_12_15.Text = "0";
            // 
            // label_9_12
            // 
            this.label_9_12.AutoSize = true;
            this.label_9_12.Location = new System.Drawing.Point(6, 29);
            this.label_9_12.Name = "label_9_12";
            this.label_9_12.Size = new System.Drawing.Size(23, 28);
            this.label_9_12.TabIndex = 0;
            this.label_9_12.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_prices);
            this.Controls.Add(this.groupBox_size);
            this.Controls.Add(this.groupBox_num);
            this.Controls.Add(this.groupBox_bill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_size.ResumeLayout(false);
            this.groupBox_size.PerformLayout();
            this.groupBox_num.ResumeLayout(false);
            this.groupBox_num.PerformLayout();
            this.groupBox_bill.ResumeLayout(false);
            this.groupBox_bill.PerformLayout();
            this.groupBox_prices.ResumeLayout(false);
            this.groupBox_prices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_size;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_buy;
        private System.Windows.Forms.GroupBox groupBox_num;
        private System.Windows.Forms.GroupBox groupBox_bill;
        private System.Windows.Forms.GroupBox groupBox_prices;
        public System.Windows.Forms.Label label_18_24;
        public System.Windows.Forms.Label label_12_15;
        public System.Windows.Forms.Label label_9_12;
        public System.Windows.Forms.TextBox textBox_num;
        public System.Windows.Forms.RadioButton radioButton_18_24;
        public System.Windows.Forms.RadioButton radioButton_12_15;
        public System.Windows.Forms.RadioButton radioButton_9_12;
        public System.Windows.Forms.Label label_bill;
    }
}

