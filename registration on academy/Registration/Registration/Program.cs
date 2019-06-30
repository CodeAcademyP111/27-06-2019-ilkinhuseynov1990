using System;

namespace Registration
{
	class Program
	{
		static void Main(string[] args)
		{

			GroupType groupType = new GroupType("Programing",4500);

			Student student1 = new Student("Ilkin",  "Huseynov",123456,groupType);

			Student student2 = new Student("Resad",  "Veliyey", 123456, groupType);

			Student student3 = new Student("Rufet",  "Qarayev", 123456, groupType);

			Student student4 = new Student("Ramiz",  "Eliyev", 123456, groupType);

			Student student5 = new Student("Sebuhi", "Dadasov", 123456, groupType);

			Student student6 = new Student("Vusal",  "Qarayev", 123456, groupType);

			Student student7 = new Student("Ayaz", "Kerimov",123456, groupType);

			Group group = new Group("P111", groupType, 5);


			group.AddSTudent(student1);

			group.AddSTudent(student2);

			group.AddSTudent(student3);

			group.AddSTudent(student4);

			group.AddSTudent(student5);

			group.AddSTudent(student6);

			group.AddSTudent(student7);

			group.Getstdudents();

		}
	}
}

