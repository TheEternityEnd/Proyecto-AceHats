namespace Proyecto_AceHats.Forms.AdminForms
{
    partial class userVerification
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
            this.dgvVerification = new System.Windows.Forms.DataGridView();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerification
            // 
            this.dgvVerification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerification.Location = new System.Drawing.Point(34, 34);
            this.dgvVerification.Name = "dgvVerification";
            this.dgvVerification.Size = new System.Drawing.Size(738, 275);
            this.dgvVerification.TabIndex = 0;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(34, 338);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(738, 295);
            this.dgvEmployees.TabIndex = 1;
            // 
            // userVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 669);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.dgvVerification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userVerification";
            this.Text = "userVerification";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerification;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}