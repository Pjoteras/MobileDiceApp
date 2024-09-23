namespace MobileDiceApp {
    public partial class MainPage : ContentPage {
        int gameResult = 0;

        public MainPage() {
            InitializeComponent();
        }

        private void DiceRoll(object sender, EventArgs e) {
            //tablica z 5oma liczbami
            int[] dice = new int[5];
            //generator liczb
            Random r = new Random();
            for (int i = 0; i < 5; i++) {
                dice[i] = r.Next(1, 7);
            }
            Dice0.Source = "k6_" + dice[0] + ".png";
            Dice1.Source = "k6_" + dice[1] + ".png";
            Dice2.Source = "k6_" + dice[2] + ".png";
            Dice3.Source = "k6_" + dice[3] + ".png";
            Dice4.Source = "k6_" + dice[4] + ".png";

            //wynik rzutu
            //sprawdzenie powtarzająych się kości
            int rollResult = 0;

            for (int dots = 1; dots <=6; dots++) {
                //sprawdza ile jest jakich liczb

                int count = 0;

                for(int diceIndex = 0; diceIndex < 5; diceIndex++) {
                    if (dice[diceIndex] == dots) {
                        count++;
                    }
                }
                if(count > 1) {
                    rollResult += dots * count;
                }
                
            }
            Label1.Text = "Wynik tego Losowania: " + rollResult;
            gameResult += rollResult;
            Label2.Text = "Wynik gry: " + gameResult;



        }

        private void ResetGame(object sender, EventArgs e) {
            Dice0.Source = "k6_0.png";
            Dice1.Source = "k6_0.png";
            Dice2.Source = "k6_0.png";
            Dice3.Source = "k6_0.png";
            Dice4.Source = "k6_0.png";
        }
    }

}
