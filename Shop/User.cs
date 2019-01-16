using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Items;
using Shop.User.Card;

namespace Shop.User
{
	public class User
	{
		public List<Item> _userList { get; private set; }

		//Вот и полиморфизм
		public virtual void AddItem(Item tmpItem)
		{
		}

		public virtual void AddItem(int tmpId, string name, int price)
		{
		}

		public virtual void DeleteItem(Item tmpItem)
		{
		}

		public virtual void BuyItem()
		{
			//redirect to register page
		}

		public void Register(string name, string mail, string pass)
		{
			//register new user
		}
	}

	//наследование
	public class RegisteredUser : User
	{
		private string _nickname;
		private string _email;
		private string _password;
		private CardInfo _userCard;

		public RegisteredUser(string name, string mail, string pass)
		{
			//register new user
		}

		public void AddCardInfo(string num, int money)
		{
			//add user card info
		}

		//Вот и полиморфизм
		public override void AddItem(Item tmpItem)
		{
		}

		public override void AddItem(int tmpId, string name, int price)
		{
		}

		public override void DeleteItem(Item tmpItem)
		{
		}

		public override void BuyItem()
		{ 
			//buy itemList
		}
	}
}
