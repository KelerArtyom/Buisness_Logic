using AuthSystemProject;
using System.Runtime.CompilerServices;

Console.Write("Введите количество объектов: ");
int length = int.Parse(Console.ReadLine());
UsersDataBaseMock db = new(100);
ObjectDataBaseMock db_obj = new(length);
Object_Flowers[] flow = db_obj.GetAll();
Authorization authorization = new(db);
Console.WriteLine("System `SunFlower` is ready to work!");
Console.WriteLine("Sigh in...");
Console.Write("Login: ");
string login = Console.ReadLine();
Console.Write("Password: ");
string pass = Console.ReadLine();

authorization.Login(login.Trim(), pass.Trim());

if (authorization.IsAuth())
{

    Console.WriteLine("Success!");
    Console.WriteLine();
    Console.WriteLine($"Welcome, {authorization.GetName()}!");
    Console.WriteLine();
    if (authorization.GetRole() == User.Roles.ADMIN)
    {
    a:
        Console.WriteLine("What do You want?");
        Console.WriteLine("1) (Re)Create | 2) Show all variety of flowers | 3) Find by ID ");
        Console.Write("Enter: ");
        int ans = int.Parse(Console.ReadLine());
        switch (ans)
        {
            case 1:
                Console.Write("Enter ID of flower: ");
                int id = int.Parse(Console.ReadLine());
                if (id >= 0 && id < length)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (id == flow[i].Id)
                        {
                            Console.WriteLine($"ID: {flow[i].Id} - {flow[i].Name} | Color: {flow[i].Color}");
                            break;
                        }
                    }
                    Console.WriteLine("Enter new data:");
                    Console.Write("Name of Sort: ");
                    string sort = Console.ReadLine();
                    Console.Write("Color: ");
                    string color = Console.ReadLine();

                    db_obj.AddById(id, sort, color);
                }
                goto a;
            case 2:

                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"ID: {flow[i].Id} - {flow[i].Name} | Color: {flow[i].Color}");
                }
                goto a;
            case 3:
                Console.Write("Enter ID of flower: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine(db_obj.GetById(id).Name + " | " + db_obj.GetById(id).Color);
                goto a;
        }

    }
    else
    {
    a:
        Console.WriteLine("What do You want?");
        Console.WriteLine("1) Show all variety of flowers | 2) Find by ID ");
        Console.Write("Enter: ");
        int ans = int.Parse(Console.ReadLine());
        switch (ans)
        {
            case 1:

                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"ID: {flow[i].Id} - {flow[i].Name} | Color: {flow[i].Color}");
                }
                goto a;
            case 2:
                Console.Write("Enter ID of flower: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(db_obj.GetById(id).Name + " | " + db_obj.GetById(id).Color);
                goto a;
        }
    }
}
else 
{

    Console.WriteLine("Not found...");
}

Console.ReadKey();


