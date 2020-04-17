using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        //Random Number Generator
        Random randGen = new Random();
        int outcomeValue;
        public Form1()
        {
            InitializeComponent();

            // display initial message and options
            displayLabel.Text = "Begin? Press E to start";
            greenButton.Text = "";
            redButton.Text = "";
            blueButton.Text = "";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;









        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void greenButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void blueButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureLabel_Click(object sender, EventArgs e)
        {

        }

        private void displayLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {

            /// Check to see what button has been pressed and advance to the next appropriate scene
            if (e.KeyCode == Keys.A)   //green button press
            {


                if (scene == 0)
                {

                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 13;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 11;
                }
                else if (scene == 7)
                {
                    scene = 35;
                }
                else if (scene == 9)
                {
                    scene = 35;
                }
                else if (scene == 10)
                {
                    scene = 34;
                }
                else if (scene == 11)
                {
                    scene = 35;
                }
                else if (scene == 12)
                {
                    scene = 14;
                }
                else if (scene == 13)
                {
                    scene = 31;
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 15)
                {
                    scene = 35;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 19;
                }
                else if (scene == 19)
                {
                    scene = 22;
                }
                else if (scene == 20)
                {
                    scene = 23;
                }
                else if (scene == 21)
                {
                    scene = 35;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {
                    scene = 24;
                }
                else if (scene == 24)
                {
                    scene = 26;
                }
                else if (scene == 25)
                {
                    scene = 26;
                }
                else if (scene == 27)
                {
                    scene = 35;
                }
                else if (scene == 28)
                {
                    scene = 35;
                }
                else if (scene == 29)
                {
                    scene = 34;
                }
                else if (scene == 30)
                {
                    scene = 34;
                }
                else if (scene == 31)
                {
                    scene = 32;
                }
                else if (scene == 32)
                {
                    scene = 34;
                }
                else if (scene == 33)
                {
                    scene = 35;
                }
                else if (scene == 34)
                {
                    scene = 0;
                }
                else if (scene == 35)
                {
                    scene = 0;
                }
                else if (scene == 37)
                {
                    scene = 34;
                }
                else if (scene == 38)
                {
                    scene = 35;
                }
                else if (scene == 8)
                {
                    outcomeValue = randGen.Next(1, 10);
                    if (outcomeValue >= 5)
                    {
                        scene = 10;
                    }
                    else
                    {
                        scene = 9;
                    }
                }
                else if (scene == 26)
                {
                    if (outcomeValue <= 7)
                    {
                        scene = 29;
                    }
                    else
                    {
                        scene = 28;
                    }
                }
                else if (scene == 36)
                {
                    outcomeValue = randGen.Next(1, 10);
                    if (outcomeValue <= 8)
                    {
                        scene = 37;
                    }
                    else
                    {
                        scene = 38;
                    }
                }

            }
            else if (e.KeyCode == Keys.S)  //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 12;
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 6)
                {
                    scene = 36;
                }
                else if (scene == 7)
                {
                    scene = 35;
                }
                else if (scene == 9)
                {
                    scene = 35;
                }
                else if (scene == 10)
                {
                    scene = 34;
                }
                else if (scene == 11)
                {
                    scene = 35;
                }
                else if (scene == 12)
                {
                    scene = 15;
                }
                else if (scene == 13)
                {
                    scene = 31;
                }
                else if (scene == 14)
                {
                    scene = 17;
                }
                else if (scene == 15)
                {
                    scene = 35;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 20;
                }
                else if (scene == 21)
                {
                    scene = 35;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {
                    scene = 25;
                }
                else if (scene == 24)
                {
                    scene = 26;
                }
                else if (scene == 25)
                {
                    scene = 27;
                }
                else if (scene == 27)
                {
                    scene = 35;
                }
                else if (scene == 28)
                {
                    scene = 35;
                }
                else if (scene == 29)
                {
                    scene = 34;
                }
                else if (scene == 30)
                {
                    scene = 34;
                }
                else if (scene == 31)
                {
                    scene = 33;
                }
                else if (scene == 32)
                {
                    scene = 34;
                }
                else if (scene == 33)
                {
                    scene = 35;
                }
                else if (scene == 34)
                {
                    Close();
                }
                else if (scene == 35)
                {
                    Close();
                }
                else if (scene == 37)
                {
                    scene = 34;
                }
                else if (scene == 38)
                {
                    scene = 35;
                }
                else if (scene == 8)
                {
                    outcomeValue = randGen.Next(1, 10);
                    if (outcomeValue >= 5)
                    {
                        scene = 10;
                    }
                    else
                    {
                        scene = 9;
                    }
                }
                else if (scene == 19)
                {
                    scene = 21;
                }
                else if (scene == 20)
                {
                    scene = 22;
                }
                else if (scene == 36)
                {
                    outcomeValue = randGen.Next(1, 10);
                    if (outcomeValue <= 8)
                    {
                        scene = 37;
                    }
                    else
                    {
                        scene = 38;
                    }
                }
                else if (scene == 26)
                {
                    outcomeValue = randGen.Next(1, 10);
                    if (outcomeValue >= 8)
                    {
                        scene = 30;
                    }
                    else
                    {
                        scene = 28;
                    }

                }
                else if (e.KeyCode == Keys.D) // blue button press
            {


                if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 8;
                }
                else if (scene == 7)
                {
                    scene = 35;
                }
                else if (scene == 9)
                {
                    scene = 35;
                }
                else if (scene == 10)
                {
                    scene = 34;
                }
                else if (scene == 11)
                {
                    scene = 35;
                }
                else if (scene == 13)
                {
                    scene = 31;
                }
                else if (scene == 15)
                {
                    scene = 35;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 20)
                {
                    scene = 23;
                }
                else if (scene == 21)
                {
                    scene = 35;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 26;
                }
                else if (scene == 27)
                {
                    scene = 35;
                }
                else if (scene == 28)
                {
                    scene = 35;
                }
                else if (scene == 29)
                {
                    scene = 34;
                }
                else if (scene == 30)
                {
                    scene = 34;
                }
                else if (scene == 32)
                {
                    scene = 34;
                }
                else if (scene == 33)
                {
                    scene = 35;
                }
                else if (scene == 37)
                {
                    scene = 34;
                }
                else if (scene == 38)
                {
                    scene = 35;
                }
                else if (scene == 8)
                {
                    outcomeValue = randGen.Next(1, 10);
                    if (outcomeValue >= 5)
                    {
                        scene = 10;
                    }
                    else
                    {
                        scene = 9;
                    }
                }
                else if (scene == 36)
                {
                    outcomeValue = randGen.Next(1, 10);
                    if (outcomeValue <= 8)
                    {
                        scene = 37;
                    }
                    else
                    {
                        scene = 38;
                    }

                }

            }
                    if (e.KeyCode == Keys.E)
                    {
                        scene = 0;
                    }
                   
                    }
             
            switch (scene)
            {
                case 0:
                    displayLabel.Text = "You wake up in your own bed. You are late for work, do you...";

                    greenButton.Text = "Go back to sleep";

                    redButton.Text = "Get up";

                    blueButton.Text = "";

                    pictureLabel.Image = Properties.Resources.Wakingup;

                    break;
                case 1: //get up

                    displayLabel.Text = "You rush out of bed and get ready to leave";

                    pictureLabel.Image = Properties.Resources.Jump;

                    displayLabel.Refresh();

                    pictureLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "Just before you step out the door you look at your phone, should you call your boss?";

                    pictureLabel.Image = Properties.Resources.Phone;

                    greenButton.Text = "Call your boss";

                    redButton.Text = "Go to work";

                    blueButton.Text = "";

                    break;
                case 2: //go back to sleep
                    displayLabel.Text = "You awaken 3 hours later to a call from your boss";

                    pictureLabel.Image = Properties.Resources.WakingupAgain;

                    displayLabel.Refresh();

                    pictureLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "BOSS: Why have you not come in to work today?";

                    pictureLabel.Image = Properties.Resources.Boss1;

                    greenButton.Text = "Lie";

                    redButton.Text = "Truth";

                    blueButton.Text = "";

                    break;
                case 3: //lie
                    displayLabel.Text = "THOMAS: Sorry my uh dog had to be rushed to the vet";

                    pictureLabel.Image = Properties.Resources.WakingupAgain;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "BOSS: You dont have a dog!";

                    pictureLabel.Image = Properties.Resources.Boss1;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";

                    break;
                case 4: //truth
                    displayLabel.Text = "THOMAS: Well i had the option to be just a little late but then i just went back to sleep";

                    pictureLabel.Image = Properties.Resources.WakingupAgain;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "BOSS: Thomas, i have had enough of your lack of work ethic!";

                    pictureLabel.Image = Properties.Resources.Boss1;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";

                    break;
                case 5: //fired
                    displayLabel.Text = "BOSS: You are FIRED";

                    pictureLabel.Image = Properties.Resources.Boss2;

                    greenButton.Text = "Beg";

                    redButton.Text = "Get Angry";

                    blueButton.Text = "Confess your love";

                    break;
                case 6: //beg
                    displayLabel.Text = "THOMAS: Boss,Please i'll do better from now on this job is all i have";

                    pictureLabel.Image = Properties.Resources.ThomasOnPhone;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "BOSS: you better get down here fast!";

                    pictureLabel.Image = Properties.Resources.Boss3;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "You hop out of bed and rush to work, when you arrive your boss and all your coworkers are waiting for you";

                    pictureLabel.Image = Properties.Resources.CoworkersOutside;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "BOSS: You and me Thomas! Gloves or Not?!... it is clear your boss intends you fight you for your job";

                    pictureLabel.Image = Properties.Resources.Boss2;

                    greenButton.Text = "Boxing gloves";

                    redButton.Text = "Bare fists";

                    blueButton.Text = "";

                    break;
                case 7: // get angry (LOSS)
                    displayLabel.Text = "THOMAS: you think i care? you must be delusional";

                    pictureLabel.Image = Properties.Resources.ThomasOnPhone;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "With no job you fail to bring in any income and you starve in poverty all alone";

                    pictureLabel.Image = Properties.Resources.Failure1;

                    greenButton.Text = "FAILURE!";

                    redButton.Text = "FAILURE!";

                    blueButton.Text = "FAILURE!";

                    break;
                case 8: // confess your love
                    displayLabel.Text = "THOMAS: boss please i dont know what i would do without you";

                    pictureLabel.Image = Properties.Resources.ThomasOnPhone;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";

                    break;
                case 9: // 50% fail (LOSS)
                    displayLabel.Text = "BOSS: im sorry Thomas, i cant be with you, im in love with Employee Number 9!";

                    pictureLabel.Image = Properties.Resources.Boss4;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "THOMAS: Employee Number 9! Nooooooo!...";

                    pictureLabel.Image = Properties.Resources.Thomas_Yelling;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "With no job you fail to bring in any income and you starve in poverty all alone";

                    pictureLabel.Image = Properties.Resources.Failure1;

                    greenButton.Text = "FAILURE!";

                    redButton.Text = "FAILURE!";

                    blueButton.Text = "FAILURE!";

                    break;
                case 10: // 50% success (WIN)
                    displayLabel.Text = "BOSS: Thomas im so glad you said something, i've felt the same way ever since i hired you!";

                    pictureLabel.Image = Properties.Resources.Boss5;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "You and your boss settle down in a nice rural county and adopt 3 children, you are living the dream";

                    pictureLabel.Image = Properties.Resources.WinLove;

                    greenButton.Text = "WINNER";

                    redButton.Text = "WINNER";

                    blueButton.Text = "WINNER";

                    break;
                case 11: // Boxing Gloves (LOSS)
                    displayLabel.Text = "You choose the boxing gloves, your coworkers immediately sigh in disgust, how could you be so cowardly?";

                    pictureLabel.Image = Properties.Resources.StunnedThomas;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "you have brought sever shame upon you and your legacy, you will never be hired again, you starve alone and in poverty";

                    pictureLabel.Image = Properties.Resources.Failure1;

                    greenButton.Text = "FAILURE!";

                    redButton.Text = "FAILURE!";

                    blueButton.Text = "FAILURE!";

                    break;
                case 12: // Go To Work
                    displayLabel.Text = "You rush out the door and hop in your car";

                    pictureLabel.Image = Properties.Resources.ThomasCar;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "you arrive at your workplace and the only parking spot left is your bosses, do you...";

                    pictureLabel.Image = Properties.Resources.ParkingLot;

                    greenButton.Text = "park in his spot";

                    redButton.Text = "park farther down the street";

                    blueButton.Text = "";

                    break;
                case 13: // call your boss
                    displayLabel.Text = "You call your boss and inform him that you will be late to work today";

                    pictureLabel.Image = Properties.Resources.ThomasOnPhone;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";

                    break;
                case 14: // Park in his spot
                    displayLabel.Text = "you park and head into the office";

                    pictureLabel.Image = Properties.Resources.ThomasEntering;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "you sit down at your desk, it seems nobody noticed you were gone";

                    pictureLabel.Image = Properties.Resources.ThomasAtDesk;

                    greenButton.Text = "start to work";

                    redButton.Text = "take a nap";

                    blueButton.Text = "";
                    break;
                case 15: // park down the street (LOSS)
                    displayLabel.Text = "you park down the street and begin walking to work";

                    pictureLabel.Image = Properties.Resources.ThomasStreet;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "the sun beating down on you, you only get halfway down the street before you pass out from heat exhaustion";

                    pictureLabel.Image = Properties.Resources.ThomasSweating;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "if you do not attend work you will not remain employed but you cannot wake up";

                    pictureLabel.Image = Properties.Resources.Failure1;

                    greenButton.Text = "FAILURE!";

                    redButton.Text = "FAILURE!";

                    blueButton.Text = "FAILURE!";

                    break;
                case 16: //start to work
                    displayLabel.Text = "you spend the day working very hard";

                    pictureLabel.Image = Properties.Resources.ThomasAtDesk;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "it is time to leave you look down at your watch, pack your things and walk outside";

                    pictureLabel.Image = Properties.Resources.ThomasLeaving;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";

                    break;
                case 17: // take a nap
                    displayLabel.Text = "you set an alarm for 5PM and spend your day sleeping at your desk";


                    pictureLabel.Image = Properties.Resources.ThomasSleeping;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "it is time to leave, your alarm goes off, you get up, get your things, and walk outside";

                    pictureLabel.Image = Properties.Resources.ThomasLeaving;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";

                    break;
                case 18: // Car Towed
                    displayLabel.Text = "your boss had your car towed to the impound and his car is in your spot";

                    pictureLabel.Image = Properties.Resources.BossCar;

                    greenButton.Text = "Vandalize his car";

                    redButton.Text = "Call a taxi to the impound";

                    blueButton.Text = "";

                    break;
                case 19: // Vandalize his car
                    displayLabel.Text = "You take out your keys and you scratch them along the sides of his vehicle";

                    pictureLabel.Image = Properties.Resources.ThomasKeying;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "your boss comes running out of the building to confront you";

                    pictureLabel.Image = Properties.Resources.Boss1;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "BOSS: Thomas what are you doing to my car?";

                    pictureLabel.Image = Properties.Resources.Boss6;

                    greenButton.Text = "Lie";

                    redButton.Text = "Truth";

                    blueButton.Text = "";

                    break;
                case 20: // Call a taxi
                    displayLabel.Text = "You attempt to call a taxi with no success. There are no taxis in your area at this time";

                    pictureLabel.Image = Properties.Resources.ThomasOnPhone;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";

                    break;
                case 21: // Truth about keying
                    displayLabel.Text = "THOMAS: im keying your ugly disgusting car";

                    pictureLabel.Image = Properties.Resources.ThomasMad;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "Filled with rage your boss charges you, you had little time to react";

                    pictureLabel.Image = Properties.Resources.Boss2;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "your boss tackles  you onto the ground";

                    pictureLabel.Image = Properties.Resources.Boss2;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "Your boss has pinned you down and you have no hopes of fighting back or running away";

                    pictureLabel.Image = Properties.Resources.Boss2;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "BOSS: YOU'RE FIRED... he shouts, with no job and no income you starve alone in poverty";

                    pictureLabel.Image = Properties.Resources.Failure1;

                    greenButton.Text = "FAILURE!";

                    redButton.Text = "FAILURE!";

                    blueButton.Text = "FAILURE!";

                    break;
                case 22: // lie about keying
                    displayLabel.Text = "THOMAS: it wasn't me, it was Tucker over there, i tried to stop him";

                    pictureLabel.Image = Properties.Resources.Boss1;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "your boss charges tucker before he can even say anything and you quickly make your escape";

                    pictureLabel.Image = Properties.Resources.ThomasLeaving;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";

                    break;
                case 23:
                    displayLabel.Text = "You begin walking down the street on your way to the impound";

                    pictureLabel.Image = Properties.Resources.ThomasLeaving;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "You turn into a dark alleyway...you start hearing strange sounds";

                    pictureLabel.Image = Properties.Resources.ThomasAlley;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "Suddenly a bright light flashes above your head and you begin levitating higher and higher";

                    pictureLabel.Image = Properties.Resources.ThomasAbductions;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "you suddenly lose consciousness and awake in a metallic room";

                    pictureLabel.Image = Properties.Resources.UFO;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "a tall green figure walks into the room and asks if you are ready to make your speech";

                    pictureLabel.Image = Properties.Resources.Alien;

                    greenButton.Text = "Yes";

                    redButton.Text = "No";

                    blueButton.Text = "";

                    break;
                case 24: //Yes Speech
                    displayLabel.Text = "THOMAS: i guess im ready...";

                    pictureLabel.Image = Properties.Resources.ConfusedThomas;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";

                    break;
                case 25: //No Speech
                    displayLabel.Text = "THOMAS: no, what? who are you? where am i?";

                    pictureLabel.Image = Properties.Resources.ConfusedThomas;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "ALIEN: You are on our ship, we saved you from that vile planet";

                    pictureLabel.Image = Properties.Resources.Alien;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "THOMAS: you kidnapped me? why?";

                    pictureLabel.Image = Properties.Resources.ConfusedThomas;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "ALIEN: WE did not kidnap you, you are the harbinger of our fate, you will lead us to glory, the corwd is waiting for you";

                    pictureLabel.Image = Properties.Resources.Alien;

                    greenButton.Text = "Give Speech";

                    redButton.Text = "Try to escape";

                    blueButton.Text = "";

                    break;
                case 26: // Give Speech
                    displayLabel.Text = "THOMAS: alright i'll do it... You walk out of the room straight onto a stage";

                    pictureLabel.Image = Properties.Resources.ThomasOnStage;

                    greenButton.Text = "Be Inspiring";

                    redButton.Text = "Be Tyrannical";

                    blueButton.Text = "";

                    break;
                case 27: // try to escape (LOSS)
                    displayLabel.Text = "THOMAS: I wont do it!... You run out of the room to see a massive crowd of green aliens, it is clear escape will not be possible";

                    pictureLabel.Image = Properties.Resources.StunnedThomas;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "The crowd is in shock, the harbinger would not try to escape, the harbinger would love them";

                    pictureLabel.Image = Properties.Resources.Alien;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "It is clear a mistake was made, you are thrown out the nearest airlock";

                    pictureLabel.Image = Properties.Resources.ThomasFrozen;

                    greenButton.Text = "FAILURE!";

                    redButton.Text = "FAILURE!";

                    blueButton.Text = "FAILURE!";

                    break;
                case 28: // Speech failure
                    displayLabel.Text = "The crowd is in uproar it is clear you are not meant to be the harbinger, you are taken and thrown out the nearest airlock";

                    pictureLabel.Image = Properties.Resources.ThomasFrozen;

                    greenButton.Text = "FAILURE!";

                    redButton.Text = "FAILURE!";

                    blueButton.Text = "FAILURE!";

                    break;
                case 29: // inspiring speech success (WIN)
                    displayLabel.Text = "The crowd is cheering they cant wait for what the future holds, as long as you are right there behind them to lead them in the right direction";

                    pictureLabel.Image = Properties.Resources.Alien;

                    greenButton.Text = "WINNER";

                    redButton.Text = "WINNER";

                    blueButton.Text = "WINNER";

                    break;
                case 30: // Tyrannical speech success (WIN)
                    displayLabel.Text = "The crowd is silent, your words struck fear into their hearts, they dare not challenge you, they may not be to sure of the future, but they are sure of your new rule";

                    pictureLabel.Image = Properties.Resources.Alien;

                    greenButton.Text = "WINNER";

                    redButton.Text = "WINNER";

                    blueButton.Text = "WINNER";

                    break;
                case 31: // call your boss
                    displayLabel.Text = "BOSS: oh my god Thomas! again? I ecpect to see you in the next 30 minutes";

                    pictureLabel.Image = Properties.Resources.ThomasOnPhone;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "You rush out your house and drive to work";

                    pictureLabel.Image = Properties.Resources.ThomasCar;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "you arrive at your workplace and your boss has parked on the street, which you find quite peculiar";

                    pictureLabel.Image = Properties.Resources.BossCar2;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "you walk into the office and your boss emerges in full Shogun armor";

                    pictureLabel.Image = Properties.Resources.BossShogun;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "BOSS: im glad you called and gave me time to prepare... he throws a sword on the ground";

                    pictureLabel.Image = Properties.Resources.SamuraiSword;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "BOSS: Duel!";

                    pictureLabel.Image = Properties.Resources.BossShogun;

                    greenButton.Text = "Pick up the sword";

                    redButton.Text = "Refuse the duel";

                    blueButton.Text = "";

                    break;
                case 32: // Pick up the sword (WIN)
                    displayLabel.Text = "You aren't backing down now! this job is your foundation, you cannot survive without it, you pick up the sword";

                    pictureLabel.Image = Properties.Resources.ThomasMad;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "you both raise your swords, your boss charges you to strike but your determination is too strong!";

                    pictureLabel.Image = Properties.Resources.ThomasSword;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "Without this job survival is impossible, you swipe at his blade with all your might completely destroying his sword!";

                    pictureLabel.Image = Properties.Resources.ThomasSword;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "it is clear your strength is unrivalled, your coworkers bow to you in honour and fear, they are awed by such strength";

                    pictureLabel.Image = Properties.Resources.CoworkersBow;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "your boss lays on the ground stunned, you are in charge now, and he cannot challenge you";

                    pictureLabel.Image = Properties.Resources.Boss4;

                    greenButton.Text = "WINNER";

                    redButton.Text = "WINNER";

                    blueButton.Text = "WINNER";

                    break;
                case 33: //Refuse the duel (LOSS)
                    displayLabel.Text = "your coworkers laugh hysterically at your cowardice, you are laughed out of the office, it is clear you no longer have a job, with no income yo ustarve alone in poverty";

                    pictureLabel.Image = Properties.Resources.Failure1;

                    greenButton.Text = "FAILURE!";

                    redButton.Text = "FAILURE!";

                    blueButton.Text = "FAILURE!";

                    break;
                case 34:
                    displayLabel.Text = "you win! Play again?";

                    pictureLabel.Image = Properties.Resources.YouWin;

                    greenButton.Text = "Yes";

                    redButton.Text = "No";

                    blueButton.Text = "";

                    break;
                case 35:
                    displayLabel.Text = "you lose! play again?";

                    pictureLabel.Image = Properties.Resources.YouLose;

                    greenButton.Text = "Yes";

                    redButton.Text = "No";

                    blueButton.Text = "";

                    break;
                case 36: // bare fists
                    displayLabel.Text = "You crack your knuckles, it is clear you don't need gloves to win this fight";

                    pictureLabel.Image = Properties.Resources.ThomasMad;

                    greenButton.Text = "PRESS";

                    redButton.Text = "PRESS";

                    blueButton.Text = "PRESS";
                    break;
                case 37: // 80% win (WIN)
                    displayLabel.Text = "Your boss was no match for your martial skill, your boss lays on the ground groaning in pain";

                    pictureLabel.Image = Properties.Resources.Boss4;

                    pictureLabel.Refresh();

                    displayLabel.Refresh();

                    Thread.Sleep(2000);

                    displayLabel.Text = "Your coworkers approach you bearing a crown, you are the boss now, nobody can challenge your power";

                    pictureLabel.Image = Properties.Resources.Crown;

                    greenButton.Text = "WINNER";

                    redButton.Text = "WINNER";

                    blueButton.Text = "WINNER";
                    break;
                case 38: // 20% fail (LOSS)
                    displayLabel.Text = "you take hit after hit, you haven't managed to punsh him once, you lie on the ground ashamed and a loser, you will never find employement ever again, you starve alone in poverty";

                    pictureLabel.Image = Properties.Resources.Failure1;

                    greenButton.Text = "FAILURE!";

                    redButton.Text = "FAILURE!";

                    blueButton.Text = "FAILURE!";

                    break;
                default:
                    break;


            }
        }
    }
}
