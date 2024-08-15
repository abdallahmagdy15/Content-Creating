using System;

class Program
{
    static void Main()
    {
        // Processing an order for a local franchise
        OrderProcessor localOrderProcessor = new LocalShopOrderProcessor();
        localOrderProcessor.ProcessOrder();

        Console.WriteLine("\n---\n");

        // Processing an order for a national franchise
        OrderProcessor nationalOrderProcessor = new NationalShopOrderProcessor();
        nationalOrderProcessor.ProcessOrder();

        Console.WriteLine("\n---\n");

        // Processing an order for an international franchise
        OrderProcessor internationalOrderProcessor = new InternationalShopOrderProcessor();
        internationalOrderProcessor.ProcessOrder();
    }
}
