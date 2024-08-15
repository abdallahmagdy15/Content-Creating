using System;

abstract class OrderProcessor
{
    public void ProcessOrder()
    {
        AcceptOrder();
        CalculateEstimatedTime();
        ProvideDirections();
        ApplyPromotions();
        AcceptPayment();
        PrepareSandwich();

        if (IsDeliveryAvailable())
        {
            DispatchDelivery();
        }
        else
        {
            NotifyPickupReady();
        }
    }

    // Abstract methods that must be implemented by subclasses.
    protected abstract void AcceptOrder();
    protected abstract void CalculateEstimatedTime();
    protected abstract void ProvideDirections();
    protected abstract void ApplyPromotions();
    protected abstract void AcceptPayment();

    // Optional method that can be overridden by subclasses.
    protected virtual void PrepareSandwich()
    {
        Console.WriteLine("Preparing the sandwich...");
    }

    protected abstract bool IsDeliveryAvailable();

    // Optional method for dispatching delivery, can be overridden.
    protected virtual void DispatchDelivery()
    {
        Console.WriteLine("Dispatching the driver for delivery...");
    }

    protected virtual void NotifyPickupReady()
    {
        Console.WriteLine("Notifying the customer that the sandwich is ready for pickup.");
    }
}
