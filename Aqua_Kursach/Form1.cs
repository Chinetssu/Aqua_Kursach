using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aqua_Kursach
{
    public partial class Form1 : Form
    {
        List<Emitter> fleeEmitters = new List<Emitter>();
        Emitter fleeEmitter; // добавим поле для эмиттера
        TopEmitter rainEmitter;
        GravityPoint gravityPoint;
        Radar radar;

        List<Particle> particles = new List<Particle>();
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);


            this.fleeEmitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 360,
                SpeedMin = 10,
                SpeedMax = 15,
                ColorFrom = Color.FromArgb(255,40,30,20),
                ColorTo = Color.FromArgb(100, Color.Red),
                ParticlesPerTick = 1,
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            fleeEmitters.Add(this.fleeEmitter);

         

            this.fleeEmitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 360,
                SpeedMin = 10,
                SpeedMax = 15,
                ColorFrom = Color.FromArgb(255, 40, 30, 20),
                ColorTo = Color.FromArgb(100, Color.Red),
                ParticlesPerTick = 1,
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };

            fleeEmitters.Add(this.fleeEmitter);

            gravityPoint = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            foreach (var em in fleeEmitters)
            {
                em.impactPoints.Add(gravityPoint);
            }

            gravityPoint = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };
            foreach (var em in fleeEmitters)
            {
                em.impactPoints.Add(gravityPoint);
            }

        }


        /*int counter = 0; // добавлю счетчик чтобы считать вызовы функции*/
        int fr = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            var g = Graphics.FromImage(picDisplay.Image);
            fr++;
            if (fr > 1)
            {
                if (rainEmitter != null)
                {
                    rainEmitter.UpdateState();
                    /*foreach (Particle particle in rainEmitter.particles)
                    {
                        foreach (Particle flee in fleeEmitter.particles)
                        {
                            if (particle.Overlaps(flee, g))
                            {
                                particle.Life = 3;
                                flee.Life = 3;
                            }
                        }
                    }*/
                }
                foreach (Emitter emiter in fleeEmitters)
                {
                    emiter.UpdateState(); // тут теперь обновляем эмиттер
                }
                fr = 0;
                
            }
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            fleeEmitter.MousePositionX = e.X;
            fleeEmitter.MousePositionY = e.Y;

        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            fleeEmitter.Direction = tbDirection.Value; // направлению эмиттера присваиваем значение ползунка 
            lblDirection.Text = $"{tbDirection.Value}°"; // добавил вывод значения
        }

        private void tbGravitonPower_Scroll(object sender, EventArgs e)
        {
            foreach (var em in fleeEmitters)
            {
                foreach (var p in em.impactPoints)
                {
                    if (p is GravityPoint) // так как impactPoints не обязательно содержит поле Power, надо проверить на тип 
                    {
                        // если гравитон то меняем силу
                        (p as GravityPoint).Power = tbGravitonPower.Value;
                    }
                }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                if(rainEmitter!=null)
                rainEmitter.Render(g);
                foreach (Emitter emiter in fleeEmitters)
                {
                    emiter.Render(g); // тут теперь обновляем эмиттер
                }
            }

            picDisplay.Invalidate();

        }

        private void CheckBox1_Changed(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                rainEmitter = new TopEmitter {
                    ColorFrom = Color.FromArgb(255, 80, 230, 100),
                    ParticlesCount = 1,
                    ParticlesPerTick = 1,
                    RadiusMax = 3,
                    RadiusMin = 3,
                    GravitationX = 0.3f,
                    GravitationY = 0.85f
                   
                };
                rainEmitter.Width = picDisplay.Width;
            }
            else
            {
                rainEmitter = null;
            }
        }
    }
}
