namespace MY_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.topPanel = new System.Windows.Forms.Panel();
			this.bulletCountLabel = new System.Windows.Forms.Label();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.scenePictureBox = new System.Windows.Forms.PictureBox();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.bulletCountLabel);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(744, 97);
			this.topPanel.TabIndex = 0;
			// 
			// bulletCountLabel
			// 
			this.bulletCountLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bulletCountLabel.Location = new System.Drawing.Point(12, 9);
			this.bulletCountLabel.Name = "bulletCountLabel";
			this.bulletCountLabel.Size = new System.Drawing.Size(133, 83);
			this.bulletCountLabel.TabIndex = 0;
			this.bulletCountLabel.Text = "-----";
			this.bulletCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bottomPanel
			// 
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 566);
			this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(744, 91);
			this.bottomPanel.TabIndex = 1;
			// 
			// scenePictureBox
			// 
			this.scenePictureBox.BackColor = System.Drawing.Color.Azure;
			this.scenePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.scenePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scenePictureBox.Location = new System.Drawing.Point(0, 97);
			this.scenePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.scenePictureBox.Name = "scenePictureBox";
			this.scenePictureBox.Size = new System.Drawing.Size(744, 469);
			this.scenePictureBox.TabIndex = 2;
			this.scenePictureBox.TabStop = false;
			this.scenePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScenePictureBox_MouseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 657);
			this.Controls.Add(this.scenePictureBox);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.topPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DTX Game - Version 1.0";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.PictureBox scenePictureBox;
		private System.Windows.Forms.Label bulletCountLabel;
	}
}
