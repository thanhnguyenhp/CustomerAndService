namespace CustomerAndService
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnfix = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.boxcustomer = new System.Windows.Forms.ComboBox();
            this.boxservice = new System.Windows.Forms.ComboBox();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 800);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(926, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý khách hàng và dịch vụ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(487, 436);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(898, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 493);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khách hàng";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(173, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 22);
            this.txtId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên khách hàng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(502, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 22);
            this.txtName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(173, 79);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(136, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(502, 73);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(164, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 272);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Danh sách khách hàng";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(747, 38);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnfix
            // 
            this.btnfix.Location = new System.Drawing.Point(747, 94);
            this.btnfix.Name = "btnfix";
            this.btnfix.Size = new System.Drawing.Size(75, 23);
            this.btnfix.TabIndex = 11;
            this.btnfix.Text = "Sửa";
            this.btnfix.UseVisualStyleBackColor = true;
            this.btnfix.Click += new System.EventHandler(this.btnfix_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(747, 150);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnfix);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(29, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 493);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Dịch vụ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tạo hóa đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tổng tiền";
            // 
            // boxcustomer
            // 
            this.boxcustomer.FormattingEnabled = true;
            this.boxcustomer.Location = new System.Drawing.Point(132, 8);
            this.boxcustomer.Name = "boxcustomer";
            this.boxcustomer.Size = new System.Drawing.Size(151, 24);
            this.boxcustomer.TabIndex = 4;
            // 
            // boxservice
            // 
            this.boxservice.FormattingEnabled = true;
            this.boxservice.Location = new System.Drawing.Point(132, 55);
            this.boxservice.Name = "boxservice";
            this.boxservice.Size = new System.Drawing.Size(151, 24);
            this.boxservice.TabIndex = 5;
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreateInvoice.Location = new System.Drawing.Point(132, 95);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(85, 27);
            this.btnCreateInvoice.TabIndex = 6;
            this.btnCreateInvoice.Text = "Tạo";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(139, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.btnCreateInvoice);
            this.panel4.Controls.Add(this.boxservice);
            this.panel4.Controls.Add(this.boxcustomer);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(460, 614);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(541, 170);
            this.panel4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 796);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quan ly";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.ComboBox boxservice;
        private System.Windows.Forms.ComboBox boxcustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfix;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
    }
}

