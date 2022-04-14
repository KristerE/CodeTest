using System;

namespace CodeTest {
    internal class Program {


        static void Main(string[] args) {

            bool run = true;
            int s = args.Length;
            string[] inArgs = null;
            PlayBoard board = new PlayBoard();
            if (args != null) {
                inArgs = args[0].Split(',');
            } else {
                run = false;
                board.outOfRange();
            }
            if (inArgs.Length < 4) {
                run = false;
                board.outOfRange();
            } else if (!board.initArgs(inArgs)) {
                run = false;
                board.outOfRange();
            } else if (board.checkPosition() == false) {
                run = false;
                board.outOfRange();
            }
 
            while (run) {
                int inputValue;

                if (!int.TryParse(Console.ReadLine(), out inputValue)) {
                    Console.WriteLine("Wrong input, only numbers 0-4");
                } else {
                    switch (inputValue) {
                        case 0:
                            run = false;
                            break;
                        case 1:
                        case 2:
                            board.move(inputValue);
                            break;
                        case 3:
                        case 4:
                            board.changeDirection(inputValue);
                            break;
                    }
                    if (board.checkPosition() == false) {
                        run = false;
                        board.outOfRange();
                    }
                }
            }
            Console.WriteLine(board.printPosition());

        }
    }
}
