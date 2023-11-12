namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employeeStack = new Stack<Employee>(); // Skapar stack för Employee

            for (int i = 1; i <= 5; i++) // Lägger till 5 objekt
            {
                Employee emp = new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? 'F' : 'M',
                    Salary = 20000
                };

                employeeStack.Push(emp);

            }

            Console.WriteLine("Objekt i stacken: "); // Skriver ut alla objekt i stacken och hur många som finns kvar i stacken
            foreach (var emp in employeeStack)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
                Console.WriteLine($"Antal objekt i stacken: {employeeStack.Count}");
            }

            Console.WriteLine("\nHämta objekt med Pop-metoden:"); // Hämtar/skriver alla objekt och räknar hur många som finns kvar i stacken
            while (employeeStack.Count > 0)
            {
                Employee emp = employeeStack.Pop();
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
                Console.WriteLine($"Antal objekt i stacken: {employeeStack.Count}");
            }

            for (int i = 1; i <= 5; i++) // Lägger till 5 objekt igen
            {
                Employee emp = new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? 'F' : 'M',
                    Salary = 20000
                };

                employeeStack.Push(emp);
            }

            Console.WriteLine("\nHämta objekt med Peek-metoden:"); // Hämtar/skriver objekt och skriver hur många objekt som är kvar
            for (int i = 0; i < 2; i++)
            {
                Employee emp = employeeStack.Peek();
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
                Console.WriteLine($"Antal objekt i stacken: {employeeStack.Count}");
            }

            bool containsObj3 = employeeStack.Contains(employeeStack.ElementAt(2)); // Kollar om objekt 3 finns i stacken
            Console.WriteLine($"\nObjekt nummer 3 {(containsObj3 ? "finns" : "finns inte")} i stacken.");

            
            List<Employee> employeeList = new List<Employee>(); // Skapar en lista för Employee

            for (int i = 1; i <= 5; i++) // Lägger till 5 objekt
            {
                Employee emp = new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? 'F' : 'M',
                    Salary = 20000
                };

                employeeList.Add(emp);
            }
            Employee emp2 = new Employee // Skapar en employee för kontroll i Contains-metoden
            {
                Id = 2,
                Name = "Employee2",
                Gender = 'F',
                Salary = 20000
            };


            if (employeeList.Contains(emp2)) // Kollar om emp2 finns
            {
                Console.WriteLine("\nEmployee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("\nEmployee2 object does not exist in the list");
            }
           
            Employee maleEmployee = employeeList.Find(e => e.Gender == 'M'); // Hittar första male employee
            if (maleEmployee != null)
            {
                Console.WriteLine($"\nId: {maleEmployee.Id}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Gender}, Salary: {maleEmployee.Salary}");
            }
            else
            {
                Console.WriteLine("\nIngen med Gender = 'Male' hittades i listan");
            }
           
            List<Employee> maleEmployees = employeeList.FindAll(e => e.Gender == 'M'); // Hittar alla male employee
            if (maleEmployees.Count > 0)
            {
                Console.WriteLine("\n");

                foreach (var maleEmp in maleEmployees)
                {
                    Console.WriteLine($"Id: {maleEmp.Id}, Name: {maleEmp.Name}, Gender: {maleEmp.Gender}, Salary: {maleEmp.Salary}");
                }
            }
            else
            {
                Console.WriteLine("Inga med Gender = 'Male' hittades i listan");
            }
        }
    }
}