using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group[] groupList = new Group[0];
            bool mainPart = true;
            while (mainPart)
            {


                Console.WriteLine("Choose the number of the process you'd like to start");
                Console.WriteLine("1.Create New Group \n" +
                    "2.Show the list of the groups \n" +
                    "3.Edit Group");

                ConsoleKeyInfo keycode = Console.ReadKey();

                string key = keycode.Key.ToString();

                switch (key)
                {
                    case "NumPad1":
                        Console.Clear();
                        Console.WriteLine("\nEnter GroupNo");
                        bool result = false;
                        string checkgroup = "";

                        while (!result)
                        {
                            checkgroup = Console.ReadLine();
                            result = Group.CheckGroupNo(checkgroup);

                            if (!result)
                            {
                                Console.Clear();
                                Console.WriteLine("Enter GroupNo correctly");
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Choose the one Category below");
                        bool invalid = true;
                        string ctgry = "";
                        while (invalid)
                        {
                            Console.WriteLine("1.Programming\n2.Design\n3.System" +
                               "Administration");
                            ConsoleKeyInfo categoryKey = Console.ReadKey();
                            string catKey = categoryKey.Key.ToString();

                            switch (catKey)
                            {
                                case "NumPad1":
                                    ctgry = "Programming";
                                    invalid = false;
                                    break;
                                case "NumPad2":
                                    ctgry = "Design";
                                    invalid = false;
                                    break;
                                case "NumPad3":
                                    ctgry = "System Administration";
                                    invalid = false;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Try again");
                                    break;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine(ctgry);
                        Console.WriteLine("Group IsOnline : Yes or No");
                        string checkonline = Console.ReadLine().ToLower();
                        bool isOnline = false;
                        int limit = 10;
                        if (checkonline == "yes")
                        {
                            isOnline = true;
                            limit = 15;
                        }
                        Group group = new Group(checkgroup, limit, ctgry, isOnline);
                        Array.Resize(ref groupList, groupList.Length + 1);
                        groupList[groupList.Length - 1] = group;



                        break;
                    case "NumPad2":
                        Console.Clear();
                        foreach (Group grp in groupList)
                        {
                            Console.WriteLine("Group No:"+ " "+ grp.No);
                            Console.WriteLine("Student Count:" + " "+ grp.Students.Length);
                            Console.WriteLine("Group Status:"+" "+ grp.IsOnline);
                            Console.WriteLine("Group Limit:"+ " "+ grp.Limit);
                            Console.WriteLine("Group Category:"+" "+ grp.Category);
                            Console.WriteLine();
                        }
                        Console.ReadLine();

                        break;
                    case "NumPad3":

                        Console.WriteLine("Show List of the Groups is chosen");
                        break;
                    case "NumPad4":
                        Console.WriteLine("List of Students in group is chosen");
                        break;
                    case "NumPad5":
                        Console.WriteLine("Show whole list of Students");
                        break;
                    case "NumPad6":
                        Console.Clear();
                        Console.WriteLine("Enter Student Fullname");
                        string stuFullname= Console.ReadLine();
                        bool isExist = false;
                        string stuGroupNo = "";
                        while(!isExist)
                        {
                            Console.WriteLine("Enter Student Group No");
                            stuGroupNo = Console.ReadLine();
                            isExist = GroupNoExists(groupList, stuGroupNo);

                            if (isExist == false)
                            {
                                Console.WriteLine("There is no group in that name");
                            }
                            
                        }
                        Console.Clear();
                        Console.WriteLine("Enter ifGuaranteed: Yes or No");
                        bool isGuarant= Console.ReadLine().ToLower() == "yes";
                        Student newStudent=new Student(stuFullname,stuGroupNo,isGuarant);

                        Console.WriteLine();
                        
                        break;
                                     


                    default:
                        Console.WriteLine("Please chose one");

                        break;

                }

            }

        }
        public static bool GroupNoExists(Group[] groups, string stuGroupNo)

        {
            foreach (Group item in groups)
            {
                if (item.No == stuGroupNo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
