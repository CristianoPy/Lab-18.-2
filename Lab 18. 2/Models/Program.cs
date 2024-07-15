using Lab_18._2.Data;
using Lab_18._2.Models;
using Microsoft.EntityFrameworkCore;

//Seed();
static void Seed()
{
    using var ctx = new ShopCarsDbCtx();

    var ford = new Manufacturer()
    {
        Name = "Ford",
        Adress = "Usa"
    };

    var bmw = new Manufacturer()
    {
        Name = "BMW",
        Adress = "Germany"
    };

    var landrover = new Manufacturer()
    {
        Name = "Land Rover",
        Adress = "England"
    };

    ctx.Add(ford);
    ctx.Add(bmw);
    ctx.Add(landrover);

    var c1 = new Car
    {
        Name = "Transit",
        Manufacturer = ford,
        Manual = new Manual { Cc = 2100, Year = 2021, Rn = Guid.NewGuid().ToString() }
    };

    var c2 = new Car
    {
        Name = "F-50",
        Manufacturer = ford,
        Manual = new Manual { Cc = 3200, Year = 2023, Rn = Guid.NewGuid().ToString() }
    };

    var c3 = new Car
    {
        Name = "X7",
        Manufacturer = bmw,
        Manual = new Manual { Cc = 2500, Year = 2022, Rn = Guid.NewGuid().ToString() }
    };

    var c4 = new Car
    {
        Name = "I.8",
        Manufacturer = bmw,
        Manual = new Manual { Cc = 2200, Year = 2024, Rn = Guid.NewGuid().ToString() }
    };

    var c5 = new Car
    {
        Name = "Range Rover",
        Manufacturer = landrover,
        Manual = new Manual { Cc = 2100, Year = 2021, Rn = Guid.NewGuid().ToString() }
    };

    var c6 = new Car
    {
        Name = "Defender",
        Manufacturer = landrover,
        Manual = new Manual { Cc = 2500, Year = 2010, Rn = Guid.NewGuid().ToString() }
    };

    ctx.Add(c1);
    ctx.Add(c2);
    ctx.Add(c3);
    ctx.Add(c4);
    ctx.Add(c5);
    ctx.Add(c6);
    ctx.SaveChanges();

    static void RemoveCar(int Id)
    {
        using var ctx = new ShopCarsDbCtx();

        var car = ctx.cars.Include(c => c.Keys)
            .FirstOrDefault(c => c.Id == Id);

        if (car == null)
        {
            throw new InvalidCastException($"Car´s Id is invalid{Id}");
        }

        car.Keys.ForEach(c => c.CarId = null);
    }
    ctx.Remove(c4);
    ctx.SaveChanges();

    static void RemoveManufacturer(int Id)
    {
        using var ctx = new ShopCarsDbCtx();

        var manufacturer = ctx.Manufacturers.Include(m => m.Cars).
            FirstOrDefault(m => m.Id == Id);

        if(manufacturer == null)
        {
            throw new InvalidCastException($"Manufacturer´s Id is invalid{Id}");
        }

        manufacturer.Cars.ForEach(c => c.Manufacturer = null);
        ctx.Remove(manufacturer); 
        ctx.SaveChanges();
    }
}