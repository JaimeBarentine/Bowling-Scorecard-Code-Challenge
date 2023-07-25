using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jaime_barentine_bowling_code_challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // used to keep track of whose turn it is
        public int currentPlayer = 0;
        // used to track if it's the first roll of the turn or not
        public bool firstRoll = true;
        // used to keep track of when two strikes are rolled in a row
        public bool doubleStrike = false;

        

        // list of player names
        public List<String> playerNames = new List<String>();


        // this function determines which textbox should be enabled for the next turn
        public void NextTurn(string nameRef)
        {
            // tells the TextChangeEvent that it's the first frame of the turn again
            firstRoll = true;
            
            // gets the first four characters of the last text box's name
            // the first four of the text boxes' names follow a p1t1 format, which stands for "player 1 turn 1"
            nameRef = nameRef.Substring(0, 4);
            
            // checks to see which player's turn it is
            if (currentPlayer == 0)
            {

                // checks to see if it's a 1 or 2 player game
                if(playerNames.Count == 1)
                {
                    // enables and disables relevant textboxes to advance to the next turn
                    if (nameRef == "p1t1")
                    {
                        p1t1_first.IsEnabled = false;
                        p1t1_second.IsEnabled = false;
                        p1t2_first.IsEnabled = true;
                    }else if(nameRef == "p1t2")
                    {
                        p1t2_first.IsEnabled = false;
                        p1t2_second.IsEnabled = false;
                        p1t3_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t3")
                    {
                        p1t3_first.IsEnabled = false;
                        p1t3_second.IsEnabled = false;
                        p1t4_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t4")
                    {
                        p1t4_first.IsEnabled = false;
                        p1t4_second.IsEnabled = false;
                        p1t5_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t5")
                    {
                        p1t5_first.IsEnabled = false;
                        p1t5_second.IsEnabled = false;
                        p1t6_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t6")
                    {
                        p1t6_first.IsEnabled = false;
                        p1t6_second.IsEnabled = false;
                        p1t7_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t7")
                    {
                        p1t7_first.IsEnabled = false;
                        p1t7_second.IsEnabled = false;
                        p1t8_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t8")
                    {
                        p1t8_first.IsEnabled = false;
                        p1t8_second.IsEnabled = false;
                        p1t9_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t9")
                    {
                        p1t9_first.IsEnabled = false;
                        p1t9_second.IsEnabled = false;
                        p1t10_first.IsEnabled = true;
                    }
                }
                // coming from player 1's turn in a two player game
                else
                {
                    // enables and disables relevant textboxes to advance to the next turn
                    if (nameRef == "p1t1")
                    {
                        p1t1_first.IsEnabled = false;
                        p1t1_second.IsEnabled = false;
                        p2t1_first.IsEnabled = true;
                        
                    }
                    else if (nameRef == "p1t2")
                    {
                        p1t2_first.IsEnabled = false;
                        p1t2_second.IsEnabled = false;
                        p2t2_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t3")
                    {
                        p1t3_first.IsEnabled = false;
                        p1t3_second.IsEnabled = false;
                        p2t3_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t4")
                    {
                        p1t4_first.IsEnabled = false;
                        p1t4_second.IsEnabled = false;
                        p2t4_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t5")
                    {
                        p1t5_first.IsEnabled = false;
                        p1t5_second.IsEnabled = false;
                        p2t5_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t6")
                    {
                        p1t6_first.IsEnabled = false;
                        p1t6_second.IsEnabled = false;
                        p2t6_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t7")
                    {
                        p1t7_first.IsEnabled = false;
                        p1t7_second.IsEnabled = false;
                        p2t7_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t8")
                    {
                        p1t8_first.IsEnabled = false;
                        p1t8_second.IsEnabled = false;
                        p2t8_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t9")
                    {
                        p1t9_first.IsEnabled = false;
                        p1t9_second.IsEnabled = false;
                        p2t9_first.IsEnabled = true;
                    }
                    else if (nameRef == "p1t10")
                    {
                        p1t9_first.IsEnabled = false;
                        p1t9_second.IsEnabled = false;
                        p2t10_first.IsEnabled = true;
                        
                    }
                    currentPlayer = 1;
                    DebugText.Text = "Player 2's turn.";
                }

            }
            // player 2's turn
            else
            {
                // enables and disables relevant textboxes to advance to the next turn
                if (nameRef == "p2t1")
                {
                    p2t1_first.IsEnabled = false;
                    p2t1_second.IsEnabled = false;
                    p1t2_first.IsEnabled = true;
                }
                else if (nameRef == "p2t2")
                {
                    p2t2_first.IsEnabled = false;
                    p2t2_second.IsEnabled = false;
                    p1t3_first.IsEnabled = true;
                }
                else if (nameRef == "p2t3")
                {
                    p2t3_first.IsEnabled = false;
                    p2t3_second.IsEnabled = false;
                    p1t4_first.IsEnabled = true;
                }
                else if (nameRef == "p2t4")
                {
                    p2t4_first.IsEnabled = false;
                    p2t4_second.IsEnabled = false;
                    p1t5_first.IsEnabled = true;
                }
                else if (nameRef == "p2t5")
                {
                    p2t5_first.IsEnabled = false;
                    p2t5_second.IsEnabled = false;
                    p1t6_first.IsEnabled = true;
                }
                else if (nameRef == "p2t6")
                {
                    p2t6_first.IsEnabled = false;
                    p2t6_second.IsEnabled = false;
                    p1t7_first.IsEnabled = true;
                }
                else if (nameRef == "p2t7")
                {
                    p2t7_first.IsEnabled = false;
                    p2t7_second.IsEnabled = false;
                    p1t8_first.IsEnabled = true;
                }
                else if (nameRef == "p2t8")
                {
                    p2t8_first.IsEnabled = false;
                    p2t8_second.IsEnabled = false;
                    p1t9_first.IsEnabled = true;
                }
                else if (nameRef == "p2t9")
                {
                    p2t9_first.IsEnabled = false;
                    p2t9_second.IsEnabled = false;
                    p1t10_first.IsEnabled = true;
                }
                currentPlayer = 0;
                DebugText.Text = "Player 1's turn.";
            }
            
            
        }

        

        public MainWindow()
        {
            InitializeComponent();
        }

        // button for adding names to the scoreboard
        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                // adds names to a list and displays them based on their index
                // there were originally going to be 4 players possible, but I ran short on time
                playerNames.Add(txtName.Text);
                txtName.Clear();
                Player1.Text = playerNames[0];
                p1t1_first.IsEnabled = true;

                // if the maximum players have been added (2 in this case), disables the add button
                if (playerNames.Count > 1)
                {
                    Player2.Text = playerNames[1];
                    btnAdd.IsEnabled = false;
                    /*
                    if (playerNames.Count > 2)
                    {
                        Player3.Text = playerNames[2];
                        if (playerNames.Count > 3)
                        {
                            Player4.Text = playerNames[3];
                            btnAdd.IsEnabled = false;
                        }
                    }
                    */
                }
                //Player5.Text = playerNames[4];
            }
        }

        // the reset button
        // sets all elements and variables back to default
        private void ButtonClearName_Click(object sender, RoutedEventArgs e)
        {
            playerNames.Clear();
            //Array.Clear(score, 0, score.Length);
            Player1.Text = "";
            Player2.Text = "";
            Player3.Text = "";
            Player4.Text = "";
            p1t1_first.Text = "";
            p1t1_first.IsEnabled = false;
            p1t1_second.Text = "";
            p1t1_second.IsEnabled = false;
            p1t1_final.Text = "";
            p1t2_first.Text = "";
            p1t2_first.IsEnabled = false;
            p1t2_second.Text = "";
            p1t2_second.IsEnabled = false;
            p1t2_final.Text = "";
            p1t3_first.Text = "";
            p1t3_first.IsEnabled = false;
            p1t3_second.Text = "";
            p1t3_second.IsEnabled = false;
            p1t3_final.Text = "";
            p1t4_first.Text = "";
            p1t4_first.IsEnabled = false;
            p1t4_second.Text = "";
            p1t4_second.IsEnabled = false;
            p1t4_final.Text = "";
            p1t5_first.Text = "";
            p1t5_first.IsEnabled = false;
            p1t5_second.Text = "";
            p1t5_second.IsEnabled = false;
            p1t5_final.Text = "";
            p1t6_first.Text = "";
            p1t6_first.IsEnabled = false;
            p1t6_second.Text = "";
            p1t6_second.IsEnabled = false;
            p1t6_final.Text = "";
            p1t7_first.Text = "";
            p1t7_first.IsEnabled = false;
            p1t7_second.Text = "";
            p1t7_second.IsEnabled = false;
            p1t7_final.Text = "";
            p1t8_first.Text = "";
            p1t8_first.IsEnabled = false;
            p1t8_second.Text = "";
            p1t8_second.IsEnabled = false;
            p1t8_final.Text = "";
            p1t9_first.Text = "";
            p1t9_first.IsEnabled = false;
            p1t9_second.Text = "";
            p1t9_second.IsEnabled = false;
            p1t9_final.Text = "";
            p1t10_first.Text = "";
            p1t10_first.IsEnabled = false;
            p1t10_second.Text = "";
            p1t10_second.IsEnabled = false;
            p1t10_third.Text = "";
            p1t10_third.IsEnabled = false;
            p1t10_final.Text = "";
            p2t1_first.Text = "";
            p2t1_first.IsEnabled = false;
            p2t1_second.Text = "";
            p2t1_second.IsEnabled = false;
            p2t1_final.Text = "";
            p2t2_first.Text = "";
            p2t2_first.IsEnabled = false;
            p2t2_second.Text = "";
            p2t2_second.IsEnabled = false;
            p2t2_final.Text = "";
            p2t3_first.Text = "";
            p2t3_first.IsEnabled = false;
            p2t3_second.Text = "";
            p2t3_second.IsEnabled = false;
            p2t3_final.Text = "";
            p2t4_first.Text = "";
            p2t4_first.IsEnabled = false;
            p2t4_second.Text = "";
            p2t4_second.IsEnabled = false;
            p2t4_final.Text = "";
            p2t5_first.Text = "";
            p2t5_first.IsEnabled = false;
            p2t5_second.Text = "";
            p2t5_second.IsEnabled = false;
            p2t5_final.Text = "";
            p2t6_first.Text = "";
            p2t6_first.IsEnabled = false;
            p2t6_second.Text = "";
            p2t6_second.IsEnabled = false;
            p2t6_final.Text = "";
            p2t7_first.Text = "";
            p2t7_first.IsEnabled = false;
            p2t7_second.Text = "";
            p2t7_second.IsEnabled = false;
            p2t7_final.Text = "";
            p2t8_first.Text = "";
            p2t8_first.IsEnabled = false;
            p2t8_second.Text = "";
            p2t8_second.IsEnabled = false;
            p2t8_final.Text = "";
            p2t9_first.Text = "";
            p2t9_first.IsEnabled = false;
            p2t9_second.Text = "";
            p2t9_second.IsEnabled = false;
            p2t9_final.Text = "";
            p2t10_first.Text = "";
            p2t10_first.IsEnabled = false;
            p2t10_second.Text = "";
            p2t10_second.IsEnabled = false;
            p2t10_third.Text = "";
            p2t10_third.IsEnabled = false;
            p2t10_final.Text = "";
            btnAdd.IsEnabled = true;
            firstRoll = true;
            currentPlayer = 0;
            DebugText.Text = "Add a name, fill a box to start.";
        }

        

        // a function for quickly converting a "/", "x", or "_" into a number
        public int ConvertScore(string toConvert)
        {

            int outNum = 0;
            if(toConvert == "/" || toConvert == "x")
            {
                outNum = 10;
            }else if(toConvert == "_")
            {
                outNum = 0;
            }
            else
            {
                outNum = Int32.Parse(toConvert);
            }
            return outNum;
        }

        ///////////////////////////////
        /*
        The following Event contains the largest chunk of code in this class
        It is essentially the logic for each individual score box as they are associated with the boxes around them
        p1t1 is my naming convention that stands for "player 1 turn 1"
        Therefore, p2t4 would be "player 2 turn 4", etc.
        p1t1_first just means it's the textbox for the first roll of the turn
        p1t1_second would mean it's the second roll's textbox
        p1t10_third; only the 10th turn has a 3rd roll, so its logic slightly differs from the rest and has a 3rd input textbox
        Due to time, most of the if-elses are copied and pasted
        Most relevant comments are on the top/original instance of the copied statement
        Given more time, my next step would be to condense all of this into a couple clean functions
        I'm currently kicking myself for not having done that from the start

        The central if-else is split into three parts:

        At the top, the third and final roll of turn 10
        Underneath that is the first roll of each turn for both players
        At the bottom is the second roll of each turn for both players
        Sections are separated by /////////////

        */



        // called every time a score is changed
        private void ScoreChangeEvent(object sender, TextChangedEventArgs e)
        {

            // used to get the name of the textbox that was changed
            TextBox txt = (TextBox)sender;

            // this is to ensure only one number is typed
            if(txt.Text.Length > 1)
            {
                txt.TextChanged -= this.ScoreChangeEvent;
                txt.Text = txt.Text[0].ToString();
                txt.TextChanged += this.ScoreChangeEvent;
            }

            // checks to see if input was a valid character
            if (txt.Text == "/" || txt.Text == "_" || txt.Text == "x" || int.TryParse(txt.Text, out _))
            {
                
                // disables the ability to add more names
                btnAdd.IsEnabled = false;

                //Checks to see if it's the last frame of the last turn
                if (txt.Name == "p1t10_third" || txt.Name == "p2t10_third")
                {

                    // if the third frame of the 10th turn
                    if (txt.Name == "p1t10_third")
                    {
                        // calculate final score
                        if(playerNames.Count > 1)
                        {
                            p2t10_first.IsEnabled = true;
                        }
                        p1t10_third.IsEnabled = false;
                        if (p1t10_first.Text == "x")
                        {
                            p1t10_final.Text = (ConvertScore(p1t10_final.Text) + 10).ToString();
                        }
                        else if(p1t10_second.Text == "/")
                        {
                            p1t10_final.Text = (ConvertScore(p1t9_final.Text) + ConvertScore(p1t10_second.Text) + ConvertScore(p1t10_third.Text)).ToString();
                        }
                        else
                        {
                            p1t10_final.Text = (ConvertScore(p1t9_final.Text) + ConvertScore(p1t10_first.Text) + ConvertScore(p1t10_second.Text) + ConvertScore(p1t10_third.Text)).ToString();
                        }
                    }
                    // same calculations of final score, but for player 2
                    else
                    {
                        p2t10_third.IsEnabled = false;


                        if (p2t10_first.Text == "x")
                        {
                            p2t10_final.Text = (ConvertScore(p2t10_final.Text) + 10).ToString();
                        }
                        else if(p2t10_second.Text == "/")
                        {
                            p2t10_final.Text = (ConvertScore(p2t9_final.Text) + ConvertScore(p2t10_second.Text) + ConvertScore(p2t10_third.Text)).ToString();
                        }
                        else
                        {
                            p2t10_final.Text = (ConvertScore(p2t9_final.Text) + ConvertScore(p2t10_first.Text) + ConvertScore(p2t10_second.Text) + ConvertScore(p2t10_third.Text)).ToString();
                        }

                        if(ConvertScore(p1t10_final.Text) > ConvertScore(p2t10_final.Text))
                        {
                            DebugText.Text = "Player 1 is the winner!";
                        }
                        else if (ConvertScore(p1t10_final.Text) < ConvertScore(p2t10_final.Text))
                        {
                            DebugText.Text = "Player 2 takes the win!";
                        }
                        else
                        {
                            DebugText.Text = "It's a tie!";
                        }

                    }

                }
                //////////////////////////// end of third frame for last roll
                else
                {

                    // calculates the score up to this point, referencing numbers stored in the TextBoxes 
                    // if first ball of the turn
                    if (firstRoll)
                    {

                        firstRoll = false;

                        if (txt.Text == "/" || txt.Text == "x")
                        {
                            txt.TextChanged -= this.ScoreChangeEvent;
                            txt.Text = "x";
                            txt.TextChanged += this.ScoreChangeEvent;
                        }


                        // relevant text boxes are enabled or disabled to allow the user to enter more info
                        //////////// player 1 /////////////////////
                        if (txt.Name == "p1t1_first")
                        {
                            // disables the box that was just filled
                            p1t1_first.IsEnabled = false;

                            // handles the strike scenario, filling in the second frame
                            if (txt.Text == "x")
                            {
                                p1t1_second.IsEnabled = false;
                                p1t1_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;
                                
                            }
                            else
                            {
                                p1t1_second.IsEnabled = true;
                            }

                            // the total for turn is calculated and displayed
                            p1t1_final.Text = ConvertScore(txt.Text).ToString();
                        }
                        else if (txt.Name == "p1t2_first")
                        {

                            // checks to see if last turn had a strike or spare
                            if (p1t1_first.Text == "x" || p1t1_second.Text == "/")
                            {
                                // if this turn and the last were strikes, add 20
                                if (p1t1_first.Text == "x" && txt.Text == "x")
                                {
                                    p1t1_final.Text = (ConvertScore(p1t1_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                    
                                }
                                // else add this frame's score to the last
                                else
                                {
                                    p1t1_final.Text = (ConvertScore(p1t1_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            // strike scenario
                            p1t2_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p1t2_second.IsEnabled = false;
                                p1t2_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;
                                
                            }
                            else
                            {
                                p1t2_second.IsEnabled = true;
                            }

                            

                            

                            // the total for turn is calculated and displayed

                                p1t2_final.Text = (ConvertScore(p1t1_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        // code for players 1 and 2 are copied up until the else that separates the second frame of the turn
                        else if (txt.Name == "p1t3_first")
                        {



                            //p1t2_final.Text = (ConvertScore(p1t2_final.Text) + ConvertScore(txt.Text)).ToString();
                            if (doubleStrike && txt.Text == "x")
                            {
                                doubleStrike = false;
                                p1t1_final.Text = (ConvertScore(p1t1_final.Text) + ConvertScore(txt.Text)).ToString();
                            }
                            

                            if (p1t2_first.Text == "x" || p1t2_second.Text == "/")
                            {
                                if (p1t2_first.Text == "x" && txt.Text == "x")
                                {
                                    p1t2_final.Text = (ConvertScore(p1t2_final.Text) + 10).ToString();
                                    doubleStrike = true;

                                }
                                else
                                {
                                    p1t2_final.Text = (ConvertScore(p1t2_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p1t3_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p1t3_second.IsEnabled = false;
                                p1t3_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;
                                
                            }
                            else
                            {
                                p1t3_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p1t3_final.Text = (ConvertScore(p1t2_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p1t4_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {
                                
                                p1t2_final.Text = (ConvertScore(p1t2_final.Text) + ConvertScore(txt.Text)).ToString();
                                
                                    doubleStrike = false;
                                
                            }

                            if (p1t3_first.Text == "x" || p1t3_second.Text == "/")
                            {
                                if (p1t3_first.Text == "x" && txt.Text == "x")
                                {



                                    p1t3_final.Text = (ConvertScore(p1t3_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {


                                    p1t3_final.Text = (ConvertScore(p1t3_final.Text) + ConvertScore(txt.Text)).ToString();

                                }
                            }

                            p1t4_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p1t4_second.IsEnabled = false;
                                NextTurn(txt.Name);
                                firstRoll = true;
                                
                                p1t4_second.Text = "_";
                            }
                            else
                            {
                                p1t4_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p1t4_final.Text = (ConvertScore(p1t3_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p1t5_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {
                                
                                p1t3_final.Text = (ConvertScore(p1t3_final.Text) + ConvertScore(txt.Text)).ToString();
                                
                                    doubleStrike = false;
                                
                            }

                            if (p1t4_first.Text == "x" || p1t4_second.Text == "/")
                            {
                                if (p1t4_first.Text == "x" && txt.Text == "x")
                                {
                                    p1t4_final.Text = (ConvertScore(p1t4_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p1t4_final.Text = (ConvertScore(p1t4_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p1t5_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p1t5_second.IsEnabled = false;
                                NextTurn(txt.Name);
                                firstRoll = true;
                                
                                p1t5_second.Text = "_";
                            }
                            else
                            {
                                p1t5_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p1t5_final.Text = (ConvertScore(p1t4_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p1t6_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {
                                
                                    p1t4_final.Text = (ConvertScore(p1t4_final.Text) + ConvertScore(txt.Text)).ToString();
                                
                                    doubleStrike = false;
                                
                            }

                            if (p1t5_first.Text == "x" || p1t5_second.Text == "/")
                            {
                                if (p1t5_first.Text == "x" && txt.Text == "x")
                                {
                                    p1t5_final.Text = (ConvertScore(p1t5_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p1t5_final.Text = (ConvertScore(p1t5_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p1t6_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p1t6_second.IsEnabled = false;
                                p1t6_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;
                                
                            }
                            else
                            {
                                p1t6_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p1t6_final.Text = (ConvertScore(p1t5_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p1t7_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {

                                p1t5_final.Text = (ConvertScore(p1t5_final.Text) + ConvertScore(txt.Text)).ToString();
                                doubleStrike = false;
                                
                            }

                            if (p1t6_first.Text == "x" || p1t6_second.Text == "/")
                            {

                                if (p1t6_first.Text == "x" && txt.Text == "x")
                                {
                                    p1t6_final.Text = (ConvertScore(p1t6_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p1t6_final.Text = (ConvertScore(p1t6_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p1t7_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p1t7_second.IsEnabled = false;
                                p1t7_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;
                               
                            }
                            else
                            {
                                p1t7_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p1t7_final.Text = (ConvertScore(p1t6_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p1t8_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {
                                
                                    doubleStrike = false;
                                
                            }

                            if (p1t7_first.Text == "x" || p1t7_second.Text == "/")
                            {
                                if (p1t7_first.Text == "x" && txt.Text == "x")
                                {
                                    p1t7_final.Text = (ConvertScore(p1t7_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p1t7_final.Text = (ConvertScore(p1t7_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p1t8_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p1t8_second.IsEnabled = false;
                                p1t8_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;
                               
                            }
                            else
                            {
                                p1t8_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p1t8_final.Text = (ConvertScore(p1t7_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p1t9_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {
                                
                                    doubleStrike = false;
                                
                            }

                            if (p1t8_first.Text == "x" || p1t8_second.Text == "/")
                            {

                                if (p1t8_first.Text == "x" && txt.Text == "x")
                                {
                                    p1t8_final.Text = (ConvertScore(p1t8_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p1t8_final.Text = (ConvertScore(p1t8_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p1t9_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p1t9_second.IsEnabled = false;
                                p1t9_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;
                                
                            }
                            else
                            {
                                p1t9_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p1t9_final.Text = (ConvertScore(p1t8_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p1t10_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {
                                
                                    doubleStrike = false;
                                
                            }

                            if (p1t9_first.Text == "x" || p1t9_second.Text == "/")
                            {
                                if (p1t9_first.Text == "x" && txt.Text == "x")
                                {
                                    p1t9_final.Text = (ConvertScore(p1t9_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p1t9_final.Text = (ConvertScore(p1t9_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p1t10_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p1t10_second.IsEnabled = false;
                                p1t10_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;
                                if (p1t10_first.Text == "x" || p1t10_second.Text == "/")
                                {
                                    p1t10_third.IsEnabled = true;
                                }

                            }
                            else
                            {
                                p1t10_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p1t10_final.Text = (ConvertScore(p1t9_final.Text) + ConvertScore(txt.Text)).ToString();
                        }

                        //////////// player 2 /////////////////////
                        if (txt.Name == "p2t1_first")
                        {
                            p2t1_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t1_second.IsEnabled = false;
                                p2t1_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;

                            }
                            else
                            {
                                p2t1_second.IsEnabled = true;
                            }

                            // the total for turn is calculated and displayed
                            p2t1_final.Text = ConvertScore(txt.Text).ToString();
                        }
                        else if (txt.Name == "p2t2_first")
                        {

                            if (p2t1_first.Text == "x" || p2t1_second.Text == "/")
                            {
                                if (p2t1_first.Text == "x" && txt.Text == "x")
                                {
                                    p2t1_final.Text = (ConvertScore(p2t1_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p2t1_final.Text = (ConvertScore(p2t1_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p2t2_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t2_second.IsEnabled = false;
                                p2t2_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;

                            }
                            else
                            {
                                p2t2_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p2t2_final.Text = (ConvertScore(p2t1_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p2t3_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {

                                p2t1_final.Text = (ConvertScore(p2t1_final.Text) + ConvertScore(txt.Text)).ToString();


                                doubleStrike = false;

                            }

                            if (p2t2_first.Text == "x" || p2t2_second.Text == "/")
                            {
                                if (p2t2_first.Text == "x" && txt.Text == "x")
                                {
                                    p2t2_final.Text = (ConvertScore(p2t2_final.Text) + 10).ToString();

                                }
                                else
                                {
                                    p2t2_final.Text = (ConvertScore(p2t2_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                                p2t3_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t3_second.IsEnabled = false;
                                p2t3_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;

                            }
                            else
                            {
                                p2t3_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p2t3_final.Text = (ConvertScore(p2t2_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p2t4_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {

                                p2t2_final.Text = (ConvertScore(p2t2_final.Text) + ConvertScore(txt.Text)).ToString();

                                doubleStrike = false;

                            }

                            if (p2t3_first.Text == "x" || p2t3_second.Text == "/")
                            {
                                if (p2t3_first.Text == "x" && txt.Text == "x")
                                {
                                    p2t3_final.Text = (ConvertScore(p2t3_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p2t3_final.Text = (ConvertScore(p2t3_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p2t4_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t4_second.IsEnabled = false;
                                NextTurn(txt.Name);
                                firstRoll = true;

                                p2t4_second.Text = "_";
                            }
                            else
                            {
                                p2t4_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p2t4_final.Text = (ConvertScore(p2t3_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p2t5_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {

                                p2t3_final.Text = (ConvertScore(p2t3_final.Text) + ConvertScore(txt.Text)).ToString();

                                doubleStrike = false;

                            }

                            if (p2t4_first.Text == "x" || p2t4_second.Text == "/")
                            {
                                if (p2t4_first.Text == "x" && txt.Text == "x")
                                {
                                    p2t4_final.Text = (ConvertScore(p2t4_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p2t4_final.Text = (ConvertScore(p2t4_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p2t5_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t5_second.IsEnabled = false;
                                NextTurn(txt.Name);
                                firstRoll = true;

                                p2t5_second.Text = "_";
                            }
                            else
                            {
                                p2t5_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p2t5_final.Text = (ConvertScore(p2t4_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p2t6_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {

                                p2t4_final.Text = (ConvertScore(p2t4_final.Text) + ConvertScore(txt.Text)).ToString();

                                doubleStrike = false;

                            }

                            if (p2t5_first.Text == "x" || p2t5_second.Text == "/")
                            {
                                if (p2t5_first.Text == "x" && txt.Text == "x")
                                {
                                    p2t5_final.Text = (ConvertScore(p2t5_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p2t5_final.Text = (ConvertScore(p2t5_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p2t6_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t6_second.IsEnabled = false;
                                p2t6_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;

                            }
                            else
                            {
                                p2t6_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p2t6_final.Text = (ConvertScore(p2t5_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p2t7_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {

                                p2t5_final.Text = (ConvertScore(p2t5_final.Text) + ConvertScore(txt.Text)).ToString();

                                doubleStrike = false;

                            }

                            if (p2t6_first.Text == "x" || p2t6_second.Text == "/")
                            {
                                if (p2t6_first.Text == "x" && txt.Text == "x")
                                {
                                    p2t6_final.Text = (ConvertScore(p2t6_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p2t6_final.Text = (ConvertScore(p2t6_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p2t7_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t7_second.IsEnabled = false;
                                p2t7_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;

                            }
                            else
                            {
                                p2t7_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p2t7_final.Text = (ConvertScore(p2t6_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p2t8_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {

                                p2t6_final.Text = (ConvertScore(p2t6_final.Text) + ConvertScore(txt.Text)).ToString();

                                doubleStrike = false;

                            }

                            if (p2t7_first.Text == "x" || p2t7_second.Text == "/")
                            {
                                if (p2t7_first.Text == "x" && txt.Text == "x")
                                {
                                    p2t7_final.Text = (ConvertScore(p2t7_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p2t7_final.Text = (ConvertScore(p2t7_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p2t8_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t8_second.IsEnabled = false;
                                p2t8_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;

                            }
                            else
                            {
                                p2t8_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p2t8_final.Text = (ConvertScore(p2t7_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p2t9_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {

                                p2t7_final.Text = (ConvertScore(p2t7_final.Text) + ConvertScore(txt.Text)).ToString();

                                doubleStrike = false;

                            }

                            if (p2t8_first.Text == "x" || p2t8_second.Text == "/")
                            {
                                if (p2t8_first.Text == "x" && txt.Text == "x")
                                {
                                    p2t8_final.Text = (ConvertScore(p2t8_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p2t8_final.Text = (ConvertScore(p2t8_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p2t9_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t9_second.IsEnabled = false;
                                p2t9_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;

                            }
                            else
                            {
                                p2t9_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p2t9_final.Text = (ConvertScore(p2t8_final.Text) + ConvertScore(txt.Text)).ToString();
                        }
                        else if (txt.Name == "p2t10_first")
                        {

                            if (doubleStrike && txt.Text == "x")
                            {

                                p2t8_final.Text = (ConvertScore(p2t8_final.Text) + ConvertScore(txt.Text)).ToString();

                                doubleStrike = false;

                            }

                            if (p2t9_first.Text == "x" || p2t9_second.Text == "/")
                            {
                                if (p2t9_first.Text == "x" && txt.Text == "x")
                                {
                                    p2t9_final.Text = (ConvertScore(p2t9_final.Text) + 10).ToString();
                                    doubleStrike = true;
                                }
                                else
                                {
                                    p2t9_final.Text = (ConvertScore(p2t9_final.Text) + ConvertScore(txt.Text)).ToString();
                                }
                            }

                            p2t10_first.IsEnabled = false;
                            if (txt.Text == "x")
                            {
                                p2t10_second.IsEnabled = false;
                                p2t10_second.Text = "_";
                                //NextTurn();
                                firstRoll = true;
                                if (p2t10_first.Text == "x" || p2t10_second.Text == "/")
                                {
                                    p2t10_third.IsEnabled = true;
                                }

                            }
                            else
                            {
                                p2t10_second.IsEnabled = true;
                            }

                            

                            // the total for turn is calculated and displayed

                            p2t10_final.Text = (ConvertScore(p2t9_final.Text) + ConvertScore(txt.Text)).ToString();
                        }




                        // converts to gutter ball symbol if score is 0
                        if (ConvertScore(txt.Text) == 0)
                        {
                            txt.Text = "_";
                        }


                        


                    }
                    //////////////////////////////////////////////////////////////////////// end of first roll
                    // if it's the second roll of the turn
                    else
                    {

                        firstRoll = true;

                        //check which turn it is by text box
                        /////////////////// PLAYER 1 /////////////////
                        if (txt.Name == "p1t1_second")
                        {

                            // disables the box that was just filled
                            p1t1_second.IsEnabled = false;

                            // handles the strike scenario
                            if ((ConvertScore(p1t1_first.Text) + ConvertScore(p1t1_second.Text)) > 9)
                            {
                                if (p1t1_first.Text != "x")
                                {
                                    this.p1t1_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t1_second.Text = "/";
                                    this.p1t1_second.TextChanged += this.ScoreChangeEvent;
                                }
                                p1t1_final.Text = "10";
                            }
                            else
                            {
                                p1t1_final.Text = (ConvertScore(p1t1_first.Text) + ConvertScore(p1t1_second.Text)).ToString();
                            }


                            // runs a function that determines which box should be enabled for the next turn
                            NextTurn(txt.Name);

                        }
                        else if (txt.Name == "p1t2_second")
                        {

                            if (p1t1_first.Text == "x")
                            {
                                p1t1_final.Text = (ConvertScore(p1t1_final.Text) + ConvertScore(txt.Text)).ToString();
                            }

                            p1t2_second.IsEnabled = false;
                            if ((ConvertScore(p1t2_first.Text) + ConvertScore(p1t2_second.Text)) > 9)
                            {
                                if (p1t1_first.Text != "x")
                                {
                                    this.p1t2_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t2_second.Text = "/";
                                    this.p1t2_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p1t2_final.Text = (ConvertScore(p1t1_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p1t2_final.Text = (ConvertScore(p1t1_final.Text) + ConvertScore(p1t2_first.Text) + ConvertScore(p1t2_second.Text)).ToString();
                            }

                            p1t2_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p1t3_second")
                        {

                            if (p1t2_first.Text == "x")
                            {
                                p1t2_final.Text = (ConvertScore(p1t2_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p1t1_final.Text = (ConvertScore(p1t1_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p1t3_second.IsEnabled = false;
                            if ((ConvertScore(p1t3_first.Text) + ConvertScore(p1t3_second.Text)) > 9)
                            {
                                if (p1t2_first.Text != "x")
                                {
                                    this.p1t3_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t3_second.Text = "/";
                                    this.p1t3_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p1t3_final.Text = (ConvertScore(p1t2_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p1t3_final.Text = (ConvertScore(p1t2_final.Text) + ConvertScore(p1t3_first.Text) + ConvertScore(p1t3_second.Text)).ToString();
                            }

                            p1t3_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p1t4_second")
                        {

                            if (p1t3_first.Text == "x")
                            {
                                p1t3_final.Text = (ConvertScore(p1t3_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p1t2_final.Text = (ConvertScore(p1t2_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p1t4_second.IsEnabled = false;
                            if ((ConvertScore(p1t4_first.Text) + ConvertScore(p1t4_second.Text)) > 9)
                            {
                                if (p1t3_first.Text != "x")
                                {
                                    this.p1t4_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t4_second.Text = "/";
                                    this.p1t4_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p1t4_final.Text = (ConvertScore(p1t3_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p1t4_final.Text = (ConvertScore(p1t3_final.Text) + ConvertScore(p1t4_first.Text) + ConvertScore(p1t4_second.Text)).ToString();
                            }

                            p1t4_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p1t5_second")
                        {

                            if (p1t4_first.Text == "x")
                            {
                                p1t4_final.Text = (ConvertScore(p1t4_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p1t3_final.Text = (ConvertScore(p1t3_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p1t5_second.IsEnabled = false;
                            if ((ConvertScore(p1t5_first.Text) + ConvertScore(p1t5_second.Text)) > 9)
                            {
                                if (p1t4_first.Text != "x")
                                {
                                    this.p1t5_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t5_second.Text = "/";
                                    this.p1t5_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p1t5_final.Text = (ConvertScore(p1t4_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p1t5_final.Text = (ConvertScore(p1t4_final.Text) + ConvertScore(p1t5_first.Text) + ConvertScore(p1t5_second.Text)).ToString();
                            }

                            p1t5_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p1t6_second")
                        {

                            if (p1t5_first.Text == "x")
                            {
                                p1t5_final.Text = (ConvertScore(p1t5_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p1t4_final.Text = (ConvertScore(p1t4_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p1t6_second.IsEnabled = false;
                            if ((ConvertScore(p1t6_first.Text) + ConvertScore(p1t6_second.Text)) > 9)
                            {
                                if (p1t5_first.Text != "x")
                                {
                                    this.p1t6_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t6_second.Text = "/";
                                    this.p1t6_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p1t6_final.Text = (ConvertScore(p1t5_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p1t6_final.Text = (ConvertScore(p1t5_final.Text) + ConvertScore(p1t6_first.Text) + ConvertScore(p1t6_second.Text)).ToString();
                            }

                            p1t6_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p1t7_second")
                        {

                            if (p1t6_first.Text == "x")
                            {
                                p1t6_final.Text = (ConvertScore(p1t6_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p1t5_final.Text = (ConvertScore(p1t5_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p1t7_second.IsEnabled = false;
                            if ((ConvertScore(p1t7_first.Text) + ConvertScore(p1t7_second.Text)) > 9)
                            {
                                if (p1t6_first.Text != "x")
                                {
                                    this.p1t7_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t7_second.Text = "/";
                                    this.p1t7_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p1t7_final.Text = (ConvertScore(p1t6_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p1t7_final.Text = (ConvertScore(p1t6_final.Text) + ConvertScore(p1t7_first.Text) + ConvertScore(p1t7_second.Text)).ToString();
                            }

                            p1t7_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p1t8_second")
                        {

                            if (p1t7_first.Text == "x")
                            {
                                p1t7_final.Text = (ConvertScore(p1t7_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p1t6_final.Text = (ConvertScore(p1t6_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p1t8_second.IsEnabled = false;
                            if ((ConvertScore(p1t8_first.Text) + ConvertScore(p1t8_second.Text)) > 9)
                            {
                                if (p1t7_first.Text != "x")
                                {
                                    this.p1t8_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t8_second.Text = "/";
                                    this.p1t8_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p1t8_final.Text = (ConvertScore(p1t7_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p1t8_final.Text = (ConvertScore(p1t7_final.Text) + ConvertScore(p1t8_first.Text) + ConvertScore(p1t8_second.Text)).ToString();
                            }

                            p1t8_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p1t9_second")
                        {

                            if (p1t8_first.Text == "x")
                            {
                                p1t8_final.Text = (ConvertScore(p1t8_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p1t7_final.Text = (ConvertScore(p1t7_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p1t9_second.IsEnabled = false;
                            if ((ConvertScore(p1t9_first.Text) + ConvertScore(p1t9_second.Text)) > 9)
                            {
                                if (p1t8_first.Text != "x")
                                {
                                    this.p1t9_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t9_second.Text = "/";
                                    this.p1t9_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p1t9_final.Text = (ConvertScore(p1t8_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p1t9_final.Text = (ConvertScore(p1t8_final.Text) + ConvertScore(p1t9_first.Text) + ConvertScore(p1t9_second.Text)).ToString();
                            }

                            p1t9_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p1t10_second")
                        {

                            if (p1t9_first.Text == "x")
                            {
                                p1t9_final.Text = (ConvertScore(p1t9_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p1t8_final.Text = (ConvertScore(p1t8_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p1t10_second.IsEnabled = false;
                            if ((ConvertScore(p1t10_first.Text) + ConvertScore(p1t10_second.Text)) > 9)
                            {
                                if (p1t9_first.Text != "x")
                                {
                                    this.p1t10_second.TextChanged -= this.ScoreChangeEvent;
                                    p1t10_second.Text = "/";
                                    this.p1t10_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p1t10_final.Text = (ConvertScore(p1t9_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p1t10_final.Text = (ConvertScore(p1t9_final.Text) + ConvertScore(p1t10_first.Text) + ConvertScore(p1t10_second.Text)).ToString();
                            }

                            p1t10_second.IsEnabled = false;
                            if (p1t10_first.Text == "x" || p1t10_second.Text == "/")
                            {
                                p1t10_third.IsEnabled = true;
                            }
                            else
                            {
                                if(playerNames.Count > 1)
                                {
                                    
                                    p2t10_first.IsEnabled = true;
                                }
                            }
                            
                        }


                        /////////////////// PLAYER 2 /////////////////
                        if (txt.Name == "p2t1_second")
                        {

                            p2t1_second.IsEnabled = false;
                            if ((ConvertScore(p2t1_first.Text) + ConvertScore(p2t1_second.Text)) > 9)
                            {
                                if (p2t1_first.Text != "x")
                                {
                                    this.p2t1_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t1_second.Text = "/";
                                    this.p2t1_second.TextChanged += this.ScoreChangeEvent;
                                }
                                p2t1_final.Text = "10";
                            }
                            else
                            {
                                p2t1_final.Text = (ConvertScore(p2t1_first.Text) + ConvertScore(p2t1_second.Text)).ToString();
                            }

                            p2t1_second.IsEnabled = false;
                            NextTurn(txt.Name);

                        }
                        else if (txt.Name == "p2t2_second")
                        {

                            if (p2t1_first.Text == "x")
                            {
                                p2t1_final.Text = (ConvertScore(p2t1_final.Text) + ConvertScore(txt.Text)).ToString();
                            }

                            p2t2_second.IsEnabled = false;
                            if ((ConvertScore(p2t2_first.Text) + ConvertScore(p2t2_second.Text)) > 9)
                            {
                                if (p2t1_first.Text != "x")
                                {
                                    this.p2t2_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t2_second.Text = "/";
                                    this.p2t2_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p2t2_final.Text = (ConvertScore(p2t1_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p2t2_final.Text = (ConvertScore(p2t1_final.Text) + ConvertScore(p2t2_first.Text) + ConvertScore(p2t2_second.Text)).ToString();
                            }

                            p2t2_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p2t3_second")
                        {

                            if (p2t2_first.Text == "x")
                            {
                                p2t2_final.Text = (ConvertScore(p2t2_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p2t1_final.Text = (ConvertScore(p2t1_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p2t3_second.IsEnabled = false;
                            if ((ConvertScore(p2t3_first.Text) + ConvertScore(p2t3_second.Text)) > 9)
                            {
                                if (p2t2_first.Text != "x")
                                {
                                    this.p2t3_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t3_second.Text = "/";
                                    this.p2t3_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p2t3_final.Text = (ConvertScore(p2t2_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p2t3_final.Text = (ConvertScore(p2t2_final.Text) + ConvertScore(p2t3_first.Text) + ConvertScore(p2t3_second.Text)).ToString();
                            }

                            p2t3_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p2t4_second")
                        {

                            if (p2t3_first.Text == "x")
                            {
                                p2t3_final.Text = (ConvertScore(p2t3_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p2t2_final.Text = (ConvertScore(p2t2_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p2t4_second.IsEnabled = false;
                            if ((ConvertScore(p2t4_first.Text) + ConvertScore(p2t4_second.Text)) > 9)
                            {
                                if (p2t3_first.Text != "x")
                                {
                                    this.p2t4_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t4_second.Text = "/";
                                    this.p2t4_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p2t4_final.Text = (ConvertScore(p2t3_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p2t4_final.Text = (ConvertScore(p2t3_final.Text) + ConvertScore(p2t4_first.Text) + ConvertScore(p2t4_second.Text)).ToString();
                            }

                            p2t4_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p2t5_second")
                        {

                            if (p2t4_first.Text == "x")
                            {
                                p2t4_final.Text = (ConvertScore(p2t4_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p2t3_final.Text = (ConvertScore(p2t3_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p2t5_second.IsEnabled = false;
                            if ((ConvertScore(p2t5_first.Text) + ConvertScore(p2t5_second.Text)) > 9)
                            {
                                if (p2t4_first.Text != "x")
                                {
                                    this.p2t5_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t5_second.Text = "/";
                                    this.p2t5_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p2t5_final.Text = (ConvertScore(p2t4_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p2t5_final.Text = (ConvertScore(p2t4_final.Text) + ConvertScore(p2t5_first.Text) + ConvertScore(p2t5_second.Text)).ToString();
                            }

                            p2t5_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p2t6_second")
                        {

                            if (p2t5_first.Text == "x")
                            {
                                p2t5_final.Text = (ConvertScore(p2t5_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p2t4_final.Text = (ConvertScore(p2t4_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p2t6_second.IsEnabled = false;
                            if ((ConvertScore(p2t6_first.Text) + ConvertScore(p2t6_second.Text)) > 9)
                            {
                                if (p2t5_first.Text != "x")
                                {
                                    this.p2t6_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t6_second.Text = "/";
                                    this.p2t6_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p2t6_final.Text = (ConvertScore(p2t5_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p2t6_final.Text = (ConvertScore(p2t5_final.Text) + ConvertScore(p2t6_first.Text) + ConvertScore(p2t6_second.Text)).ToString();
                            }

                            p2t6_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p2t7_second")
                        {

                            if (p2t6_first.Text == "x")
                            {
                                p2t6_final.Text = (ConvertScore(p2t6_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p2t5_final.Text = (ConvertScore(p2t5_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p2t7_second.IsEnabled = false;
                            if ((ConvertScore(p2t7_first.Text) + ConvertScore(p2t7_second.Text)) > 9)
                            {
                                if (p2t6_first.Text != "x")
                                {
                                    this.p2t7_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t7_second.Text = "/";
                                    this.p2t7_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p2t7_final.Text = (ConvertScore(p2t6_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p2t7_final.Text = (ConvertScore(p2t6_final.Text) + ConvertScore(p2t7_first.Text) + ConvertScore(p2t7_second.Text)).ToString();
                            }

                            p2t7_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p2t8_second")
                        {

                            if (p2t7_first.Text == "x")
                            {
                                p2t7_final.Text = (ConvertScore(p2t7_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p2t6_final.Text = (ConvertScore(p2t6_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p2t8_second.IsEnabled = false;
                            if ((ConvertScore(p2t8_first.Text) + ConvertScore(p2t8_second.Text)) > 9)
                            {
                                if (p2t7_first.Text != "x")
                                {
                                    this.p2t8_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t8_second.Text = "/";
                                    this.p2t8_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p2t8_final.Text = (ConvertScore(p2t7_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p2t8_final.Text = (ConvertScore(p2t7_final.Text) + ConvertScore(p2t8_first.Text) + ConvertScore(p2t8_second.Text)).ToString();
                            }

                            p2t8_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p2t9_second")
                        {

                            if (p2t8_first.Text == "x")
                            {
                                p2t8_final.Text = (ConvertScore(p2t8_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p2t7_final.Text = (ConvertScore(p2t7_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p2t9_second.IsEnabled = false;
                            if ((ConvertScore(p2t9_first.Text) + ConvertScore(p2t9_second.Text)) > 9)
                            {
                                if (p2t8_first.Text != "x")
                                {
                                    this.p2t9_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t9_second.Text = "/";
                                    this.p2t9_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p2t9_final.Text = (ConvertScore(p2t8_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p2t9_final.Text = (ConvertScore(p2t8_final.Text) + ConvertScore(p2t9_first.Text) + ConvertScore(p2t9_second.Text)).ToString();
                            }

                            p2t9_second.IsEnabled = false;
                            NextTurn(txt.Name);
                        }
                        else if (txt.Name == "p2t10_second")
                        {

                            if (p2t9_first.Text == "x")
                            {
                                p2t9_final.Text = (ConvertScore(p2t9_final.Text) + ConvertScore(txt.Text)).ToString();
                                if (doubleStrike)
                                {
                                    p2t8_final.Text = (ConvertScore(p2t8_final.Text) + ConvertScore(txt.Text)).ToString();
                                    doubleStrike = false;
                                }
                            }

                            p2t10_second.IsEnabled = false;
                            if ((ConvertScore(p2t10_first.Text) + ConvertScore(p2t10_second.Text)) > 9)
                            {
                                if (p2t9_first.Text != "x")
                                {
                                    this.p2t10_second.TextChanged -= this.ScoreChangeEvent;
                                    p2t10_second.Text = "/";
                                    this.p2t10_second.TextChanged += this.ScoreChangeEvent;
                                }


                                p2t10_final.Text = (ConvertScore(p2t9_final.Text) + 10).ToString();
                            }
                            else
                            {
                                p2t10_final.Text = (ConvertScore(p2t9_final.Text) + ConvertScore(p2t10_first.Text) + ConvertScore(p2t10_second.Text)).ToString();
                            }

                            p2t10_second.IsEnabled = false;
                            if (p2t10_first.Text == "x" || p2t10_second.Text == "/")
                            {
                                p2t10_third.IsEnabled = true;
                            }
                            else
                            {
                                if (ConvertScore(p1t10_final.Text) > ConvertScore(p2t10_final.Text))
                                {
                                    DebugText.Text = "Player 1 is the winner!";
                                }
                                else if (ConvertScore(p1t10_final.Text) < ConvertScore(p2t10_final.Text))
                                {
                                    DebugText.Text = "Player 2 takes the win!";
                                }
                                else
                                {
                                    DebugText.Text = "It's a tie!";
                                }
                            }
                            //NextTurn(txt.Name);
                        }




                    }
                }
                
                /////////////////////////////// end of second roll
            }
            // if input is invalid, clear the textbox to prompt the user to type something else
            else
            {
                txt.Text = "";
            }
        }
        
    }
}
