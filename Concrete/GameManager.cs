using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
  public  class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("New game added to db :" + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted from db :" + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated :" + game.GameName);
        }

        public static implicit operator GameManager(Campaign v)
        {
            throw new NotImplementedException();
        }
    }
}
