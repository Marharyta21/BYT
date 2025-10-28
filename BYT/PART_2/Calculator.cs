namespace BYT


{
    public class Calculator
    {
        public double A { get; }
        public double B { get; }
        public string Operation { get; }

        public Calculator(double a, double b, string operation)
        {
            A = a;
            B = b;
            Operation = operation;
        }

        public double Calculate()
        {
            switch (Operation)
            {
                case "+":
                    return A + B;
                case "-":
                    return A - B;
                case "*":
                    return A * B;
                case "/":
                    if (B == 0)
                        throw new DivideByZeroException("Cannot divide by zero");
                    return A / B;
                default:
                    throw new ArgumentException($"Invalid operation: {Operation}");
            }
        }
    }
}