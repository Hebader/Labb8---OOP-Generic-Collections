using System.Collections.Generic;

namespace Labb8___OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee(); // skapar ett objekt
            E1.Id = 11;  // Tilldelar ett värde för Id i objektet
            E1.Name = "Anna";
            E1.Gender = "Female";
            E1.Salary = 20000;

            Employee E2 = new Employee();
            E2.Id = 12;
            E2.Name = "Lena";
            E2.Gender = "Female";
            E2.Salary = 22000;

            Employee E3 = new Employee();
            E3.Id = 13;
            E3.Name = "Tomas";
            E3.Gender = "Male";
            E3.Salary = 25000;

            Employee E4 = new Employee();
            E4.Id = 14;
            E4.Name = "Kalle";
            E4.Gender = "Male";
            E4.Salary = 23000;

            Employee E5 = new Employee();
            E5.Id = 15;
            E5.Name = "Stina";
            E5.Gender = "Female";
            E5.Salary = 28000;


            //Del 1 
            //Gör en stack som innehåller Employee som datatyp
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(E1); //Lägger till objekten i stacken
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5); // Objekten läggs på varandra, sist hamnar lämgst upp


            foreach (Employee emp in stack) // Gör en foreach loop för att skriva ut objekten i stacken
            {
                Console.WriteLine($"ID : {emp.Id} - Name: {emp.Name} - Gender: {emp.Gender} - Salary: {emp.Salary}");
                Console.WriteLine($"There is {stack.Count} items in the stack."); // Skriver ut antal objekt i stacken
            }

            // stack.pop metoden tar bort objekt från stacken, sist in först ut
            Console.WriteLine("***********************************");
            Employee stackemp1 = stack.Pop();
            Console.WriteLine($"ID : {stackemp1.Id} Name: {stackemp1.Name}");
            Console.WriteLine("Items  left in the stack " + stack.Count());
            Employee stackemp2 = stack.Pop();
            Console.WriteLine($"ID : {stackemp2.Id} Name: {stackemp2.Name}");
            Console.WriteLine("Items  left in the stack " + stack.Count());
            Employee stackemp3 = stack.Pop();
            Console.WriteLine($"ID : {stackemp3.Id} Name: {stackemp3.Name}");
            Console.WriteLine("Items  left in the stack " + stack.Count());
            Employee stackemp4 = stack.Pop();
            Console.WriteLine($"ID : {stackemp4.Id} Name: {stackemp4.Name}");
            Console.WriteLine("Items  left in the stack " + stack.Count());
            Employee stackemp5 = stack.Pop();
            Console.WriteLine($"ID : {stackemp5.Id} Name: {stackemp5.Name}");
            Console.WriteLine("Items  left in the stack " + stack.Count());


            Console.WriteLine("***********************************");

            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            // stack.peek metoden pekar på objektet längst upp i stacken
            Employee puchEmp1 = stack.Peek();
            Console.WriteLine($"ID : {puchEmp1.Id} Name: {puchEmp1.Name}");
            Console.WriteLine("Items in the stack: " + stack.Count());
            Employee puchEmp2 = stack.Peek();
            Console.WriteLine($"ID : {puchEmp2.Id} Name: {puchEmp2.Name}");
            Console.WriteLine("Items in the stack: " + stack.Count());

            Console.WriteLine("************************");
            // Kollar om objekt nr 3 finns i stacken genom stack.Contains metoden
            if (stack.Contains(E3))

            {
                Console.WriteLine("E3 is in  the stack.");
            }
            else
            {
                Console.WriteLine("E3 is not in the stack.");
            }

            Console.WriteLine("***************************************");

            //Del 2 list
            List<Employee> mylist = new List<Employee>(); // Skapar en list med datatypen Employee

            mylist.Add(E1); //lägger till alla objekt i listan
            mylist.Add(E2);
            mylist.Add(E3);
            mylist.Add(E4);
            mylist.Add(E5);

            if (mylist.Contains(E4)) // Om listan innehåller Employee nr 4
            {
                Console.WriteLine("Employee4 object exists in the list.\n");
            }

            //Hitta första male employee i listan
            Employee firstMaleEmployee = mylist.Find(x => x.Gender == "Male"); // Hittar male med hjälp av Find metoden som innehåller lambda-uttryck 
            if (firstMaleEmployee != null) // villkor sålänge det inte är null,dvs så länge det finns male i listan
            {
                Console.WriteLine($"ID : {firstMaleEmployee.Id} - Name: {firstMaleEmployee.Name} - Gender: {firstMaleEmployee.Gender} - Salary: {firstMaleEmployee.Salary}\n");
            }

            List<Employee> maleEmployees = mylist.FindAll(x => x.Gender == "Male"); // Skapar en list med alla male employees
            if (maleEmployees.Count > 0)
            {
                foreach (Employee emp in maleEmployees) // foreach loop för att skriva ut alla male
                {
                    Console.WriteLine($"ID : {emp.Id} - Name: {emp.Name} - Gender: {emp.Gender} - Salary: {emp.Salary}");
                }

            }
        }

    }
}



   