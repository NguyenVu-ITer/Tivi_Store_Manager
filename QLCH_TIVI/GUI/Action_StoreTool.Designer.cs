namespace GUI
{
    partial class Action_StoreTool
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.bAction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tProCode = new System.Windows.Forms.TextBox();
            this.tProWeight = new System.Windows.Forms.TextBox();
            this.tProName = new System.Windows.Forms.TextBox();
            this.tProType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tProOrigin = new System.Windows.Forms.TextBox();
            this.tProPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tProSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProSupplier = new System.Windows.Forms.ComboBox();
            this.cbProGuarantee = new System.Windows.Forms.ComboBox();
            this.cbProDisplay = new System.Windows.Forms.ComboBox();
            this.panel_Pro = new System.Windows.Forms.Panel();
            this.tProInventory = new System.Windows.Forms.NumericUpDown();
            this.cbProDebut = new System.Windows.Forms.ComboBox();
            this.bulkhead_under = new System.Windows.Forms.Panel();
            this.bulkhead_above = new System.Windows.Forms.Panel();
            this.panel_anchor = new System.Windows.Forms.Panel();
            this.panel_Sup = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tSupPhone = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tSupName = new System.Windows.Forms.TextBox();
            this.tSupAdress = new System.Windows.Forms.TextBox();
            this.tSupCode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel_Pro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tProInventory)).BeginInit();
            this.panel_Sup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(101, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(458, 23);
            this.lbTitle.TabIndex = 11;
            this.lbTitle.Text = "FORM ACTION";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBack.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.bBack.ForeColor = System.Drawing.Color.White;
            this.bBack.Location = new System.Drawing.Point(3, 3);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(144, 36);
            this.bBack.TabIndex = 13;
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
            this.bAction.Size = new System.Drawing.Size(144, 36);
            this.bAction.TabIndex = 12;
            this.bAction.Text = "Lưu";
            this.bAction.UseVisualStyleBackColor = false;
            this.bAction.Click += new System.EventHandler(this.bAction_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bBack);
            this.panel1.Controls.Add(this.bAction);
            this.panel1.Location = new System.Drawing.Point(176, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 42);
            this.panel1.TabIndex = 17;
            // 
            // tProCode
            // 
            this.tProCode.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProCode.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tProCode.Location = new System.Drawing.Point(78, 3);
            this.tProCode.Name = "tProCode";
            this.tProCode.Size = new System.Drawing.Size(183, 27);
            this.tProCode.TabIndex = 0;
            this.tProCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tProWeight
            // 
            this.tProWeight.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProWeight.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tProWeight.Location = new System.Drawing.Point(128, 183);
            this.tProWeight.Name = "tProWeight";
            this.tProWeight.Size = new System.Drawing.Size(78, 27);
            this.tProWeight.TabIndex = 4;
            this.tProWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tProName
            // 
            this.tProName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tProName.Location = new System.Drawing.Point(108, 48);
            this.tProName.Name = "tProName";
            this.tProName.Size = new System.Drawing.Size(526, 27);
            this.tProName.TabIndex = 1;
            // 
            // tProType
            // 
            this.tProType.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProType.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tProType.Location = new System.Drawing.Point(78, 93);
            this.tProType.Name = "tProType";
            this.tProType.Size = new System.Drawing.Size(183, 27);
            this.tProType.TabIndex = 2;
            this.tProType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mã SP:";
            // 
            // tProOrigin
            // 
            this.tProOrigin.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProOrigin.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tProOrigin.Location = new System.Drawing.Point(376, 183);
            this.tProOrigin.Name = "tProOrigin";
            this.tProOrigin.Size = new System.Drawing.Size(258, 27);
            this.tProOrigin.TabIndex = 9;
            // 
            // tProPrice
            // 
            this.tProPrice.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProPrice.ForeColor = System.Drawing.Color.Tomato;
            this.tProPrice.Location = new System.Drawing.Point(272, 272);
            this.tProPrice.Name = "tProPrice";
            this.tProPrice.Size = new System.Drawing.Size(181, 38);
            this.tProPrice.TabIndex = 11;
            this.tProPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sản phẩm:";
            // 
            // tProSize
            // 
            this.tProSize.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProSize.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tProSize.Location = new System.Drawing.Point(108, 138);
            this.tProSize.Name = "tProSize";
            this.tProSize.Size = new System.Drawing.Size(153, 27);
            this.tProSize.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thương hiệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Khối lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "(kg)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Độ phân giải:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bảo hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Loại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "SL vào kho:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(341, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Ra mắt:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(188, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 31);
            this.label13.TabIndex = 15;
            this.label13.Text = "Giá:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Xuất xứ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Màn hình:";
            // 
            // cbProSupplier
            // 
            this.cbProSupplier.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbProSupplier.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbProSupplier.FormattingEnabled = true;
            this.cbProSupplier.Location = new System.Drawing.Point(416, 3);
            this.cbProSupplier.Name = "cbProSupplier";
            this.cbProSupplier.Size = new System.Drawing.Size(218, 28);
            this.cbProSupplier.TabIndex = 6;
            // 
            // cbProGuarantee
            // 
            this.cbProGuarantee.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbProGuarantee.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbProGuarantee.FormattingEnabled = true;
            this.cbProGuarantee.Location = new System.Drawing.Point(386, 137);
            this.cbProGuarantee.Name = "cbProGuarantee";
            this.cbProGuarantee.Size = new System.Drawing.Size(248, 28);
            this.cbProGuarantee.TabIndex = 8;
            // 
            // cbProDisplay
            // 
            this.cbProDisplay.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbProDisplay.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbProDisplay.FormattingEnabled = true;
            this.cbProDisplay.Location = new System.Drawing.Point(426, 92);
            this.cbProDisplay.Name = "cbProDisplay";
            this.cbProDisplay.Size = new System.Drawing.Size(208, 28);
            this.cbProDisplay.TabIndex = 7;
            // 
            // panel_Pro
            // 
            this.panel_Pro.BackColor = System.Drawing.Color.White;
            this.panel_Pro.Controls.Add(this.tProInventory);
            this.panel_Pro.Controls.Add(this.cbProDisplay);
            this.panel_Pro.Controls.Add(this.cbProDebut);
            this.panel_Pro.Controls.Add(this.cbProGuarantee);
            this.panel_Pro.Controls.Add(this.cbProSupplier);
            this.panel_Pro.Controls.Add(this.label6);
            this.panel_Pro.Controls.Add(this.label10);
            this.panel_Pro.Controls.Add(this.label13);
            this.panel_Pro.Controls.Add(this.label12);
            this.panel_Pro.Controls.Add(this.label7);
            this.panel_Pro.Controls.Add(this.label3);
            this.panel_Pro.Controls.Add(this.label8);
            this.panel_Pro.Controls.Add(this.label9);
            this.panel_Pro.Controls.Add(this.label4);
            this.panel_Pro.Controls.Add(this.label2);
            this.panel_Pro.Controls.Add(this.label5);
            this.panel_Pro.Controls.Add(this.tProSize);
            this.panel_Pro.Controls.Add(this.label1);
            this.panel_Pro.Controls.Add(this.tProPrice);
            this.panel_Pro.Controls.Add(this.tProOrigin);
            this.panel_Pro.Controls.Add(this.label11);
            this.panel_Pro.Controls.Add(this.tProType);
            this.panel_Pro.Controls.Add(this.tProName);
            this.panel_Pro.Controls.Add(this.tProWeight);
            this.panel_Pro.Controls.Add(this.tProCode);
            this.panel_Pro.Location = new System.Drawing.Point(12, 106);
            this.panel_Pro.Name = "panel_Pro";
            this.panel_Pro.Size = new System.Drawing.Size(637, 325);
            this.panel_Pro.TabIndex = 0;
            // 
            // tProInventory
            // 
            this.tProInventory.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.tProInventory.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tProInventory.Location = new System.Drawing.Point(131, 228);
            this.tProInventory.Name = "tProInventory";
            this.tProInventory.Size = new System.Drawing.Size(130, 27);
            this.tProInventory.TabIndex = 5;
            // 
            // cbProDebut
            // 
            this.cbProDebut.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbProDebut.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbProDebut.FormattingEnabled = true;
            this.cbProDebut.Location = new System.Drawing.Point(426, 227);
            this.cbProDebut.Name = "cbProDebut";
            this.cbProDebut.Size = new System.Drawing.Size(208, 28);
            this.cbProDebut.TabIndex = 8;
            // 
            // bulkhead_under
            // 
            this.bulkhead_under.BackColor = System.Drawing.Color.DarkRed;
            this.bulkhead_under.Location = new System.Drawing.Point(12, 418);
            this.bulkhead_under.Name = "bulkhead_under";
            this.bulkhead_under.Size = new System.Drawing.Size(637, 10);
            this.bulkhead_under.TabIndex = 18;
            // 
            // bulkhead_above
            // 
            this.bulkhead_above.BackColor = System.Drawing.Color.DarkRed;
            this.bulkhead_above.Location = new System.Drawing.Point(12, 53);
            this.bulkhead_above.Name = "bulkhead_above";
            this.bulkhead_above.Size = new System.Drawing.Size(637, 10);
            this.bulkhead_above.TabIndex = 18;
            // 
            // panel_anchor
            // 
            this.panel_anchor.BackColor = System.Drawing.Color.Transparent;
            this.panel_anchor.Location = new System.Drawing.Point(12, 78);
            this.panel_anchor.Name = "panel_anchor";
            this.panel_anchor.Size = new System.Drawing.Size(637, 10);
            this.panel_anchor.TabIndex = 18;
            // 
            // panel_Sup
            // 
            this.panel_Sup.BackColor = System.Drawing.Color.White;
            this.panel_Sup.Controls.Add(this.label14);
            this.panel_Sup.Controls.Add(this.label19);
            this.panel_Sup.Controls.Add(this.label23);
            this.panel_Sup.Controls.Add(this.tSupPhone);
            this.panel_Sup.Controls.Add(this.label26);
            this.panel_Sup.Controls.Add(this.tSupName);
            this.panel_Sup.Controls.Add(this.tSupAdress);
            this.panel_Sup.Controls.Add(this.tSupCode);
            this.panel_Sup.Location = new System.Drawing.Point(12, 69);
            this.panel_Sup.Name = "panel_Sup";
            this.panel_Sup.Size = new System.Drawing.Size(637, 325);
            this.panel_Sup.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(106, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Điện thoại";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(106, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 20);
            this.label19.TabIndex = 15;
            this.label19.Text = "Thương hiệu:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(107, 233);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 20);
            this.label23.TabIndex = 15;
            this.label23.Text = "Địa chỉ:";
            // 
            // tSupPhone
            // 
            this.tSupPhone.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSupPhone.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tSupPhone.Location = new System.Drawing.Point(250, 175);
            this.tSupPhone.Name = "tSupPhone";
            this.tSupPhone.Size = new System.Drawing.Size(269, 27);
            this.tSupPhone.TabIndex = 2;
            this.tSupPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(106, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 20);
            this.label26.TabIndex = 15;
            this.label26.Text = "Mã NCC:";
            // 
            // tSupName
            // 
            this.tSupName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSupName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tSupName.Location = new System.Drawing.Point(250, 120);
            this.tSupName.Name = "tSupName";
            this.tSupName.Size = new System.Drawing.Size(269, 27);
            this.tSupName.TabIndex = 1;
            this.tSupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tSupAdress
            // 
            this.tSupAdress.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSupAdress.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tSupAdress.Location = new System.Drawing.Point(250, 230);
            this.tSupAdress.Name = "tSupAdress";
            this.tSupAdress.Size = new System.Drawing.Size(269, 27);
            this.tSupAdress.TabIndex = 3;
            this.tSupAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tSupCode
            // 
            this.tSupCode.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSupCode.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tSupCode.Location = new System.Drawing.Point(250, 65);
            this.tSupCode.Name = "tSupCode";
            this.tSupCode.Size = new System.Drawing.Size(269, 27);
            this.tSupCode.TabIndex = 0;
            this.tSupCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Action_StoreTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 498);
            this.Controls.Add(this.panel_Sup);
            this.Controls.Add(this.panel_Pro);
            this.Controls.Add(this.panel_anchor);
            this.Controls.Add(this.bulkhead_above);
            this.Controls.Add(this.bulkhead_under);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Action_StoreTool";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Action_StoreTool_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Pro.ResumeLayout(false);
            this.panel_Pro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tProInventory)).EndInit();
            this.panel_Sup.ResumeLayout(false);
            this.panel_Sup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bAction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tProCode;
        private System.Windows.Forms.TextBox tProWeight;
        private System.Windows.Forms.TextBox tProName;
        private System.Windows.Forms.TextBox tProType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tProOrigin;
        private System.Windows.Forms.TextBox tProPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tProSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbProSupplier;
        private System.Windows.Forms.ComboBox cbProGuarantee;
        private System.Windows.Forms.ComboBox cbProDisplay;
        private System.Windows.Forms.Panel panel_Pro;
        private System.Windows.Forms.NumericUpDown tProInventory;
        private System.Windows.Forms.Panel bulkhead_under;
        private System.Windows.Forms.Panel bulkhead_above;
        private System.Windows.Forms.Panel panel_anchor;
        private System.Windows.Forms.ComboBox cbProDebut;
        private System.Windows.Forms.Panel panel_Sup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tSupPhone;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tSupName;
        private System.Windows.Forms.TextBox tSupAdress;
        private System.Windows.Forms.TextBox tSupCode;
    }
}