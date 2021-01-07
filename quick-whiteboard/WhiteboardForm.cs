using Shell32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_whiteboard
{
	public partial class WhiteboardForm : Form
	{
		private static int whiteboardWidth;
		private static int whiteboardHeight;
		private static Point downPoint;
		private static bool mouseDown = false;
		private static Graphics curG;
		private static string tool = "pen";
		private static Shell shellObj;
		private static SolidBrush brush;
		private static Pen pen;
		private static Bitmap desktopBmp;
		private static Graphics bmpG;

		public WhiteboardForm()
		{
			InitializeComponent();

			whiteboardWidth = Screen.FromPoint(Cursor.Position).WorkingArea.Width;
			whiteboardHeight = Screen.FromPoint(Cursor.Position).WorkingArea.Height;
			Size = new Size(whiteboardWidth, whiteboardHeight);

			shellObj = new Shell();

			curG = drawPanel.CreateGraphics();
			curG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
			curG.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

			desktopBmp = new Bitmap(WallpaperManager.Get());
			bmpG = Graphics.FromImage(desktopBmp);
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void setBtn_Click(object sender, EventArgs e)
		{
			WallpaperManager.Set(desktopBmp, WallpaperManager.Style.Fill);
			Close();
		}

		private void drawPanel_MouseDown(object sender, MouseEventArgs e)
		{
			brush = new SolidBrush(colorDialog1.Color);
			pen = new Pen(brush, weightSlider.Value);
			pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
			pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

			downPoint = e.Location;
			mouseDown = true;
		}

		private void drawPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				if (tool == "pen")
				{
					DrawLine(e.Location);
					downPoint = e.Location;
				}
			}
		}

		private void DrawLine(Point location)
		{
			if (location == downPoint)
			{
				float radius = weightSlider.Value / 2;
				curG.FillEllipse(brush, downPoint.X - radius, downPoint.Y - radius, weightSlider.Value, weightSlider.Value);
				bmpG.FillEllipse(brush, downPoint.X - radius, downPoint.Y - radius, weightSlider.Value, weightSlider.Value);
			}
			else
			{
				curG.DrawLine(pen, downPoint, location);
				bmpG.DrawLine(pen, downPoint, location);
			}
		}

		private void DrawRect(Point location)
		{
			if (location == downPoint)
			{
				float radius = weightSlider.Value / 2;
				curG.FillEllipse(brush, downPoint.X - radius, downPoint.Y - radius, weightSlider.Value, weightSlider.Value);
				bmpG.FillEllipse(brush, downPoint.X - radius, downPoint.Y - radius, weightSlider.Value, weightSlider.Value);
			}
			else
			{
				int x = downPoint.X;
				int y = downPoint.Y;
				int w = Math.Abs(location.X - downPoint.X);
				int h = Math.Abs(location.Y - downPoint.Y);
				if (location.X < x)
				{
					x = location.X;
				}
				if (location.Y < y)
				{
					y = location.Y;
				}
				curG.DrawRectangle(pen, x, y, w, h);
				bmpG.DrawRectangle(pen, x, y, w, h);
			}
		}

		private void drawPanel_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;

			if (tool == "line")
			{
				DrawLine(e.Location);
			}
			else if (tool == "rect")
			{
				DrawRect(e.Location);
			}
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			curG.Clear(drawPanel.BackColor);
			desktopBmp = new Bitmap(WallpaperManager.Get());
		}

		private void weightSlider_ValueChanged(object sender, EventArgs e)
		{
			weightLabel.Text = weightSlider.Value.ToString();
		}

		private void colorBtn_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				colorBtn.BackColor = colorDialog1.Color;
			}
		}

		private void penBtn_Click(object sender, EventArgs e)
		{
			tool = "pen";
		}

		private void lineBtn_Click(object sender, EventArgs e)
		{
			tool = "line";
		}

		private void WhiteboardForm_Activated(object sender, EventArgs e)
		{
			shellObj.MinimizeAll();
		}

		private void rectBtn_Click(object sender, EventArgs e)
		{
			tool = "rect";
		}

		private void WhiteboardForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				if (e.KeyCode == Keys.S)
				{
					setBtn.PerformClick();
				}
			}
			else
			{
				if (e.KeyCode == Keys.Escape)
				{
					Close();
				}
			}
		}
	}
}
