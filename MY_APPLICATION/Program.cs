namespace MY_APPLICATION
{
	internal static class Program
	{
		static Program()
		{
		}

		[System.STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

			MainForm startupForm = new MainForm();

			System.Windows.Forms.Application.Run(startupForm);

			if (startupForm != null)
			{
				if (startupForm.IsDisposed == false)
				{
					startupForm.Dispose();
				}

				//startupForm = null;
			}
		}
	}
}
