using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rascal.PlayerClasses {

    class Player {

        Stats stats = new Stats();
        public string name;
        public string title;

        string[] titles = new string[] { "Ye Earl of Canderburn", "The Oaken Soldier", "The Sneaky One", "Rodent Lover", "King of Slimes", "The Promised One", "Master of Thieves"};
        string[] names = new string[] { "Carl", "Derrick", "Jaco", "Kieran", "Dan"};

        public Player() {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            name = names[rand.Next(0, names.Length)];
            title = titles[rand.Next(0, titles.Length)];
        }

        public Stats GetStats() {
            return stats;
        }

    }
}
