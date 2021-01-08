namespace quick_whiteboard
{
	partial class PreviewForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
			this.drawPanel = new quick_whiteboard.DrawPanel();
			this.SuspendLayout();
			// 
			// drawPanel
			// 
			this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.drawPanel.Location = new System.Drawing.Point(0, 0);
			this.drawPanel.Margin = new System.Windows.Forms.Padding(0);
			this.drawPanel.Name = "drawPanel";
			this.drawPanel.Size = new System.Drawing.Size(128, 128);
			this.drawPanel.TabIndex = 0;
			// 
			// PreviewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumBlue;
			this.ClientSize = new System.Drawing.Size(128, 128);
			this.ControlBox = false;
			this.Controls.Add(this.drawPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PreviewForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Preview";
			this.TransparencyKey = System.Drawing.Color.MediumBlue;
			this.ResumeLayout(false);

		}

		#endregion

		private DrawPanel drawPanel;
	}
}