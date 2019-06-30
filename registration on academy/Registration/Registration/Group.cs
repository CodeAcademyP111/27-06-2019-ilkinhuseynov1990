using System;

namespace Registration
{
	class Group
	{
		private static int ID;

		public string Groupname;

		public byte GroupSize;

		private GroupType groupType;

		Student[] students;


		public Group(string groupname, GroupType type, byte Size)
		{
			ID++;

			Groupname = groupname;

			groupType = type;

			GroupSize = Size;

			students = new Student[0];

		}




		public void AddSTudent(Student student)
		{


			if (students.Length <= GroupSize)
			{
				Array.Resize(ref students, students.Length + 1);

				students[students.Length - 1] = student;
			}
			else
			{
				Console.WriteLine(" Tessufler olsun ki bos yerimiz qalmayib ");
			}
		}


		public void Getstdudents()
		{
			foreach (var item in students)
			{
				Console.WriteLine($"{item.Name} {item.Surname} {item.GroupType.Grouptype}");
			}
		}

	}
}
