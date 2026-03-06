using Calculator1;

namespace calculator1{
    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            add.DoAddition(5, 10);

            Subtraction sub = new Subtraction();
            sub.DoSubtraction(20, 10);

            Multiplication mult = new Multiplication();
            mult.DoMultiplication(20, 10);
        }

    }
}