using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PlayerRepo
    {
        private List<Player> _players = new List<Player>();

        public PlayerRepo()
        {
            
        }

        public List<Player> GetAllPlayers(Player p)
        {
            return _players;
        }
        

        public void AddPlayer(Player p)
        {

            //throw new NotImplementedException();
        }
    }
}
