using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_stair
{
    class GameCls
    {
        public static List<String> users = new List<String>();
        public static int dicenum = 0;
        public static int turn = 1;
        public static int level = 0;
        public static Random generator = new Random();

        //***************************Add User to list*********************************//
        public static void adduser(string username)
        {
            users.Add(username);
        }
        //****************************Set Level***************************************//
        public static int SetLevel(string LevelName)
        {
            switch (LevelName)
            {
                case "Easy":
                    level = 1;
                    break;
                case "Meduim":
                    level = 2;
                    break;
                case "Hard":
                    level = 3;
                    break;
                default:
                    break;
            }
            return level;
        }
        //**************************Set Steps of fall and up*************************//
        public static int setStep(int cell)
        {

            int result = 0;

            if (level == 1)
            {
                switch (cell)
                {
                    case 2:
                        result = 21;
                        break;
                    case 6:
                        result = 19;
                        break;
                    case 30:
                        result = 4;
                        break;
                    case 43:
                        result = 19;
                        break;
                    case 49:
                        result = 17;
                        break;
                    case 54:
                        result = 18;
                        break;
                    case 77:
                        result = 21;
                        break;
                    case 45:
                        result = -32;
                        break;
                    case 86:
                        result = -29;
                        break;
                    case 60:
                        result = -22;
                        break;
                }
            }

            if (level == 2)
            {
                switch (cell)
                {
                    case 2:
                        result = 21;
                        break;
                    case 30:
                        result = 4;
                        break;
                    case 43:
                        result = 19;
                        break;
                    case 49:
                        result = 17;
                        break;
                    case 77:
                        result = 21;
                        break;
                    case 72:
                        result = -18;
                        break;
                    case 36:
                        result = -19;
                        break;
                    case 45:
                        result = -32;
                        break;
                    case 86:
                        result = -29;
                        break;
                    case 60:
                        result = -22;
                        break;
                }
            }

            if (level == 3)
            {
                switch (cell)
                {
                    case 30:
                        result = 4;
                        break;
                    case 43:
                        result = 19;
                        break;
                    case 49:
                        result = 17;
                        break;
                    case 23:
                        result = -21;
                        break;
                    case 98:
                        result = -21;
                        break;
                    case 72:
                        result = -18;
                        break;
                    case 36:
                        result = -19;
                        break;
                    case 45:
                        result = -32;
                        break;
                    case 86:
                        result = -29;
                        break;
                    case 60:
                        result = -22;
                        break;
                }
            }

            return result;

        }
        //**************************Set Dice*****************************************//
        public static int Dice()
        {
            dicenum = generator.Next(1, 7);//return values from 1 to 6
            return dicenum;
        }
        //**************************Set turn******************************************//
        public static int Turn(int Numplayer)
        {
            int result;
            if (turn % Numplayer == 0)
            {
                result = 1;
                turn++;
            }
            else if (turn % Numplayer == 1)
            {
                result = 2;
                turn++;
            }
            else if (turn % Numplayer == 2)
            {
                result = 3;
                turn++;
            }
            else if (turn % Numplayer == 3)
            {
                result = 4;
                turn++;
            }
            else
            {
                result = 5;
                turn++;
            }
            return result;
        }
    }
}
