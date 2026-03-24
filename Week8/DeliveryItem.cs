namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; protected set; }
    public double Weight { get; protected set; }
    
    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();
    
    

    public virtual void PrintInfo()
    {
        Console.WriteLine($"номере завмовлення: {TrackingNumber}, вага {Weight}");
    }
    
}