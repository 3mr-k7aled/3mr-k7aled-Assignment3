namespace CSharpBasicsAssignment;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== PART A: Project & Structure ===");

        Console.WriteLine("\n=== PART B: Variables, Types & Casting ===");

        RunTypesDemo();

        Console.WriteLine("\n=== PART C: Value vs Reference Types ===");

        RunValueVsReferenceDemo();
    }

    static void RunTypesDemo()
    {
        int age = 19;
        long population = 1000000000;
        double height = 170.5;
        decimal price = 99.99m;
        bool isStudent = true;
        char grade = 'A';
        string name = "Amr";
        var city = "Cairo";

        Console.WriteLine($"int: {age} - {age.GetType()}");
        Console.WriteLine($"long: {population} - {population.GetType()}");
        Console.WriteLine($"double: {height} - {height.GetType()}");
        Console.WriteLine($"decimal: {price} - {price.GetType()}");
        Console.WriteLine($"bool: {isStudent} - {isStudent.GetType()}");
        Console.WriteLine($"char: {grade} - {grade.GetType()}");
        Console.WriteLine($"string: {name} - {name.GetType()}");
        Console.WriteLine($"var: {city} - {city.GetType()}");

        int number = 50;
        long bigNumber = number;

        char letter = 'A';
        int letterCode = letter;

        Console.WriteLine($"int to long: {bigNumber}");
        Console.WriteLine($"char to int: {letterCode}");

        double decimalNumber = 9.8;

        int truncatedNumber = (int)decimalNumber;
        int roundedNumber = Convert.ToInt32(decimalNumber);
        Console.WriteLine($"Using (int): {truncatedNumber}");
        Console.WriteLine($"Using Convert.ToInt32: {roundedNumber}");

        int integerDivision = 5 / 2;
        double doubleDivision = 5.0 / 2;
        Console.WriteLine($"5 / 2 = {integerDivision}");
        Console.WriteLine($"5.0 / 2 = {doubleDivision}");

        int originalNumber = 42;

        object boxedNumber = originalNumber;
        Console.WriteLine($"After boxing: {boxedNumber}");

        int unboxedNumber = (int)boxedNumber;
        Console.WriteLine($"After unboxing: {unboxedNumber}");

        string validText = "42";
        int parsedNumber = int.Parse(validText);

        Console.WriteLine($"int.Parse result: {parsedNumber}");

        string invalidText = "abc";
        bool success = int.TryParse(invalidText, out int tryParsedNumber);

        Console.WriteLine($"TryParse succeeded: {success}");

        if (!success)
        {
            Console.WriteLine("TryParse failed because the input is not a valid integer.");
        }

        float floatNumber = 12.5f;

        decimal convertedDecimal = (decimal)floatNumber;

        Console.WriteLine($"float to decimal: {convertedDecimal}");

        Order o1 = new Order
        {
            OrderId = 1001,
            CustomerName = "Amr",
            Quantity = 3,
            UnitPrice = 100m,
            TotalPrice = 0m,
            IsPaid = false,
            DiscountPercent = 10,
            ShippingCity = "Cairo",
            Priority = 'H',
            ItemCode = 123456789
        };

        o1.CalculateTotal();

        Console.WriteLine($"o1 TotalPrice = {o1.TotalPrice}");

    }
    static void RunValueVsReferenceDemo()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;

        p2.X = 99;

        Console.WriteLine($"p1.X = {p1.X}");
        Console.WriteLine($"p2.X = {p2.X}");

    }

    struct Point
    {
        public int X;
        public int Y;
    }



}

class Order
{
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;

    public void CalculateTotal()
    {
        TotalPrice = Quantity * UnitPrice * (decimal)(1 - DiscountPercent / 100);
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Order ID: {OrderId}, Customer: {CustomerName}, Total: {TotalPrice}, Paid: {IsPaid}");
    }


}







// Part A - Project & Structure
// .csproj: contains project settings and configuration.
// Program.cs: contains the main C# code of the application.
// obj/: contains temporary files generated during the build process.
// bin/: contains the compiled files and the final application output.

// File-scoped namespace removes one level of indentation
// because we don't need to wrap the whole file inside braces.

// This project uses the classic .sln format.
// The newer .slnx format is more modern and uses a simpler XML-based structure.
