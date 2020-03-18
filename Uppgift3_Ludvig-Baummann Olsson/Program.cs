using System;
using System.Collections.Generic;

namespace Uppgift3_Ludvig_Baummann_Olsson
{
    class Program
    {
        static void Main(string[] args)
        {

        //det går ej att komma åt personens privata egenskaper, istället går man igenom de publika getsen och setsen
        //Person p = new Person();
        //p.Age = 30;

        //3.2 Arv
        //F-8: Det är i Bird som vi bör göra ändringar eller lägga till attribut som ska påverka alla typers av birds.
        //F-9: Om alla djur behöver ett nytt attribut eller någon ändring så bör det läggas in i Animal klassen.

        //3.3 polymorfism
        //F-7: Man kan inte lägga in hästar i hund listan för att häst klassen inte ärver från hund klassen.
        //F-8: Både hundar och hästar ärver från animal, däför kan dem båda finnas i en animal lista.

        //F-11: foreach loopen går igenom varje objekt som finns i listan och kör metoden Stats() på objekten.
        // Metoden Stats() sätter ihop och returnerar en string text,
        //baserat på vad för värden objektets properties har.

        //F-15: Nej, man kommer inte åt metoden i animal.
        // Det är för att animal klassen inte har tillgång till metoden.
        // Om det är ett animal objekt som är av typen dog i listan,
        // så måste man först casta från animal klassen till dog klassen,
        // då får man tillgång till metoden i objektet.

        //3.4 Polymorfism

        //F-11-12: Jag skulle säga att polymorfism är viktigt att kunna just för att det används väldigt
        // ofta i dem flesta programmerings APIer eller kodbaser man kommer stötta på.
        // Det används specifikt för att kunna återanvända gränsnittet som redan är byggt,
        // fast på olika sätt beroende på kontexten man arbetar i.
        // Som ett exempel så kan man ha ett objekt med en metod vid namn "virtual void AddStat(var Input)"
        // som kan återanvändas genom override för samtliga variabel typer som man kan tänka sig är en "Stat".
        // Vilket gör att man inte behöver göra fler än en metod signatur, som exempel AddStatString(), AddStatInt()...
        // Genom att återanvända samma metod singatur med hjälp av polymorfism,
        // så kan man med hjälp av system som visual studios intellisense,
        // direkt se alla olika typer av input som AddStat() kan ta.
        // Kortsagt, polymorfism gör koden mer strukturedard och läsbar genom återanvänding av signaturer,
        // därför är det viktigt att kunna.

        //F-13: En markant skillnad är att ett objekt kan bara ärva fån en abstrakt klass,
        // men kan däremot ärva från ett flertal olika interfaces.

            PersonHandler ph = new PersonHandler();

            ph.SavePerson(ph.CreatePerson(30, "kalle", "grön", 150.5, 60.5));
            ph.SavePerson(ph.CreatePerson(15, "jenny", "blå", 140.5, 50.5));
            ph.SavePerson(ph.CreatePerson(60, "jens", "röd", 170.5, 80.5));
            ph.SavePerson(ph.CreatePerson(40, "gustav", "gul", 160.5, 70.5));

            Console.WriteLine(ph.GetAllSavedPersonsToString());

            
            List<Animal> animals = new List<Animal>() 
            {
            new Horse("Chestnut horse",100,20,true),
            new Flamingo("Pink flamingo",6,10,30),
            new Hedgehog("Blue hedgehog",2,15,1000),
            new Dog("Black pug",5,8,false)
            };

            Console.WriteLine("------------------Animal List------------------");
            foreach (var anim in animals)
            {
                Console.WriteLine(anim.Stats());

                if (anim is Dog tempDog)
                {
                    Console.WriteLine(tempDog.Bark());
                }
                
            }

           
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Brown pug",5,8,false),
                new Dog("Spotty bulldog",10,10,true),
                new Dog("Tan shiba",7,4,false),
                new Dog("Wite poodle",5,9,true)
            };

            Console.WriteLine("------------------Dog List------------------");         
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Stats());
            }

            List<UserError> errors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new CharInputError(),
                new DoubleInputError(),
                new PersonInputError()
            };

            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
