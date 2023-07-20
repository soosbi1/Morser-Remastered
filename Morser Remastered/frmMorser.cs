using System;
using System.Windows.Forms;

namespace Morser_Remastered
{
	public partial class frmMorser : Form
	{
		public frmMorser()
		{
			InitializeComponent();
		}

		private void btnCopy_Click(object sender, EventArgs e) => Clipboard.SetText(tbResult.Text);
		private void tbMorsecode_TextChanged(object sender, EventArgs e) => tbResult.Clear();
		private void tbResult_TextChanged(object sender, EventArgs e) => btnCopy.Visible = !String.IsNullOrEmpty(tbResult.Text);
		private void btnCopy_VisibleChanged(object sender, EventArgs e) => tbResult.Width = btnCopy.Visible ? 257 : 308;


		private void btnTextToMorse_Click(object sender, EventArgs e) => tbResult.Text = Morsecode.TextToMorsecode(tbMorsecode.Text);
		private void btnMorseToText_Click(object sender, EventArgs e) => tbResult.Text = Morsecode.MorsecodeToText(tbMorsecode.Text);
		private void btnMorseToAcoustic_Click(object sender, EventArgs e) => Morsecode.MorsecodeToAcoustic(tbMorsecode.Text);
		private void btnMorseToVisual_Click(object sender, EventArgs e) => Morsecode.MorsecodeToVisual(this, tbMorsecode.Text);
	}
}