namespace quick_whiteboard
{
	partial class WhiteboardForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhiteboardForm));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.drawPanel = new quick_whiteboard.DrawPanel();
			this.setBtn = new System.Windows.Forms.Button();
			this.penBtn = new System.Windows.Forms.Button();
			this.lineBtn = new System.Windows.Forms.Button();
			this.closeBtn = new System.Windows.Forms.Button();
			this.colorBtn = new System.Windows.Forms.Button();
			this.weightPanel = new quick_whiteboard.ToolPanel();
			this.weightLabel = new System.Windows.Forms.Label();
			this.weightSlider = new System.Windows.Forms.TrackBar();
			this.clearBtn = new System.Windows.Forms.Button();
			this.rectBtn = new System.Windows.Forms.Button();
			this.fillPanel = new quick_whiteboard.ToolPanel();
			this.fillCheckBox = new System.Windows.Forms.CheckBox();
			this.elipseBtn = new System.Windows.Forms.Button();
			this.drawPanel.SuspendLayout();
			this.weightPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.weightSlider)).BeginInit();
			this.fillPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// colorDialog1
			// 
			this.colorDialog1.Color = System.Drawing.Color.Red;
			// 
			// drawPanel
			// 
			this.drawPanel.Controls.Add(this.setBtn);
			this.drawPanel.Controls.Add(this.penBtn);
			this.drawPanel.Controls.Add(this.lineBtn);
			this.drawPanel.Controls.Add(this.closeBtn);
			this.drawPanel.Controls.Add(this.colorBtn);
			this.drawPanel.Controls.Add(this.weightPanel);
			this.drawPanel.Controls.Add(this.clearBtn);
			this.drawPanel.Controls.Add(this.rectBtn);
			this.drawPanel.Controls.Add(this.fillPanel);
			this.drawPanel.Controls.Add(this.elipseBtn);
			this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.drawPanel.Location = new System.Drawing.Point(0, 0);
			this.drawPanel.Margin = new System.Windows.Forms.Padding(0);
			this.drawPanel.Name = "drawPanel";
			this.drawPanel.Size = new System.Drawing.Size(640, 400);
			this.drawPanel.TabIndex = 0;
			this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
			this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
			this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
			// 
			// setBtn
			// 
			this.setBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.setBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.setBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.setBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.setBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setBtn.Location = new System.Drawing.Point(440, 368);
			this.setBtn.Margin = new System.Windows.Forms.Padding(0);
			this.setBtn.Name = "setBtn";
			this.setBtn.Size = new System.Drawing.Size(200, 32);
			this.setBtn.TabIndex = 1;
			this.setBtn.Text = "Set as desktop background";
			this.setBtn.UseVisualStyleBackColor = false;
			this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
			// 
			// penBtn
			// 
			this.penBtn.BackColor = System.Drawing.Color.Red;
			this.penBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.penBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.penBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.penBtn.Location = new System.Drawing.Point(240, 0);
			this.penBtn.Margin = new System.Windows.Forms.Padding(0);
			this.penBtn.Name = "penBtn";
			this.penBtn.Size = new System.Drawing.Size(64, 32);
			this.penBtn.TabIndex = 5;
			this.penBtn.Text = "Pen";
			this.penBtn.UseVisualStyleBackColor = false;
			this.penBtn.Click += new System.EventHandler(this.penBtn_Click);
			// 
			// lineBtn
			// 
			this.lineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.lineBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.lineBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lineBtn.Location = new System.Drawing.Point(303, 0);
			this.lineBtn.Margin = new System.Windows.Forms.Padding(0);
			this.lineBtn.Name = "lineBtn";
			this.lineBtn.Size = new System.Drawing.Size(64, 32);
			this.lineBtn.TabIndex = 6;
			this.lineBtn.Text = "Line";
			this.lineBtn.UseVisualStyleBackColor = false;
			this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Location = new System.Drawing.Point(608, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 9;
			this.closeBtn.Text = "X";
			this.closeBtn.UseVisualStyleBackColor = false;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// colorBtn
			// 
			this.colorBtn.BackColor = System.Drawing.Color.Red;
			this.colorBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.colorBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colorBtn.Location = new System.Drawing.Point(0, 0);
			this.colorBtn.Margin = new System.Windows.Forms.Padding(0);
			this.colorBtn.Name = "colorBtn";
			this.colorBtn.Size = new System.Drawing.Size(64, 32);
			this.colorBtn.TabIndex = 2;
			this.colorBtn.Text = "Color";
			this.colorBtn.UseVisualStyleBackColor = false;
			this.colorBtn.BackColorChanged += new System.EventHandler(this.colorBtn_BackColorChanged);
			this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
			// 
			// weightPanel
			// 
			this.weightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.weightPanel.Controls.Add(this.weightLabel);
			this.weightPanel.Controls.Add(this.weightSlider);
			this.weightPanel.Cursor = System.Windows.Forms.Cursors.Default;
			this.weightPanel.Location = new System.Drawing.Point(63, 0);
			this.weightPanel.Margin = new System.Windows.Forms.Padding(0);
			this.weightPanel.Name = "weightPanel";
			this.weightPanel.Size = new System.Drawing.Size(125, 32);
			this.weightPanel.TabIndex = 3;
			// 
			// weightLabel
			// 
			this.weightLabel.AutoSize = true;
			this.weightLabel.Location = new System.Drawing.Point(104, 7);
			this.weightLabel.Margin = new System.Windows.Forms.Padding(0);
			this.weightLabel.Name = "weightLabel";
			this.weightLabel.Size = new System.Drawing.Size(15, 17);
			this.weightLabel.TabIndex = 6;
			this.weightLabel.Text = "3";
			// 
			// weightSlider
			// 
			this.weightSlider.AutoSize = false;
			this.weightSlider.LargeChange = 1;
			this.weightSlider.Location = new System.Drawing.Point(1, 6);
			this.weightSlider.Margin = new System.Windows.Forms.Padding(0);
			this.weightSlider.Maximum = 9;
			this.weightSlider.Minimum = 1;
			this.weightSlider.Name = "weightSlider";
			this.weightSlider.Size = new System.Drawing.Size(104, 25);
			this.weightSlider.TabIndex = 4;
			this.weightSlider.TickStyle = System.Windows.Forms.TickStyle.None;
			this.weightSlider.Value = 3;
			this.weightSlider.ValueChanged += new System.EventHandler(this.weightSlider_ValueChanged);
			// 
			// clearBtn
			// 
			this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.clearBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearBtn.Location = new System.Drawing.Point(545, 0);
			this.clearBtn.Margin = new System.Windows.Forms.Padding(0);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(64, 32);
			this.clearBtn.TabIndex = 8;
			this.clearBtn.Text = "Clear";
			this.clearBtn.UseVisualStyleBackColor = false;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// rectBtn
			// 
			this.rectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.rectBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.rectBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.rectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rectBtn.Location = new System.Drawing.Point(366, 0);
			this.rectBtn.Margin = new System.Windows.Forms.Padding(0);
			this.rectBtn.Name = "rectBtn";
			this.rectBtn.Size = new System.Drawing.Size(64, 32);
			this.rectBtn.TabIndex = 7;
			this.rectBtn.Text = "Rect";
			this.rectBtn.UseVisualStyleBackColor = false;
			this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
			// 
			// fillPanel
			// 
			this.fillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.fillPanel.Controls.Add(this.fillCheckBox);
			this.fillPanel.Cursor = System.Windows.Forms.Cursors.Default;
			this.fillPanel.Location = new System.Drawing.Point(187, 0);
			this.fillPanel.Margin = new System.Windows.Forms.Padding(0);
			this.fillPanel.Name = "fillPanel";
			this.fillPanel.Size = new System.Drawing.Size(54, 32);
			this.fillPanel.TabIndex = 10;
			// 
			// fillCheckBox
			// 
			this.fillCheckBox.AutoSize = true;
			this.fillCheckBox.Enabled = false;
			this.fillCheckBox.Location = new System.Drawing.Point(9, 6);
			this.fillCheckBox.Name = "fillCheckBox";
			this.fillCheckBox.Size = new System.Drawing.Size(42, 21);
			this.fillCheckBox.TabIndex = 0;
			this.fillCheckBox.Text = "Fill";
			this.fillCheckBox.UseVisualStyleBackColor = true;
			this.fillCheckBox.CheckedChanged += new System.EventHandler(this.fillCheckBox_CheckedChanged);
			// 
			// elipseBtn
			// 
			this.elipseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.elipseBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.elipseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.elipseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.elipseBtn.Location = new System.Drawing.Point(429, 0);
			this.elipseBtn.Margin = new System.Windows.Forms.Padding(0);
			this.elipseBtn.Name = "elipseBtn";
			this.elipseBtn.Size = new System.Drawing.Size(64, 32);
			this.elipseBtn.TabIndex = 11;
			this.elipseBtn.Text = "Elipse";
			this.elipseBtn.UseVisualStyleBackColor = false;
			this.elipseBtn.Click += new System.EventHandler(this.elipseBtn_Click);
			// 
			// WhiteboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumBlue;
			this.ClientSize = new System.Drawing.Size(640, 400);
			this.Controls.Add(this.drawPanel);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "WhiteboardForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Quick Whiteboard";
			this.TransparencyKey = System.Drawing.Color.MediumBlue;
			this.Activated += new System.EventHandler(this.WhiteboardForm_Activated);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WhiteboardForm_KeyDown);
			this.drawPanel.ResumeLayout(false);
			this.weightPanel.ResumeLayout(false);
			this.weightPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.weightSlider)).EndInit();
			this.fillPanel.ResumeLayout(false);
			this.fillPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button setBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private DrawPanel drawPanel;
		private System.Windows.Forms.Button clearBtn;
		private ToolPanel weightPanel;
		private System.Windows.Forms.TrackBar weightSlider;
		private System.Windows.Forms.Label weightLabel;
		private System.Windows.Forms.Button colorBtn;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button penBtn;
		private System.Windows.Forms.Button lineBtn;
		private System.Windows.Forms.Button rectBtn;
		private ToolPanel fillPanel;
		private System.Windows.Forms.CheckBox fillCheckBox;
		private System.Windows.Forms.Button elipseBtn;
	}
}

