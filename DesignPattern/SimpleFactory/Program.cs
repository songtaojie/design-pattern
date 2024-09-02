namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入数字A：");
                var stringNumberA = Console.ReadLine();
                Console.WriteLine("请输入运算符(+、-，*，/)：");
                var operate = Console.ReadLine();
                Console.WriteLine("请输入数字B：");
                var stringNumberB = Console.ReadLine();
                var operation = OperationFactory.CreateOperation(operate);
                operation.NumberA = Convert.ToDouble(stringNumberA);
                operation.NumberB = Convert.ToDouble(stringNumberB);
                var result =operation.GetResult();
                Console.WriteLine("运算结果为：" + result);
                Console.ReadLine();
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"输入参数有误：{ex.Message}");
            }
        }
    }
}
