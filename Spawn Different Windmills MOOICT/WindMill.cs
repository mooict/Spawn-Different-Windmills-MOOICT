using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

// Made by MOO ICT
// For educational purpose only

namespace Spawn_Different_Windmills_MOOICT
{
    internal class WindMill
    {

        Random random = new Random();
        public int positionX;
        public int positionY;
        public int height;
        public int width;
        public Image windMill;


        public WindMill()
        {
            positionX = random.Next(10, 760);
            positionY = random.Next(10, 400);
            height = 50;
            width = 50;
            windMill = Properties.Resources.Windmill;
        }



    }
}
