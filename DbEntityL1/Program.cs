// See https://aka.ms/new-console-template for more information


using DbEntityL1.Models;
using DbEntityL1;
using DbEntityL1.Service;

//EntityDbContext dbContext = new EntityDbContext();


for (; ; )
{
    //CRUD => Create,Read,Update,Delete

    //Console.WriteLine($"Choose action\n" +
    //    $"\nfor create enter 1" +
    //    $"\nfor delete enter 2" +
    //    $"\nfor update enter 3" +
    //    $"\nfor get all enter 4" +
    //    $"\nfor get object 5");
    //int ActionNumber = Convert.ToInt32(Console.ReadLine());
    //switch (ActionNumber)
    //{
    //    case 1:
    //        Book book = new Book();
    //        Console.WriteLine("write book name:");
    //        book.Name = Console.ReadLine();
    //        Console.WriteLine("Descriptation");
    //        book.Descriptation = Console.ReadLine();
    //        dbContext.books.Add(book);
    //        dbContext.SaveChanges();
    //        break;

    //    case 2:
    //        Console.WriteLine("write book id");
    //        int BookId = Convert.ToInt32(Console.ReadLine());
    //        Book DeletedBook = dbContext.books.Find(BookId);
    //        dbContext.books.Remove(DeletedBook);
    //        dbContext.SaveChanges();
    //        break;

    //    case 3:
    //        Console.WriteLine("write book id");
    //        int UpdatedBookId = Convert.ToInt32(Console.ReadLine());
    //        Book UpdatedBook = dbContext.books.Where(x => x.Id == UpdatedBookId).SingleOrDefault();
    //        Console.WriteLine("enter new name:");
    //        UpdatedBook.Name = Console.ReadLine();
    //        Console.WriteLine("Enter descripation");
    //        UpdatedBook.Descriptation = Console.ReadLine();
    //        dbContext.books.Update(UpdatedBook);
    //        dbContext.SaveChanges();
    //        break;

    //    case 4:
    //        List<Book> books = dbContext.books.ToList();
    //        foreach (Book item in books)
    //        {
    //            Console.WriteLine($"{item.Id}: {item.Name}\nDescriptation: {item.Descriptation}");
    //        }
    //        break;
    //    case 5:
    //        Console.WriteLine("enter book id");
    //        int BookIdGet = Convert.ToInt16(Console.ReadLine());
    //        Book bookObj= dbContext.books.Find(BookIdGet);
    //        Console.WriteLine($"Id:{bookObj.Id}\nBook name: {bookObj.Name}\nDescipation: {bookObj.Descriptation}");
    //        break;

    //    default:
    //        break;
    //}
    Console.WriteLine("Chouse your action\n" +
        "\n1 for add" +
        "\n2 for update" +
        "\n3 for delete" +
        "\n4 for get" +
        "\n5 for get all");
    int Action = Convert.ToInt32(Console.ReadLine());
    NationalityService nationalityService = new NationalityService();
    Nationality nationality = new Nationality();
    switch (Action)
    {
        case 1:
            Console.WriteLine("Insert nationality name: ");
            nationality.Name = Console.ReadLine();
            nationalityService.Add(nationality);
            break;
        case 2:
            Console.WriteLine("Nationality id:");
            nationality.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter nationality new name:");
            nationality.Name = Console.ReadLine();
            nationalityService.Update(nationality);
            break;
        case 3:
            Console.WriteLine("Nationality Id:");
            int Id = Convert.ToInt32(Console.ReadLine());
            nationalityService.Delete(Id);
            break;
        case 4:
            Console.WriteLine("Nationality id");
            int DeletedId = Convert.ToInt32(Console.ReadLine());
            nationality= nationalityService.Get(DeletedId);
            Console.WriteLine($"Nationality details{nationality.Id}. {nationality.Name}" +
                $"\nCreated Date {nationality.CreatedDate}" +
                $"\nLast modified {nationality.LastModified}");
            break;
        case 5:
            List<Nationality> nationalities = nationalityService.Get();
            foreach (Nationality item in nationalities)
            {
                Console.WriteLine($"{item.Id}. {item.Name}\n" +
                    $"Created date: {item.CreatedDate}");
            }
            break;
        default:
            break;
    }

    Console.WriteLine("Do you want to take any action?\n y or n");
    string Result = Console.ReadLine();
    if (Result == "n") { break; }

}
