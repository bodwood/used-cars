using System;
using System.Collections.Generic;

public class Car                  //constructor class
{
  public string MakeModel;
  public int Price;
  public int Miles;
}

public class Program
{
  public static void Main(){
    Car volkswagen = new Car();  //make new instance of car
    volkswagen.MakeModel = "1974 Volkswagen Thing";
    volkswagen.Price = 1100;
    volkswagen.Miles = 368792;

    Car yugo = new Car();  //make new instance of car
    yugo.MakeModel = "1980 Yugo Koral";
    yugo.Price = 700;
    yugo.Miles = 56000;

    Car ford = new Car();  //make new instance of car
    ford.MakeModel = "1988 Ford Country Squire";
    ford.Price = 1400;
    ford.Miles = 239001;

    Car amc = new Car();  //make new instance of car
    amc.MakeModel = "1976 AMC Pacer";
    amc.Price = 400;
    amc.Miles = 198000;

    List<Car> CarList = new List<Car>();
    CarList.Add(volkswagen);
    CarList.Add(yugo);
    CarList.Add(ford);
    CarList.Add(amc);

    foreach(Car i in CarList){
      Console.WriteLine(i.MakeModel + ", " + i.Price + ", " + i.Miles);
    }
  }

  // public showCars(e){
  //   foreach(Car i in e){
  //     Console.WriteLine(i);
  //   }
  // }
}