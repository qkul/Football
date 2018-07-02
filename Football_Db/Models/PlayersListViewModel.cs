using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Football_Db.Models
{
    public class PlayersListViewModel
    {
        public IEnumerable<Player> Players { get; set; }//список игроков
        public SelectList Teams { get; set; }//команд
        public SelectList Positions { get; set; }//позиций
        
    }
}