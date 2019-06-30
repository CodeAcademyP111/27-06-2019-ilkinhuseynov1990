using System;

namespace Registration
{
	class Student
	{
		private static int ID;

		public string Name;

		public string Surname;

		public int Mobnumber;

		public GroupType GroupType;


		public Student( string name , string surname , int number , GroupType groupType)
		{

			ID++;

			Name = name;

			Surname = surname;

			Mobnumber = number;

			GroupType = groupType;
		}

	}
}
