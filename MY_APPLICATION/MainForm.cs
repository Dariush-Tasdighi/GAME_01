using System.Linq;

namespace MY_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public int EnemyCount { get; set; }

		public int BulletCount { get; set; }

		public System.Collections.Generic.List<GameObjects.Enemy> Enemies { get; set; }

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			string pathName =
				Infrastructure.Utility.GetPathName("Space.jpg");

			if (System.IO.File.Exists(pathName))
			{
				scenePictureBox.ImageLocation = pathName;
			}

			scenePictureBox.BackColor =
				System.Drawing.Color.White;

			EnemyCount = 20;
			BulletCount = 30;
			bulletCountLabel.Text = BulletCount.ToString();

			Enemies =
				new System.Collections.Generic.List<GameObjects.Enemy>();

			for (int index = 1; index <= EnemyCount; index++)
			{
				GameObjects.Enemy enemy =
					new GameObjects.Enemy(scenePictureBox);

				Enemies.Add(enemy);
			}
		}

		private void ScenePictureBox_MouseClick
			(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (BulletCount > 0)
			{
				Infrastructure.Utility.PlaySoundEffect_Fire();

				BulletCount--;
				bulletCountLabel.Text = BulletCount.ToString();

				for (int index = Enemies.Count - 1; index >= 0; index--)
				{
					var enemy = Enemies[index];

					bool hitted =
						enemy.Hitted(x: e.X, y: e.Y);

					if (hitted)
					{
						enemy.Kill();
						Enemies.Remove(enemy);
					}
				}
			}
		}
	}
}
