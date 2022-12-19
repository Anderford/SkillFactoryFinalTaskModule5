using System;

class MainClass
{
    public static void Main(string[] args)
    {

        GetValues();

        static void GetValues()
        {

            (string Name, 
             string Firstname, 
             int Age,
             bool Pets
             ) Person;


            Console.WriteLine("Ваше имя");
            Person.Name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия");
            Person.Firstname = Console.ReadLine();

            do
            {
                Console.Write("Ваш возраст");
                Person.Age = Convert.ToInt32(Console.ReadLine());
                if (!InputExam(Person.Age))
                    Console.WriteLine("Ваш возраст (цифрами)");
            } while (!InputExam(Person.Age));


            Console.WriteLine($"{Person.Name} {Person.Firstname} {Person.Age}");
        }






        static bool InputExam(int number)
        {
            return (number > 0 && number < 100);
        }
        

    }
}


