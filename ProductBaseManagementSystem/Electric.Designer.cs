namespace ProductBaseManagementSystem
{
    partial class Electric
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerElectricMonth = new System.Windows.Forms.DateTimePicker();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.dateTimePickerSearchToDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerSearchFromDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltxtElectricPaymentMonth = new System.Windows.Forms.Label();
            this.lbltxtElectricPaymentTo = new System.Windows.Forms.Label();
            this.lbltxtElectricPaidAmount = new System.Windows.Forms.Label();
            this.lbltxtElectricAmount = new System.Windows.Forms.Label();
            this.txtElectricPaymentTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnElectricPaid = new System.Windows.Forms.Button();
            this.txtElectricPaidAmount = new System.Windows.Forms.TextBox();
            this.txtElectricAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDueAmountPaid = new System.Windows.Forms.Panel();
            this.btnDueAmountPaid = new System.Windows.Forms.Button();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewElectric = new System.Windows.Forms.DataGridView();
            this.lblElectricPaymentToShow = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblElectricDueAmountShow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDueAmountPaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePickerElectricMonth);
            this.panel1.Controls.Add(this.btnSearchByDate);
            this.panel1.Controls.Add(this.dateTimePickerSearchToDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimePickerSearchFromDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbltxtElectricPaymentMonth);
            this.panel1.Controls.Add(this.lbltxtElectricPaymentTo);
            this.panel1.Controls.Add(this.lbltxtElectricPaidAmount);
            this.panel1.Controls.Add(this.lbltxtElectricAmount);
            this.panel1.Controls.Add(this.txtElectricPaymentTo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnElectricPaid);
            this.panel1.Controls.Add(this.txtElectricPaidAmount);
            this.panel1.Controls.Add(this.txtElectricAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 606);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Month";
            // 
            // dateTimePickerElectricMonth
            // 
            this.dateTimePickerElectricMonth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerElectricMonth.CustomFormat = "yyyy-MM";
            this.dateTimePickerElectricMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerElectricMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerElectricMonth.Location = new System.Drawing.Point(12, 335);
            this.dateTimePickerElectricMonth.Name = "dateTimePickerElectricMonth";
            this.dateTimePickerElectricMonth.Size = new System.Drawing.Size(191, 27);
            this.dateTimePickerElectricMonth.TabIndex = 2;
            this.dateTimePickerElectricMonth.Leave += new System.EventHandler(this.dateTimePickerElectricPaymentDate_Leave);
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByDate.Location = new System.Drawing.Point(39, 562);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(126, 41);
            this.btnSearchByDate.TabIndex = 18;
            this.btnSearchByDate.Text = "Search";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // dateTimePickerSearchToDate
            // 
            this.dateTimePickerSearchToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearchToDate.CustomFormat = "yyyy-MM";
            this.dateTimePickerSearchToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearchToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSearchToDate.Location = new System.Drawing.Point(10, 533);
            this.dateTimePickerSearchToDate.Name = "dateTimePickerSearchToDate";
            this.dateTimePickerSearchToDate.Size = new System.Drawing.Size(193, 23);
            this.dateTimePickerSearchToDate.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "From";
            // 
            // dateTimePickerSearchFromDate
            // 
            this.dateTimePickerSearchFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearchFromDate.CustomFormat = "yyyy-MM";
            this.dateTimePickerSearchFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearchFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSearchFromDate.Location = new System.Drawing.Point(10, 486);
            this.dateTimePickerSearchFromDate.Name = "dateTimePickerSearchFromDate";
            this.dateTimePickerSearchFromDate.Size = new System.Drawing.Size(193, 23);
            this.dateTimePickerSearchFromDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search By Date";
            // 
            // lbltxtElectricPaymentMonth
            // 
            this.lbltxtElectricPaymentMonth.AutoSize = true;
            this.lbltxtElectricPaymentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtElectricPaymentMonth.Location = new System.Drawing.Point(14, 340);
            this.lbltxtElectricPaymentMonth.Name = "lbltxtElectricPaymentMonth";
            this.lbltxtElectricPaymentMonth.Size = new System.Drawing.Size(0, 17);
            this.lbltxtElectricPaymentMonth.TabIndex = 13;
            // 
            // lbltxtElectricPaymentTo
            // 
            this.lbltxtElectricPaymentTo.AutoSize = true;
            this.lbltxtElectricPaymentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtElectricPaymentTo.Location = new System.Drawing.Point(13, 282);
            this.lbltxtElectricPaymentTo.Name = "lbltxtElectricPaymentTo";
            this.lbltxtElectricPaymentTo.Size = new System.Drawing.Size(0, 17);
            this.lbltxtElectricPaymentTo.TabIndex = 12;
            // 
            // lbltxtElectricPaidAmount
            // 
            this.lbltxtElectricPaidAmount.AutoSize = true;
            this.lbltxtElectricPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtElectricPaidAmount.Location = new System.Drawing.Point(14, 208);
            this.lbltxtElectricPaidAmount.Name = "lbltxtElectricPaidAmount";
            this.lbltxtElectricPaidAmount.Size = new System.Drawing.Size(0, 17);
            this.lbltxtElectricPaidAmount.TabIndex = 11;
            // 
            // lbltxtElectricAmount
            // 
            this.lbltxtElectricAmount.AutoSize = true;
            this.lbltxtElectricAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtElectricAmount.Location = new System.Drawing.Point(13, 138);
            this.lbltxtElectricAmount.Name = "lbltxtElectricAmount";
            this.lbltxtElectricAmount.Size = new System.Drawing.Size(0, 17);
            this.lbltxtElectricAmount.TabIndex = 10;
            // 
            // txtElectricPaymentTo
            // 
            this.txtElectricPaymentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectricPaymentTo.Location = new System.Drawing.Point(12, 255);
            this.txtElectricPaymentTo.Multiline = true;
            this.txtElectricPaymentTo.Name = "txtElectricPaymentTo";
            this.txtElectricPaymentTo.Size = new System.Drawing.Size(191, 24);
            this.txtElectricPaymentTo.TabIndex = 3;
            this.txtElectricPaymentTo.TextChanged += new System.EventHandler(this.txtElectricPaymentTo_TextChanged);
            this.txtElectricPaymentTo.Leave += new System.EventHandler(this.txtElectricPaymentTo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Payment To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paid Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount";
            // 
            // btnElectricPaid
            // 
            this.btnElectricPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElectricPaid.Location = new System.Drawing.Point(39, 373);
            this.btnElectricPaid.Name = "btnElectricPaid";
            this.btnElectricPaid.Size = new System.Drawing.Size(138, 46);
            this.btnElectricPaid.TabIndex = 5;
            this.btnElectricPaid.Text = "Paid";
            this.btnElectricPaid.UseVisualStyleBackColor = true;
            this.btnElectricPaid.Click += new System.EventHandler(this.btnElectricPaid_Click);
            // 
            // txtElectricPaidAmount
            // 
            this.txtElectricPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectricPaidAmount.Location = new System.Drawing.Point(12, 181);
            this.txtElectricPaidAmount.Multiline = true;
            this.txtElectricPaidAmount.Name = "txtElectricPaidAmount";
            this.txtElectricPaidAmount.Size = new System.Drawing.Size(191, 24);
            this.txtElectricPaidAmount.TabIndex = 2;
            this.txtElectricPaidAmount.Leave += new System.EventHandler(this.txtElectricPaidAmount_Leave);
            // 
            // txtElectricAmount
            // 
            this.txtElectricAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectricAmount.Location = new System.Drawing.Point(12, 112);
            this.txtElectricAmount.Multiline = true;
            this.txtElectricAmount.Name = "txtElectricAmount";
            this.txtElectricAmount.Size = new System.Drawing.Size(191, 24);
            this.txtElectricAmount.TabIndex = 1;
            this.txtElectricAmount.Leave += new System.EventHandler(this.txtElectricAmount_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Electric";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.pnlDueAmountPaid);
            this.panel2.Controls.Add(this.dataGridViewElectric);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(216, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 606);
            this.panel2.TabIndex = 1;
            // 
            // pnlDueAmountPaid
            // 
            this.pnlDueAmountPaid.Controls.Add(this.lblElectricPaymentToShow);
            this.pnlDueAmountPaid.Controls.Add(this.label11);
            this.pnlDueAmountPaid.Controls.Add(this.lblElectricDueAmountShow);
            this.pnlDueAmountPaid.Controls.Add(this.label5);
            this.pnlDueAmountPaid.Controls.Add(this.btnDueAmountPaid);
            this.pnlDueAmountPaid.Controls.Add(this.txtPaidAmount);
            this.pnlDueAmountPaid.Controls.Add(this.label7);
            this.pnlDueAmountPaid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDueAmountPaid.Location = new System.Drawing.Point(0, 506);
            this.pnlDueAmountPaid.Name = "pnlDueAmountPaid";
            this.pnlDueAmountPaid.Size = new System.Drawing.Size(909, 100);
            this.pnlDueAmountPaid.TabIndex = 1;
            // 
            // btnDueAmountPaid
            // 
            this.btnDueAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDueAmountPaid.Location = new System.Drawing.Point(744, 23);
            this.btnDueAmountPaid.Name = "btnDueAmountPaid";
            this.btnDueAmountPaid.Size = new System.Drawing.Size(150, 49);
            this.btnDueAmountPaid.TabIndex = 9;
            this.btnDueAmountPaid.Text = "Paid";
            this.btnDueAmountPaid.UseVisualStyleBackColor = true;
            this.btnDueAmountPaid.Click += new System.EventHandler(this.btnDueAmountPaid_Click);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(509, 42);
            this.txtPaidAmount.Multiline = true;
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(191, 26);
            this.txtPaidAmount.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Paid Amount";
            // 
            // dataGridViewElectric
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewElectric.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewElectric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewElectric.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewElectric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewElectric.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewElectric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewElectric.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewElectric.Name = "dataGridViewElectric";
            this.dataGridViewElectric.RowHeadersVisible = false;
            this.dataGridViewElectric.RowTemplate.Height = 30;
            this.dataGridViewElectric.Size = new System.Drawing.Size(909, 606);
            this.dataGridViewElectric.TabIndex = 0;
            this.dataGridViewElectric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewElectric_CellContentClick);
            // 
            // lblElectricPaymentToShow
            // 
            this.lblElectricPaymentToShow.AutoSize = true;
            this.lblElectricPaymentToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricPaymentToShow.Location = new System.Drawing.Point(148, 18);
            this.lblElectricPaymentToShow.Name = "lblElectricPaymentToShow";
            this.lblElectricPaymentToShow.Size = new System.Drawing.Size(52, 26);
            this.lblElectricPaymentToShow.TabIndex = 22;
            this.lblElectricPaymentToShow.Text = "Due";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Payment To  :";
            // 
            // lblElectricDueAmountShow
            // 
            this.lblElectricDueAmountShow.AutoSize = true;
            this.lblElectricDueAmountShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricDueAmountShow.Location = new System.Drawing.Point(148, 58);
            this.lblElectricDueAmountShow.Name = "lblElectricDueAmountShow";
            this.lblElectricDueAmountShow.Size = new System.Drawing.Size(88, 26);
            this.lblElectricDueAmountShow.TabIndex = 20;
            this.lblElectricDueAmountShow.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Due Amount  :";
            // 
            // Electric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Electric";
            this.Text = "Electric";
            this.Load += new System.EventHandler(this.Electric_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlDueAmountPaid.ResumeLayout(false);
            this.pnlDueAmountPaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnElectricPaid;
        private System.Windows.Forms.TextBox txtElectricPaidAmount;
        private System.Windows.Forms.TextBox txtElectricAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewElectric;
        private System.Windows.Forms.Panel pnlDueAmountPaid;
        private System.Windows.Forms.Button btnDueAmountPaid;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltxtElectricPaymentMonth;
        private System.Windows.Forms.Label lbltxtElectricPaymentTo;
        private System.Windows.Forms.Label lbltxtElectricPaidAmount;
        private System.Windows.Forms.Label lbltxtElectricAmount;
        private System.Windows.Forms.TextBox txtElectricPaymentTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchToDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerElectricMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblElectricPaymentToShow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblElectricDueAmountShow;
        private System.Windows.Forms.Label label5;
    }
}