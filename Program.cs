using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GamerManager gamerManager = new GamerManager(new UserValidationManager()); // kimlik doğrulamasını bağladığımız için bunu belirtmemiz gerekiyor.
            
            Gamer gamer1 = new Gamer();
            gamer1.Id= 1;
            gamer1.FirstName = "Edanur";
            gamer1.LastName = "Yazıcı";
            gamer1.DateOfBirth = 2001;
            gamer1.IdentityNumber = 69082090644;

            Gamer gamer2= new Gamer();
            gamer2.Id= 2;
            gamer2.FirstName = "Buğra";
            gamer2.LastName = "Çetinkaya";
            gamer2.DateOfBirth = 2002;
            gamer2.IdentityNumber = 12345678901;

            gamerManager.Add(gamer2);
            
            Game game1= new Game();
            game1.GameId= 1;
            game1.GameName = "Sims";
            game1.GamePrice = 100;

            Game game2= new Game();
            game2.GameId= 2;
            game2.GameName = "Valorant";
            game2.GamePrice = 70;

            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.Sale(gamer2, game2);

          
            Console.ReadLine();
            
        }
    }
}
