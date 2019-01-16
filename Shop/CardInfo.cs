using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.User.Card
{
	public class CardInfo
	{
		private string _cardNumber;
		private int _cardMoney;

		public CardInfo(string num, int money)
		{
			//get info from somwhere
			_cardNumber = num;
			_cardMoney = money;
		}
	}
}
