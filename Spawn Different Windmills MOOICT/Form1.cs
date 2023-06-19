namespace Spawn_Different_Windmills_MOOICT
{

    // Made by MOO ICT
    // For educational purpose only
    public partial class Form1 : Form
    {

        List<WindMill> windMillCollection = new List<WindMill>();
        int spawnTimer = 20;
        int tempTime;


        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            tempTime--;

            if (tempTime < 1)
            {
                AddWindMills();
                tempTime = spawnTimer;
            }

            this.Text = "Total number of WindMills - " + windMillCollection.Count + " MOO ICT";
        }

        private void DrawWindMillsEvent(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();

            foreach (WindMill tempImg in windMillCollection)
            {
                e.Graphics.DrawImage(tempImg.windMill, tempImg.positionX, tempImg.positionY, tempImg.width, tempImg.height);
            }

        }

        private void AddWindMills()
        {
            WindMill newWindMill = new WindMill();
            windMillCollection.Add(newWindMill);

            for (int i = 0; i < windMillCollection.Count; i++)
            {
                ImageAnimator.Animate(windMillCollection[i].windMill, this.OnFrameChangeHandler);
            }

        }

        private void OnFrameChangeHandler(object? sender, EventArgs e)
        {
            this.Invalidate();  
        }
    }
}