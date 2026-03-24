namespace Week8;

class Program
{
    static void Main(string[] args)
    {
        Letter letter1 = new Letter("123fsdf", 123);
        Letter letter2 = new Letter("jhsofdigsdfg", 9999999);
        Letter letter3 = new Letter("tuda", 123123);
        Parcel parcel1 = new Parcel("su'da", 8080808, "30x100x150");
        Parcel parcel2 = new Parcel("kuda", 6666, "77x77x77");
        
        letter1.PrintInfo();
        parcel1.PrintInfo();
        
        CargoContainer<DeliveryItem> MyCargo = new CargoContainer<DeliveryItem>();
        
        MyCargo.AddItem(letter1);
        MyCargo.AddItem(letter2);
        MyCargo.AddItem(letter3);
        MyCargo.AddItem(parcel1);
        MyCargo.AddItem(parcel2);

        double total = MyCargo.GetTotalCost();
        Console.WriteLine(total);





    }
}