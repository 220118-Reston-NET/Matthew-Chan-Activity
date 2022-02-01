using OOPFunction;
using MoreConversionFunction;

//Initialized Collection class
Collection collect = new Collection();
collect.CollectionMain();

Conversion.ConversionMain();

Console.WriteLine("===Static Demo===");
Conversion._num = 10;
Conversion conv1 = new Conversion();
Conversion conv2 = new Conversion();

Console.WriteLine(conv1.GiveMeNumber());
Console.WriteLine(conv2.GiveMeNumber());

Conversion._num = 200;

Console.WriteLine(conv1.GiveMeNumber());
Console.WriteLine(conv2.GiveMeNumber());

Serialization.SerialMain();


OOP.OOPMain();