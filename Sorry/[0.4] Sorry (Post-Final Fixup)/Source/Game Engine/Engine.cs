using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sorry{
    //internal class Player

    internal class Pawn {
        public struct TeamData {
            public string Name;
            public int TeamID;
            public Bitmap PawnImage;
            //public Bitmap PawnImageReady;
            //public Bitmap PawnImageSleep;
            public Color TeamColor;
            public int StartLocation;
            public int StartGateLocation;
            public int EndLocation;
            public int EndGateLocation;
        }

        TeamData teamOfPawn;
        int positionOfPawn;

        public Pawn(int defaultPosition) {
            positionOfPawn = 100;
        }

        public int Position {
            get { return positionOfPawn; }
            set { positionOfPawn = value; }
        }

        public TeamData Team {
            get { return teamOfPawn; }
            set { teamOfPawn = value; }
        }

        public void SetTeam(string color) {
            switch (color.ToLower()) {
            case "green":
                teamOfPawn.Name = "Green";
                teamOfPawn.TeamID = 3;
                teamOfPawn.PawnImage = global::Sorry.Properties.Resources.Ready_Green;
                teamOfPawn.TeamColor = Color.Green;
                teamOfPawn.StartLocation = 96;
                teamOfPawn.StartGateLocation = 49;
                teamOfPawn.EndLocation = 83;
                teamOfPawn.EndGateLocation = 47;
                break;
            case "blue":

                teamOfPawn.Name = "Blue";
                teamOfPawn.TeamID = 1;
                teamOfPawn.PawnImage = global::Sorry.Properties.Resources.Ready_Blue;
                teamOfPawn.TeamColor = Color.Blue;
                teamOfPawn.StartLocation = 88;
                teamOfPawn.StartGateLocation = 19;
                teamOfPawn.EndLocation = 71;
                teamOfPawn.EndGateLocation = 17;
                break;
            case "yellow":
                teamOfPawn.Name = "Yellow";
                teamOfPawn.TeamID = 2;
                teamOfPawn.PawnImage = global::Sorry.Properties.Resources.Ready_Yellow;
                teamOfPawn.TeamColor = Color.Yellow;
                teamOfPawn.StartLocation = 92;
                teamOfPawn.StartGateLocation = 34;
                teamOfPawn.EndLocation = 77;
                teamOfPawn.EndGateLocation = 32;
                break;
            case "red":
                teamOfPawn.Name = "Red";
                teamOfPawn.TeamID = 0;
                teamOfPawn.PawnImage = global::Sorry.Properties.Resources.Ready_Red;
                teamOfPawn.StartLocation = 84;
                teamOfPawn.TeamColor = Color.Red;
                teamOfPawn.StartGateLocation = 4;
                teamOfPawn.EndLocation = 65;
                teamOfPawn.EndGateLocation = 2;
                break;
            case "empty":
                teamOfPawn.Name = "DUMMY";
                teamOfPawn.TeamID = 4;
                teamOfPawn.StartLocation = 100;
                teamOfPawn.StartGateLocation = 100;
                teamOfPawn.EndLocation = 100;
                teamOfPawn.EndGateLocation = 100;
                break;
            }
        }
    }

    internal class Space : Button {
        int containedPawnIndex, idNumber;
        string spaceType;

        public Space(int defaultPawnIndex) {
            containedPawnIndex = defaultPawnIndex;
            spaceType = "Null";
        }

        public string Type {
            set {
                spaceType = value;
            }
            get {
                return spaceType;
            }
        }

        public int IndexOfPawnInSpace {
            set { containedPawnIndex = value; }
            get { return containedPawnIndex; }
        }

        public int IdNumber {
            set { idNumber = value; }
            get { return idNumber; }
        }

        public void SetCountImageAt(int number) {
            switch (number) {
            case 1:
                this.BackgroundImage = global::Sorry.Properties.Resources._1;
                break;
            case 2:
                this.BackgroundImage = global::Sorry.Properties.Resources._2;
                break;
            case 3:
                this.BackgroundImage = global::Sorry.Properties.Resources._3;
                break;
            case 4:
                this.BackgroundImage = global::Sorry.Properties.Resources._4;
                break;
            }
        }
    }

    internal class Card {
        string cardName, specialStuff;
        string[] validTeamTargets = new string[3];
        int cardAdvancement;
        bool givesExtraTurn;

        public Card() {
            givesExtraTurn = false;
        }

        public string[] TeamTargets {
            set { validTeamTargets = value; }
            get { return validTeamTargets; }
        }

        public string SpecialMoves {
            set { specialStuff = value; }
            get { return specialStuff; }
        }

        public string Name {
            set { cardName = value; }
            get { return cardName; }
        }

        public int AdvancementAmount {
            set { cardAdvancement = value; }
            get { return cardAdvancement; }
        }

        public bool GivesExtraTurn {
            set { givesExtraTurn = value; }
            get { return givesExtraTurn; }
        }
    }

    public partial class MainGame : Form {
        const int BUTTON_SIZE = 34;
        const int BUTTON_MARGIN = 2;
        const int BOARD_PADDING = 27;
        const int NUMBER_OF_PAWNS = 17;
        const int NUMBER_OF_SPACES = 101;
        const int NUMBER_OF_CARDS = 11;
        const int NUMBER_OF_PLAYERS = 4;
        const int DUMMY_PAWN = 16;
        const int DUMMY_SPACE = 100;

        SorryDebugger bugChecker = new SorryDebugger();
        Space[] sorrySpace = new Space[NUMBER_OF_SPACES];
        Pawn[] sorryPawn = new Pawn[NUMBER_OF_PAWNS];
        Card[] sorryCard = new Card[NUMBER_OF_CARDS];
        List<int> splitSpaces = new List<int>();

        int[] numOfPawnsFinished = new int[NUMBER_OF_PLAYERS];
        string[] playerName = new string[NUMBER_OF_PLAYERS];

        string startPosition;

        bool choosePawnMode, chooseSpaceMode, hasConflict;
        int chosenSpace, previousSpace, chosenPawnIndex, currentPlayer, pickedCard;
        //For [7-Card] Only
        bool secondPawnMode, secondSpaceMode;
        int chosenSpace2, previousSpace2, chosenPawnIndex2, lengthOfLastMove;

        public MainGame() {
            startPosition = "normal";
            FullReset();
        }
        public MainGame(string startLocationArgument) {
            startPosition = startLocationArgument;
            FullReset();
        }

        public void InitializePawns() {
            for (int i = 0; i < NUMBER_OF_PAWNS; i++) {
                sorryPawn[i] = new Pawn(DUMMY_PAWN);
                switch (i / 4) {
                case 0:
                    sorryPawn[i].SetTeam("Red");
                    break;
                case 1:
                    sorryPawn[i].SetTeam("Blue");
                    break;
                case 2:
                    sorryPawn[i].SetTeam("Yellow");
                    break;
                case 3:
                    sorryPawn[i].SetTeam("Green");
                    break;
                default:
                    break;
                }
            }

            sorryPawn[16].SetTeam("empty");

            for (int i = 0; i < NUMBER_OF_PAWNS; i++) {
                if (startPosition == "front")
                    SetPawnAtIndex(i, sorryPawn[i].Team.StartGateLocation - i % 4);
                else if (startPosition == "end")
                    SetPawnAtIndex(i, sorryPawn[i].Team.EndLocation - i % 4 - 1);
                else
                    SetPawnAtIndex(i, sorryPawn[i].Team.StartLocation + i % 4);
            }
        }
        public void InitializeCards() {
            for (int i = 0; i < NUMBER_OF_CARDS - 1; i++) {
                sorryCard[i] = new Card();
                sorryCard[i].TeamTargets[0] = "Normal";
                if (i != 8)
                    sorryCard[i].TeamTargets[1] = "Safe";
            }
            sorryCard[NUMBER_OF_CARDS - 1] = new Card();
            sorryCard[0].TeamTargets[2] = "Start";
            sorryCard[1].TeamTargets[2] = "Start";
            sorryCard[10].TeamTargets[0] = "Start";

            sorryCard[5].SpecialMoves = "Split";
            sorryCard[7].SpecialMoves = "ForceStepBack";
            sorryCard[8].SpecialMoves = "Switch";
            sorryCard[10].SpecialMoves = "Sorry";

            for (int i = 0; i < 5; i++)
                sorryCard[i].AdvancementAmount = i + 1;
            for (int i = 7; i < 10; i++)
                sorryCard[i].AdvancementAmount = i + 3;

            sorryCard[3].AdvancementAmount *= -1;
            sorryCard[5].AdvancementAmount = 7;
            sorryCard[6].AdvancementAmount = 8;

            sorryCard[1].GivesExtraTurn = true;

            sorryCard[0].Name = "[1-Card]" + "   Move a pawn from Start or move a pawn 1 space forward.";
            sorryCard[1].Name = "[2-Card]" + "   Move a pawn from Start or move a pawn 2 spaces forward. Drawing a 2 \n\nentitles the player to draw again at the end of his or her turn, whether the 2 itself can be used or not.";
            sorryCard[2].Name = "[3-Card]" + "   Move a pawn 3 spaces forward.";
            sorryCard[3].Name = "[4-Card]" + "   Move a pawn 4 spaces backwards.";
            sorryCard[4].Name = "[5-Card]" + "   Move a pawn 5 spaces forward.";
            sorryCard[5].Name = "[7-Card]" + "   Move one pawn 7 spaces forward or split the 7 spaces between two pawns \n(Such as making one pawn move 3 spaces and another space move 4). \n\n CAN'T be used to get out of the start space and the two pawns MUST move a total of seven spaces.";
            sorryCard[7].Name = "[10-Card]" + "   Move a pawn 10 spaces forward or 1 space backward. \n\nIf a player cannot go forward ten spaces, they must go back one space.";
            sorryCard[8].Name = "[11-Card]" + "   Move 11 spaces forward or switch places with one opposing pawn; \n\nif the player cannot move 11 spaces they are not forced to switch and instead can forfeit their turn.";
            sorryCard[9].Name = "[12-Card]" + "   Move a pawn 12 spaces forward.";
            sorryCard[10].Name = "[Sorry Card]" + "   Move any one pawn from Start to a square occupied by any opponent, sending that pawn back to its own Start. \n\nNothing happens if there are no opposing pawns on the board or there are no pawns in Start; the player instead can forfeit their turn.";

        }
        public void InitializeSpace() {
            for (int g = 0; g < NUMBER_OF_SPACES; g++) {
                sorrySpace[g] = new Space(DUMMY_PAWN);
                sorrySpace[g].Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                sorrySpace[g].IdNumber = g;
                sorrySpace[g].Click += new System.EventHandler(this.Space_Click);
                sorrySpace[g].FlatStyle = FlatStyle.Flat;
                sorrySpace[g].FlatAppearance.MouseOverBackColor = Color.Aquamarine;

                if (g <= 59) {
                    sorrySpace[g].Type = "Normal";
                }
                else if (g <= 83) {
                    if ((g - 65) % 6 == 0)
                        sorrySpace[g].Type = "Finish";
                    else
                        sorrySpace[g].Type = "Safe";
                }
                else if (g <= 99)
                    sorrySpace[g].Type = "Start";
                this.Controls.Add(sorrySpace[g]);
            }

            sorrySpace[100].Hide();

            int spaceIndx = 0;
            int i = 0;

            for (i = 0; i < 16; i++) {
                sorrySpace[spaceIndx].Location = new Point(i * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, 0 + BOARD_PADDING);
                spaceIndx++;
            }
            for (i = 0; i < 15; i++) {
                sorrySpace[spaceIndx].Location = new Point((BUTTON_SIZE + BUTTON_MARGIN) * 15 + BOARD_PADDING, (i + 1) * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
                spaceIndx++;
            }
            for (i = 14; i >= 0; i--) {
                sorrySpace[spaceIndx].Location = new Point((i) * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, (BUTTON_SIZE + BUTTON_MARGIN) * 15 + BOARD_PADDING);
                spaceIndx++;
            }

            for (i = 13; i >= 0; i--) {
                sorrySpace[spaceIndx].Location = new Point(BOARD_PADDING, (i + 1) * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
                spaceIndx++;
            }

            for (i = 0; i < 6; i++) {
                sorrySpace[spaceIndx].Location = new Point(2 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, (i + 1) * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
                spaceIndx++;
            }

            for (i = 6; i > 0; i--) {
                sorrySpace[spaceIndx].Location = new Point((i + 8) * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, 2 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
                spaceIndx++;
            }

            for (i = 6; i > 0; i--) {
                sorrySpace[spaceIndx].Location = new Point(13 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, (i + 8) * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
                spaceIndx++;
            }

            for (i = 0; i < 6; i++) {
                sorrySpace[spaceIndx].Location = new Point((i + 1) * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, 13 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
                spaceIndx++;
            }

            sorrySpace[spaceIndx].Location = new Point(4 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING, (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
            sorrySpace[spaceIndx + 1].Location = new Point(5 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING, (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
            sorrySpace[spaceIndx + 2].Location = new Point(4 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING, 2 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
            sorrySpace[spaceIndx + 3].Location = new Point(5 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING, 2 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);

            sorrySpace[spaceIndx + 4].Location = new Point(13 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, 4 * (BUTTON_SIZE + BUTTON_MARGIN) + (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING);
            sorrySpace[spaceIndx + 5].Location = new Point(13 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, 4 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING);
            sorrySpace[spaceIndx + 6].Location = new Point(14 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, 4 * (BUTTON_SIZE + BUTTON_MARGIN) + (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING);
            sorrySpace[spaceIndx + 7].Location = new Point(14 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, 4 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING);

            sorrySpace[spaceIndx + 8].Location = new Point(11 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING, 13 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
            sorrySpace[spaceIndx + 9].Location = new Point(12 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING, 13 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
            sorrySpace[spaceIndx + 10].Location = new Point(11 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING, 14 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);
            sorrySpace[spaceIndx + 11].Location = new Point(12 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING, 14 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING);

            sorrySpace[spaceIndx + 12].Location = new Point(BUTTON_SIZE + BUTTON_MARGIN + BOARD_PADDING, 11 * (BUTTON_SIZE + BUTTON_MARGIN) + (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING);
            sorrySpace[spaceIndx + 13].Location = new Point(BUTTON_SIZE + BUTTON_MARGIN + BOARD_PADDING, 11 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING);
            sorrySpace[spaceIndx + 14].Location = new Point(2 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, 11 * (BUTTON_SIZE + BUTTON_MARGIN) + (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING);
            sorrySpace[spaceIndx + 15].Location = new Point(2 * (BUTTON_SIZE + BUTTON_MARGIN) + BOARD_PADDING, 11 * (BUTTON_SIZE + BUTTON_MARGIN) - (BUTTON_SIZE + BUTTON_MARGIN) / 2 + BOARD_PADDING);
        }

        public void FullReset() {
            choosePawnMode = true;
            chooseSpaceMode = false;
            secondSpaceMode = false;
            secondPawnMode = false;
            hasConflict = false;
            pickedCard = 0;
            currentPlayer = 0;
            InitializeComponent();
            InitializeSpace();
            InitializeCards();
            InitializePawns();
            ResetBoardData();
            ResetBoardDisplay();
            GetNewCard();
            SetBoard();
            //===Debug==================================================================================
            UpdateDebugger();
            //==========================================================================================
        }
        public void ResetBoardData() {
            chosenSpace = 100;
            previousSpace = 100;
            hasConflict = false;
            chosenPawnIndex = 16;
            sorryPawn[chosenPawnIndex].Position = 100; //Temporary Fix
            chosenSpace2 = 100;
            previousSpace2 = 100;
            chosenPawnIndex2 = 16;
            splitSpaces.Clear();
            GetDebuggerData();
        }
        public void ResetBoardDisplay() {
            for (int i = 0; i < NUMBER_OF_SPACES; i++) {
                sorrySpace[i].FlatAppearance.BorderColor = Color.Silver;
                sorrySpace[i].FlatAppearance.BorderSize = 1;
                sorrySpace[i].BackgroundImage = null;
            }
            Lbl_Message.Text = "Player " + sorryPawn[currentPlayer * 4].Team.Name + "'s turn.";
            Lbl_Message.ForeColor = sorryPawn[currentPlayer * 4].Team.TeamColor;

            for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
                sorrySpace[65 + (i * 6)].SetCountImageAt(NUMBER_OF_PLAYERS - numOfPawnsFinished[i]);
        }
        public void ResetModes() {
            choosePawnMode = true;
            chooseSpaceMode = false;
            secondSpaceMode = false;
            secondPawnMode = false;
        }
        public void SetBoard() {
            List<int> illegalSpaces = new List<int>();
            int[] spaceChoices = FindValidSpaces(out illegalSpaces);
            int playersFirstPawn = 4 * currentPlayer;
            int pawnPosition;

            sorrySpace[chosenSpace].FlatAppearance.BorderColor = Color.Plum;
            sorrySpace[chosenSpace].FlatAppearance.BorderSize = 2;
            sorrySpace[sorryPawn[chosenPawnIndex].Position].FlatAppearance.BorderColor = Color.Aquamarine;
            sorrySpace[sorryPawn[chosenPawnIndex].Position].FlatAppearance.BorderSize = 2;

            //Runs Below if the Player is chosing a PAWN
            if (choosePawnMode || secondPawnMode) {
                //Enables All the Spaces containing the Current Player's Pawns that
                //which fit under the Conditions of the Current Card 
                for (int i = 0; i < 4; i++) {
                    pawnPosition = sorryPawn[i + playersFirstPawn].Position;
                    for (int j = 0; j < 3; j++) {
                        if (sorrySpace[pawnPosition].Type == sorryCard[pickedCard].TeamTargets[j]) {
                            sorrySpace[pawnPosition].FlatAppearance.BorderSize = 2;
                            sorrySpace[pawnPosition].FlatAppearance.BorderColor = Color.CornflowerBlue;
                            sorrySpace[pawnPosition].Enabled = true;
                        }
                    }
                }
            }

            if (chooseSpaceMode || secondSpaceMode) {
                for (int i = 0; i < spaceChoices.Length; i++) {
                    sorrySpace[spaceChoices[i]].FlatAppearance.BorderSize = 2;
                    sorrySpace[spaceChoices[i]].FlatAppearance.BorderColor = Color.DarkGreen;
                    sorrySpace[spaceChoices[i]].Enabled = true;
                }

                for (int i = 0; i < illegalSpaces.Count; i++) {
                    sorrySpace[illegalSpaces[i]].FlatAppearance.BorderSize = 2;
                    sorrySpace[illegalSpaces[i]].FlatAppearance.BorderColor = Color.Red;
                }

            }
            else if (secondPawnMode) {
                //ONLY FOR [7-CARD]
                //Disables the space the first chosen pawn is on.
                Lbl_Message.Text += "\nYou have " + (sorryCard[pickedCard].AdvancementAmount - lengthOfLastMove) + " spaces left.";
                sorrySpace[sorryPawn[chosenPawnIndex].Position].FlatAppearance.BorderSize = 1;
                sorrySpace[sorryPawn[chosenPawnIndex].Position].FlatAppearance.BorderColor = Color.Silver;
                sorrySpace[sorryPawn[chosenPawnIndex].Position].Enabled = false;
            }

            for (int i = 0; i < NUMBER_OF_PAWNS; i++) {
                sorrySpace[sorryPawn[i].Position].BackgroundImage = sorryPawn[i].Team.PawnImage;
            }
        }

        public int[] FindValidSpaces() {
            List<int> nullList;
            return FindValidSpaces(out nullList);
        }
        public int[] FindValidSpaces(out List<int> invalidSpaces) {
            int predictedSpace = 100;
            int playersFirstPawn = 4 * currentPlayer;
            int advancementSpace;
            List<int> occupiedInvalids = new List<int>();
            List<int> validSpaces = new List<int>();

            for (int i = 0; i < 100; i++) {
                sorrySpace[i].Enabled = false;
            }

            //Runs Below if the Player is chosing a SPACE a second time for the [7-Card]
            if (secondSpaceMode) {
                predictedSpace = sorryPawn[chosenPawnIndex2].Position + sorryCard[pickedCard].AdvancementAmount - lengthOfLastMove;
                FixBoardMovement(ref predictedSpace, sorryCard[pickedCard].AdvancementAmount - lengthOfLastMove);
                validSpaces.Add(predictedSpace);
            }
            //Runs Below if the Player is chosing a SPACE the first time
            else if (chooseSpaceMode) {
                if (sorrySpace[chosenSpace].Type == "Start")
                    if (sorryCard[pickedCard].SpecialMoves == "Sorry") {
                        for (int i = 0; i < NUMBER_OF_PAWNS; i++) {
                            if (i / NUMBER_OF_PLAYERS != currentPlayer) {
                                if (sorrySpace[sorryPawn[i].Position].Type == "Normal")
                                    validSpaces.Add(sorryPawn[i].Position);
                            }
                        }
                    }
                    else
                        validSpaces.Add(sorryPawn[chosenPawnIndex].Team.StartGateLocation);
                else if (sorrySpace[chosenSpace].Type == "Safe" || sorrySpace[chosenSpace].Type == "Normal") {
                    if (sorryCard[pickedCard].SpecialMoves != null) {
                        if (sorryCard[pickedCard].SpecialMoves == "ForceStepBack") {
                            predictedSpace = sorryPawn[chosenPawnIndex].Position - 1;
                            FixBoardMovement(ref predictedSpace, -1);
                            advancementSpace = predictedSpace;
                            validSpaces.Add(predictedSpace);
                        }
                        else if (sorryCard[pickedCard].SpecialMoves == "Split") {

                            for (int i = 1; i < sorryCard[pickedCard].AdvancementAmount; i++) {
                                predictedSpace = sorryPawn[chosenPawnIndex].Position + i;
                                FixBoardMovement(ref predictedSpace, i);
                                if (predictedSpace <= sorryPawn[chosenPawnIndex].Team.EndLocation) {//?
                                    validSpaces.Add(predictedSpace);
                                    splitSpaces.Add(predictedSpace);
                                }
                            }
                        }
                        else if (sorryCard[pickedCard].SpecialMoves == "Switch") {
                            advancementSpace = sorryPawn[chosenPawnIndex].Position + sorryCard[pickedCard].AdvancementAmount;
                            FixBoardMovement(ref advancementSpace, sorryCard[pickedCard].AdvancementAmount);
                            for (int i = 0; i < NUMBER_OF_PAWNS; i++) {
                                if (!(sorryPawn[i].Team.TeamID == currentPlayer)) {
                                    hasConflict = (advancementSpace == sorryPawn[i].Position);

                                    if (sorrySpace[sorryPawn[i].Position].Type == "Normal")
                                        validSpaces.Add(sorryPawn[i].Position);
                                }
                            }
                        }
                    }
                    //Default Advancement Movement
                    //MUST BE LAST FOR THE SPLIT CARDS TO WORK
                    predictedSpace = sorryPawn[chosenPawnIndex].Position + sorryCard[pickedCard].AdvancementAmount;
                    FixBoardMovement(ref predictedSpace, sorryCard[pickedCard].AdvancementAmount);
                    if (predictedSpace <= sorryPawn[chosenPawnIndex].Team.EndLocation) {  //factor this [1]
                        validSpaces.Add(predictedSpace);
                        splitSpaces.Add(predictedSpace);
                    }
                }
            }
            //Removes any spaces where it is...
            for (int i = 0; i < validSpaces.Count; i++) {
                bool ownPawnOccupied = (sorrySpace[validSpaces[i]].IndexOfPawnInSpace / 4 == currentPlayer);
                if (((validSpaces[i] == chosenSpace) //...Location of First Space Choice. ([7-Card] ONLY)
                        || (validSpaces[i] > sorryPawn[chosenPawnIndex].Team.EndLocation) //...going past the finish space
                        || ownPawnOccupied) //...Location of Player's other pawns
                        && (validSpaces[i] != sorryPawn[chosenPawnIndex].Position)
                        && (sorrySpace[validSpaces[i]].Type != "Finish")) { //...is not going to the Finish Space. (Always Keeps Finsh Space Valid)
                    if (ownPawnOccupied || (validSpaces[i] == chosenSpace))
                        occupiedInvalids.Add(validSpaces[i]);
                    validSpaces[i] = 100;
                }
            }
            invalidSpaces = occupiedInvalids;
            return validSpaces.ToArray();
        }
        public void FixBoardMovement(ref int nextSpace, int advanceNum) {
            int currentPawn = DUMMY_PAWN;
            int imaginaryGate = DUMMY_SPACE;

            if (chooseSpaceMode)
                currentPawn = chosenPawnIndex;
            else if (secondSpaceMode)
                currentPawn = chosenPawnIndex2;

            imaginaryGate = sorryPawn[currentPawn].Team.EndLocation - 6;

            if (sorrySpace[sorryPawn[currentPawn].Position].Type == "Safe") {
                if ((nextSpace <= imaginaryGate)
                    && (advanceNum < 0)) {
                    nextSpace = sorryPawn[currentPawn].Team.EndGateLocation - (imaginaryGate - nextSpace);

                    if (nextSpace >= 60)
                        nextSpace -= 60;
                    if (nextSpace < 0)
                        nextSpace += 60;
                }
            }
            else if (sorrySpace[sorryPawn[currentPawn].Position].Type == "Normal") {
                if (sorryPawn[currentPawn].Position == sorryPawn[currentPawn].Team.EndGateLocation) {
                    if (advanceNum > 0)
                        nextSpace = imaginaryGate + advanceNum;
                }
                else {
                    if (nextSpace >= 60)
                        nextSpace -= 60;
                }
                if (nextSpace < 0)
                    nextSpace += 60;
            }
        }
        public void MovePawnAtIndex(int pawnIndex, int nextSpaceIndex, int previousSpace) {
            if (sorrySpace[nextSpaceIndex].IndexOfPawnInSpace != 16) {
                SorryBump(pawnIndex, nextSpaceIndex, previousSpace);
            }

            sorryPawn[pawnIndex].Position = nextSpaceIndex;
            sorrySpace[nextSpaceIndex].IndexOfPawnInSpace = pawnIndex;
            sorrySpace[previousSpace].IndexOfPawnInSpace = DUMMY_PAWN;
        }
        public void SwitchPawns(int pawnIndex, int nextSpaceIndex, int prevSpaceIndex, int targetIndex) {
            sorryPawn[pawnIndex].Position = nextSpaceIndex;
            sorryPawn[targetIndex].Position = prevSpaceIndex;
            sorrySpace[nextSpaceIndex].IndexOfPawnInSpace = pawnIndex;
            sorrySpace[prevSpaceIndex].IndexOfPawnInSpace = targetIndex;
        }
        public void SorryBump(int pawnIndex, int nextSpaceIndex, int previousSpace) {
            bool emptySpaceFound = false;
            int i = 0;
            int indexOfBumpedPawn = sorrySpace[nextSpaceIndex].IndexOfPawnInSpace;

            while (!emptySpaceFound) {
                if (sorrySpace[(sorryPawn[indexOfBumpedPawn].Team.StartLocation + i)].IndexOfPawnInSpace == 16) {
                    MovePawnAtIndex(indexOfBumpedPawn, sorryPawn[indexOfBumpedPawn].Team.StartLocation + i, nextSpaceIndex);
                    emptySpaceFound = true;
                }
                i++;
            }
            SetPawnAtIndex(pawnIndex, nextSpaceIndex);
        }
        public void SetPawnAtIndex(int pawnIndex, int nextSpaceIndex) {
            sorryPawn[pawnIndex].Position = nextSpaceIndex;
            sorrySpace[nextSpaceIndex].IndexOfPawnInSpace = pawnIndex;
        }
        public void GetNewCard() {
            Random randomizer = new Random();

            bool pawnIsMovable = false;
            int playerPawnPosition;

            pickedCard = randomizer.Next(0, NUMBER_OF_CARDS - 1);
            for (int i = 0; i < NUMBER_OF_PLAYERS; i++) {
                playerPawnPosition = sorryPawn[currentPlayer * 4 + i].Position;
                if ((sorrySpace[playerPawnPosition].Type == "Normal") || (sorrySpace[playerPawnPosition].Type == "Safe"))
                    pawnIsMovable = true;
            }
            Lbl_CardName.Text = sorryCard[pickedCard].Name;
            Btn_Skip.Enabled = true;
            if ((sorryCard[pickedCard].SpecialMoves == "ForceStepBack") && (pawnIsMovable))
                Btn_Skip.Enabled = false;
        }
        public void CancelTurn(bool isConfirmed) {
            if (isConfirmed) {
                NextPlayer();
                GetNewCard();
                GetDebuggerData();
            }
            ResetModes();
            UpdateDebugger();
            ResetBoardData();
            ResetBoardDisplay();
            SetBoard();
        }
        public void NextPlayer() {
            if (!sorryCard[pickedCard].GivesExtraTurn)
                currentPlayer = (currentPlayer + 1) % 4;
        }
        public int[] GetPawnPositions() {
            int[] pawnPositions = new int[NUMBER_OF_PAWNS];

            for (int i = 0; i < NUMBER_OF_PAWNS; i++) {
                pawnPositions[i] = sorryPawn[i].Position;
            }
            return pawnPositions;
        }
        public void RunPlayersPhase() {
            bool finishedTurn = false;
            //int checkedMoves;

            ResetBoardDisplay();

            if (choosePawnMode) {
                chosenPawnIndex = sorrySpace[chosenSpace].IndexOfPawnInSpace;
                previousSpace = chosenSpace;
                chooseSpaceMode = !chooseSpaceMode;
                choosePawnMode = !choosePawnMode;
            }
            else if (chooseSpaceMode) {
                int i = 0;
                chooseSpaceMode = !chooseSpaceMode;
                if (sorryCard[pickedCard].SpecialMoves == "Split") {
                    secondPawnMode = !secondPawnMode;
                    while (chosenSpace != splitSpaces[i])
                        i++;
                    lengthOfLastMove = i + 1;
                    if (lengthOfLastMove >= sorryCard[pickedCard].AdvancementAmount)
                        finishedTurn = true;
                }
                else
                    finishedTurn = true;
            }
            else if (secondPawnMode) {
                chosenPawnIndex2 = sorrySpace[chosenSpace2].IndexOfPawnInSpace;
                previousSpace2 = chosenSpace2;
                secondPawnMode = !secondPawnMode;
                secondSpaceMode = !secondSpaceMode;
            }
            else if (secondSpaceMode) {
                secondSpaceMode = !secondSpaceMode;
                finishedTurn = true;
            }

            UpdateDebugger();
            //checkedMoves = EnableValidSpaces().Length;

            if (finishedTurn) {
                if (sorryCard[pickedCard].SpecialMoves == "Switch") {
                    FormMoveQuery conflictQuery = new FormMoveQuery();

                    if (hasConflict) {
                        conflictQuery.ShowDialog();
                        if (conflictQuery.willBump)
                            MovePawnAtIndex(chosenPawnIndex, chosenSpace, previousSpace);
                    }

                    if (conflictQuery.willSwitch) {
                        chosenPawnIndex2 = sorrySpace[chosenSpace].IndexOfPawnInSpace;
                        chosenSpace2 = sorryPawn[chosenPawnIndex].Position;
                        SwitchPawns(chosenPawnIndex, chosenSpace, chosenSpace2, chosenPawnIndex2);
                    }
                }
                else {
                    MovePawnAtIndex(chosenPawnIndex, chosenSpace, previousSpace);

                    if (sorryCard[pickedCard].SpecialMoves == "Split")
                        MovePawnAtIndex(chosenPawnIndex2, chosenSpace2, previousSpace2);
                }

                if ("Finish" == sorrySpace[chosenSpace].Type) {
                    numOfPawnsFinished[currentPlayer]++;
                    sorryPawn[chosenPawnIndex].SetTeam("DUMMY");
                    sorryPawn[chosenPawnIndex].Position = 100;
                    sorrySpace[chosenSpace].IndexOfPawnInSpace = 16;
                }

                if ("Finish" == sorrySpace[chosenSpace2].Type) {
                    numOfPawnsFinished[currentPlayer]++;
                    sorryPawn[chosenPawnIndex2].SetTeam("DUMMY");
                    sorryPawn[chosenPawnIndex2].Position = 100;
                    sorrySpace[chosenSpace2].IndexOfPawnInSpace = 16;
                }

                for (int i = 0; i < NUMBER_OF_PLAYERS; i++) {
                    string winner;
                    if ((NUMBER_OF_PAWNS / NUMBER_OF_PLAYERS) <= numOfPawnsFinished[i]) {
                        switch (i) {
                        case 0:
                            winner = "Red";
                            break;
                        case 1:
                            winner = "Blue";
                            break;
                        case 2:
                            winner = "Yellow";
                            break;
                        case 3:
                            winner = "Green";
                            break;
                        default:
                            winner = "Unknown";
                            break;
                        }
                        MessageBox.Show("Player " + winner + " Won");
                        this.Close();
                    }
                }


                NextPlayer();
                GetNewCard();
                ResetBoardDisplay();
                ResetBoardData();
                ResetModes();
            }
            /*
            else if (checkedMoves <= 0) {
                if (choosePawnMode)
                    LblMessage.Text = "You have no moves. Please Press Skip...";
                else {
                        CancelTurn(false);
                        LblMessage.Text = "Invalid Move";   
                    }
                    finishedTurn = false;
                }
                */

            SetBoard();
            Btn_CancelMove.Enabled = !choosePawnMode;

        }

        public void GetDebuggerData() {
            if (bugChecker.ForcedCardIsOn) {
                pickedCard = bugChecker.ForcedCard;
                Btn_Skip.Enabled = true;
                Lbl_CardName.Text = sorryCard[pickedCard].Name;
            }
            if (bugChecker.ForcedPlayerIsOn) {
                currentPlayer = bugChecker.ForcedPlayer - 1;
                Btn_Skip.Enabled = true;
                ResetBoardDisplay();
                SetBoard();
            }
        }
        public void UpdateDebugger() {
            bugChecker.MoveInfoDisplay(pickedCard.ToString(), currentPlayer.ToString(), chosenPawnIndex.ToString(),
                            chosenSpace.ToString(), previousSpace.ToString(), chooseSpaceMode.ToString(), secondPawnMode.ToString(),
                            secondSpaceMode.ToString(), chosenSpace2.ToString(), previousSpace2.ToString(), chosenPawnIndex2.ToString());
            bugChecker.PawnLocationDisplay(GetPawnPositions());

            if (bugChecker.IsSpaceInfoOn) {
                for (int i = 0; i < NUMBER_OF_SPACES; i++)
                    sorrySpace[i].Text = sorrySpace[i].IndexOfPawnInSpace.ToString();
            }
            else if (bugChecker.IsPawnInfoOn) {
                for (int i = 0; i < NUMBER_OF_SPACES; i++)
                    sorrySpace[i].Text = i.ToString();
            }
        }
    }
}
