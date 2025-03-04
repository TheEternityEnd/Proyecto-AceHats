namespace Proyecto_AceHats.Forms.RegularForms.subForms
{
    partial class formAddGoods
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnAddBC = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtWholesalePrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(154, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(155, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(154, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(412, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(154, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio de menudeo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(155, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio de mayoreo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(155, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(413, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Imagen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(157, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(457, 15);
            this.txtName.TabIndex = 10;
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarCode.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtBarCode.Location = new System.Drawing.Point(159, 467);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(200, 15);
            this.txtBarCode.TabIndex = 12;
            // 
            // btnAddBC
            // 
            this.btnAddBC.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBC.Location = new System.Drawing.Point(158, 495);
            this.btnAddBC.Name = "btnAddBC";
            this.btnAddBC.Size = new System.Drawing.Size(200, 23);
            this.btnAddBC.TabIndex = 13;
            this.btnAddBC.Text = "Agregar codigo de barras";
            this.btnAddBC.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Roboto", 9F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "xd",
            "xd1",
            "xd2",
            "xd3",
            "xd4",
            "xd5",
            "xd6",
            "xd7",
            "xd8"});
            this.cbCategory.Location = new System.Drawing.Point(158, 221);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 22);
            this.cbCategory.TabIndex = 14;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuyPrice.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtBuyPrice.Location = new System.Drawing.Point(416, 222);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(200, 15);
            this.txtBuyPrice.TabIndex = 15;
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetailPrice.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtRetailPrice.Location = new System.Drawing.Point(158, 348);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(200, 15);
            this.txtRetailPrice.TabIndex = 16;
            // 
            // txtWholesalePrice
            // 
            this.txtWholesalePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWholesalePrice.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtWholesalePrice.Location = new System.Drawing.Point(158, 289);
            this.txtWholesalePrice.Name = "txtWholesalePrice";
            this.txtWholesalePrice.Size = new System.Drawing.Size(200, 15);
            this.txtWholesalePrice.TabIndex = 17;
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtStock.Location = new System.Drawing.Point(158, 408);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(200, 15);
            this.txtStock.TabIndex = 18;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(416, 289);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 19;
            this.pbImage.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(416, 495);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(200, 23);
            this.btnImage.TabIndex = 20;
            this.btnImage.Text = "Buscar Imagen";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(578, 562);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 51);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Location = new System.Drawing.Point(158, 122);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(456, 64);
            this.txtDesc.TabIndex = 22;
            this.txtDesc.Text = "";
            // 
            // formAddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 669);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtWholesalePrice);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnAddBC);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAddGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fromAddGoods";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnAddBC;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtWholesalePrice;
        private System.Windows.Forms.TextBox txtStock;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtDesc;
    }
}