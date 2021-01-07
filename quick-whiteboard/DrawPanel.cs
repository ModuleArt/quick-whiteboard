using System.Drawing;
using System.Windows.Forms;

namespace quick_whiteboard
{
	class DrawPanel : Panel
	{
        private SolidBrush brush = new SolidBrush(Color.FromArgb(50, 0, 0, 0));

        public DrawPanel()
        {

        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var cp = base.CreateParams;
        //        cp.ExStyle |= 0x00000020;
        //        return cp;
        //    }
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    e.Graphics.FillRectangle(brush, ClientRectangle);
        //}
    }
}
