using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ChooseGameSummative2222
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)       //heart button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 5) { scene = 99; }
                else if (scene == 6) { scene = 9; }
                else if (scene == 9) { scene = 14; }
                else if (scene == 14) { scene = 99; }
                else if (scene == 15) { scene = 18; }
                else if (scene == 18) { scene = 99; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 7; }
                else if (scene == 7) { scene = 13; }
                else if (scene == 12) { scene = 17; }
                else if (scene == 16) { scene = 22; }
                else if (scene == 99) { scene = 0; }

            }
            else if (e.KeyCode == Keys.N) //star button press
            {
                if (scene == 6)
                {
                    int value = randGen.Next(1, 11);

                    if (value <= 3) { scene = 10; }
                    else { scene = 11; }
                }
                else if (scene == 11) { scene = 99; }
                else if (scene == 0) { scene = 2; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 4) { scene = 8; }
                else if (scene == 8) { scene = 99; }
                else if (scene == 7) { scene = 12; }
                else if (scene == 12) { scene = 16; }
                else if (scene == 16) { scene = 23; }
                else if (scene == 23) { scene = 99; }
                else if (scene == 1) { scene = 0; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 15) { scene = 19; }
                else if (scene == 9) { scene = 15; }
                else if (scene == 10) { scene = 15; }
                else if (scene == 19) { scene = 99; }

            }
            else if (e.KeyCode == Keys.Space) //diamond button press
            {
                if (scene == 15) { scene = 20; }
                else if (scene == 20) { scene = 99; }
                else if (scene == 16) { scene = 21; }
                else if (scene == 21) { scene = 99; }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:
                    SoundPlayer opening = new SoundPlayer(Properties.Resources.opening);
                    opening.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Unicampus;
                    textLabel.Text = "You just got of class at your 3rd year in university. Walking around campus, you notice 2 boys. Which one do you have a crush on? ";
                    heartLabel.Text = "Bang 'Christopher' Chan";
                    starLabel.Text = "Seo Changbin";
                    diamondLabel.Text = "";
                    break;
                case 1:
                    SoundPlayer chrisTheme = new SoundPlayer(Properties.Resources.classical);
                    chrisTheme.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Chris_titlescreen;
                    textLabel.Text = "Bang 'Christopher' Chan- Very popular, extremely nice, friends with basically everyone on campus and a bussniss major. Do you like him?";
                    heartLabel.Text = "Yes";
                    starLabel.Text = "No, not my type";
                    diamondLabel.Text = "";
                    break;
                case 2:
                    SoundPlayer changbinTheme = new SoundPlayer(Properties.Resources.rock);
                    changbinTheme.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Changbin_titlescreen;
                    textLabel.Text = "Seo Changbin- everyone knows him, bad boy persona, player, and is here on a sports scholarship. Do you like him?";
                    heartLabel.Text = "Yes";
                    starLabel.Text = "No, not my type";
                    diamondLabel.Text = "";
                    break;
                case 3:
                    SoundPlayer chrisStart = new SoundPlayer(Properties.Resources.ChrisStart);
                    chrisStart.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Chris_Smiling;
                    textLabel.Text = "Chris notices you and quickly gathers up his things before jogging up to you. " +
                        "He has a wide smile on his face as he slows down to a stop in front of you." +
                        " \n\nHe asks if you're busy, are you?";
                    heartLabel.Text = "Yes";
                    starLabel.Text = "No!";
                    diamondLabel.Text = "";
                    break;
                case 4:
                    SoundPlayer changbinStart = new SoundPlayer(Properties.Resources.ChangbinStart);
                    changbinStart.Play();
                    textLabel.Text = "You shyly approach him and ask if he want's to hang out with you." +
                        " He scoffs but says yes anyway. Strange he agreed so fast but you think nothing of it." +
                        " You hear whispers as the two of you get off campus. They call you his next use and throw lover." +
                        "\n\n What do you do?";
                    heartLabel.Text = "Roll your eyes and glare at them ";
                    starLabel.Text = "Shamefully lower your head even \nthough it isn't true";
                    diamondLabel.Text = "";
                    break;
                case 5:
                     SoundPlayer gameOver = new SoundPlayer(Properties.Resources.gameover);
                     gameOver.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Bad_Ending;
                    textLabel.Text = "You say yes and he laughs and bids a somewhat awkward goodbye, you lost your chance.";
                    heartLabel.Text = "Press M key to proceed";
                    starLabel.Text = "";
                    diamondLabel.Text = "";
                    break;
                case 6:
                    SoundPlayer chrisContinue = new SoundPlayer(Properties.Resources.ChrisContinue);
                    chrisContinue.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Resturant_Choice;
                    textLabel.Text = "His smile grows wider as he invites you out for lunch. You agree because duh, who wouldn't? " +
                        "The two of you walk off campus and end up between two shops. \n\nWhere do you go? ";
                    heartLabel.Text = "The sushi place";
                    starLabel.Text = "McDonalds";
                    diamondLabel.Text = "";
                    break;
                case 7:
                    textLabel.Text = "Changbin smirks and stands a little closer to you, the walking eventually leads you guys to a nearby park. He sits down by a nearby tree but he accidently sits on something spiky and lets out a girlish scream";
                    heartLabel.Text = "Pretend you didn't see anything";
                    starLabel.Text = "Laugh";
                    diamondLabel.Text = "";
                    break;
                case 8:
                    SoundPlayer gameOver2 = new SoundPlayer(Properties.Resources.gameover);
                    gameOver2.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Bad_Ending;
                    textLabel.Text = "Changbin thinks you have no backbone and ditches you at the entrance ";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    diamondLabel.Text = "";
                    break;
                case 9:
                    SoundPlayer resturant1 = new SoundPlayer(Properties.Resources.resturantChatterrr);
                    resturant1.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Sushi_Date;
                    textLabel.Text = "He agrees and the two of you have a good time and you learn much more about eachother than you did before. " +
                        "\n\nThe check finally comes, what do you do?";
                    heartLabel.Text = "Wait for Chris to pay for you";
                    starLabel.Text = "Immediately bring out your walet";
                    diamondLabel.Text = "";
                    break;
                case 10:
                    SoundPlayer resturant2 = new SoundPlayer(Properties.Resources.resturantChatterrr);
                    resturant2.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Mcdonalds_Date;
                    textLabel.Text = "He agrees and the both of you have a simple conversation. Its going alright. " +
                        "\n\nEventually, the check comes, what do you do?";
                    heartLabel.Text = "Wait for Chris to pay for you";
                    starLabel.Text = "Immediately bring out your walet";
                    diamondLabel.Text = "";
                    break;
                case 11:
                    SoundPlayer gameOver3 = new SoundPlayer(Properties.Resources.gameover);
                    gameOver3.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Bad_Ending;
                    textLabel.Text = "He agrees and the both of you have a simple conversation. Things" +
                        " eventually got way too awkward and you two parted ways early";
                    heartLabel.Text = "";
                    starLabel.Text = "Press N key to continue";
                    diamondLabel.Text = "";
                    break;
                case 12:
                    SoundPlayer park = new SoundPlayer(Properties.Resources.park);
                    park.Play();
                    textLabel.Text = "He goes to glare at you but its immediately gone when he sees you smiling. You go and sit beside him, this wasn't what you exactly had in mind but it still works. Your bodies are oddly close and your heart is drumming in your chest";
                    heartLabel.Text = "Do nothing";
                    starLabel.Text = "Hold Changbin's hand";
                    diamondLabel.Text = "";
                    break;
                case 13:
                    SoundPlayer gameOver4 = new SoundPlayer(Properties.Resources.gameover);
                    gameOver4.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Bad_Ending;
                    textLabel.Text = "He thinks you're mocking him and ends up complaining " +
                        "about how he should not have agreed to come.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    diamondLabel.Text = "";
                    break;
                case 14:
                    SoundPlayer gameOver5 = new SoundPlayer(Properties.Resources.gameover);
                    gameOver5.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Bad_Ending;
                    textLabel.Text = "The meal was expensive, he regrets asking you out to lunch";
                    heartLabel.Text = "Press M to continue";
                    starLabel.Text = "";
                    diamondLabel.Text = "";
                    break;
                case 15:
                    SoundPlayer chrisAfterDate = new SoundPlayer(Properties.Resources.Chris_AfterDate);
                    chrisAfterDate.Play();
                    sceneImage.BackgroundImage = Properties.Resources.After_Chris_Date;
                    textLabel.Text = "He kindly denies but you insist on paying for half. A faint blush decorates his cheeks. " +
                        "You two exit the place and he says it was fun, what's your next move?";
                    heartLabel.Text = "You give him a friendly hug";
                    starLabel.Text = "You ask for his number";
                    diamondLabel.Text = "You kiss him on the cheek";
                    break;
                case 16:
                    SoundPlayer changbinEndings = new SoundPlayer(Properties.Resources.Changbin3Endings);
                    changbinEndings.Play();
                    textLabel.Text = "You quietly interlace your fingers together and to your shock, he shyly squeezes your hand. 'This wasn't what I had in mind.' You mumble as he looks at you curiously. 'What did you have in mind then?'";
                    heartLabel.Text = "Kiss him";
                    starLabel.Text = "'I was thinking we could actually do something'";
                    diamondLabel.Text = "'Oh nothing, nevermind'";
                    break;
                case 17:
                    SoundPlayer gameOver6 = new SoundPlayer(Properties.Resources.gameover);
                    gameOver6.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Bad_Ending;
                    textLabel.Text = "You two sit in silence as other people walk by. The day ends quickly and you guys never speak again, what a nightmare that was.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    diamondLabel.Text = "";
                    break;
                case 18:
                    SoundPlayer gameOver7 = new SoundPlayer(Properties.Resources.gameover);
                    gameOver7.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Bad_Ending;
                    textLabel.Text = "He thinks he's been friendzoned, you two never meet again.";
                    heartLabel.Text = "Press M to continue";
                    starLabel.Text = "";
                    diamondLabel.Text = "";
                    break;
                case 19:
                    SoundPlayer normalEnding = new SoundPlayer(Properties.Resources.NormalEnding);
                    normalEnding.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Normal_Ending;
                    textLabel.Text = "He agrees and you two go on a few more outings. It doesn't go anywhere but the company was nice.";
                    heartLabel.Text = "";
                    starLabel.Text = "Press N to continue";
                    diamondLabel.Text = "";
                    break;
                case 20:
                    SoundPlayer goodEnding = new SoundPlayer(Properties.Resources.goodending);
                    goodEnding.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Good_Ending;
                    textLabel.Text = "He understands your affections clearly, the two of you eventually start dating.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    diamondLabel.Text = "Press the Space Bar to continue";
                    break;
                case 21:
                    sceneImage.BackgroundImage = Properties.Resources.Normal_Ending;
                    textLabel.Text = "Changbin shrugs as you two go back to sitting in silence. You chickened out";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    diamondLabel.Text = "";
                    break;
                case 22:
                    SoundPlayer goodEnding2 = new SoundPlayer(Properties.Resources.goodending);
                    goodEnding2.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Good_Ending;
                    textLabel.Text = "You lean over and shyly kiss his cheek. Changbin's face turned a dark shade of red, what a strange start to the relationship.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    diamondLabel.Text = "";
                    break;
                case 23:
                    SoundPlayer gameOver10 = new SoundPlayer(Properties.Resources.gameover);
                    gameOver10.Play();
                    sceneImage.BackgroundImage = Properties.Resources.Bad_Ending;
                    textLabel.Text = "Changbin frowns. Did you not like hanging out with him? You unintentionally left a bad impression and he resents you now.";
                    heartLabel.Text = "";
                    starLabel.Text = "";
                    diamondLabel.Text = "";
                    break;

                case 99:
                    textLabel.Text = "Play again?";
                    heartLabel.Text = "Yes";
                    starLabel.Text = "No";
                    diamondLabel.Text = "";
                    break;

                default:
                    break;
            }
        }

    }
}
