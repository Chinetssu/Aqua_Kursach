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
        List<IDynamic> dynamicComponents = new List<IDynamic>();
        Emitter fleeEmitter; // добавим поле для эмиттера
        TopEmitter rainEmitter;
        GravityPoint gravityPoint;
        Radar radar;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            rainEmitter = new TopEmitter
            {
                ColorFrom = Color.FromArgb(255, 80, 230, 100),
                ParticlesCount = 1,
                ParticlesPerTick = 1,
                RadiusMax = 3,
                RadiusMin = 3,
                GravitationX = 0.3f,
                GravitationY = 0.85f

            };
            rainEmitter.Width = picDisplay.Width;

            this.fleeEmitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 360,
                SpeedMin = 10,
                SpeedMax = 15,
                ColorFrom = Color.FromArgb(255,40,30,20),
                ColorTo = Color.FromArgb(100, 240, 60,60),
                ParticlesPerTick = 1,
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            dynamicComponents.Add(this.fleeEmitter);

         

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

            dynamicComponents.Add(this.fleeEmitter);

            gravityPoint = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            foreach (var em in dynamicComponents)
            {
                if (em is Emitter)
                    (em as Emitter).impactPoints.Add(gravityPoint);
            }

            gravityPoint = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };
            foreach (var em in dynamicComponents)
            {
                if (em is Emitter)
                    (em as Emitter).impactPoints.Add(gravityPoint);
            }
            radar = new Radar(picDisplay.Width, picDisplay.Height/2);
            foreach (var em in dynamicComponents)
            {
                if (em is Emitter)
                    (em as Emitter).impactPoints.Add(radar);
            }

        }

        private void Tick()
        {
            {
                foreach (IDynamic dComponent in dynamicComponents)
                {
                    dComponent.UpdateState(); // тут теперь обновляем эмиттер
                }
                labelScanHP.Text = radar.counter.ToString();
                if (!radar.existance)
                    dynamicComponents.Remove(radar);
            }
        }


        /*int counter = 0; // добавлю счетчик чтобы считать вызовы функции*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            Tick();
        }


        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            fleeEmitter.MousePositionX = e.X;
            fleeEmitter.MousePositionY = e.Y;

        }

        private void tbGravitonPower_Scroll(object sender, EventArgs e)
        {
            foreach (var em in dynamicComponents) {
                if (em is Emitter)
                   foreach (var p in (em as Emitter).impactPoints)
                   {
                        if (p is GravityPoint) // так как impactPoints не обязательно содержит поле Power, надо проверить на тип 
                        {
                            // если гравитон то меняем силу
                            (p as GravityPoint).Power = tbGravitonPower.Value*3;
                        }
                   }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                foreach (IDynamic dComponent in dynamicComponents)
                {
                    dComponent.Render(g); // тут теперь обновляем эмиттер
                }
            }

            picDisplay.Invalidate();

        }

        private void CheckBox1_Changed(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dynamicComponents.Add(rainEmitter);
            }
            else
            {
                dynamicComponents.Remove(rainEmitter);
            }
        }

        private void ButtonRadar_Click(object sender, EventArgs e)
        {
            radar.existance = true;
            radar.LifeMax = 30;
            radar.Life = 30;
            dynamicComponents.Add(radar);
            foreach(IDynamic DC in dynamicComponents)
            {
                if(DC is Emitter)
                (DC as Emitter).impactPoints.Add(radar);
            }
        }

        private void tbTimeTrack_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = tbTimeTrack.Value;
        }

        private void checkBox_Step_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Step.Checked)
            {
                timer1.Enabled = false;
                buttonStep.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                buttonStep.Enabled = false;
            }
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            Tick();
        }
    }
}
