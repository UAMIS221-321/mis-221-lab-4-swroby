
int userChoice = GetUserChoice(); //priming read
while (userChoice!=3){
    RouteEm(userChoice);
}


static int GetUserChoice(){
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}


static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle");
    System.Console.WriteLine("Enter 2 to display partial triangle");
    System.Console.WriteLine("Enter 3 to exit");
    System.Console.WriteLine("Enter Menu Option");

}

static bool IsValidChoice(string userChoice){
    if(userChoice=="1" || userChoice=="2" || userChoice=="3"){
        return true;
    }
    return false;

}

static void SayFullTriangle(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    System.Console.WriteLine("Full Triangle");   
   for (int i = 0; i < number; i++)
   {
        for (int j = 0; j < i+1; j++)
        {
            Console.Write("O");
        }
        System.Console.WriteLine();
   }
   PauseAction();
}

static void SayPartialTriangle(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    System.Console.WriteLine("Partial Triangle");
    for (int i = 0; i < number; i++)
   {
        for (int j = 0; j < i+1; j++)
        {
            if(number == rnd.Next(3,10))
                Console.Write(" ");
            else
                Console.Write("O");
        }
        System.Console.WriteLine();
   }
   PauseAction();
 }



static void SayExit(){
    System.Console.WriteLine("Exit");
    PauseAction();
}

static void SayInvalid(){
    System.Console.WriteLine("Invalid Choice");
    PauseAction();

}

static void RouteEm( int menuChoice){
    if(menuChoice==1){
        SayFullTriangle();
    }
    else if (menuChoice==2) {
        SayPartialTriangle();
    }
    else if (menuChoice==3){
        SayExit();
    }
    else {
        SayInvalid();{
            DisplayMenu();
        }
    }
}

static void PauseAction(){
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}
