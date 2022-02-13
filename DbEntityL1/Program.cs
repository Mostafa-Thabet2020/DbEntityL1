// See https://aka.ms/new-console-template for more information


using DbEntityL1.Models;
using DbEntityL1;

EntityDbContext dbContext = new EntityDbContext();


for (; ; )
{
    //CRUD => Create,Read,Update,Delete

    Console.WriteLine($"Choose action\n" +
        $"\nfor create enter 1" +
        $"\nfor delete enter 2" +
        $"\nfor update enter 3" +
        $"\nfor get all enter 4" +
        $"\nfor get object 5");
    int ActionNumber = Convert.ToInt32(Console.ReadLine());
    switch (ActionNumber)
    {
        case 1:
            Book book = new Book();
            Console.WriteLine("write book name:");
            book.Name = Console.ReadLine();
            Console.WriteLine("Descriptation");
            book.Descriptation = Console.ReadLine();
            dbContext.books.Add(book);
            dbContext.SaveChanges();
            break;

        case 2:
            Console.WriteLine("write book id");
            int BookId = Convert.ToInt32(Console.ReadLine());
            Book DeletedBook = dbContext.books.Find(BookId);
            dbContext.books.Remove(DeletedBook);
            dbContext.SaveChanges();
            break;

        case 3:
            Console.WriteLine("write book id");
            int UpdatedBookId = Convert.ToInt32(Console.ReadLine());
            Book UpdatedBook = dbContext.books.Where(x => x.Id == UpdatedBookId).SingleOrDefault();
            Console.WriteLine("enter new name:");
            UpdatedBook.Name = Console.ReadLine();
            Console.WriteLine("Enter descripation");
            UpdatedBook.Descriptation = Console.ReadLine();
            dbContext.books.Update(UpdatedBook);
            dbContext.SaveChanges();
            break;

        case 4:
            List<Book> books = dbContext.books.ToList();
            foreach (Book item in books)
            {
                Console.WriteLine($"{item.Id}: {item.Name}\nDescriptation: {item.Descriptation}");
            }
            break;
        case 5:
            Console.WriteLine("enter book id");
            int BookIdGet = Convert.ToInt16(Console.ReadLine());
            Book bookObj= dbContext.books.Find(BookIdGet);
            Console.WriteLine($"Id:{bookObj.Id}\nBook name: {bookObj.Name}\nDescipation: {bookObj.Descriptation}");
            break;

        default:
            break;
    }



    Console.WriteLine("Do you want to take any action?\n y or n");
    string Result = Console.ReadLine();
    if (Result == "n") { break; }

}
