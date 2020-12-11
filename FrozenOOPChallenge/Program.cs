using System;
using System.IO;
using System.Collections.Generic;

namespace BoxOffice
{
    class Program
    {
        class Item
        {
            string name;
            string item;

            public Item(string _name, string _item)
            {
                name = _name;
                item = _item;
            }

            public string Name
            {
                get { return name; }
            }
            
            public string Itemz
            {
                get { return item; }
            }

            class ItemList
            {
                List<Item> Items;

                public ItemList()
                {
                    Items = new List<Item>();
                }

                public void AddItemsToList(string name, string item)
                {
                    Item newItem = new Item(name, item);
                    Items.Add(newItem);
                }

                public void PrintAllMovies()
                {
                    foreach (Item item in Items)
                    {
                        Console.WriteLine($"{item.Name} wants {item.Itemz} for Christmas");
                    }
                }
            }
            static void Main(string[] args)
            {
                string filePath = @"C:\Users\opilane\samples";
                string fileName = @"frozenI.txt";
                string fullFilePath = Path.Combine(filePath, fileName);

                string[] linesFromFile = File.ReadAllLines(fullFilePath);

                ItemList myItems = new ItemList();

                foreach (string line in linesFromFile)
                {
                    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    string ItemName = tempArray[0];
                    string ItemItem = tempArray[1];
                    myItems.AddItemsToList(ItemName, ItemItem);
                }
                myItems.PrintAllMovies();
            }
        }
    }
}
