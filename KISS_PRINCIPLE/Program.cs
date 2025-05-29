class DiscountCalculator
{
    public double CalculateFinalPrice(double price, double discountRate)
    {
        return price - (price * discountRate);
    }
}

class Program
{
    static void Main()
    {
        var calculator = new DiscountCalculator();

        double goldPrice = calculator.CalculateFinalPrice(1000, 0.10);  // 10% off
        double silverPrice = calculator.CalculateFinalPrice(1000, 0.05); // 5% off
        double bronzePrice = calculator.CalculateFinalPrice(1000, 0.02); // 2% off

        Console.WriteLine($"Gold Price: {goldPrice}"); // Output: Gold Price: 900
        Console.WriteLine($"Silver Price: {silverPrice}"); // Output: Silver Price: 950
        Console.WriteLine($"Bronze Price: {bronzePrice}"); // Output: Bronze Price: 980
    }
}
