using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void buttonKids_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            WaitSomeTime();

            KidsMode kidsForm = new KidsMode();
            kidsForm.Show();
            this.Hide();
        }
        public async void WaitSomeTime()
        {
            await Task.Delay(5000);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void buttonTeens_Click(object sender, EventArgs e)
        {
            TeensMode teensForm = new TeensMode();
            teensForm.Show();
            this.Hide();
        }

        private void buttonAdults_Click(object sender, EventArgs e)
        {
            AdultsMode adultsForm = new AdultsMode();
            adultsForm.Show();
            this.Hide();
        }
    }
}
