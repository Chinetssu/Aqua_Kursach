using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Aqua_Kursach
{
    class Informer : IDynamic
    {
        public float X;
        public float Y;
        public List<Emitter> emitters = new List<Emitter>();
        public Informer (float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Particle OverlapParticle()
        {
            foreach(Emitter em in emitters)
            {
                foreach(Particle p in em.particles)
                {
                    if (Math.Abs(p.X - X) <= p.Radius && Math.Abs(p.Y - Y) <= p.Radius)
                    {
                        return p;
                    }
                }
            }
            return null;
        }
        public virtual void UpdateState() { }
        public virtual void Render(Graphics g)
        {
            var particle = OverlapParticle();
            if (particle != null)
            {
            var p = new Pen(Color.DarkGray);
            var b = new SolidBrush(Color.WhiteSmoke);
            g.FillRectangle(b, X, Y, 80, 40);
            g.DrawRectangle(p, X, Y, 80, 40);
            g.DrawString(
                " X: "+particle.X+"\n Y: "+ particle.Y + "\n Жизнь: "+ particle.Life,
                new Font("Verdana", 8), // шрифт и размер
                new SolidBrush(Color.Black), // цвет шрифта
                X, Y // точка в которой нарисовать текст
                );

            }
        }
    }
}
