namespace BlackJack_GUI
{

    public partial class Form1 : Form
    {
        private BlackJackGame game;
        public Form1()
        {
            InitializeComponent();
        }

        public void Print(string message)
        {
            outputBox.AppendText(message + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new BlackJackGame(this);
        }


        //Button that player presses to hit
        private void hitButton_Click(object sender, EventArgs e)
        {
            game.UserHit();
        }
        //Button that player presses to stand
        private void standButton_Click(object sender, EventArgs e)
        {
            game.UserStand();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            game.StartNewGame();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e) { }

        private void outputBox_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Method that clears the output box
        public void ClearOutput()
        {
            outputBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       /* public void ShowCardImage(int cardNumber)
        {
            string path = Path.Combine(Application.StartupPath, "cards", cardNumber + ".png");

            if (File.Exists(path))
            {
                cardPictureBox.Image = Image.FromFile(path);
            }
            else
            {
                Print("⚠ Card image not found: " + path);
            }
        }
       */




    }
}
