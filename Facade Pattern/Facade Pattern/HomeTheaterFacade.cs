using Facade_Pattern.SubSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    internal class HomeTheaterFacade
    {
        public Player player { get; set; }
        public Radio radio { get; set; }
        public Screen screen { get; set; }

        public HomeTheaterFacade(Player player, Radio radio,Screen screen)
        {
            this.player = player;
            this.radio = radio;
            this.screen = screen;
        }

        public void playMovie(Movie movie)
        {
            Console.WriteLine("playing movie");
            radio.VolunmUp();
            screen.down();
            player.play(movie);

        }
        public void endMovie()
        {
            Console.WriteLine("end movie");
            radio.VolunmDown();
            screen.up();

        }
    }
}
