using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morser_Remastered
{
	public static class Morsecode
	{
		private const int c_timeUnit = 100;
		private static Dictionary<char, string> s_key => File
				.ReadAllLines($@"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\Morser Remastered\code.txt")
				.ToList()
				.Select(s => (s[0], s.Split('#').Last())).ToDictionary(x => x.Item1, x => x.Item2);

		public static string TextToMorsecode(string text) => string.Concat(text.Select(c => $"{s_key.SingleOrDefault(x => c == x.Key).Value} ")).Trim();
		public static string MorsecodeToText(string morsecode) => string.Concat(morsecode.Split(' ').Select(s => s_key.SingleOrDefault(x => s == x.Value).Key));
		public static void MorsecodeToAcoustic(string morsecode) => Task.Run(() =>
		{
			morsecode.ToList().ForEach(c =>
			{
				switch (c)
				{
					case '.':
						Console.Beep(500, c_timeUnit);
						break;
					case '-':
						Console.Beep(500, c_timeUnit * 3);
						break;
					case ' ':
						Thread.Sleep(c_timeUnit * 2);
						break;
					case '/':
						Thread.Sleep(c_timeUnit * 6);
						break;
				}
				Thread.Sleep(c_timeUnit);
			});
		});
		public static void MorsecodeToVisual(Form form, string morsecode) => Task.Run(() =>
		{
			var backcolor = form.BackColor;
			foreach (var c in morsecode)
			{
				switch (c)
				{
					case '.':
						form.BackColor = Color.White;
						form.Invoke((MethodInvoker)form.Refresh);
						Thread.Sleep(c_timeUnit);
						break;
					case '-':
						form.BackColor = Color.White;
						form.Invoke((MethodInvoker)form.Refresh);
						Thread.Sleep(c_timeUnit * 3);
						break;
					case ' ':
						Thread.Sleep(c_timeUnit * 2);
						break;
					case '/':
						Thread.Sleep(c_timeUnit * 6);
						break;
				}
				form.BackColor = backcolor;
				form.Invoke((MethodInvoker)form.Refresh);
				Thread.Sleep(c_timeUnit);
			}
		});
	}
}