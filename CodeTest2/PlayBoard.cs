using System;

namespace CodeTest {
    public class PlayBoard {
        public int boardHeight { get; private set; }
        public int boardWidth { get; private set; }

        public int currentPosX { get; private set; }
        public int CurrentPosY { get; private set; }


        // direction= "N", "S", "W", "E" default value is "N"
        string direction = "N";

        private void setPos(int x, int y) {
            currentPosX = x;
            CurrentPosY = y;
        }

        private int ToInt(string value) {
            int result;
            if (int.TryParse(value, out result)) {
                return result;
            } else {
                return -1;
            }
        }
        public bool initArgs(string[] args) {
            // Create board an check if current position is inside board
            try {
                if (args != null && args.Length > 3) {
                    boardWidth = (ToInt(args[0]) > 0 && (ToInt(args[0]) > ToInt(args[2]))) ? ToInt(args[0]) : 4;
                    boardHeight = (ToInt(args[1]) > 0 && (ToInt(args[1]) > ToInt(args[3]))) ? ToInt(args[1]) : 4;
                    currentPosX = (ToInt(args[2]) < boardWidth) ? ToInt(args[2]) : 0;
                    CurrentPosY = (ToInt(args[3]) < boardHeight) ? ToInt(args[3]) : 0;
                    return true;
                } else {
                    return false;
                }
            }
            catch (Exception) {
                return false;
            }
        }

        public void move(int step) {
            if (step == 1) {
                switch (direction) {
                    case "N":
                        CurrentPosY--;
                        break;
                    case "S":
                        CurrentPosY++;
                        break;
                    case "W":
                        currentPosX--;
                        break;
                    case "E":
                        currentPosX++;
                        break;

                }

            } else if (step == 2) {
                switch (direction) {
                    case "N":
                        CurrentPosY++;
                        break;
                    case "S":
                        CurrentPosY--;
                        break;
                    case "W":
                        currentPosX++;
                        break;
                    case "E":
                        currentPosX--;
                        break;

                }
            }
        }

        public void changeDirection(int value) {
            switch (value) {
                case 3:
                    switch (direction) {
                        case "N":
                            direction = "E";
                            break;
                        case "E":
                            direction = "S";
                            break;
                        case "S":
                            direction = "W";
                            break;
                        case "W":
                            direction = "N";
                            break;
                    }
                    break;

                case 4:
                    switch (direction) {
                        case "N":
                            direction = "W";
                            break;
                        case "W":
                            direction = "S";
                            break;
                        case "S":
                            direction = "E";
                            break;
                        case "E":
                            direction = "N";
                            break;
                    }
                    break;

            }
        }

        public string printPosition() {
            string position = $"[{currentPosX.ToString()},{CurrentPosY.ToString()}]";
            return position;
        }
        public bool checkPosition() {
            if (currentPosX < 0 || CurrentPosY < 0 || currentPosX >= boardWidth || CurrentPosY >= boardHeight) {
                return false;
            } else {
                return true;
            }
        }
        public void outOfRange() {
            // Set current position to [-1,-1]
            currentPosX = -1;
            CurrentPosY = -1;
        }
    }
}
