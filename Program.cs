//Test algorithms
//Fix Row and maybe Colum Algoritms
char[,] board = 
{
{'*','*','*','*','*'},
{'*','*','*','*','*'},
{'*','*','*','*','*'},
{'*','*','*','*','*'},
{'*','*','*','*','*'},
};

bool gameRunning = true;
int slot;
char turn = '0';
int[] lastMove = {0, 0};

void CheckWinning(){
    int localPoints = 1;

    


    Console.WriteLine(localPoints);
    if (localPoints == 4){
        Console.Clear();
        ShowBoard();
        Console.WriteLine("Player " + turn + " Wins!");
        
        gameRunning = false;
    }
}

void ShowBoard(){
    for (int l = 0; l < 5; l++){
        Console.Write(l+1);
        Console.Write(" ");
    }

    Console.WriteLine();

    for (int ul = 0; ul < 10; ul++){
        Console.Write("-");
    }

    Console.WriteLine();

    for (int i = 0; i < board.GetLength(0); i++){
        for (int j = 0; j < board.GetLength(1); j++ ){
            Console.Write(board[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void PlaceInSlot(int slot){    
    for (int k = 4; k > -1; k--){
        if (board[k,slot] == '*'){
            board[k,slot] = turn;
            lastMove[0] = k;
            lastMove[1] = slot;
            break;
        }
    }
}


while (gameRunning == true){
    //Console.Clear();
    if (turn == '0'){
        turn = '1';
    }
    else if (turn == '1'){
        turn = '0';
    }

    ShowBoard();
    Console.WriteLine();
    Console.WriteLine("Player " + turn + "'s Turn:");    
    //Gets slot
    Console.WriteLine("Enter Slot");
    slot = Convert.ToInt32(Console.ReadLine());
    
    PlaceInSlot(slot - 1);
    CheckWinning();
}