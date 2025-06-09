public class Database
{
    static Database database;
    private Database()
    {
        Console.WriteLine("New database connection created..");
    }

    public static Database getInstance()
    {
        if (database == null)
        {
            database = new Database();
        }
        return database;
    }

    public void Query(string query)
    {
        Console.WriteLine($"Running query: {query}");
    }

}

public class UserService
{
    public void GetUser()
    {
        var db = Database.getInstance();
        db.Query("SELECT * FROM users");
        Console.WriteLine("Getting users data..");
    }
}

public class ProductService
{
    public void GetProduct()
    {
        var db = Database.getInstance();
        db.Query("SELECT * FROM products");
        Console.WriteLine("Getting products data..");
    }
}

class Program
{
    static void Main(String[] args)
    {
        UserService userservice = new UserService();
        userservice.GetUser();
        /*
            Output: New database connection created..
            Output: Running query: SELECT * FROM users
            Output: Getting users data..
        */

        ProductService productService = new ProductService();
        productService.GetProduct();
        /*
            Output: Running query: SELECT * FROM products
            Output: Getting products data..
        */
    }
}