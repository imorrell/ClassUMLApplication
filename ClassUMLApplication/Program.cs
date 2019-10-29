using System;
using System.Collections.Generic;

namespace ClassUMLApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create student and staff objects
            Student studentOne = new Student("Doug Funnie", "124 Blumfield Ave", "Mechanical Engineering", 2018, 900.00);
            Student studentTwo = new Student("Jack Sparrow", "The Black Pearl", "Hydrology", 2027, 3000.00);
            Student studentThree = new Student("Nino Brown", "2131 Brooklyn Square", "Pharmacusical Science", 2018, 10000.00);

            Staff staffOne = new Staff("Sterling Silver", "323 Crooks Ave", "University of Harvard", 300000);
            Staff staffTwo = new Staff("Bill Clinton", "1212 Roosevelt Drive", "University of Michigan", 8000000);

            //add the students and the staff to a person list
            List<Person> people = new List<Person> { studentOne, studentTwo, studentThree, staffOne, staffTwo };
            
            //call the AddStudentOrStaff method
            AddStudentOrStaff(people);
        }

        //the AddStudentStaff method prompts the user on whether or not they would like to add a student of staff to the list
        public static void AddStudentOrStaff(List<Person> people)
        {
            //initialize variables
            bool ok = true;

            //prompt the user on whether to add student or staff
            while (ok)
            {
                //use foreach loop to print out students and staff
                foreach (Person person in people)
                {
                    if (person is Student)
                    {
                        //print out the students information
                        Student student = (Student)person;
                        Console.WriteLine(student.ToString());
                    }
                    else
                    {
                        //Person is staff. Print out staff member information
                        Staff staff = (Staff)person;
                        Console.WriteLine(staff.ToString());
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Would you like to add a new student or staff member (please enter number)?\n");

                Console.WriteLine("1. Student");
                Console.WriteLine("2. Staff");
                Console.WriteLine("3. Exit Program\n");

                //get the user selection
                int selection = int.Parse(Console.ReadLine());

                Console.WriteLine();

                //process user selection
                if (selection == 1)
                {
                    //add new student to the list.
                    Console.WriteLine("Enter students name\n");
                    string studentName = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Enter students address\n");
                    string studentAddress = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter students program\n");
                    string studentProgram = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter students year\n");
                    int studentYear = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Enter students fee\n");
                    double studentFee = double.Parse(Console.ReadLine());

                    //create new student object and add this object to the persons list
                    Student studentInfo = new Student(studentName, studentAddress, studentProgram, studentYear, studentFee);

                    people.Add(studentInfo);

                    Console.WriteLine();
                }
                else if (selection == 2)
                {
                    //add new staff to the list.
                    Console.WriteLine("Enter staff name\n");
                    string staffName = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Enter staff address\n");
                    string staffAddress = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter staff school\n");
                    string staffSchool = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter staff salary\n");
                    double staffSalary = double.Parse(Console.ReadLine());

                    //create new student object and add this object to the persons list
                    Staff staffInfo = new Staff(staffName, staffAddress, staffSchool, staffSalary);

                    people.Add(staffInfo);
                    Console.WriteLine();
                }
                else if (selection == 3)
                {
                    //exit the loop and the program
                    Console.WriteLine("Goodbye!\n");
                    ok = false;
                }
                else
                {
                    //user entered wrong input. use recursion to cycle back through the method
                    Console.WriteLine("Wrong input! Please try again. \n");
                    AddStudentOrStaff(people);
                }
            }
            



        }
    }
}
