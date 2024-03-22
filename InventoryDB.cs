using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_C_
{
    public class InventoryDB
    {
        private static readonly string Path = @"C:\Users\gdham\source\repos\Lab_6_C#\grocery_inventory_items.txt";
        private const string Delimiter = "|";
        public static List<InventoryItem> GetItems()
        {
            List<InventoryItem> items = new List<InventoryItem>();


            using (StreamReader textIn = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                while ((row = textIn.ReadLine()) != null)
                {
                    string[] columns = row.Split(Delimiter);


                    if (columns.Length == 3)
                    {
                        InventoryItem item = new InventoryItem
                        {
                            ItemNo = Convert.ToInt32(columns[0]),
                            Description = columns[1],
                            Price = Convert.ToDouble(columns[2])
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static void SaveItems(List<InventoryItem> items)
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                foreach (InventoryItem item in items)
                {
                    textOut.Write(item.ItemNo + Delimiter);
                    textOut.Write(item.Description + Delimiter);
                    textOut.WriteLine(item.Price);
                }
            }
        }
        public static void DeleteItem(int itemNo)
        {
            List<InventoryItem> items = GetItems();
            InventoryItem removeItem = items.FirstOrDefault(item => item.ItemNo == itemNo);
            if (removeItem != null)
            {
                items.Remove(removeItem);
                SaveItems(items);
            }
        }
    }
}