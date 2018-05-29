namespace WinHogar.Forms.IncomeForms
{
    partial class NewIncomeWindow
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
            this.lblIncomeAmount = new System.Windows.Forms.Label();
            this.lblIncomeMonth = new System.Windows.Forms.Label();
            this.lblIncomeType = new System.Windows.Forms.Label();
            this.lblIncomeDate = new System.Windows.Forms.Label();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarIncome = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbMonths = new System.Windows.Forms.ComboBox();
            this.cbIncomeType = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIncomeAmount
            // 
            this.lblIncomeAmount.AutoSize = true;
            this.lblIncomeAmount.Location = new System.Drawing.Point(31, 46);
            this.lblIncomeAmount.Name = "lblIncomeAmount";
            this.lblIncomeAmount.Size = new System.Drawing.Size(109, 17);
            this.lblIncomeAmount.TabIndex = 0;
            this.lblIncomeAmount.Text = "Income Amount:";
            // 
            // lblIncomeMonth
            // 
            this.lblIncomeMonth.AutoSize = true;
            this.lblIncomeMonth.Location = new System.Drawing.Point(44, 108);
            this.lblIncomeMonth.Name = "lblIncomeMonth";
            this.lblIncomeMonth.Size = new System.Drawing.Size(100, 17);
            this.lblIncomeMonth.TabIndex = 2;
            this.lblIncomeMonth.Text = "Income Month:";
            // 
            // lblIncomeType
            // 
            this.lblIncomeType.AutoSize = true;
            this.lblIncomeType.Location = new System.Drawing.Point(410, 104);
            this.lblIncomeType.Name = "lblIncomeType";
            this.lblIncomeType.Size = new System.Drawing.Size(89, 17);
            this.lblIncomeType.TabIndex = 3;
            this.lblIncomeType.Text = "Income Type";
            // 
            // lblIncomeDate
            // 
            this.lblIncomeDate.AutoSize = true;
            this.lblIncomeDate.Location = new System.Drawing.Point(408, 46);
            this.lblIncomeDate.Name = "lblIncomeDate";
            this.lblIncomeDate.Size = new System.Drawing.Size(91, 17);
            this.lblIncomeDate.TabIndex = 5;
            this.lblIncomeDate.Text = "Income Date:";
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(186, 43);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(100, 22);
            this.txtIncomeAmount.TabIndex = 6;
            this.txtIncomeAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtIncomeAmount_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(502, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnGuardarIncome
            // 
            this.btnGuardarIncome.Location = new System.Drawing.Point(81, 315);
            this.btnGuardarIncome.Name = "btnGuardarIncome";
            this.btnGuardarIncome.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarIncome.TabIndex = 12;
            this.btnGuardarIncome.Text = "Guardar";
            this.btnGuardarIncome.UseVisualStyleBackColor = true;
            this.btnGuardarIncome.Click += new System.EventHandler(this.btnGuardarIncome_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(411, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbMonths
            // 
            this.cbMonths.FormattingEnabled = true;
            this.cbMonths.Location = new System.Drawing.Point(186, 101);
            this.cbMonths.Name = "cbMonths";
            this.cbMonths.Size = new System.Drawing.Size(181, 24);
            this.cbMonths.TabIndex = 15;
            // 
            // cbIncomeType
            // 
            this.cbIncomeType.FormattingEnabled = true;
            this.cbIncomeType.Location = new System.Drawing.Point(505, 101);
            this.cbIncomeType.Name = "cbIncomeType";
            this.cbIncomeType.Size = new System.Drawing.Size(197, 24);
            this.cbIncomeType.TabIndex = 16;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(47, 180);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 17);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "Usuario";
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(146, 171);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(206, 24);
            this.cbUsers.TabIndex = 18;
            // 
            // NewIncomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbIncomeType);
            this.Controls.Add(this.cbMonths);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardarIncome);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtIncomeAmount);
            this.Controls.Add(this.lblIncomeDate);
            this.Controls.Add(this.lblIncomeType);
            this.Controls.Add(this.lblIncomeMonth);
            this.Controls.Add(this.lblIncomeAmount);
            this.Name = "NewIncomeWindow";
            this.Text = "NewIncomeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncomeAmount;
        private System.Windows.Forms.Label lblIncomeMonth;
        private System.Windows.Forms.Label lblIncomeType;
        private System.Windows.Forms.Label lblIncomeDate;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGuardarIncome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbMonths;
        private System.Windows.Forms.ComboBox cbIncomeType;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cbUsers;
    }
}