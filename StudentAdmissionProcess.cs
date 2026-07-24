using System;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp1
{
    internal class Program
    {
        class student
        {
            public int AdmissonNumber;
            public String StudentName;
            public string Course;
            public int Semister;
            private double Fees;
            private bool isScholshipElligible;
            private const double Scholarship = 0.10;
            public student()
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("STUDENT ADDMISSION SYSTEM");
                Console.WriteLine("----------------------------------");
                Course = "COMPUTER SCIENCE";
                Semister = 5;
                Console.WriteLine("STUDENT OBJECT CREATED SUCCESFULLY");
                Console.WriteLine();


            }
            public void AcceptDetails()
            {
                Console.WriteLine("ENTER ADMISSION NUMBER: ");
                AdmissonNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ENTER STUDENT NAME :");
                StudentName = Console.ReadLine();
                Console.WriteLine("ENTER COURSE :");
                Course = Console.ReadLine();
                Console.WriteLine("ENTER SEMISTER :");
                Semister = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ENTER ADMISSION FEES :");
                Fees = Convert.ToDouble(Console.ReadLine());



            }
            public void CheckScolarshipEligibility()
            {
                if (Fees <= 50000)
                {
                    isScholshipElligible = true;
                }
                else
                {
                    isScholshipElligible = false;
                }
            }
            public void DisplayDetails()
            {
                double FinalFees = Fees;
                if (isScholshipElligible)
                {
                    FinalFees = Fees - (Fees * Scholarship);

                }
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine("ADDMISSION NUMBER: " + AdmissonNumber);
                Console.WriteLine("STUDENT NAME: " + StudentName);
                Console.WriteLine("COURSE: " + Course);
                Console.WriteLine("SEMESTER: " + Semister);
                Console.WriteLine("ADDMISSION FEES: " + Fees);
                Console.WriteLine("SCHOLARSHIP: " + (isScholshipElligible ? "Eligible" : "Not Eligible"));
                Console.WriteLine("FINAL FEES: " + FinalFees);
                Console.WriteLine("--------------------------------");
            }

        }
        static void Main(string[] args)
        {
            student student1 = new student();
            student1.AcceptDetails();
            student1.CheckScolarshipEligibility();
            student1.DisplayDetails();



        }
    }
}