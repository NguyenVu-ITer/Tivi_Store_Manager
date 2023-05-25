namespace GUI
{
    partial class Action_TransactionTool
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
            this.panel_anchor = new System.Windows.Forms.Panel();
            this.bulkhead_under = new System.Windows.Forms.Panel();
            this.panel_Pro = new System.Windows.Forms.Panel();
            this.grCustomer = new System.Windows.Forms.GroupBox();
            this.bCheck_CusCode = new System.Windows.Forms.Button();
            this.cbCusName = new System.Windows.Forms.ComboBox();
            this.rCusOld = new System.Windows.Forms.RadioButton();
            this.rCusNew = new System.Windows.Forms.RadioButton();
            this.tCusAdress = new System.Windows.Forms.TextBox();
            this.tCusEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tCusPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tCusName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tCusCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grDBill = new System.Windows.Forms.GroupBox();
            this.bCheck_DBCode = new System.Windows.Forms.Button();
            this.nDBAmount = new System.Windows.Forms.NumericUpDown();
            this.cbDBProCode = new System.Windows.Forms.ComboBox();
            this.tDBTotalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tDBProName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tDBCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grBill = new System.Windows.Forms.GroupBox();
            this.bCheck_BCode = new System.Windows.Forms.Button();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bulkhead_above = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBack = new System.Windows.Forms.Button();
            this.bAction = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel_Pro.SuspendLayout();
            this.grCustomer.SuspendLayout();
            this.grDBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDBAmount)).BeginInit();
            this.grBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_anchor
            // 
            this.panel_anchor.BackColor = System.Drawing.Color.Transparent;
            this.panel_anchor.Location = new System.Drawing.Point(12, 78);
            this.panel_anchor.Name = "panel_anchor";
            this.panel_anchor.Size = new System.Drawing.Size(776, 10);
            this.panel_anchor.TabIndex = 22;
            // 
            // bulkhead_under
            // 
            this.bulkhead_under.BackColor = System.Drawing.Color.DarkRed;
            this.bulkhead_under.Location = new System.Drawing.Point(12, 417);
            this.bulkhead_under.Name = "bulkhead_under";
            this.bulkhead_under.Size = new System.Drawing.Size(776, 10);
            this.bulkhead_under.TabIndex = 23;
            // 
            // panel_Pro
            // 
            this.panel_Pro.BackColor = System.Drawing.Color.White;
            this.panel_Pro.Controls.Add(this.grCustomer);
            this.panel_Pro.Controls.Add(this.grDBill);
            this.panel_Pro.Controls.Add(this.grBill);
            this.panel_Pro.Location = new System.Drawing.Point(12, 68);
            this.panel_Pro.Name = "panel_Pro";
            this.panel_Pro.Size = new System.Drawing.Size(776, 325);
            this.panel_Pro.TabIndex = 19;
            // 
            // grCustomer
            // 
            this.grCustomer.Controls.Add(this.bCheck_CusCode);
            this.grCustomer.Controls.Add(this.cbCusName);
            this.grCustomer.Controls.Add(this.rCusOld);
            this.grCustomer.Controls.Add(this.rCusNew);
            this.grCustomer.Controls.Add(this.tCusAdress);
            this.grCustomer.Controls.Add(this.tCusEmail);
            this.grCustomer.Controls.Add(this.label10);
            this.grCustomer.Controls.Add(this.tCusPhone);
            this.grCustomer.Controls.Add(this.label9);
            this.grCustomer.Controls.Add(this.label8);
            this.grCustomer.Controls.Add(this.tCusName);
            this.grCustomer.Controls.Add(this.label7);
            this.grCustomer.Controls.Add(this.tCusCode);
            this.grCustomer.Controls.Add(this.label1);
            this.grCustomer.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.grCustomer.ForeColor = System.Drawing.Color.Goldenrod;
            this.grCustomer.Location = new System.Drawing.Point(387, 3);
            this.grCustomer.Name = "grCustomer";
            this.grCustomer.Size = new System.Drawing.Size(386, 319);
            this.grCustomer.TabIndex = 16;
            this.grCustomer.TabStop = false;
            this.grCustomer.Text = "Thông tin khách hàng";
            // 
            // bCheck_CusCode
            // 
            this.bCheck_CusCode.Location = new System.Drawing.Point(326, 100);
            this.bCheck_CusCode.Name = "bCheck_CusCode";
            this.bCheck_CusCode.Size = new System.Drawing.Size(31, 30);
            this.bCheck_CusCode.TabIndex = 16;
            this.bCheck_CusCode.Text = "!";
            this.bCheck_CusCode.UseVisualStyleBackColor = true;
            this.bCheck_CusCode.Click += new System.EventHandler(this.bCheck_CusCode_Click);
            // 
            // cbCusName
            // 
            this.cbCusName.FormattingEnabled = true;
            this.cbCusName.Location = new System.Drawing.Point(161, 146);
            this.cbCusName.Name = "cbCusName";
            this.cbCusName.Size = new System.Drawing.Size(219, 28);
            this.cbCusName.TabIndex = 9;
            this.cbCusName.SelectedValueChanged += new System.EventHandler(this.cbCusName_SelectedValueChanged);
            // 
            // rCusOld
            // 
            this.rCusOld.AutoSize = true;
            this.rCusOld.ForeColor = System.Drawing.Color.Black;
            this.rCusOld.Location = new System.Drawing.Point(220, 50);
            this.rCusOld.Name = "rCusOld";
            this.rCusOld.Size = new System.Drawing.Size(110, 24);
            this.rCusOld.TabIndex = 7;
            this.rCusOld.TabStop = true;
            this.rCusOld.Text = "Khách cũ";
            this.rCusOld.UseVisualStyleBackColor = true;
            this.rCusOld.CheckedChanged += new System.EventHandler(this.rCusNew_CheckedChanged);
            // 
            // rCusNew
            // 
            this.rCusNew.AutoSize = true;
            this.rCusNew.ForeColor = System.Drawing.Color.Black;
            this.rCusNew.Location = new System.Drawing.Point(65, 50);
            this.rCusNew.Name = "rCusNew";
            this.rCusNew.Size = new System.Drawing.Size(120, 24);
            this.rCusNew.TabIndex = 6;
            this.rCusNew.TabStop = true;
            this.rCusNew.Text = "Khách mới";
            this.rCusNew.UseVisualStyleBackColor = true;
            this.rCusNew.CheckedChanged += new System.EventHandler(this.rCusNew_CheckedChanged);
            // 
            // tCusAdress
            // 
            this.tCusAdress.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCusAdress.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tCusAdress.Location = new System.Drawing.Point(138, 258);
            this.tCusAdress.Name = "tCusAdress";
            this.tCusAdress.Size = new System.Drawing.Size(219, 27);
            this.tCusAdress.TabIndex = 12;
            this.tCusAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tCusEmail
            // 
            this.tCusEmail.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCusEmail.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tCusEmail.Location = new System.Drawing.Point(138, 219);
            this.tCusEmail.Name = "tCusEmail";
            this.tCusEmail.Size = new System.Drawing.Size(219, 27);
            this.tCusEmail.TabIndex = 11;
            this.tCusEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(31, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Địa chỉ:";
            // 
            // tCusPhone
            // 
            this.tCusPhone.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCusPhone.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tCusPhone.Location = new System.Drawing.Point(138, 180);
            this.tCusPhone.Name = "tCusPhone";
            this.tCusPhone.Size = new System.Drawing.Size(219, 27);
            this.tCusPhone.TabIndex = 10;
            this.tCusPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "SĐT:";
            // 
            // tCusName
            // 
            this.tCusName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCusName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tCusName.Location = new System.Drawing.Point(138, 141);
            this.tCusName.Name = "tCusName";
            this.tCusName.Size = new System.Drawing.Size(219, 27);
            this.tCusName.TabIndex = 9;
            this.tCusName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Họ Tên:";
            // 
            // tCusCode
            // 
            this.tCusCode.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCusCode.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tCusCode.Location = new System.Drawing.Point(138, 102);
            this.tCusCode.Name = "tCusCode";
            this.tCusCode.Size = new System.Drawing.Size(182, 27);
            this.tCusCode.TabIndex = 8;
            this.tCusCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã KH:";
            // 
            // grDBill
            // 
            this.grDBill.Controls.Add(this.bCheck_DBCode);
            this.grDBill.Controls.Add(this.nDBAmount);
            this.grDBill.Controls.Add(this.cbDBProCode);
            this.grDBill.Controls.Add(this.tDBTotalPrice);
            this.grDBill.Controls.Add(this.label6);
            this.grDBill.Controls.Add(this.label5);
            this.grDBill.Controls.Add(this.tDBProName);
            this.grDBill.Controls.Add(this.label4);
            this.grDBill.Controls.Add(this.label3);
            this.grDBill.Controls.Add(this.tDBCode);
            this.grDBill.Controls.Add(this.label2);
            this.grDBill.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.grDBill.ForeColor = System.Drawing.Color.Blue;
            this.grDBill.Location = new System.Drawing.Point(3, 92);
            this.grDBill.Name = "grDBill";
            this.grDBill.Size = new System.Drawing.Size(378, 230);
            this.grDBill.TabIndex = 16;
            this.grDBill.TabStop = false;
            this.grDBill.Text = "Chi tiết hóa đơn";
            // 
            // bCheck_DBCode
            // 
            this.bCheck_DBCode.Location = new System.Drawing.Point(308, 32);
            this.bCheck_DBCode.Name = "bCheck_DBCode";
            this.bCheck_DBCode.Size = new System.Drawing.Size(31, 30);
            this.bCheck_DBCode.TabIndex = 16;
            this.bCheck_DBCode.Text = "!";
            this.bCheck_DBCode.UseVisualStyleBackColor = true;
            this.bCheck_DBCode.Click += new System.EventHandler(this.bCheck_DBCode_Click);
            // 
            // nDBAmount
            // 
            this.nDBAmount.Location = new System.Drawing.Point(148, 147);
            this.nDBAmount.Name = "nDBAmount";
            this.nDBAmount.Size = new System.Drawing.Size(191, 27);
            this.nDBAmount.TabIndex = 4;
            this.nDBAmount.ValueChanged += new System.EventHandler(this.nDBAmount_ValueChanged);
            // 
            // cbDBProCode
            // 
            this.cbDBProCode.FormattingEnabled = true;
            this.cbDBProCode.Location = new System.Drawing.Point(148, 73);
            this.cbDBProCode.Name = "cbDBProCode";
            this.cbDBProCode.Size = new System.Drawing.Size(191, 28);
            this.cbDBProCode.TabIndex = 2;
            this.cbDBProCode.SelectedValueChanged += new System.EventHandler(this.cbDBProCode_SelectedValueChanged);
            // 
            // tDBTotalPrice
            // 
            this.tDBTotalPrice.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDBTotalPrice.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tDBTotalPrice.Location = new System.Drawing.Point(158, 190);
            this.tDBTotalPrice.Name = "tDBTotalPrice";
            this.tDBTotalPrice.Size = new System.Drawing.Size(181, 27);
            this.tDBTotalPrice.TabIndex = 5;
            this.tDBTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(43, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số lượng:";
            // 
            // tDBProName
            // 
            this.tDBProName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDBProName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tDBProName.Location = new System.Drawing.Point(148, 112);
            this.tDBProName.Name = "tDBProName";
            this.tDBProName.Size = new System.Drawing.Size(191, 27);
            this.tDBProName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã SP:";
            // 
            // tDBCode
            // 
            this.tDBCode.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDBCode.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tDBCode.Location = new System.Drawing.Point(148, 34);
            this.tDBCode.Name = "tDBCode";
            this.tDBCode.Size = new System.Drawing.Size(154, 27);
            this.tDBCode.TabIndex = 1;
            this.tDBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã CT:";
            // 
            // grBill
            // 
            this.grBill.Controls.Add(this.bCheck_BCode);
            this.grBill.Controls.Add(this.tBCode);
            this.grBill.Controls.Add(this.label11);
            this.grBill.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.grBill.ForeColor = System.Drawing.Color.Blue;
            this.grBill.Location = new System.Drawing.Point(3, 3);
            this.grBill.Name = "grBill";
            this.grBill.Size = new System.Drawing.Size(378, 83);
            this.grBill.TabIndex = 16;
            this.grBill.TabStop = false;
            this.grBill.Text = "Hóa đơn";
            // 
            // bCheck_BCode
            // 
            this.bCheck_BCode.Location = new System.Drawing.Point(308, 33);
            this.bCheck_BCode.Name = "bCheck_BCode";
            this.bCheck_BCode.Size = new System.Drawing.Size(31, 30);
            this.bCheck_BCode.TabIndex = 16;
            this.bCheck_BCode.Text = "!";
            this.bCheck_BCode.UseVisualStyleBackColor = true;
            this.bCheck_BCode.Click += new System.EventHandler(this.bCheck_BCode_Click);
            // 
            // tBCode
            // 
            this.tBCode.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCode.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tBCode.Location = new System.Drawing.Point(148, 35);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(154, 27);
            this.tBCode.TabIndex = 0;
            this.tBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(43, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mã HĐ:";
            // 
            // bulkhead_above
            // 
            this.bulkhead_above.BackColor = System.Drawing.Color.DarkRed;
            this.bulkhead_above.Location = new System.Drawing.Point(12, 52);
            this.bulkhead_above.Name = "bulkhead_above";
            this.bulkhead_above.Size = new System.Drawing.Size(776, 10);
            this.bulkhead_above.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bBack);
            this.panel1.Controls.Add(this.bAction);
            this.panel1.Location = new System.Drawing.Point(243, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 43);
            this.panel1.TabIndex = 21;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBack.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.bBack.ForeColor = System.Drawing.Color.White;
            this.bBack.Location = new System.Drawing.Point(3, 3);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(144, 37);
            this.bBack.TabIndex = 14;
            this.bBack.Text = "Trở về";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bAction
            // 
            this.bAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.bAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAction.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.bAction.ForeColor = System.Drawing.Color.White;
            this.bAction.Location = new System.Drawing.Point(163, 3);
            this.bAction.Name = "bAction";
            this.bAction.Size = new System.Drawing.Size(144, 37);
            this.bAction.TabIndex = 13;
            this.bAction.Text = "Lưu";
            this.bAction.UseVisualStyleBackColor = false;
            this.bAction.Click += new System.EventHandler(this.bAction_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(15, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(773, 23);
            this.lbTitle.TabIndex = 20;
            this.lbTitle.Text = "FORM ACTION";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Action_TransactionTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel_Pro);
            this.Controls.Add(this.panel_anchor);
            this.Controls.Add(this.bulkhead_under);
            this.Controls.Add(this.bulkhead_above);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Action_TransactionTool";
            this.Load += new System.EventHandler(this.Action_TransactionTool_Load);
            this.panel_Pro.ResumeLayout(false);
            this.grCustomer.ResumeLayout(false);
            this.grCustomer.PerformLayout();
            this.grDBill.ResumeLayout(false);
            this.grDBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDBAmount)).EndInit();
            this.grBill.ResumeLayout(false);
            this.grBill.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_anchor;
        private System.Windows.Forms.Panel bulkhead_under;
        private System.Windows.Forms.Panel panel_Pro;
        private System.Windows.Forms.GroupBox grCustomer;
        private System.Windows.Forms.TextBox tCusCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grDBill;
        private System.Windows.Forms.TextBox tDBCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grBill;
        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel bulkhead_above;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bAction;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tCusAdress;
        private System.Windows.Forms.TextBox tCusEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tCusPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tCusName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tDBTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tDBProName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rCusOld;
        private System.Windows.Forms.RadioButton rCusNew;
        private System.Windows.Forms.ComboBox cbCusName;
        private System.Windows.Forms.ComboBox cbDBProCode;
        private System.Windows.Forms.NumericUpDown nDBAmount;
        private System.Windows.Forms.Button bCheck_CusCode;
        private System.Windows.Forms.Button bCheck_DBCode;
        private System.Windows.Forms.Button bCheck_BCode;
    }
}