using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_5.Models;
using System.IO;

/* Author : Chenyuan Xie
 * Date : July 19th, 2016
 * Date Modified: Jul 22th, 2016
 * Description : Assignment 5 File I/O
 * Version : 1.1 - 
 *                  Redo the while loop
 */
namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                while (true)
                {
                    Console.WriteLine("1-Display Grade       2-Exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            const string myfile = "..\\..\\Grade.txt";
                            List<Students> students = new List<Students>();
                            const char DELIM = ',';
                            FileStream inFile = new FileStream(myfile, FileMode.Open, FileAccess.Read);
                            StreamReader reader = new StreamReader(inFile);
                            string recordIN;
                            string[] fields;

                            recordIN = reader.ReadLine();

                            Console.WriteLine("Enter your file to load");
                            

                                string filename = (Console.ReadLine());
                            if (filename == "Grade")
                            {

                                while (recordIN != null)
                                {
                                    Students student = new Students();
                                    fields = recordIN.Split(DELIM);
                                    student.StudentNumber = Convert.ToInt32(fields[1]);
                                    student.Name = fields[0];
                                    student.Class = fields[2];
                                    student.Grade = fields[3];
                                    students.Add(student);
                                
                                    Console.WriteLine("{0} {1} {2} {3}",
                                    student.Name,
                                    student.StudentNumber,
                                    student.Class,
                                    student.Grade);
                                    recordIN = reader.ReadLine();
                                }

                                }
                                else
                                {
                                    Console.WriteLine("File does not exist");
                                }
                                
                            

                            break;
                        case 2:

                            return;
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }







            
        }
    }
}
