using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Items
{
	public class Item
	{
		private int _id;
		private string _name;
		private int _price;
		private string _description;

		public Item(int id, string name, int price, string description)
		{
		}

		public Item(int id, string name, int price)
		{
			_id = id;
			_name = name;
			_price = price;
		}

		public static bool operator <(Item item1, Item item2)
		{
			return item1._price < item2._price ? true : false;
		}

		public static bool operator >(Item item1, Item item2)
		{
			return item1._price > item2._price ? true : false;
		}

		public static bool operator ==(Item item1, Item item2)
		{
			return item1._price == item2._price ? true : false;
		}

		public static bool operator !=(Item item1, Item item2)
		{
			return item1._price != item2._price ? true : false;
		}
	}
}
