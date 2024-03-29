﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Aqua_Kursach
{
    public class GravityPoint : ImpactPoint
    {
        public int Power = 200; // сила притяжения

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX += gX * Power / r2;
            particle.SpeedY += gY * Power / r2;
        }
        public override void Render(Graphics g)
        {
           
        }
    }
}
