using GamingDemo.Abstract;
using GamingDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerIfRealPerson(gamer) == true)
            {
                Console.WriteLine("Yeni oyuncu eklendi : " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Kayıt hatalı.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Bilgiler güncellendi : " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}