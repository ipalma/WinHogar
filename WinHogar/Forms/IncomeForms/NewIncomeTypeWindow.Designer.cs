namespace WinHogar.Forms.IncomeForms
{
    partial class NewIncomeTypeWindow
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
            this.lblIncomeTypeDescription = new System.Windows.Forms.Label();
            this.btnRegisterIncomeType = new System.Windows.Forms.Button();
            this.txtIncomeTypeDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIncomeTypeDescription
            // 
            this.lblIncomeTypeDescription.AutoSize = true;
            this.lblIncomeTypeDescription.Location = new System.Drawing.Point(31, 47);
            this.lblIncomeTypeDescription.Name = "lblIncomeTypeDescription";
            this.lblIncomeTypeDescription.Size = new System.Drawing.Size(134, 17);
            this.lblIncomeTypeDescription.TabIndex = 0;
            this.lblIncomeTypeDescription.Text = "Income Type Name:";
            // 
            // btnRegisterIncomeType
            // 
            this.btnRegisterIncomeType.Location = new System.Drawing.Point(108, 222);
            this.btnRegisterIncomeType.Name = "btnRegisterIncomeType";
            this.btnRegisterIncomeType.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterIncomeType.TabIndex = 1;
            this.btnRegisterIncomeType.Text = "Accept";
            this.btnRegisterIncomeType.UseVisualStyleBackColor = true;
            this.btnRegisterIncomeType.Click += new System.EventHandler(this.btnRegisterIncomeType_Click);
            // 
            // txtIncomeTypeDescription
            // 
            this.txtIncomeTypeDescription.Location = new System.Drawing.Point(219, 44);
            this.txtIncomeTypeDescription.Name = "txtIncomeTypeDescription";
            this.txtIncomeTypeDescription.Size = new System.Drawing.Size(100, 22);
            this.txtIncomeTypeDescription.TabIndex = 2;
            // 
            // NewIncomeTypeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIncomeTypeDescription);
            this.Controls.Add(this.btnRegisterIncomeType);
            this.Controls.Add(this.lblIncomeTypeDescription);
            this.Name = "NewIncomeTypeWindow";
            this.Text = "NewIncomeTypeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncomeTypeDescription;
        private System.Windows.Forms.Button btnRegisterIncomeType;
        private System.Windows.Forms.TextBox txtIncomeTypeDescription;
    }
}