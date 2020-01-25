namespace ListProducts
{
    partial class ProductsListViewDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsListViewDisplay));
            this.productsList = new System.Windows.Forms.ListView();
            this.ProductIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductBarcodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductSuplierColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductAddedAtColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.productDescription = new System.Windows.Forms.Label();
            this.productDescriptionText = new System.Windows.Forms.TextBox();
            this.productBarcodeText = new System.Windows.Forms.TextBox();
            this.productBarcode = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.productSupplierText = new System.Windows.Forms.TextBox();
            this.productSupplier = new System.Windows.Forms.Label();
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.buttonReloadProducts = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsList
            // 
            this.productsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductDescriptionColumn,
            this.ProductBarcodeColumn,
            this.ProductSuplierColumn,
            this.ProductAddedAtColumn});
            this.productsList.FullRowSelect = true;
            this.productsList.HideSelection = false;
            this.productsList.Location = new System.Drawing.Point(3, 118);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(707, 380);
            this.productsList.TabIndex = 0;
            this.productsList.UseCompatibleStateImageBehavior = false;
            this.productsList.View = System.Windows.Forms.View.Details;
            this.productsList.SelectedIndexChanged += new System.EventHandler(this.ProductsList_SelectedIndexChanged);
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.Text = "ID";
            this.ProductIDColumn.Width = 40;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.Text = "Name";
            this.ProductNameColumn.Width = 107;
            // 
            // ProductDescriptionColumn
            // 
            this.ProductDescriptionColumn.Text = "Description";
            this.ProductDescriptionColumn.Width = 166;
            // 
            // ProductBarcodeColumn
            // 
            this.ProductBarcodeColumn.Text = "Barcode";
            this.ProductBarcodeColumn.Width = 118;
            // 
            // ProductSuplierColumn
            // 
            this.ProductSuplierColumn.Text = "Suplier";
            this.ProductSuplierColumn.Width = 71;
            // 
            // ProductAddedAtColumn
            // 
            this.ProductAddedAtColumn.Text = "Product added at";
            this.ProductAddedAtColumn.Width = 195;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 27);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // productName
            // 
            this.productName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productName.Location = new System.Drawing.Point(44, 6);
            this.productName.Margin = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(76, 13);
            this.productName.TabIndex = 8;
            this.productName.Text = "Product name:";
            // 
            // productNameText
            // 
            this.productNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNameText.Location = new System.Drawing.Point(123, 3);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(460, 20);
            this.productNameText.TabIndex = 1;
            // 
            // productDescription
            // 
            this.productDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productDescription.Location = new System.Drawing.Point(19, 32);
            this.productDescription.Margin = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(101, 13);
            this.productDescription.TabIndex = 9;
            this.productDescription.Text = "Product description:";
            // 
            // productDescriptionText
            // 
            this.productDescriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDescriptionText.Location = new System.Drawing.Point(123, 29);
            this.productDescriptionText.Name = "productDescriptionText";
            this.productDescriptionText.Size = new System.Drawing.Size(460, 20);
            this.productDescriptionText.TabIndex = 2;
            // 
            // productBarcodeText
            // 
            this.productBarcodeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productBarcodeText.Location = new System.Drawing.Point(123, 55);
            this.productBarcodeText.Name = "productBarcodeText";
            this.productBarcodeText.Size = new System.Drawing.Size(460, 20);
            this.productBarcodeText.TabIndex = 3;
            // 
            // productBarcode
            // 
            this.productBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productBarcode.Location = new System.Drawing.Point(30, 58);
            this.productBarcode.Margin = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.productBarcode.Name = "productBarcode";
            this.productBarcode.Size = new System.Drawing.Size(90, 13);
            this.productBarcode.TabIndex = 10;
            this.productBarcode.Text = "Product Barcode:";
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(3, 36);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 27);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 14);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 11;
            // 
            // productSupplierText
            // 
            this.productSupplierText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productSupplierText.Location = new System.Drawing.Point(123, 81);
            this.productSupplierText.Name = "productSupplierText";
            this.productSupplierText.Size = new System.Drawing.Size(460, 20);
            this.productSupplierText.TabIndex = 4;
            // 
            // productSupplier
            // 
            this.productSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productSupplier.Location = new System.Drawing.Point(34, 84);
            this.productSupplier.Margin = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.productSupplier.Name = "productSupplier";
            this.productSupplier.Size = new System.Drawing.Size(86, 13);
            this.productSupplier.TabIndex = 12;
            this.productSupplier.Text = "Product supplier:";
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewProductButton.Location = new System.Drawing.Point(3, 69);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(103, 29);
            this.AddNewProductButton.TabIndex = 7;
            this.AddNewProductButton.Text = "Add new product";
            this.AddNewProductButton.UseVisualStyleBackColor = true;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // buttonReloadProducts
            // 
            this.buttonReloadProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReloadProducts.Location = new System.Drawing.Point(590, 3);
            this.buttonReloadProducts.Name = "buttonReloadProducts";
            this.buttonReloadProducts.Size = new System.Drawing.Size(114, 35);
            this.buttonReloadProducts.TabIndex = 13;
            this.buttonReloadProducts.Text = "Reload products";
            this.buttonReloadProducts.UseVisualStyleBackColor = true;
            this.buttonReloadProducts.Click += new System.EventHandler(this.ButtonReloadProducts_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.productsList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 548);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.Controls.Add(this.buttonReloadProducts, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.statusLabel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 504);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(707, 41);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.78577F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21423F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(707, 109);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.productNameText, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.productName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.productSupplierText, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.productSupplier, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.productBarcodeText, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.productDescription, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.productDescriptionText, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.productBarcode, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(586, 103);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.saveButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.AddNewProductButton, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.deleteButton, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(595, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(109, 101);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // ProductsListViewDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsListViewDisplay";
            this.Text = "Product manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView productsList;
        private System.Windows.Forms.ColumnHeader ProductIDColumn;
        private System.Windows.Forms.ColumnHeader ProductNameColumn;
        private System.Windows.Forms.ColumnHeader ProductDescriptionColumn;
        private System.Windows.Forms.ColumnHeader ProductBarcodeColumn;
        private System.Windows.Forms.ColumnHeader ProductSuplierColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label productDescription;
        private System.Windows.Forms.TextBox productDescriptionText;
        private System.Windows.Forms.TextBox productSupplierText;
        private System.Windows.Forms.TextBox productBarcodeText;
        private System.Windows.Forms.Label productBarcode;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label productSupplier;
        private System.Windows.Forms.ColumnHeader ProductAddedAtColumn;
        private System.Windows.Forms.Button AddNewProductButton;
        private System.Windows.Forms.Button buttonReloadProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

