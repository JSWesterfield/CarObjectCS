using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management
{
	class Program
	{
		static void Main(string[]args)
		{
			Employee e1 = new Employee();
			e1.ID = 1234;
			e1.Name = "Joe Schmoe";
			e1.Age = 27;
			e1.Gender = "Male";
			e1.Salary = 100000;
			e1.IsFullTime = true; 
			e1.PrintEmployee();

			/*Console.WriteLine("Is employee Retire? " + this.IsRetired());
			Console.WriteLIne("Employee Details: /n");
			Console.WriteLine("Employee ID: " + this.ID);
			Console.WriteLine("Employee Name: " + this.Name);
			Console.WriteLine("Employee Age: " + this.Age);
			Console.WriteLine("Employee Gender: " + this.Gender);
			Console.WriteLine("Employee Salary: " + this.Salary);
			Console.WriteLine("Employee IsFullTime: " + this.IsFullTime());
			Console.WriteLine("Employee Bonus: " + this.CalculateBonus());*/

			Employee e2 = new Employee();
			e2.ID = 4321;
			e2.Name = "Sara Williams";
			e2.Age = 22;
			e2.Gender = "Female";
			e2.Salary = 70000;
			e2.IsFullTime = false; 
			e2.PrintEmployee();

			console.ReadLine();
		}

		class Employee{ 
			public int ID{get; set;}
			public string Name{get; set;}
			public int Age{get; set;}
			public string Gender{get; set;}
			public double Salary{get; set;}
			public bool IsFullTime{get; set;}

			public bool IsRetired() {
				//if employee is less than 60yrs old return true
				if(this.Age < 60) {
					return true;
				}
				else 
				{
					return false;
				}

			public double CalculateBonus() {
			//calculate bonuses for employees 
				double Bonus = this.Salary * 0.1;
				return Bonus;
			//variation of this is ...(below)
			//return this.Salary * 0.1;
			}
			public void PrintEmployee() {
			//print information for employee for redundancy. 
				

				}
			}
			}
		}
	}
}