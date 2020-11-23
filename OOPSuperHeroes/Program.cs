using System;

namespace OOPSuperHeroes
{
    class Program
    {

        class Player
        {
            string name;
            int hp;
            private string _name;



            public Player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }





            public void SayHello()
            {

                Console.WriteLine($"{name} says hello");
            }

            public void ShowYourHP()
            {
                Console.WriteLine($"{name}'s HP: {hp}");
            }

            public int MakeDamage()
            {

                Random rnd = new Random();
                return rnd.Next(10, 51);
            }




            public void TakeDamage(int damage)
            {
                if (hp <= 0)
                {
                    hp = 0;

                }
                else
                {
                    hp = hp - damage;
                }
            }

            public int HP 
            {
                get { return hp; }
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Name your first character: ");
            Console.WriteLine("Name your second character: ");
            string characterNameTwo = Console.ReadLine();
            string characterNameOne = Console.ReadLine();
            Player playerOne = new Player(characterNameOne);
            Player playerTwo = new Player(characterNameTwo);
            playerOne.SayHello();
            playerOne.ShowYourHP();
            playerTwo.SayHello();
            playerTwo.ShowYourHP();

            for(int i = 0; i < 3; i++)
            {
                playerOne.TakeDamage(playerTwo.MakeDamage());
                playerTwo.TakeDamage(playerOne.MakeDamage());
                playerOne.ShowYourHP();
                playerTwo.ShowYourHP();
            }

            if (playerOne.HP > playerTwo.HP)
            {
                Console.WriteLine("Player One won!");
            } else
            {
                Console.WriteLine("It's a tie!");
            }

            Console.WriteLine($"Player one hit {playerOne.MakeDamage()}");
        }
    }
}
