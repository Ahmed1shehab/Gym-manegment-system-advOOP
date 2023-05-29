namespace Gym_Management_System
{
    partial class Payments
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
            this.lblPExit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPAmount = new System.Windows.Forms.TextBox();
            this.txtPSearch = new System.Windows.Forms.TextBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.dtpPDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.btnPReset = new System.Windows.Forms.Button();
            this.btnPBack = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbPName = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPExit
            // 
            this.lblPExit.AutoSize = true;
            this.lblPExit.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPExit.ForeColor = System.Drawing.Color.Black;
            this.lblPExit.Location = new System.Drawing.Point(1729, 39);
            this.lblPExit.Name = "lblPExit";
            this.lblPExit.Size = new System.Drawing.Size(47, 46);
            this.lblPExit.TabIndex = 47;
            this.lblPExit.Text = "X";
            this.lblPExit.Click += new System.EventHandler(this.lblPExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(787, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 46);
            this.label2.TabIndex = 46;
            this.label2.Text = "Payments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(771, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 46);
            this.label1.TabIndex = 45;
            this.label1.Text = "FITNESS GYM";
            // 
            // txtPAmount
            // 
            this.txtPAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAmount.Location = new System.Drawing.Point(83, 596);
            this.txtPAmount.Name = "txtPAmount";
            this.txtPAmount.Size = new System.Drawing.Size(205, 38);
            this.txtPAmount.TabIndex = 51;
            // 
            // txtPSearch
            // 
            this.txtPSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSearch.Location = new System.Drawing.Point(787, 394);
            this.txtPSearch.Name = "txtPSearch";
            this.txtPSearch.Size = new System.Drawing.Size(430, 38);
            this.txtPSearch.TabIndex = 50;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.Black;
            this.lblPName.Location = new System.Drawing.Point(85, 384);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(122, 46);
            this.lblPName.TabIndex = 49;
            this.lblPName.Text = "NAME";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(80, 526);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(178, 46);
            this.lblAmount.TabIndex = 48;
            this.lblAmount.Text = "amount";
            // 
            // dtpPDate
            // 
            this.dtpPDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPDate.Location = new System.Drawing.Point(88, 768);
            this.dtpPDate.Name = "dtpPDate";
            this.dtpPDate.Size = new System.Drawing.Size(301, 42);
            this.dtpPDate.TabIndex = 52;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentDate.Location = new System.Drawing.Point(85, 689);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(304, 46);
            this.lblPaymentDate.TabIndex = 53;
            this.lblPaymentDate.Text = "payment date";
            // 
            // btnPReset
            // 
            this.btnPReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnPReset.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPReset.Location = new System.Drawing.Point(266, 870);
            this.btnPReset.Name = "btnPReset";
            this.btnPReset.Size = new System.Drawing.Size(173, 63);
            this.btnPReset.TabIndex = 56;
            this.btnPReset.Text = "Reset";
            this.btnPReset.UseVisualStyleBackColor = false;
            this.btnPReset.Click += new System.EventHandler(this.btnPReset_Click);
            // 
            // btnPBack
            // 
            this.btnPBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnPBack.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPBack.Location = new System.Drawing.Point(167, 948);
            this.btnPBack.Name = "btnPBack";
            this.btnPBack.Size = new System.Drawing.Size(173, 63);
            this.btnPBack.TabIndex = 55;
            this.btnPBack.Text = "Back";
            this.btnPBack.UseVisualStyleBackColor = false;
            this.btnPBack.Click += new System.EventHandler(this.btnPBack_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.IndianRed;
            this.btnPay.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(66, 870);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(173, 63);
            this.btnPay.TabIndex = 54;
            this.btnPay.Text = "pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(484, 478);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersWidth = 82;
            this.dgvPayments.RowTemplate.Height = 33;
            this.dgvPayments.Size = new System.Drawing.Size(1259, 651);
            this.dgvPayments.TabIndex = 57;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnSearch.Font = new System.Drawing.Font("Showcard Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1250, 384);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(173, 63);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbPName
            // 
            this.cmbPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPName.FormattingEnabled = true;
            this.cmbPName.Items.AddRange(new object[] {
            "1Month",
            "2Months",
            "3Months",
            "1Year"});
            this.cmbPName.Location = new System.Drawing.Point(83, 455);
            this.cmbPName.Name = "cmbPName";
            this.cmbPName.Size = new System.Drawing.Size(205, 39);
            this.cmbPName.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_Management_System.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(779, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 1184);
            this.Controls.Add(this.cmbPName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnPReset);
            this.Controls.Add(this.btnPBack);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.dtpPDate);
            this.Controls.Add(this.txtPAmount);
            this.Controls.Add(this.txtPSearch);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPAmount;
        private System.Windows.Forms.TextBox txtPSearch;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DateTimePicker dtpPDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Button btnPReset;
        private System.Windows.Forms.Button btnPBack;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbPName;
    }
}