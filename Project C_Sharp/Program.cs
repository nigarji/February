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

                Console.Clear();
                Console.WriteLine("Choose the number of the process you'd like to start");
                Console.WriteLine("1.Create New Group \n" +
                    "2.Show the list of the groups \n" +
                    "3.Edit Group\n"+
                    "4.Students in Group\n"+
                    "5.All students list\n"+
                    "6.Create new Student.");

                ConsoleKeyInfo keycode = Console.ReadKey();

                string key = keycode.Key.ToString();

                switch (key)
                {
                    case "NumPad1":
                        Console.Clear();
                        Console.WriteLine("\nEnter GroupNo");
                        bool result = false;
                        string groupNo = "";

                        while (!result)
                        {
                            groupNo = Console.ReadLine();
                            result = Group.CheckGroupNo(groupNo);

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

                        Group groupIn = new Group(groupNo, limit, ctgry, isOnline);
                        Array.Resize(ref groupList, groupList.Length + 1);
                        groupList[groupList.Length - 1] = groupIn;



                        break;
                    case "NumPad2":
                        Console.Clear();
                        foreach (Group grp in groupList)
                        {
                            Console.WriteLine("Group No:" + " " + grp.No);
                            Console.WriteLine("Student Count:" + " " + grp.Students.Length);
                            Console.WriteLine("Group Status:" + " " + (grp.IsOnline ?"Yes" :"No"));
                            Console.WriteLine("Group Limit:" + " " + grp.Limit);
                            Console.WriteLine("Group Category:" + " " + grp.Category);
                            Console.WriteLine();
                        }
                        Console.ReadLine();

                        break;
                    case "NumPad3":
                        Console.Clear();
                        Console.WriteLine("Enter GroupNo you want to change");
                        Group existsNo ;
                        string newgroupNo;
                        string oldgroupNo = Console.ReadLine();
                        existsNo = GroupNoExists(groupList, oldgroupNo);
                      
                        if (existsNo!=null)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter New GroupNo"); 
                            newgroupNo = Console.ReadLine();
                           while (GroupNoExists(groupList,newgroupNo)!=null)
                            {
                                Console.WriteLine("This GroupNo is already exist.Try new group number.");
                                newgroupNo=Console.ReadLine();
                            }
                            Group.NewGroupNo(newgroupNo, oldgroupNo, groupList);
                            Console.WriteLine("This GroupNo was changed to" + " "+newgroupNo);

                        }
                        else
                        {
                            Console.WriteLine("There is GroupNo under this name");
                        }
                        
                            
                        Console.WriteLine();
                      
                        break;
                    case "NumPad4":
                        Console.Clear();
                        Console.WriteLine("Enter the GroupNo you want to see the Students");
                    
                        Group isExistsGroupNo = null;
                        while (isExistsGroupNo == null)
                        {
                           string seeStudentsGroupNo = Console.ReadLine();
                            isExistsGroupNo = GroupNoExists(groupList, seeStudentsGroupNo);
                            if (isExistsGroupNo != null)
                            {
                                isExistsGroupNo.ShowListStudents();
                                Console.Read();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("There is no GroupNo under that name.Try Again");

                            }

                        }
                        break;

                    case "NumPad5":
                        Console.Clear();
                        AllInfo(groupList);
                        Console.ReadLine();
                        break;

                    case "NumPad6":
                        Console.Clear();
                        Console.WriteLine("Enter Student Fullname");
                        string stuFullname = Console.ReadLine();
                        Group isExist=null;
                        string stuGroupNo = "";
                        while (isExist==null)
                        {
                            Console.WriteLine("Enter Student Group No");
                            stuGroupNo = Console.ReadLine();
                            isExist = GroupNoExists(groupList, stuGroupNo);

                            if (isExist == null)
                            {
                                Console.WriteLine("There is no group in that name");
                            }

                        }
                        Console.Clear();
                        Console.WriteLine("Enter ifGuaranteed: Yes or No");
                        bool isGuarant = Console.ReadLine().ToLower() == "yes";
                        Student newStudent = new Student(stuFullname, stuGroupNo, isGuarant);
                        Group.NewStuInGroup(newStudent, groupList); 
                        
                        Console.WriteLine();
                     
                        break;
                    default:
                        Console.WriteLine("Please choose one");

                        break;

                }

            }

        }
        public static Group GroupNoExists(Group[] groups, string stuGroupNo)

        {
            foreach (Group item in groups)
            {
                if (item.No == stuGroupNo)
                {
                    return item;
                }
            }
            return null;
        }
        public static void AllInfo (Group[] grouplist)

        {
            foreach (Group grp in grouplist)
            {
                foreach (Student stu in grp.Students)
                {
                    Console.WriteLine($"Student Fullname: {stu.Fullname }");
                    Console.WriteLine($"Student Group No: {stu.GroupNo}");
                    Console.WriteLine("Student Is Online: " + ( grp.IsOnline ? "Online" : "Offline"));
                }

            }
        }
    }
}
