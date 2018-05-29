namespace WinHogar.Forms.TotalAmountsForms
{
    partial class AmountsWindow
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
            this.dgvAmounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAmounts
            // 
            this.dgvAmounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmounts.Location = new System.Drawing.Point(12, 345);
            this.dgvAmounts.Name = "dgvAmounts";
            this.dgvAmounts.RowTemplate.Height = 24;
            this.dgvAmounts.Size = new System.Drawing.Size(938, 254);
            this.dgvAmounts.TabIndex = 0;
            // 
            // AmountsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 611);
            this.Controls.Add(this.dgvAmounts);
            this.Name = "AmountsWindow";
            this.Text = "AmountsWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAmounts;
    }
}