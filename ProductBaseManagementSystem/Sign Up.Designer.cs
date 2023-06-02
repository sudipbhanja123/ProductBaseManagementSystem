namespace ProductBaseManagementSystem
{
    partial class Sign_Up
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdminPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAdminNickName = new System.Windows.Forms.TextBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminConfirmPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewShowDetails = new System.Windows.Forms.DataGridView();
            this.lbltxtAdminName = new System.Windows.Forms.Label();
            this.lbltxtAdminNickName = new System.Windows.Forms.Label();
            this.lbltxtAdminPhoneNo = new System.Windows.Forms.Label();
            this.lbltxtAdminPassword = new System.Windows.Forms.Label();
            this.lbltxtAdminConfirmPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtAdminName
            // 
            this.txtAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminName.Location = new System.Drawing.Point(7, 108);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(255, 30);
            this.txtAdminName.TabIndex = 1;
            this.txtAdminName.Leave += new System.EventHandler(this.txtAdminName_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(877, 206);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 59);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(708, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nick Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1126, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 58);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sign Up";
            // 
            // txtAdminPhoneNo
            // 
            this.txtAdminPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPhoneNo.Location = new System.Drawing.Point(714, 110);
            this.txtAdminPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminPhoneNo.MaxLength = 10;
            this.txtAdminPhoneNo.Name = "txtAdminPhoneNo";
            this.txtAdminPhoneNo.Size = new System.Drawing.Size(255, 30);
            this.txtAdminPhoneNo.TabIndex = 4;
            this.txtAdminPhoneNo.Leave += new System.EventHandler(this.txtAdminPhoneNo_Leave);
            // 
            // txtAdminNickName
            // 
            this.txtAdminNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminNickName.Location = new System.Drawing.Point(362, 110);
            this.txtAdminNickName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminNickName.Name = "txtAdminNickName";
            this.txtAdminNickName.Size = new System.Drawing.Size(255, 30);
            this.txtAdminNickName.TabIndex = 3;
            this.txtAdminNickName.Leave += new System.EventHandler(this.txtAdminNickName_Leave);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassword.Location = new System.Drawing.Point(1132, 110);
            this.txtAdminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(255, 30);
            this.txtAdminPassword.TabIndex = 5;
            this.txtAdminPassword.Leave += new System.EventHandler(this.txtAdminPassword_Leave);
            // 
            // txtAdminConfirmPassword
            // 
            this.txtAdminConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminConfirmPassword.Location = new System.Drawing.Point(23, 241);
            this.txtAdminConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminConfirmPassword.Name = "txtAdminConfirmPassword";
            this.txtAdminConfirmPassword.Size = new System.Drawing.Size(255, 30);
            this.txtAdminConfirmPassword.TabIndex = 6;
            this.txtAdminConfirmPassword.Leave += new System.EventHandler(this.txtAdminConfirmPassword_Leave);
            // 
            // dataGridViewShowDetails
            // 
            this.dataGridViewShowDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShowDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewShowDetails.Location = new System.Drawing.Point(0, 318);
            this.dataGridViewShowDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewShowDetails.Name = "dataGridViewShowDetails";
            this.dataGridViewShowDetails.RowHeadersVisible = false;
            this.dataGridViewShowDetails.Size = new System.Drawing.Size(1500, 428);
            this.dataGridViewShowDetails.TabIndex = 18;
            this.dataGridViewShowDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowDetails_CellContentClick);
            // 
            // lbltxtAdminName
            // 
            this.lbltxtAdminName.AutoSize = true;
            this.lbltxtAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtAdminName.Location = new System.Drawing.Point(3, 144);
            this.lbltxtAdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtAdminName.Name = "lbltxtAdminName";
            this.lbltxtAdminName.Size = new System.Drawing.Size(0, 20);
            this.lbltxtAdminName.TabIndex = 19;
            // 
            // lbltxtAdminNickName
            // 
            this.lbltxtAdminNickName.AutoSize = true;
            this.lbltxtAdminNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtAdminNickName.Location = new System.Drawing.Point(358, 156);
            this.lbltxtAdminNickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtAdminNickName.Name = "lbltxtAdminNickName";
            this.lbltxtAdminNickName.Size = new System.Drawing.Size(39, 20);
            this.lbltxtAdminNickName.TabIndex = 21;
            this.lbltxtAdminNickName.Text = "nick";
            // 
            // lbltxtAdminPhoneNo
            // 
            this.lbltxtAdminPhoneNo.AutoSize = true;
            this.lbltxtAdminPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtAdminPhoneNo.Location = new System.Drawing.Point(710, 156);
            this.lbltxtAdminPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtAdminPhoneNo.Name = "lbltxtAdminPhoneNo";
            this.lbltxtAdminPhoneNo.Size = new System.Drawing.Size(54, 20);
            this.lbltxtAdminPhoneNo.TabIndex = 22;
            this.lbltxtAdminPhoneNo.Text = "phone";
            // 
            // lbltxtAdminPassword
            // 
            this.lbltxtAdminPassword.AutoSize = true;
            this.lbltxtAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtAdminPassword.Location = new System.Drawing.Point(1128, 156);
            this.lbltxtAdminPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtAdminPassword.Name = "lbltxtAdminPassword";
            this.lbltxtAdminPassword.Size = new System.Drawing.Size(81, 20);
            this.lbltxtAdminPassword.TabIndex = 23;
            this.lbltxtAdminPassword.Text = "password";
            // 
            // lbltxtAdminConfirmPassword
            // 
            this.lbltxtAdminConfirmPassword.AutoSize = true;
            this.lbltxtAdminConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtAdminConfirmPassword.Location = new System.Drawing.Point(30, 285);
            this.lbltxtAdminConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtAdminConfirmPassword.Name = "lbltxtAdminConfirmPassword";
            this.lbltxtAdminConfirmPassword.Size = new System.Drawing.Size(0, 20);
            this.lbltxtAdminConfirmPassword.TabIndex = 24;
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 746);
            this.Controls.Add(this.lbltxtAdminConfirmPassword);
            this.Controls.Add(this.lbltxtAdminPassword);
            this.Controls.Add(this.lbltxtAdminPhoneNo);
            this.Controls.Add(this.lbltxtAdminNickName);
            this.Controls.Add(this.lbltxtAdminName);
            this.Controls.Add(this.dataGridViewShowDetails);
            this.Controls.Add(this.txtAdminConfirmPassword);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminNickName);
            this.Controls.Add(this.txtAdminPhoneNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sign_Up";
            this.Text = "Sign_Up";
            this.Load += new System.EventHandler(this.Sign_Up_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdminPhoneNo;
        private System.Windows.Forms.TextBox txtAdminNickName;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminConfirmPassword;
        private System.Windows.Forms.DataGridView dataGridViewShowDetails;
        private System.Windows.Forms.Label lbltxtAdminName;
        private System.Windows.Forms.Label lbltxtAdminNickName;
        private System.Windows.Forms.Label lbltxtAdminPhoneNo;
        private System.Windows.Forms.Label lbltxtAdminPassword;
        private System.Windows.Forms.Label lbltxtAdminConfirmPassword;
    }
}