namespace MathServiceConsumer
{

    public static class Program
    {
        public static void Main()
        {   
            var mathServiceSoap = new MathService.MathServiceSoapClient(MathService.MathServiceSoapClient.EndpointConfiguration.MathServiceSoap12);

            Console.WriteLine("2 + 4 = {0}", mathServiceSoap.Add(2, 4));
            Console.WriteLine("6 - 4 = {0}", mathServiceSoap.Subtract(6, 4));
            Console.WriteLine("2 * 4 = {0}", mathServiceSoap.Multiply(2, 4));
            Console.WriteLine("2 / 0 = {0}", mathServiceSoap.Divide(2, 0));
        }
    }
}
