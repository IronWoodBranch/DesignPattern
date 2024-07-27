using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.SubSystem
{
    internal class Player
    {
        public void play(Movie movie)
        {
            Console.WriteLine($"play 《{movie.name}》");
        }
    }
}
