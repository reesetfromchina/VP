namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3] {{'-', '-', '-'},
                                            {'-', '-', '-'},
                                            {'-', '-', '-'}};

            Console.WriteLine("Welcome to Tic Tac Toe!");
            PrintBoard(board);

            while (!IsGameOver(board))
            {
                if (GetTurnCount(board) % 2 == 0)
                {
                    // Player's turn
                    Console.WriteLine("Enter row and column indices (separated by a space):");
                    string[] input = Console.ReadLine().Split(' ');
                    int row = int.Parse(input[0]);
                    int col = int.Parse(input[1]);
                    if (IsValidMove(board, row, col))
                    {
                        MakeMove(board, row, col, 'X');
                    }
                    else
                    {
                        Console.WriteLine("Invalid move! Try again.");
                        continue;
                    }
                }
                else
                {
                    // Computer's turn
                    Console.WriteLine("Computer is making a move...");
                    int[] computerMove = GetBestMove(board, 'O');
                    MakeMove(board, computerMove[0], computerMove[1], 'O');
                }

                PrintBoard(board);
            }

            char winner = GetWinner(board);
            if (winner == '-')
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine(winner + " wins!");
            }
        }

        static int GetTurnCount(char[,] board)
        {
            int count = 0;
            foreach (char c in board)
            {
                if (c != '-') count++;
            }
            return count;
        }

        static void MakeMove(char[,] board, int row, int col, char player)
        {
            board[row, col] = player;
        }

        static bool IsValidMove(char[,] board, int row, int col)
        {
            return board[row, col] == '-';
        }

        static void PrintBoard(char[,] board)
        {
            Console.WriteLine("   0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool IsGameOver(char[,] board)
        {
            return GetWinner(board) != '-' || IsBoardFull(board);
        }

        static bool IsBoardFull(char[,] board)
        {
            foreach (char c in board)
            {
                if (c == '-') return false;
            }
            return true;
        }

        static char GetWinner(char[,] board)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != '-' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return board[i, 0];
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] != '-' && board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    return board[0, j];
                }
            }

            // Check diagonals
            if (board[0, 0] != '-' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }
            if (board[0, 2] != '-' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return board[0, 2];
            }

            // No winner yet
            return '-';
        }

        static int Evaluate(char[,] board, char player)
        {
            char opponent = player == 'X' ? 'O' : 'X';

            // Check rows for potential wins
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == '-')
                {
                    return 10;
                }
                if (board[i, 0] == player && board[i, 1] == '-' && board[i, 2] == player)
                {
                    return 10;
                }
                if (board[i, 0] == '-' && board[i, 1] == player && board[i, 2] == player)
                {
                    return 10;
                }

                if (board[i, 0] == opponent && board[i, 1] == opponent && board[i, 2] == '-')
                {
                    return -10;
                }
                if (board[i, 0] == opponent && board[i, 1] == '-' && board[i, 2] == opponent)
                {
                    return -10;
                }
                if (board[i, 0] == '-' && board[i, 1] == opponent && board[i, 2] == opponent)
                {
                    return -10;
                }
            }

            // Check columns for potential wins
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == player && board[1, j] == player && board[2, j] == '-')
                {
                    return 10;
                }
                if (board[0, j] == player && board[1, j] == '-' && board[2, j] == player)
                {
                    return 10;
                }
                if (board[0, j] == '-' && board[1, j] == player && board[2, j] == player)
                {
                    return 10;
                }

                if (board[0, j] == opponent && board[1, j] == opponent && board[2, j] == '-')
                {
                    return -10;
                }
                if (board[0, j] == opponent && board[1, j] == '-' && board[2, j] == opponent)
                {
                    return -10;
                }
                if (board[0, j] == '-' && board[1, j] == opponent && board[2, j] == opponent)
                {
                    return -10;
                }
            }

            // Check diagonals for potential wins
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == '-')
            {
                return 10;
            }
            if (board[0, 0] == player && board[1, 1] == '-' && board[2, 2] == player)
            {
                return 10;
            }
            if (board[0, 0] == '-' && board[1, 1] == player && board[2, 2] == player)
            {
                return 10;
            }

            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == '-')
            {
                return 10;
            }
            if (board[0, 2] == player && board[1, 1] == '-' && board[2, 0] == player)
            {
                return 10;
            }
            if (board[0, 2] == '-' && board[1, 1] == player && board[2, 0] == player)
            {
                return 10;
            }

            if (board[0, 0] == opponent && board[1, 1] == opponent && board[2, 2] == '-')
            {
                return -10;
            }
            if (board[0, 0] == opponent && board[1, 1] == '-' && board[2, 2] == opponent)
            {
                return -10;
            }
            if (board[0, 0] == '-' && board[1, 1] == opponent && board[2, 2] == opponent)
            {
                return -10;
            }

            if (board[0, 2] == opponent && board[1, 1] == opponent && board[2, 0] == '-')
            {
                return -10;
            }
            if (board[0, 2] == opponent && board[1, 1] == '-' && board[2, 0] == opponent)
            {
                return -10;
            }
            if (board[0, 2] == '-' && board[1, 1] == opponent && board[2, 0] == opponent)
            {
                return -10;
            }

            // No potential win found
            return 0;
        }

        static int Minimax(char[,] board, char player, int depth)
        {
            char opponent = player == 'X' ? 'O' : 'X';

            // Check for terminal states
            if (GetWinner(board) == 'X')
            {
                return -100 + depth;
            }
            else if (GetWinner(board) == 'O') {
                return 100 - depth;
            }
            else if (IsBoardFull(board))
            {
                return 0;
            }

            // Maximize player's score and minimize opponent's score
            if (player == 'O')
            {
                int bestScore = int.MaxValue;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == '-')
                        {
                            board[i, j] = 'O';
                            int score = Minimax(board, 'X', depth + 1);
                            board[i, j] = '-';

                            if (score < bestScore)
                            {
                                bestScore = score;
                            }
                        }
                    }
                }

                return bestScore;
            }
            else
            {
                int bestScore = int.MinValue;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == '-')
                        {
                            board[i, j] = 'X';
                            int score = Minimax(board, 'O', depth + 1);
                            board[i, j] = '-';

                            if (score > bestScore)
                            {
                                bestScore = score;
                            }
                        }
                    }
                }

                return bestScore;
            }
        }

        static int[] GetBestMove(char[,] board, char player)
        {
            int[] bestMove = new int[2];
            int bestScore = int.MinValue;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '-')
                    {
                        board[i, j] = player;
                        int score = Minimax(board, player, 0);
                        board[i, j] = '-';

                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove[0] = i;
                            bestMove[1] = j;
                        }
                    }
                }
            }

            return bestMove;
        }
    }
}
            
            