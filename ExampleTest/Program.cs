using ExampleTest.AbstractFactory;
using ExampleTest.Builder;
using ExampleTest.FactoryMethod;
using ExampleTest.Prototype;
using ExampleTest.Singleton;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTest
{
    class MyClass
    {
        public bool MyProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Factory Method
            //Developer developer = new PanelDeveloper("Панельный строитель!");
            //Console.WriteLine(developer.Name);
            //House panelHouse = developer.Create();


            //developer = new WoodDeveloper("Деревянный строитель!");
            //Console.WriteLine(developer.Name);
            //House woodHouse = developer.Create();


            //Abstract Factory
            //Hero elf = new Hero(new ElfFactory());
            //elf.Hit();
            //elf.Run();

            //Hero voin = new Hero(new VoinFactory());
            //voin.Hit();
            //voin.Run();


            ////Singleton
            //Computer comp = new Computer();
            //comp.Launch("Windows 8.1");
            //Console.WriteLine(comp.OS.Name);

            //// у нас не получится изменить ОС, так как объект уже создан    
            //comp.OS = OS.getInstance("Windows 10");
            //Console.WriteLine(comp.OS.Name);


            //Prototype
            //IFigure figure = new Rectangle(30, 40);
            //IFigure clonedFigure = figure.Clone();
            //figure.GetInfo();
            //clonedFigure.GetInfo();

            //figure = new Circle(30);
            //clonedFigure = figure.Clone();
            //figure.GetInfo();
            //clonedFigure.GetInfo();



            //Builder
            // содаем объект пекаря
            //Baker baker = new Baker();
            //// создаем билдер для ржаного хлеба
            //BreadBuilder builder = new RyeBreadBuilder();
            //// выпекаем
            //Bread ryeBread = baker.Bake(builder);
            //Console.WriteLine(ryeBread.ToString());
            //// cоздаем билдер для пшеничного хлеба
            //builder = new WheatBreadBuilder();
            //Bread wheatBread = baker.Bake(builder);
            //Console.WriteLine(wheatBread.ToString());

            //Console.ReadKey();
        }
        //  enum Colors { Red, Green, Blue, Yellow };
    }
}
