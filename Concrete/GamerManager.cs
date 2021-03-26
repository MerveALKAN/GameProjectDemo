using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public new void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("New Gamer" + gamer.FirstName + "Added to db");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        public new void Remove(Gamer gamer)
        {
            Console.WriteLine("Gamer removed from db");
        }

        public void Update(GamerManager gamer)
        {
            Console.WriteLine("Gamer's data updated");
        }
    }
}
