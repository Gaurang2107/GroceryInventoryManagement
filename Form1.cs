namespace Lab_6_C_
{
    public partial class Form1 : Form
    {
        public List<InventoryItem> inventory = new List<InventoryItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadInventoryItems()
        {
            inventory = InventoryDB.GetItems();
            UpdateList();
        }

        private void UpdateList()
        {
            lbInventoryItems.Items.Clear();
            foreach (var item in inventory)
            {
                lbInventoryItems.Items.Add(item.ItemNo + " | " +
                    item.Description + " | " + item.Price);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItems addItems = new AddItems();
            if (addItems.ShowDialog() == DialogResult.OK)
            {
                inventory.Add(addItems.addItem);
                InventoryDB.SaveItems(inventory);
                UpdateList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbInventoryItems.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    int selectedIndex = lbInventoryItems.SelectedIndex;
                    inventory.RemoveAt(selectedIndex);
                    InventoryDB.SaveItems(inventory);
                    UpdateList();

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInventoryItems();
        }
    }
}