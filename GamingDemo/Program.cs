using GamingDemo.Concrete;
using GamingDemo.Entity;
using System;

namespace GamingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Fikriye";
            gamer1.LastName = "Barut";
            gamer1.DateOfBirth = new DateTime(2000, 3, 22);
            gamer1.NationalityId = "123";

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer1);

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Araba Oyunu";
            game1.UnitPrice = 150;


            Campaing campaing1 = new Campaing();
            campaing1.Id = 1;
            campaing1.CompaingName = "%70 indirim";

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaing1);

            OrderManager orderManager = new OrderManager();
            orderManager.Sales(game1, gamer1, campaing1);
        }
    }
}
