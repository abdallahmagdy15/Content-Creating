using System;

class LocalShopOrderProcessor : OrderProcessor
{
    protected override void AcceptOrder()
    {
        Console.WriteLine("Accepting order from the local shop's online system...");
    }

    protected override void CalculateEstimatedTime()
    {
        // Calculate based on local factors like current in-store orders, staff availability, etc.
        Console.WriteLine("Calculating estimated preparation time based on local shop's current workload...");
    }

    protected override void ProvideDirections()
    {
        // Use a local mapping service or integrate with a common service like Google Maps.
        Console.WriteLine("Providing directions using a local mapping service with real-time traffic information...");
    }

    protected override void ApplyPromotions()
    {
        // Apply promotions specific to the local shop.
        Console.WriteLine("Applying local daily promotions: 10% off for in-store pickup on Tuesdays.");
    }

    protected override void AcceptPayment()
    {
        // Local shops might offer specific payment methods popular in the area.
        Console.WriteLine("Accepting payment online or upon pickup with local payment options.");
    }

    protected override bool IsDeliveryAvailable()
    {
        // Assume local shops might not have a delivery service.
        return false;
    }
}
