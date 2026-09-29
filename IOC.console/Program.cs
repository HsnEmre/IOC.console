using IOC.console;

Console.WriteLine("Hello, World!");

BL bl = new BL(new DAL());
//BL bl = new BL(new OracleDAL());
bl.GetProducts().ForEach(x =>
{
    Console.WriteLine($"{x.ID}-{x.Name}-{x.Price}-{x.Stock}");
});


Console.ReadLine();