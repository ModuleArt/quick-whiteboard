using System.Drawing;
using System.Windows.Forms;

namespace quick_whiteboard
{
	class ToolPanel : Panel
	{
		private Pen borderPen = new Pen(Color.Red, 1);

		public ToolPanel()
		{

		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.DrawRectangle(borderPen, 0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
		}
	}
}
