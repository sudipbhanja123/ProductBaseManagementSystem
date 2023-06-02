namespace ProductBaseManagementSystem
{
    partial class Transport
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
            this.txtTransportImportAmount = new System.Windows.Forms.TextBox();
            this.txtTransportImportPaidAmount = new System.Windows.Forms.TextBox();
            this.btnTransportImportPaid = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltxtImportPaymentDate = new System.Windows.Forms.Label();
            this.lbltxtImportPaymentTo = new System.Windows.Forms.Label();
            this.txtPaymentTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerTransportDate = new System.Windows.Forms.DateTimePicker();
            this.lbltxtImportAmount = new System.Windows.Forms.Label();
            this.lbltxtImportPaidAmount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTransportDueAmountPaid = new System.Windows.Forms.Panel();
            this.btnDueAmountPaid = new System.Windows.Forms.Button();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTransportDueAmountShow = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewTransportImportPaidAmount = new System.Windows.Forms.DataGridView();
            this.lblTransportPaymentToShow = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlTransportDueAmountPaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransportImportPaidAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(15, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(15, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paid";
            // 
            // txtTransportImportAmount
            // 
            this.txtTransportImportAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportImportAmount.Location = new System.Drawing.Point(12, 148);
            this.txtTransportImportAmount.Multiline = true;
            this.txtTransportImportAmount.Name = "txtTransportImportAmount";
            this.txtTransportImportAmount.Size = new System.Drawing.Size(205, 24);
            this.txtTransportImportAmount.TabIndex = 1;
            this.txtTransportImportAmount.Leave += new System.EventHandler(this.txtTransportImportAmount_Leave);
            // 
            // txtTransportImportPaidAmount
            // 
            this.txtTransportImportPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportImportPaidAmount.Location = new System.Drawing.Point(12, 213);
            this.txtTransportImportPaidAmount.Multiline = true;
            this.txtTransportImportPaidAmount.Name = "txtTransportImportPaidAmount";
            this.txtTransportImportPaidAmount.Size = new System.Drawing.Size(205, 24);
            this.txtTransportImportPaidAmount.TabIndex = 2;
            this.txtTransportImportPaidAmount.Leave += new System.EventHandler(this.txtTransportImportPaidAmount_Leave);
            // 
            // btnTransportImportPaid
            // 
            this.btnTransportImportPaid.BackColor = System.Drawing.Color.Indigo;
            this.btnTransportImportPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransportImportPaid.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportImportPaid.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnTransportImportPaid.Location = new System.Drawing.Point(32, 385);
            this.btnTransportImportPaid.Name = "btnTransportImportPaid";
            this.btnTransportImportPaid.Size = new System.Drawing.Size(165, 52);
            this.btnTransportImportPaid.TabIndex = 5;
            this.btnTransportImportPaid.Text = "Paid";
            this.btnTransportImportPaid.UseVisualStyleBackColor = false;
            this.btnTransportImportPaid.Click += new System.EventHandler(this.btnTransportImportPaid_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dateTimePickerTo);
            this.panel2.Controls.Add(this.dateTimePickerFrom);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbltxtImportPaymentDate);
            this.panel2.Controls.Add(this.lbltxtImportPaymentTo);
            this.panel2.Controls.Add(this.txtPaymentTo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimePickerTransportDate);
            this.panel2.Controls.Add(this.lbltxtImportAmount);
            this.panel2.Controls.Add(this.lbltxtImportPaidAmount);
            this.panel2.Controls.Add(this.txtTransportImportAmount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTransportImportPaidAmount);
            this.panel2.Controls.Add(this.btnTransportImportPaid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 606);
            this.panel2.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Indigo;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSearch.Location = new System.Drawing.Point(50, 567);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 35);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(12, 539);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(205, 26);
            this.dateTimePickerTo.TabIndex = 18;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 492);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(205, 26);
            this.dateTimePickerFrom.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(10, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(8, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Search By Date";
            // 
            // lbltxtImportPaymentDate
            // 
            this.lbltxtImportPaymentDate.AutoSize = true;
            this.lbltxtImportPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtImportPaymentDate.ForeColor = System.Drawing.Color.PowderBlue;
            this.lbltxtImportPaymentDate.Location = new System.Drawing.Point(12, 379);
            this.lbltxtImportPaymentDate.Name = "lbltxtImportPaymentDate";
            this.lbltxtImportPaymentDate.Size = new System.Drawing.Size(0, 17);
            this.lbltxtImportPaymentDate.TabIndex = 13;
            // 
            // lbltxtImportPaymentTo
            // 
            this.lbltxtImportPaymentTo.AutoSize = true;
            this.lbltxtImportPaymentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtImportPaymentTo.ForeColor = System.Drawing.Color.PowderBlue;
            this.lbltxtImportPaymentTo.Location = new System.Drawing.Point(12, 310);
            this.lbltxtImportPaymentTo.Name = "lbltxtImportPaymentTo";
            this.lbltxtImportPaymentTo.Size = new System.Drawing.Size(0, 17);
            this.lbltxtImportPaymentTo.TabIndex = 12;
            // 
            // txtPaymentTo
            // 
            this.txtPaymentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentTo.Location = new System.Drawing.Point(12, 284);
            this.txtPaymentTo.Multiline = true;
            this.txtPaymentTo.Name = "txtPaymentTo";
            this.txtPaymentTo.Size = new System.Drawing.Size(205, 24);
            this.txtPaymentTo.TabIndex = 3;
            this.txtPaymentTo.TextChanged += new System.EventHandler(this.txtPaymentTo_TextChanged);
            this.txtPaymentTo.Leave += new System.EventHandler(this.txtPaymentTo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(15, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payment To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Transport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(15, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transport Date";
            // 
            // dateTimePickerTransportDate
            // 
            this.dateTimePickerTransportDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransportDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerTransportDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTransportDate.Location = new System.Drawing.Point(12, 352);
            this.dateTimePickerTransportDate.Name = "dateTimePickerTransportDate";
            this.dateTimePickerTransportDate.Size = new System.Drawing.Size(205, 26);
            this.dateTimePickerTransportDate.TabIndex = 4;
            this.dateTimePickerTransportDate.ValueChanged += new System.EventHandler(this.dateTimePickerTransportDate_ValueChanged);
            this.dateTimePickerTransportDate.Leave += new System.EventHandler(this.dateTimePickerTransportDate_Leave);
            // 
            // lbltxtImportAmount
            // 
            this.lbltxtImportAmount.AutoSize = true;
            this.lbltxtImportAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtImportAmount.ForeColor = System.Drawing.Color.PowderBlue;
            this.lbltxtImportAmount.Location = new System.Drawing.Point(12, 174);
            this.lbltxtImportAmount.Name = "lbltxtImportAmount";
            this.lbltxtImportAmount.Size = new System.Drawing.Size(0, 17);
            this.lbltxtImportAmount.TabIndex = 6;
            // 
            // lbltxtImportPaidAmount
            // 
            this.lbltxtImportPaidAmount.AutoSize = true;
            this.lbltxtImportPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtImportPaidAmount.ForeColor = System.Drawing.Color.PowderBlue;
            this.lbltxtImportPaidAmount.Location = new System.Drawing.Point(9, 239);
            this.lbltxtImportPaidAmount.Name = "lbltxtImportPaidAmount";
            this.lbltxtImportPaidAmount.Size = new System.Drawing.Size(0, 17);
            this.lbltxtImportPaidAmount.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlTransportDueAmountPaid);
            this.panel3.Controls.Add(this.dataGridViewTransportImportPaidAmount);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1125, 606);
            this.panel3.TabIndex = 8;
            // 
            // pnlTransportDueAmountPaid
            // 
            this.pnlTransportDueAmountPaid.Controls.Add(this.lblTransportPaymentToShow);
            this.pnlTransportDueAmountPaid.Controls.Add(this.label11);
            this.pnlTransportDueAmountPaid.Controls.Add(this.btnDueAmountPaid);
            this.pnlTransportDueAmountPaid.Controls.Add(this.txtPaidAmount);
            this.pnlTransportDueAmountPaid.Controls.Add(this.label8);
            this.pnlTransportDueAmountPaid.Controls.Add(this.lblTransportDueAmountShow);
            this.pnlTransportDueAmountPaid.Controls.Add(this.label9);
            this.pnlTransportDueAmountPaid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTransportDueAmountPaid.Location = new System.Drawing.Point(233, 506);
            this.pnlTransportDueAmountPaid.Name = "pnlTransportDueAmountPaid";
            this.pnlTransportDueAmountPaid.Size = new System.Drawing.Size(892, 100);
            this.pnlTransportDueAmountPaid.TabIndex = 8;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Paid Amount";
            // 
            // lblTransportDueAmountShow
            // 
            this.lblTransportDueAmountShow.AutoSize = true;
            this.lblTransportDueAmountShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportDueAmountShow.Location = new System.Drawing.Point(134, 53);
            this.lblTransportDueAmountShow.Name = "lblTransportDueAmountShow";
            this.lblTransportDueAmountShow.Size = new System.Drawing.Size(88, 26);
            this.lblTransportDueAmountShow.TabIndex = 6;
            this.lblTransportDueAmountShow.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Due Amount  :";
            // 
            // dataGridViewTransportImportPaidAmount
            // 
            this.dataGridViewTransportImportPaidAmount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransportImportPaidAmount.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridViewTransportImportPaidAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransportImportPaidAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransportImportPaidAmount.Location = new System.Drawing.Point(233, 0);
            this.dataGridViewTransportImportPaidAmount.Name = "dataGridViewTransportImportPaidAmount";
            this.dataGridViewTransportImportPaidAmount.RowHeadersVisible = false;
            this.dataGridViewTransportImportPaidAmount.RowTemplate.Height = 30;
            this.dataGridViewTransportImportPaidAmount.Size = new System.Drawing.Size(892, 606);
            this.dataGridViewTransportImportPaidAmount.TabIndex = 0;
            this.dataGridViewTransportImportPaidAmount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransportImportPaidAmount_CellContentClick);
            // 
            // lblTransportPaymentToShow
            // 
            this.lblTransportPaymentToShow.AutoSize = true;
            this.lblTransportPaymentToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportPaymentToShow.Location = new System.Drawing.Point(136, 18);
            this.lblTransportPaymentToShow.Name = "lblTransportPaymentToShow";
            this.lblTransportPaymentToShow.Size = new System.Drawing.Size(52, 26);
            this.lblTransportPaymentToShow.TabIndex = 14;
            this.lblTransportPaymentToShow.Text = "Due";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Payment To  :";
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 606);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transport";
            this.ShowIcon = false;
            this.Text = "Transport";
            this.Load += new System.EventHandler(this.Transport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlTransportDueAmountPaid.ResumeLayout(false);
            this.pnlTransportDueAmountPaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransportImportPaidAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransportImportAmount;
        private System.Windows.Forms.TextBox txtTransportImportPaidAmount;
        private System.Windows.Forms.Button btnTransportImportPaid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewTransportImportPaidAmount;
        private System.Windows.Forms.Label lbltxtImportAmount;
        private System.Windows.Forms.Label lbltxtImportPaidAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransportDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltxtImportPaymentDate;
        private System.Windows.Forms.Label lbltxtImportPaymentTo;
        private System.Windows.Forms.TextBox txtPaymentTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlTransportDueAmountPaid;
        private System.Windows.Forms.Button btnDueAmountPaid;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTransportDueAmountShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTransportPaymentToShow;
        private System.Windows.Forms.Label label11;
    }
}