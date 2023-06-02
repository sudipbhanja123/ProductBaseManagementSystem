namespace ProductBaseManagementSystem
{
    partial class Transaction_Status
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPaymentAmount = new System.Windows.Forms.Panel();
            this.btnTransactionRefresh = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchTransactionDate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lbltxtpaymentAmount = new System.Windows.Forms.Label();
            this.btnPaymentAmount = new System.Windows.Forms.Button();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewGetAllTransaction = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlPaymentAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAllTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction";
            // 
            // pnlPaymentAmount
            // 
            this.pnlPaymentAmount.Controls.Add(this.btnTransactionRefresh);
            this.pnlPaymentAmount.Controls.Add(this.dateTimePickerTo);
            this.pnlPaymentAmount.Controls.Add(this.label4);
            this.pnlPaymentAmount.Controls.Add(this.btnSearchTransactionDate);
            this.pnlPaymentAmount.Controls.Add(this.label3);
            this.pnlPaymentAmount.Controls.Add(this.dateTimePickerFrom);
            this.pnlPaymentAmount.Controls.Add(this.lbltxtpaymentAmount);
            this.pnlPaymentAmount.Controls.Add(this.btnPaymentAmount);
            this.pnlPaymentAmount.Controls.Add(this.txtPaymentAmount);
            this.pnlPaymentAmount.Controls.Add(this.label2);
            this.pnlPaymentAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPaymentAmount.Location = new System.Drawing.Point(0, 44);
            this.pnlPaymentAmount.Name = "pnlPaymentAmount";
            this.pnlPaymentAmount.Size = new System.Drawing.Size(212, 562);
            this.pnlPaymentAmount.TabIndex = 2;
            // 
            // btnTransactionRefresh
            // 
            this.btnTransactionRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionRefresh.Location = new System.Drawing.Point(47, 523);
            this.btnTransactionRefresh.Name = "btnTransactionRefresh";
            this.btnTransactionRefresh.Size = new System.Drawing.Size(119, 36);
            this.btnTransactionRefresh.TabIndex = 7;
            this.btnTransactionRefresh.Text = "Refresh";
            this.btnTransactionRefresh.UseVisualStyleBackColor = true;
            this.btnTransactionRefresh.Click += new System.EventHandler(this.btnTransactionRefresh_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(7, 387);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerTo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "To";
            // 
            // btnSearchTransactionDate
            // 
            this.btnSearchTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTransactionDate.Location = new System.Drawing.Point(43, 435);
            this.btnSearchTransactionDate.Name = "btnSearchTransactionDate";
            this.btnSearchTransactionDate.Size = new System.Drawing.Size(119, 36);
            this.btnSearchTransactionDate.TabIndex = 4;
            this.btnSearchTransactionDate.Text = "Search";
            this.btnSearchTransactionDate.UseVisualStyleBackColor = true;
            this.btnSearchTransactionDate.Click += new System.EventHandler(this.btnSearchTransactionDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(7, 319);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // lbltxtpaymentAmount
            // 
            this.lbltxtpaymentAmount.AutoSize = true;
            this.lbltxtpaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtpaymentAmount.Location = new System.Drawing.Point(18, 99);
            this.lbltxtpaymentAmount.Name = "lbltxtpaymentAmount";
            this.lbltxtpaymentAmount.Size = new System.Drawing.Size(0, 17);
            this.lbltxtpaymentAmount.TabIndex = 4;
            // 
            // btnPaymentAmount
            // 
            this.btnPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentAmount.Location = new System.Drawing.Point(43, 143);
            this.btnPaymentAmount.Name = "btnPaymentAmount";
            this.btnPaymentAmount.Size = new System.Drawing.Size(133, 46);
            this.btnPaymentAmount.TabIndex = 2;
            this.btnPaymentAmount.Text = "Pay";
            this.btnPaymentAmount.UseVisualStyleBackColor = true;
            this.btnPaymentAmount.Click += new System.EventHandler(this.btnPaymentAmount_Click);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentAmount.Location = new System.Drawing.Point(7, 66);
            this.txtPaymentAmount.Multiline = true;
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(198, 30);
            this.txtPaymentAmount.TabIndex = 1;
            this.txtPaymentAmount.Leave += new System.EventHandler(this.txtPaymentAmount_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = " Payment Amount";
            // 
            // dataGridViewGetAllTransaction
            // 
            this.dataGridViewGetAllTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGetAllTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetAllTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGetAllTransaction.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGetAllTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGetAllTransaction.Location = new System.Drawing.Point(212, 44);
            this.dataGridViewGetAllTransaction.Name = "dataGridViewGetAllTransaction";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGetAllTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGetAllTransaction.RowHeadersVisible = false;
            this.dataGridViewGetAllTransaction.RowTemplate.Height = 30;
            this.dataGridViewGetAllTransaction.Size = new System.Drawing.Size(913, 562);
            this.dataGridViewGetAllTransaction.TabIndex = 3;
            this.dataGridViewGetAllTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGetAllTransaction_CellContentClick);
            // 
            // Transaction_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 606);
            this.Controls.Add(this.dataGridViewGetAllTransaction);
            this.Controls.Add(this.pnlPaymentAmount);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction_Status";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Status_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPaymentAmount.ResumeLayout(false);
            this.pnlPaymentAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAllTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPaymentAmount;
        private System.Windows.Forms.Button btnPaymentAmount;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewGetAllTransaction;
        private System.Windows.Forms.Label lbltxtpaymentAmount;
        private System.Windows.Forms.Button btnTransactionRefresh;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchTransactionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
    }
}