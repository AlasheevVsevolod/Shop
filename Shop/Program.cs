using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Items;

namespace Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			var item1 = new Item(123, "Motherboard", 300);
			var item2 = new Item(123, "Videocard", 500);

			Console.WriteLine(item1 < item2 ? "Item1 is cheaper than item2" : "Item1 is more expensive than item2");
			Console.WriteLine(item2 > item1 ? "Item2 is more expensive than item1" : "Item2 is cheaper than item1");
			Console.WriteLine(item1 == item2 ? "Items have the same price" : "Items have different prices");
			Console.WriteLine(item1 != item1 ? "Items have different prices" : "Items have the same price");



			Console.ReadLine();
		}
	}
}
