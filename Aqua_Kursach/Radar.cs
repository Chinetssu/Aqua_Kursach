using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace Aqua_Kursach
{
    public class Radar : ImpactPoint, IDynamic
    {
        public bool existance;
        public float Radius;
        public float RadiusMax;
        public float LifeMax;
        public float Life;
        public int counter;

        public Radar(float X, float Y)
        {
            existance = false;
            this.X = X;
            this.Y = Y;
            Radius = 1;
            LifeMax = 0;
            Life = LifeMax;
            RadiusMax = Math.Abs(X*2);
        }

        public void UpdateState()
        {
            counter = 0;
            Life--;
            if (Life > 0)
            {
            Radius = (float)Math.Sin(3.14159*Life / LifeMax)*RadiusMax;
            }
            else
            {
                existance = false;
            }
        }

        public override void ImpactParticle(Particle particle)
        {
            float cathX = Math.Abs((particle as ParticleColorful).X-this.X);
            float cathY = Math.Abs((particle as ParticleColorful).Y-this.Y);
            if (Math.Sqrt(Math.Pow(cathY,2)+Math.Pow(cathX,2))<=Radius)
            {
                (particle as ParticleColorful).FromColor = Color.FromArgb(255, 0, 200, 0);
                (particle as ParticleColorful).ToColor = Color.FromArgb(40, 0, 200, 0);
                particle.Alight = 80;
            }
        }
        public override void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.FromArgb(250,0,180,0)),
                    X - Radius/2,
                    Y - Radius/2,
                    Radius,
                    Radius
                );
        }
    }
}
