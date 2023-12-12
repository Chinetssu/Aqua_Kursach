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
        public List<ParticleColorful> MarkedParticles = new List<ParticleColorful>();
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
            Life--;
            if (Life > 0)
            {
            Radius = (float)Math.Sin(3.14159*Life / LifeMax)*RadiusMax/2;
            }
            else
            {
                existance = false;
                foreach (ParticleColorful p in MarkedParticles)
                {
                    p.Alight = false;
                }
                MarkedParticles.Clear();
            }
            counter = MarkedParticles.Count;
        }

        public void MarkParticle (Particle particle)
        {
            MarkedParticles.Add(particle as ParticleColorful);
            (particle as ParticleColorful).FromColor = Color.FromArgb(255, 0, 200, 0);
            (particle as ParticleColorful).ToColor = Color.FromArgb(40, 0, 200, 0);
            particle.Alight = true;
        }

        public void RemoveMarkedParticle(Particle particle)
        {
            MarkedParticles.Remove(particle as ParticleColorful);
            particle.Alight = false;
        }

        public override void ImpactParticle(Particle particle)
        {
            float cathX = Math.Abs((particle as ParticleColorful).X-this.X);
            float cathY = Math.Abs((particle as ParticleColorful).Y-this.Y);
            if ((Math.Sqrt(Math.Pow(cathY,2)+Math.Pow(cathX,2))<=Radius)&&(!MarkedParticles.Contains(particle)))
            {
                MarkParticle(particle);
            }
            else
            {

                if((Math.Sqrt(Math.Pow(cathY, 2) + Math.Pow(cathX, 2)) > Radius) && MarkedParticles.Contains(particle as ParticleColorful))
                {
                    RemoveMarkedParticle(particle);
                }
            }
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                    new Pen(Color.FromArgb(250,0,180,0)),
                    X - Radius ,
                    Y - Radius ,
                    2 * Radius,
                    2 * Radius
                );
        }
    }
}
