//using System;

namespace GameObjects
{
	public class Enemy : object
	{
		public Enemy(System.Windows.Forms.PictureBox gameScene) : base()
		{
			GameScene = gameScene;
			GameScene.Paint += GameScene_Paint;

			X = Infrastructure.Utility.GetRandomNumber(0, GameScene.Width);
			Y = 0;

			Width = MyImage.Width;
			Height = MyImage.Height;

			SpeedX =
				Infrastructure.Utility.GetRandom() * GetRandomSpeedX();

			SpeedY =
				Infrastructure.Utility.GetRandom() * GetRandomSpeedY();

			MyTimer.Start();
		}

		protected int X { get; set; }

		protected int Y { get; set; }

		protected int Width { get; set; }

		protected int Height { get; set; }

		protected bool Killed { get; set; }

		protected int SpeedX { get; set; }

		protected int SpeedY { get; set; }

		protected System.Windows.Forms.PictureBox GameScene { get; set; }

		private System.Drawing.Image myImage;

		protected virtual System.Drawing.Image MyImage
		{
			get
			{
				if (myImage == null)
				{
					string pathName =
						Infrastructure.Utility.GetPathName("Circle.png");

					myImage =
						System.Drawing.Image.FromFile(filename: pathName);
				}

				return myImage;
			}
		}

		private System.Timers.Timer myTimer { get; set; }

		protected System.Timers.Timer MyTimer
		{
			get
			{
				if (myTimer == null)
				{
					myTimer =
						new System.Timers.Timer(interval: 1);

					myTimer.Elapsed += MyTimer_Elapsed;
				}

				return myTimer;
			}
		}

		protected virtual void DisposeTimer()
		{
			if (myTimer != null)
			{
				myTimer.Enabled = false;
				myTimer.Dispose();
				myTimer = null;
			}
		}

		protected virtual int GetRandomSpeedX()
		{
			int result =
				Infrastructure.Utility.GetRandomNumber(1, 5);

			return result;
		}

		protected virtual int GetRandomSpeedY()
		{
			int result =
				Infrastructure.Utility.GetRandomNumber(1, 5);

			return result;
		}

		protected virtual void GameScene_Paint
			(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Draw(e.Graphics);
		}

		private void MyTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			X += SpeedX;
			Y += SpeedY;

			if (X < 0)
			{
				SpeedX =
					(1) * GetRandomSpeedX();
			}
			else
			{
				if (X + Width > GameScene.Width)
				{
					SpeedX =
						(-1) * GetRandomSpeedX();
				}
			}

			if (Y < 0)
			{
				SpeedY =
					(1) * GetRandomSpeedY();
			}
			else
			{
				if (Y + Height > GameScene.Height)
				{
					SpeedY =
						(-1) * GetRandomSpeedY();
				}
			}

			GameScene.Invalidate();
		}

		protected virtual void Draw(System.Drawing.Graphics graphics)
		{
			graphics.CompositingQuality =
				System.Drawing.Drawing2D.CompositingQuality.HighSpeed;

			//graphics.CompositingMode =
			//	System.Drawing.Drawing2D.CompositingMode.SourceOver;

			if (Killed)
			{
				graphics.FillEllipse
					(brush: System.Drawing.Brushes.Transparent, x: X, y: Y, width: Width, height: Height);

				DisposeTimer();
			}
			else
			{
				graphics.DrawImage(image: MyImage, x: X, y: Y, width: Width, height: Height);

				//graphics.FillEllipse
				//	(brush: System.Drawing.Brushes.Red, x: X, y: Y, width: Width, height: Height);
			}
		}

		public virtual bool Hitted(int x, int y)
		{
			if ((x > X) && (x < X + Width))
			{
				if ((y > Y) && (y < Y + Height))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		public virtual void Kill()
		{
			Killed = true;
		}
	}
}
