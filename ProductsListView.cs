using System;
using System.Windows.Forms;
using ProductSerializer;

namespace ListProducts
{
    public partial class ProductsListViewDisplay : Form {
        private readonly String Url = "http://localhost:57851/api/products";
        private bool UpdateProduct = false;
        private string SelectedID = null;

        public ProductsListViewDisplay() {
            InitializeComponent();
            GetAllProducts();
        }

        private string GetAllProducts()
        {
            string stringResult = null;
            try {
                var products = Product.FromJsonArray(new RESTClient(Url, MethodType.GET).MakeRequest());
                foreach (Product item in products) {
                    SetItemToListView(item);
                }
                statusLabel.Text = "Products successfully loaded.";
            } catch (Exception e) {
                statusLabel.Text = "Can't connect to server";
            }
            return stringResult;
        }

        private void SetItemToListView(Product product) {
            String[] row = {
                product.Id.ToString(),
                product.Name,
                product.Description,
                product.Barcode,
                product.Supplier,
                product.AddedAt.ToString("R"),
            };
            productsList.Items.Add(new ListViewItem(row));
        }

        private void ClearFields() {
            UpdateProduct = false;
            SelectedID = null;
            productNameText.Clear();
            productDescriptionText.Clear();
            productSupplierText.Clear();
            productBarcodeText.Clear();
            productNameText.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(productNameText.Text) 
                || string.IsNullOrEmpty(productDescriptionText.Text)
                || string.IsNullOrEmpty(productSupplierText.Text)
                || string.IsNullOrEmpty(productBarcodeText.Text)) {
                statusLabel.Text = "Povide all required data!";
                return;
            }
            Product productToSaveObject = new Product(SelectedID ,productNameText.Text, productDescriptionText.Text, DateTimeOffset.Now, productSupplierText.Text, productBarcodeText.Text);

            string ApiResponse = null;
            Product returnedProduct = null;
            if (!UpdateProduct)
            {
                ApiResponse = new RESTClient(Url, MethodType.POST, Serialize.ToJson(productToSaveObject)).MakeRequest();
                returnedProduct = Product.FromJson(ApiResponse);
                SetItemToListView(returnedProduct);
                statusLabel.Text = "Product " + returnedProduct.Name + " with ID: " + returnedProduct.Id + " was added.";
            } else
            {
                ApiResponse = new RESTClient(Url + "/" + productToSaveObject.Id, MethodType.PUT, Serialize.ToJson(productToSaveObject)).MakeRequest();
                returnedProduct = Product.FromJson(ApiResponse);
                productsList.BeginUpdate();
                for (int i = 0; i < productsList.Items.Count; i++) {
                    if (productsList.Items[i].Text.Equals(SelectedID))
                    {
                        String[] row = {
                            returnedProduct.Id.ToString(),
                            returnedProduct.Name,
                            returnedProduct.Description,
                            returnedProduct.Barcode,
                            returnedProduct.Supplier,
                            returnedProduct.AddedAt.ToString("R") };
                        productsList.Items[i] = new ListViewItem(row);
                        break;
                    }
                }
                productsList.EndUpdate();
                statusLabel.Text = "Product " + returnedProduct.Name + " with ID: " + returnedProduct.Id + " was updated.";
                ApiResponse = "OK";
            }
            if (ApiResponse != null) { ClearFields(); }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (productsList.Items.Count > 0) {
                if (productsList.SelectedItems.Count == 0)
                {
                    statusLabel.Text = "Select product you want to delete!";
                    return;
                }
                ClearFields();
                ListViewItem selectedProduct = productsList.SelectedItems[0];
                new RESTClient(Url + "/" + selectedProduct.Text, MethodType.DELETE, selectedProduct.Text).MakeRequest();
                productsList.Items.Remove(selectedProduct);
                statusLabel.Text = "Product " + selectedProduct.SubItems[1].Text + " with ID: " + selectedProduct.Text + " was DELETED!";
            }
        }

        private void AddNewProductButton_Click(object sender, EventArgs e) {
            ClearFields();
            statusLabel.Text = "If there wes data in fields it was removed, you can add new product now.";
        }

        private void ButtonReloadProducts_Click(object sender, EventArgs e) {
            ClearFields();
            productsList.Items.Clear();
            GetAllProducts();
        }

        private void ProductsList_SelectedIndexChanged(object sender, EventArgs e) {
            if (productsList.SelectedItems.Count == 0)
            {
                ClearFields();
                statusLabel.Text = "Select product you want to update or add new item.";
                return;
            }
            UpdateProduct = true;
            ListViewItem selectedProduct = productsList.SelectedItems[0];
            SelectedID = selectedProduct.Text;
            productNameText.Text = selectedProduct.SubItems[1].Text;
            productDescriptionText.Text = selectedProduct.SubItems[2].Text;
            productBarcodeText.Text = selectedProduct.SubItems[3].Text;
            productSupplierText.Text = selectedProduct.SubItems[4].Text;
        }
    }
}
