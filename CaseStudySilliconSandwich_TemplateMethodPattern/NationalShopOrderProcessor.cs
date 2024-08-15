using System;

class NationalShopOrderProcessor : OrderProcessor
{
    protected override void AcceptOrder()
    {
        Console.WriteLine("Accepting order from the national website or mobile app...");
    }

    protected override void CalculateEstimatedTime()
    {
        // Calculate based on broader factors, like regional demand.
        Console.WriteLine("Calculating estimated preparation time considering nationwide order volume...");
    }

    protected override void ProvideDirections()
    {
        // Likely to use a national or global mapping service with integrated traffic data.
        Console.WriteLine("Providing directions using a national mapping service with traffic integration...");
    }

    protected override void ApplyPromotions()
    {
        // Apply promotions that are available across all national franchises.
        Console.WriteLine("Applying national daily promotions: Free delivery on orders over $50.");
    }

    protected override void AcceptPayment()
    {
        // National franchises might support a broader range of payment methods, including online and mobile payments.
        Console.WriteLine("Accepting payment online, in person, or upon delivery with various national payment methods.");
    }

    protected override bool IsDeliveryAvailable()
    {
        // Assume all national shops offer delivery.
        return true;
    }
}
