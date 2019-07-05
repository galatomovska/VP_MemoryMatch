using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{


    public partial class KidsMode : Form
    {
        Random random = new Random();
        bool canClick = false;
        PictureBox firstCard;
        Timer timerClick = new Timer();
        //2 minutes for kids
        int time = 120;
        //1 second per tick on the timer
        Timer timer = new Timer { Interval = 1000 };
        int moves = 0;

        public KidsMode()
        {
            InitializeComponent();
        }


        private PictureBox[] pictureBoxes
        {
            //add to array
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.ben10,
                    Properties.Resources.tomandjerry,
                    Properties.Resources.spongebob,
                    Properties.Resources.simpsons,
                    Properties.Resources.dora,
                    Properties.Resources.dekster,
                    Properties.Resources.bugs_bunny,
                    Properties.Resources.powerpuffgirls
                };
            }
        }

        private void gameTimerStart()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    //timer.Stop();
                    RoundLost();
                    
                }
                if (time >= 60 && (time - 60) < 10)
                { 
                    labelTime.Text = "01:0" + (time - 60).ToString();
                }
                else if(time >= 70)
                    labelTime.Text = "01:" + (time - 60).ToString();
                else
                {
                    if (time < 10)
                    {
                        labelTime.Text = "00:0" + time.ToString();
                        labelNoTime.Visible = true;
                    }
                    else
                        labelTime.Text = "00:" + time.ToString();
                }

                labelMoves.Text = moves.ToString();
            };
        }

        private void RoundWon()
        {
            timer.Stop();
            DialogResult dialogResult = MessageBox.Show("Do you want to play another round?", "GOOD JOB!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //start timer right away
                moves = 0;
                ResetImages();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }
        private void RoundLost()
        {
            timer.Stop();
            DialogResult dialogResult = MessageBox.Show("Do you want to play another round?", "GAME OVER!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //start timer right away
                moves = 0;
                ResetImages();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void playSound()
        {
        // put flip.wav's file path to play sound
            SoundPlayer simpleSound = new SoundPlayer(@"Resources\flip.wav");
            simpleSound.Play();
        }

        private void ResetImages()
        {
            foreach(var picture in pictureBoxes)
            {
                picture.Tag = null;
                picture.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 120;
            timer.Start();
        }

        private void setRandomImages()
        {
            foreach(var img in images)
            {
                getSlot().Tag = img;
                getSlot().Tag = img;
            }
        
        }
        private PictureBox getSlot()
        {
            int tempNumber;
            do
            {
                tempNumber = random.Next(0, pictureBoxes.Count());

            } while (pictureBoxes[tempNumber].Tag != null);
            return pictureBoxes[tempNumber];
        }

        private void HideImages()
        {
            foreach(var picture in pictureBoxes)
            {
                picture.Image = Properties.Resources.back;
            }
        }

        private void TIMERCLICK_TICK(Object sender, EventArgs e)
        {
            HideImages();
            canClick = true;
            timerClick.Stop();
            //moves++;
        }

        private void clickImage(object sender, EventArgs e)
        {
            playSound();
            if (!canClick)
                return;
            var picture = (PictureBox)sender;
            if(firstCard == null)
            {
                firstCard = picture;
                picture.Image = (Image)picture.Tag;
                return;
            }
            picture.Image = (Image)picture.Tag;
            if(picture.Image == firstCard.Image && picture != firstCard)
            {
                picture.Visible = firstCard.Visible = false;
                {
                    firstCard = picture;
                }
                HideImages();
            }
            else
            {
                canClick = false;
                timerClick.Start();
            }
            firstCard = null;
            moves++;
            //check if game is finished
            if (pictureBoxes.Any(p => p.Visible))
                return;
            RoundWon();
            
        }

        private void startGame(object sender, EventArgs e)
        {
            canClick = true;
            setRandomImages();
            HideImages();
            //moves = 0;
            labelMoves.Text = "0";
            labelNoTime.Visible = false;
            gameTimerStart();
            //time in which both cards are shown. Make it shorter to test 
            timerClick.Interval = 500;
            timerClick.Tick += TIMERCLICK_TICK;
            buttonStart.Enabled = false;
        }

        private void ButtonMode_Click(object sender, EventArgs e)
        {
            Mode mode = new Mode();
            mode.Show();
            this.Hide();
        }
    }
}
