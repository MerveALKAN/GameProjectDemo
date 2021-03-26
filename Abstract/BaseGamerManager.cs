using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Saved to db :" + gamer.FirstName);
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Removed to db :" + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated to db :" + gamer.FirstName);
        }
    }
}
