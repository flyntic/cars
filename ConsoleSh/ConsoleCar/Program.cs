// See https://aka.ms/new-console-template for more information

using ConsoleSh;


Car C = new Lorry() {Marka = "Приора Груз", Weight = 500, CarClass = "грузовой", Carrying = 5000,
                     Driver = new Driver {Name="Иван",LastName = "Иванов",Birthday = DateTime.Parse("1.2.2005"),DateGetRights = DateTime.Parse("1.2.2021")} , 
                     Engine = new Engine {Company = "Тойота", Power = 200}};
Console.WriteLine(C);

Car S = new SportCar() {Marka = "Приора Спорт", Weight = 500, CarClass = "легковой", Speed = 500,
                        Driver = new Driver {Name="Иван",LastName = "Ливанов",Birthday = DateTime.Parse("1.2.2001"),DateGetRights = DateTime.Parse("1.2.2019")} , 
                        Engine = new Engine {Company = "Тойота", Power = 200}};

Console.WriteLine(S);
