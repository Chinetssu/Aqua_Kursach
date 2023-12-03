using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Aqua_Kursach
{
    interface IDynamic
    {
        void UpdateState();
        void Render(Graphics g);
    }
}
