namespace Proyecto_AceHats.Forms
{
    partial class AceHats
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblInv = new System.Windows.Forms.Label();
            this.lblPriceG = new System.Windows.Forms.Label();
            this.lblAside = new System.Windows.Forms.Label();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblSaleReview = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Location = new System.Drawing.Point(264, 41);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(807, 669);
            this.panelMain.TabIndex = 0;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.Gray;
            this.lblDashboard.Location = new System.Drawing.Point(37, 257);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(110, 23);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.MouseEnter += new System.EventHandler(this.lblDashboard_MouseEnter);
            this.lblDashboard.MouseLeave += new System.EventHandler(this.lblDashboard_MouseLeave);
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.BackColor = System.Drawing.Color.Transparent;
            this.lblInv.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInv.ForeColor = System.Drawing.Color.Gray;
            this.lblInv.Location = new System.Drawing.Point(37, 317);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(102, 23);
            this.lblInv.TabIndex = 2;
            this.lblInv.Text = "Inventario";
            this.lblInv.Click += new System.EventHandler(this.lblInv_Click);
            this.lblInv.MouseEnter += new System.EventHandler(this.lblInv_MouseEnter);
            this.lblInv.MouseLeave += new System.EventHandler(this.lblInv_MouseLeave);
            // 
            // lblPriceG
            // 
            this.lblPriceG.AutoSize = true;
            this.lblPriceG.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceG.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceG.ForeColor = System.Drawing.Color.Gray;
            this.lblPriceG.Location = new System.Drawing.Point(37, 377);
            this.lblPriceG.Name = "lblPriceG";
            this.lblPriceG.Size = new System.Drawing.Size(178, 23);
            this.lblPriceG.TabIndex = 3;
            this.lblPriceG.Text = "Gestor de Precios";
            this.lblPriceG.Click += new System.EventHandler(this.lblPriceG_Click);
            this.lblPriceG.MouseEnter += new System.EventHandler(this.lblPriceG_MouseEnter);
            this.lblPriceG.MouseLeave += new System.EventHandler(this.lblPriceG_MouseLeave);
            // 
            // lblAside
            // 
            this.lblAside.AutoSize = true;
            this.lblAside.BackColor = System.Drawing.Color.Transparent;
            this.lblAside.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAside.ForeColor = System.Drawing.Color.Gray;
            this.lblAside.Location = new System.Drawing.Point(37, 437);
            this.lblAside.Name = "lblAside";
            this.lblAside.Size = new System.Drawing.Size(106, 23);
            this.lblAside.TabIndex = 4;
            this.lblAside.Text = "Apartados";
            this.lblAside.Click += new System.EventHandler(this.lblAside_Click);
            this.lblAside.MouseEnter += new System.EventHandler(this.lblAside_MouseEnter);
            this.lblAside.MouseLeave += new System.EventHandler(this.lblAside_MouseLeave);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.BackColor = System.Drawing.Color.Transparent;
            this.lblPayments.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayments.ForeColor = System.Drawing.Color.Gray;
            this.lblPayments.Location = new System.Drawing.Point(37, 497);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(69, 23);
            this.lblPayments.TabIndex = 5;
            this.lblPayments.Text = "Pagos";
            this.lblPayments.Click += new System.EventHandler(this.lblPayments_Click);
            this.lblPayments.MouseEnter += new System.EventHandler(this.lblPayments_MouseEnter);
            this.lblPayments.MouseLeave += new System.EventHandler(this.lblPayments_MouseLeave);
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.BackColor = System.Drawing.Color.Transparent;
            this.lblShipping.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.ForeColor = System.Drawing.Color.Gray;
            this.lblShipping.Location = new System.Drawing.Point(37, 557);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(72, 23);
            this.lblShipping.TabIndex = 6;
            this.lblShipping.Text = "Envios";
            this.lblShipping.Click += new System.EventHandler(this.lblShipping_Click);
            this.lblShipping.MouseEnter += new System.EventHandler(this.lblShipping_MouseEnter);
            this.lblShipping.MouseLeave += new System.EventHandler(this.lblShipping_MouseLeave);
            // 
            // lblSaleReview
            // 
            this.lblSaleReview.AutoSize = true;
            this.lblSaleReview.BackColor = System.Drawing.Color.Transparent;
            this.lblSaleReview.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleReview.ForeColor = System.Drawing.Color.Gray;
            this.lblSaleReview.Location = new System.Drawing.Point(37, 617);
            this.lblSaleReview.Name = "lblSaleReview";
            this.lblSaleReview.Size = new System.Drawing.Size(184, 23);
            this.lblSaleReview.TabIndex = 7;
            this.lblSaleReview.Text = "Analisis de Ventas";
            this.lblSaleReview.Click += new System.EventHandler(this.lblSaleReview_Click);
            this.lblSaleReview.MouseEnter += new System.EventHandler(this.lblSaleReview_MouseEnter);
            this.lblSaleReview.MouseLeave += new System.EventHandler(this.lblSaleReview_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(1048, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Location = new System.Drawing.Point(1025, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(38, 148);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 19);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "label1";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Gray;
            this.lblUser.Location = new System.Drawing.Point(39, 176);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 15);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "label1";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Gray;
            this.lblAdmin.Location = new System.Drawing.Point(12, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(99, 15);
            this.lblAdmin.TabIndex = 13;
            this.lblAdmin.Text = "Administrador";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            this.lblAdmin.MouseEnter += new System.EventHandler(this.lblAdmin_MouseEnter);
            this.lblAdmin.MouseLeave += new System.EventHandler(this.lblAdmin_MouseLeave);
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::Proyecto_AceHats.Properties.Resources.userPH;
            this.pbProfile.Location = new System.Drawing.Point(41, 41);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(99, 92);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 10;
            this.pbProfile.TabStop = false;
            // 
            // AceHats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1083, 722);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSaleReview);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.lblAside);
            this.Controls.Add(this.lblPriceG);
            this.Controls.Add(this.lblInv);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.panelMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AceHats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AceHats";
            this.Load += new System.EventHandler(this.AceHats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblInv;
        private System.Windows.Forms.Label lblPriceG;
        private System.Windows.Forms.Label lblAside;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblSaleReview;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAdmin;
    }
}