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
		private static string tool;
		private static Shell shellObj;
		private static SolidBrush brush;
		private static Pen pen;
		private static Bitmap desktopBmp;
		private static Graphics bmpG;
		private static PreviewForm previewForm;

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

			previewForm = new PreviewForm();

			LoadSettings();
		}

		private void LoadSettings()
		{
			colorBtn.BackColor = Properties.Settings.Default.Color;
			weightSlider.Value = Properties.Settings.Default.Weight;
			SetTool(Properties.Settings.Default.Tool);
			fillCheckBox.Checked = Properties.Settings.Default.Fill;
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

			if (tool == "line" || tool == "rect" || tool == "elipse")
			{
				previewForm.Size = new Size(0, 0);
				previewForm.Show();
			}
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
				else if (tool == "line" || tool == "rect" || tool == "elipse")
				{
					int x = downPoint.X;
					int y = downPoint.Y;
					int w = Math.Abs(e.Location.X - downPoint.X);
					int h = Math.Abs(e.Location.Y - downPoint.Y);
					if (e.Location.X < x)
					{
						x = e.Location.X;
					}
					if (e.Location.Y < y)
					{
						y = e.Location.Y;
					}
					previewForm.Location = new Point(x, y);
					previewForm.Size = new Size(w, h);
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

				if (fillCheckBox.Checked)
				{
					curG.FillRectangle(brush, x, y, w, h);
					bmpG.FillRectangle(brush, x, y, w, h);
				}
				else
				{
					curG.DrawRectangle(pen, x, y, w, h);
					bmpG.DrawRectangle(pen, x, y, w, h);
				}
			}
		}

		private void DrawElipse(Point location)
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

				if (fillCheckBox.Checked)
				{
					curG.FillEllipse(brush, x, y, w, h);
					bmpG.FillEllipse(brush, x, y, w, h);
				}
				else
				{
					curG.DrawEllipse(pen, x, y, w, h);
					bmpG.DrawEllipse(pen, x, y, w, h);
				}
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
			else if (tool == "elipse")
			{
				DrawElipse(e.Location);
			}

			previewForm.Hide();
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			curG.Clear(drawPanel.BackColor);
			desktopBmp = new Bitmap(WallpaperManager.Get());
		}

		private void weightSlider_ValueChanged(object sender, EventArgs e)
		{
			weightLabel.Text = weightSlider.Value.ToString();
			Properties.Settings.Default.Weight = weightSlider.Value;
			Properties.Settings.Default.Save();
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
			SetTool("pen");
		}

		private void lineBtn_Click(object sender, EventArgs e)
		{
			SetTool("line");
		}

		private void WhiteboardForm_Activated(object sender, EventArgs e)
		{
			shellObj.MinimizeAll();
		}

		private void rectBtn_Click(object sender, EventArgs e)
		{
			SetTool("rect");
		}

		private void SetTool(string str)
		{
			tool = str;

			if (str == "pen") penBtn.BackColor = Color.Red;
			else penBtn.BackColor = weightPanel.BackColor;
			if (str == "line") lineBtn.BackColor = Color.Red;
			else lineBtn.BackColor = weightPanel.BackColor;
			if (str == "rect") rectBtn.BackColor = Color.Red;
			else rectBtn.BackColor = weightPanel.BackColor;
			if (str == "elipse") elipseBtn.BackColor = Color.Red;
			else elipseBtn.BackColor = weightPanel.BackColor;

			if (str == "rect" || str == "elipse")
			{
				fillCheckBox.Enabled = true;
			}
			else
			{
				fillCheckBox.Enabled = false;
			}

			Properties.Settings.Default.Tool = str;
			Properties.Settings.Default.Save();
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
				else if (e.KeyCode == Keys.Delete)
				{
					clearBtn.PerformClick();
				}
			}
		}

		private void elipseBtn_Click(object sender, EventArgs e)
		{
			SetTool("elipse");
		}

		private void fillCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Fill = fillCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void colorBtn_BackColorChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Color = colorBtn.BackColor;
			Properties.Settings.Default.Save();
		}
	}
}
