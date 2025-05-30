namespace CoffeeDecorator
{
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return $"Simple Coffee";
        }

        public double GetCost()
        {
            return 5.0;
        }
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription()
        {

            return _coffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }
    }

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {

            return _coffee.GetDescription() + " with Milk";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 1.5;
        }
    }

    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " with Sugar";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.5;
        }
    }
}