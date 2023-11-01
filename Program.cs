namespace Labb8___OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee();
            E1.Id = 11;
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
            E3.Gender = "Male,";
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

            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

        
            foreach (Employee emp in stack)
            {
                Console.WriteLine($"ID : {emp.Id} Name: {emp.Name}. Gender {emp.Gender}. Salary {emp.Salary}");
                Console.WriteLine($"There is {stack.Count} items in the stack.");
            }
            Console.WriteLine("***********************************");

            Employee stackEmp1 = stack.Pop();
            Console.WriteLine($"ID : {stackEmp1.Id} Name: {stackEmp1.Name}");
            Console.WriteLine("Items left in the stack " + stack.Count());
            Employee stackEmp2 = stack.Pop();
            Console.WriteLine($"ID : {stackEmp2.Id} Name: {stackEmp2.Name}");
            Console.WriteLine("Items left  in the stack " + stack.Count());
            Employee stackEmp3 = stack.Pop();
            Console.WriteLine($"ID : {stackEmp3.Id} Name: {stackEmp3.Name}");
            Console.WriteLine("Items  left in the stack " + stack.Count());
            Employee stackEmp4 = stack.Pop();
            Console.WriteLine($"ID : {stackEmp4.Id} Name: {stackEmp4.Name}");
            Console.WriteLine("Items left in the stack " + stack.Count());
            Employee stackEmp5 = stack.Pop();
            Console.WriteLine($"ID : {stackEmp5.Id} Name: {stackEmp5.Name}");
            Console.WriteLine("Items  left in the stack " + stack.Count());


            foreach (Employee emp in stack)
            {
                Console.WriteLine($"ID : {emp.Id}");
            }

            Console.WriteLine("***********************************");

            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            Employee puchEmp1 = stack.Peek();
            Console.WriteLine($"ID : {puchEmp1.Id} Name: {puchEmp1.Name}");
            Console.WriteLine("Items in the stack: " + stack.Count());
            Employee puchEmp2= stack.Peek();
            Console.WriteLine($"ID : {puchEmp2.Id} Name: {puchEmp2.Name}");
            Console.WriteLine("Items in the stack: " + stack.Count());

            Console.WriteLine("************************");
            if (E3 == stackEmp3)

            {
                Console.WriteLine("StackEmp3 is in stack");
            }
        }
    }
}


   