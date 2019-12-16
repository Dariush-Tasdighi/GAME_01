namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static readonly object LockObject = new object();

		public static int GetRandomNumber(int minValue, int maxValue)
		{
			System.Random random =
				new System.Random(System.Guid.NewGuid().GetHashCode());

			int result =
				random.Next(minValue: minValue, maxValue: maxValue + 1);

			return result;
		}

		public static int GetRandom()
		{
			int result =
				GetRandomNumber(1, 2);

			if (result == 1)
			{
				return -1;
			}
			else
			{
				return 1;
			}
		}

		public static string GetPathName(string fileName)
		{
			string path =
				System.Environment.CurrentDirectory;

			string pathName =
				$@"{ path }\Assets\{ fileName }";

			return pathName;
		}

		public static void PlaySoundEffect_Fire()
		{
			string pathName =
				GetPathName("Rocket.wav");

			System.Media.SoundPlayer player =
				new System.Media.SoundPlayer(soundLocation: pathName);

			player.Play();
		}
	}
}
