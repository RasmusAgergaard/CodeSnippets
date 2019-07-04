using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAndLambda
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /********** Method 1 **********/

            //Populate the list with items
            var items1 = new List<Item>()
            {
                {new Item() {ItemId = 1, ItemName = "Ball", ItemNumber = 8845 }},
                {new Item() {ItemId = 2, ItemName = "Flower", ItemNumber = 8537 }},
                {new Item() {ItemId = 3, ItemName = "Rock", ItemNumber = 5421 }},
                {new Item() {ItemId = 4, ItemName = "Cup", ItemNumber = 1278 }},
                {new Item() {ItemId = 5, ItemName = "Pen", ItemNumber = 9965 }},
            };

            //Create Query
            var itemQuery1 = from i in items1
                              where i.ItemName.Contains("o")
                              orderby i.ItemId
                              select i;

            //Run though query and output the content
            Console.WriteLine("Query 1");
            foreach (var item in itemQuery1)
            {
                Console.WriteLine(item.ItemName);
            }


            /********** Method 2 **********/

            //Populate the list with items
            var items2 = new List<Item>()
            {
                {new Item() {ItemId = 1, ItemName = "Ball", ItemNumber = 8845 }},
                {new Item() {ItemId = 2, ItemName = "Flower", ItemNumber = 8537 }},
                {new Item() {ItemId = 3, ItemName = "Rock", ItemNumber = 5421 }},
                {new Item() {ItemId = 4, ItemName = "Cup", ItemNumber = 1278 }},
                {new Item() {ItemId = 5, ItemName = "Pen", ItemNumber = 9965 }},
            };

            //Create Query
            var itemQuery2 = items2.Where(FilterItems).OrderBy(OrderItemsByName);

            //Run though query and output the content
            Console.WriteLine("Query 2");
            foreach (var item in itemQuery2)
            {
                Console.WriteLine(item.ItemName);
            }


            /********** Method 3 **********/

            //Populate the list with items
            var items3 = new List<Item>()
            {
                {new Item() {ItemId = 1, ItemName = "Ball", ItemNumber = 8845 }},
                {new Item() {ItemId = 2, ItemName = "Flower", ItemNumber = 8537 }},
                {new Item() {ItemId = 3, ItemName = "Rock", ItemNumber = 5421 }},
                {new Item() {ItemId = 4, ItemName = "Cup", ItemNumber = 1278 }},
                {new Item() {ItemId = 5, ItemName = "Pen", ItemNumber = 9965 }},
            };

            //Create Query
            var itemQuery3 = items3.Where(i => i.ItemName.Contains("o"))
                                     .OrderBy(i => i.ItemName);

            //Run though query and output the content
            Console.WriteLine("Query 3");
            foreach (var item in itemQuery3)
            {
                Console.WriteLine(item.ItemName);
            }

            Console.ReadLine();
        }

        //Used for method 2
        private static bool FilterItems(Item i) => i.ItemName.Contains("o");
        private static string OrderItemsByName(Item i) => i.ItemName;
    }
}