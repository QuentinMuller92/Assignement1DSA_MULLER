using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1DSA_MULLER
{
    public class Program
    {        
        static void Main(string[] args)
        {
            CustomDataList dataList = new CustomDataList();

            while (true)
            {
                Console.Clear();

                int counter = 1;
                Console.WriteLine("List of Students :");
                for (int i = 0; i < dataList.DataList.Count; i++)
                {
                    Console.WriteLine(counter + ". " + dataList.DataList[i].FirstName);
                    counter++;
                }

                Console.WriteLine(new string('=', 50));
                Console.WriteLine("1. Populate some sample data");
                Console.WriteLine("2. Add an item");
                Console.WriteLine("3. Display the information of a selected item");
                Console.WriteLine("4. Remove an element from the list");
                Console.WriteLine("5. Remove the first element of the list");
                Console.WriteLine("6. Remove the last element of the list");
                Console.WriteLine("7. Display all items of the list ");
                Console.WriteLine("8. Exit");
                Console.WriteLine(new string('=', 50));

                int choice = 0;
                while (choice < 1 || choice > 8)
                {
                    Console.Write("Please enter your choice: ");
                    int.TryParse(Console.ReadLine(), out choice);
                }

                if (choice == 8)
                {
                    break;
                }

                switch(choice)
                {
                    case 1:
                        dataList.PopulateWithSampleData();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Adding a student ...\n");

                        Console.Write("First Name > ");
                        string firstName = Console.ReadLine();

                        Console.Write("Last Name > ");
                        string lastName = Console.ReadLine();

                        string studentNumber = "";
                        while (studentNumber.Length != 5 || studentNumber == null)
                        {
                            Console.Write("Student Number (Ex : HJZ36) > ");
                            studentNumber = Console.ReadLine().ToUpper();
                        }

                        float averageScore = 0;
                        while (averageScore  < 1 || averageScore > 100)
                        {
                            Console.Write("Average Score (1-100) > ");
                            float.TryParse(Console.ReadLine(), out averageScore);
                        }

                        Student student = new Student(firstName, lastName, studentNumber, averageScore);
                        dataList.Add(student);
                        break;
                    case 3:
                        choice = 0;
                        if(dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            Console.WriteLine();
                            while (choice < 1 || choice > dataList.DataList.Count)
                            {
                                Console.Write("Please enter the number of the student whose you want more information about : ");
                                int.TryParse(Console.ReadLine(), out choice);
                            }

                            Console.Clear();

                            dataList.GetElement(choice);
                        }                        
                        break;
                    case 4:
                        choice = 0;
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            Console.WriteLine();
                            while (choice < 1 || choice > dataList.DataList.Count)
                            {
                                Console.Write("Please enter the number of the student that you want to remove : ");
                                int.TryParse(Console.ReadLine(), out choice);
                            }
                            dataList.RemoveByIndex(choice);
                        }
                        break;
                    case 5:
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            dataList.RemoveFirst();
                        }
                        break;
                    case 6:
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            dataList.RemoveLast();
                        }
                        break;
                    case 7:
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            Console.Clear();
                            dataList.DisplayList();
                        }
                        break;
                }
                Console.ReadLine();
            }

            Console.ReadKey();
        }       
    }
}
