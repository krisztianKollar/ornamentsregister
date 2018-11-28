using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornaments_Register.Service
{
    class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyColors()) { }
    }

    class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.SaddleBrown;
        public override Color MenuItemSelectedGradientBegin => Color.SaddleBrown;
        public override Color MenuItemSelectedGradientEnd => Color.SaddleBrown;
        public override Color ToolStripBorder => Color.LimeGreen;
    }
}
