using GamingDemo.Abstract;
using GamingDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Concrete
{
    public class OrderManager : IOrderService
    {

        public void Sales(Game game, Gamer gamer, Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " - " + campaing.CompaingName + " kampanyası" + game.GameName + " isimli oyunu " + game.UnitPrice+ " Tl");
        }
    }
}