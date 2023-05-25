namespace GUI
{
    partial class Salary_Up
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
            this.bAction = new System.Windows.Forms.Button();
            this.nSalary = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // bAction
            // 
            this.bAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bAction.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bAction.Location = new System.Drawing.Point(130, 67);
            this.bAction.Name = "bAction";
            this.bAction.Size = new System.Drawing.Size(141, 43);
            this.bAction.TabIndex = 0;
            this.bAction.Text = "Lưu";
            this.bAction.UseVisualStyleBackColor = false;
            this.bAction.Click += new System.EventHandler(this.bAction_Click);
            // 
            // nSalary
            // 
            this.nSalary.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nSalary.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.nSalary.Location = new System.Drawing.Point(20, 19);
            this.nSalary.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.nSalary.Name = "nSalary";
            this.nSalary.Size = new System.Drawing.Size(251, 36);
            this.nSalary.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(20, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salary_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(291, 122);
            this.Controls.Add(this.nSalary);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary_Up";
            this.Text = "Salary_Up";
            this.Load += new System.EventHandler(this.Salary_Up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAction;
        private System.Windows.Forms.NumericUpDown nSalary;
        private System.Windows.Forms.Button button1;
    }
}