using Connected.DAL;
using Connected.Model;

namespace Connected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int no_of_affected = 0;
            do
            {
                DacDbContext dacDbContext= new DacDbContext();

                Console.WriteLine("1. Read\n2. Insert\n3. Update\n4. Delete\n5. Exit");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        List<Student> stud = dacDbContext.SelectRecord();
                        foreach(var item in stud)
                        {
                            Console.WriteLine($"Id: {item.Id}\nName: {item.Name}\nCity: {item.City}" );
                        }
                        break;
                    case 2:
                        Student student= new Student();
                        Console.WriteLine("Enter Student Name");
                        student.Name = Console.ReadLine();
                        Console.WriteLine("Enter City");
                        student.City = Console.ReadLine();
                        no_of_affected= dacDbContext.Insert(student);
                        if (no_of_affected > 0)
                        {
                            Console.WriteLine("Inserted");
                        }
                        no_of_affected = 0;
                        break;
                    case 3:
                        Student Upstudent = new Student();
                        Console.WriteLine("Enter Id to be updated");
                        Upstudent.Id= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name");
                        Upstudent.Name = Console.ReadLine();
                        Console.WriteLine("Enter City");
                        Upstudent.City = Console.ReadLine();
                        no_of_affected = dacDbContext.Update(Upstudent);
                        if (no_of_affected > 0)
                        {
                            Console.WriteLine("Updated" +
                                "" +
                                "");
                        }
                        no_of_affected = 0;
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;


                }
            } while (choice != 6);
        }
    }
}
