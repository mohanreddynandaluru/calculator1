namespace calculator1{
    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            add.doAddition(5, 10);

            Subtraction sub = new Subtraction();
            sub.doSubtraction(20, 10);

            Multiplication mult = new Multiplication();
            mult.doMultiplication(20, 10);
        }

    }
}