using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice3
{
    internal class GroceryVoucher
    {
        private readonly string filePath;
        private List<GroceryItem> items;
        private List<string> duplicateIds;

        public GroceryVoucher(string filePath)
        {
            this.filePath = filePath;
            this.items = new List<GroceryItem>();
            this.duplicateIds = new List<string>();
        }

        public void ProcessItems()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found: " + filePath);
                return;
            }

            ReadItemsFromFile();

            if (duplicateIds.Any())
            {
                Console.WriteLine("Duplicate item IDs found: " + string.Join(", ", duplicateIds));
                return;
            }

            DisplayAndSaveVoucher();
        }

        private void ReadItemsFromFile()
        {
            var lines = File.ReadAllLines(filePath);
            var seenIds = new HashSet<string>();  // ✅ fixed variable name

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length != 3) continue;

                string id = parts[0].Trim();
                int qty = int.Parse(parts[1].Trim());
                double price = double.Parse(parts[2].Trim());

                if (!seenIds.Add(id))
                {
                    duplicateIds.Add(id);
                }
                else
                {
                    items.Add(new GroceryItem
                    {
                        ItemID = id,
                        Quantity = qty,
                        UnitPrice = price
                    });
                }
            }
        }

        private void DisplayAndSaveVoucher()
        {
            string outputFile = "voucher.txt";
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                void WriteLine(string text)
                {
                    Console.WriteLine(text);
                    writer.WriteLine(text);
                }

                WriteLine("Item id\t\tQty\tunit price\ttotal");

                int totalQty = 0;
                double grandTotal = 0;

                foreach (var item in items)
                {
                    WriteLine($"{item.ItemID}\t{item.Quantity}\t{item.UnitPrice}\t\t{item.TotalPrice}");
                    totalQty += item.Quantity;
                    grandTotal += item.TotalPrice;
                }

                double vat = grandTotal * 0.05;
                double netTotal = grandTotal + vat;

                WriteLine($"\nTotal\t\t{totalQty}\tGrand total \t{grandTotal}");
                WriteLine($"VAT (5%)\t{vat}");
                WriteLine($"Net total\t{netTotal}");
            }

            Console.WriteLine("\nVoucher saved to 'voucher.txt'");
        }
    }
}
