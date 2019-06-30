using System;

namespace Registration
{
	class GroupType
	{
		private static int ID;

		public string Grouptype;

		public float Price;


		public GroupType(string Type , float Priceg)
		{
			ID++;

			Grouptype = Type;

			Price = Priceg;
		}
	}
}
