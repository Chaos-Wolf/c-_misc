using System;

namespace HellowWorldApplication {
	class Object_Test{
		public class Person{
			public Person(string n, double a){
				name = n;
				age = a;
			}

			string name{get; set;}
			double age{get; set;}

			public void Print_Person() {
				Console.WriteLine("Name: {0}",name);
				Console.WriteLine("Age: {0}", age);
			}
		}
		public class Student : Person{
			public Student(string n, double a, int i) : base(n,a){
				id = i;
			}
			int id{get; set;}
			public void Print_Student(){
				base.Print_Person();
				Console.WriteLine("ID: {0}", id);
			}
		}
		static void Main(){
			Person Person1 = new Person("jeff", 25);
			Person1.Print_Person();
			Student Person2 = new Student("greg",25, 109092);
			Person2.Print_Person();
			Person2.Print_Student();
		}
	}
}