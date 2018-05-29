namespace WinHogar.Forms.IncomeForms
{
    partial class IncomeTypesWindow
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
            this.dgvIncomeTypes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncomeTypes
            // 
            this.dgvIncomeTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomeTypes.Location = new System.Drawing.Point(12, 76);
            this.dgvIncomeTypes.Name = "dgvIncomeTypes";
            this.dgvIncomeTypes.RowTemplate.Height = 24;
            this.dgvIncomeTypes.Size = new System.Drawing.Size(776, 362);
            this.dgvIncomeTypes.TabIndex = 0;
            // 
            // IncomeTypesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIncomeTypes);
            this.Name = "IncomeTypesWindow";
            this.Text = "IncomeTypesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncomeTypes;
    }
}