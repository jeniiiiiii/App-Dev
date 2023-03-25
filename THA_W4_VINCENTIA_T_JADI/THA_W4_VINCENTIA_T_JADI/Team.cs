using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static THA_W4_VINCENTIA_T_JADI.Form1;

namespace THA_W4_VINCENTIA_T_JADI
{
    public class team
    {

        public string teamname { get; set; }
        public string teamcountry { get; set; }
        public string teamcity { get; set; }

        private List<Player> players = new List<Player>();


        public void addplayer(string playernum, string playername, string playerpos)
        {
            var player = new Player
            {
                playernum = playernum,
                playername = playername,
                playerpos = playerpos
            };
            players.Add(player);

        }

        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }
    }
}
