using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;


  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Price <= macPrice);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);  //make new instance of car
    Car yugo = new Car("1980 Yugo Koral", 700, 56000);  //make new instance of car
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001);  //make new instance of car
    Car amc = new Car("1976 AMC Pacer", 400, 198000);  //make new instance of car

    List<Car> CarList = new List<Car>();
    CarList.Add(volkswagen);
    CarList.Add(yugo);
    CarList.Add(ford);
    CarList.Add(amc);

    foreach (Car i in CarList)
    {
      Console.WriteLine(i.MakeModel + ", " + i.Price + ", " + i.Miles);
    }
  }

  // public showCars(e){
  //   foreach(Car i in e){
  //     Console.WriteLine(i);
  //   }
  // }

}