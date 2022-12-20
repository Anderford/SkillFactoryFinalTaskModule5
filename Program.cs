using System;
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)
    {

        ShowPerson(GetValues());

        static (string Name, string Firstname, int Age, bool HavePets, int NumberOfPets, string[] PetName, int NumOfFavColor, string[] FavColors) GetValues()
        {

            (string Name, string Firstname, int Age, bool HavePets, int NumberOfPets, string[] PetName, int NumOfFavColor, string[] FavColors) Person;

            Person.HavePets = false;
            Person.PetName = new string[0];
            Person.FavColors = new string[0];


            Console.WriteLine("Ваше имя");
            Person.Name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия");
            Person.Firstname = Console.ReadLine();

            do
            {
                Console.WriteLine("Ваш возраст");
                Person.Age = Convert.ToInt32(Console.ReadLine());
                if (Person.Age < 0 || Person.Age > 100)
                    Console.WriteLine("Ваш возраст (цифрами)");
            } while (Person.Age < 0 || Person.Age > 100);

            Console.WriteLine("Есть ли у вас питомец?");
            var Pets = (Console.ReadLine());
            
                if(Pets == "да")
                {
                    Person.HavePets = true;
                }

                else if(Pets == "нет")
                {
                    Person.HavePets = false;
                }

            if (Person.HavePets == true)
            {
                Console.WriteLine("Сколько у вас питомцев?");
                Person.NumberOfPets = Convert.ToInt32(Console.ReadLine());
                if(Person.NumberOfPets > 0 || Person.NumberOfPets < 100)
                {
                    Person.PetName = PersonPets(Person.NumberOfPets);
                }
            }

            else
            {
                Person.PetName = new string[0];
                Person.NumberOfPets = 0;
            }

            Console.WriteLine("Сколько у вас любимых цветов?");
            Person.NumOfFavColor = Convert.ToInt32(Console.ReadLine());
            if (Person.NumOfFavColor > 0 || Person.NumOfFavColor < 100)
            {
                Person.FavColors = PersonColor(Person.NumOfFavColor);
            }

            else
            {
                Person.FavColors = new string[0];
            }
            return Person;
        }

        static string[] PersonPets(int NumberOfPets)
        {

            var PetsName = new string[NumberOfPets];

            for (int i = 0; i < NumberOfPets; i++)
            {
               
                Console.WriteLine($"Кличка {i + 1} питомца");
                PetsName[i] = Console.ReadLine();

                
            }
            return PetsName;
        }

        static string[] PersonColor(int NumOfFavColor)
        {
            var FavColors = new string[NumOfFavColor];

            for (int i = 0; i < NumOfFavColor; i++)
            {
                Console.WriteLine($"{i + 1}-й цвет");
                FavColors[i] = Console.ReadLine();
            }
            return FavColors;
        }
        
        static  void ShowPerson((string Name, string Firstname, int Age, bool HavePets, int NumberOfPets, string[] PetName, int NumOfFavColor, string[] FavColors) Person)
        {
            Console.WriteLine($"Вас зовут {Person.Name} {Person.Firstname} \nВам {Person.Age}");

            Console.Write("Ваши питомцы: ");
            foreach (var pet in Person.PetName)
            {
                Console.Write(pet + ", ");            
            }

            Console.WriteLine();

            Console.Write("Ваши любимые цвета: ");
            foreach (var color in Person.FavColors)
            {
                Console.Write(color + ", ");
            }
        }
    }
}


