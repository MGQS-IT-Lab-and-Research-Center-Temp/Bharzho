// I am Abdulsalam Abdulbasit 
//i created this simple dice game 
//and i committed the previous one i did because i didnt do it in the way the organization waants it.

Console.Write("===Simple Dice Game=== \nType 'Start' or 'S' to begin: ");
string  startGame = Console.ReadLine()!;

const int DOUBLEPOINT = 2;
const int TRIPPLEPOINT = 6;
int totalPoint = 0;
const int LUCKYNUMBER = 21;


while (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid key word inserted");
    Console.ResetColor();
    Console.Write("Type 'Start' or 'S' to begin: ");
    startGame = Console.ReadLine()!;
}


Random rand = new();
int diceOne = rand.Next(1, 7);
int diceTwo = rand.Next(1, 7);
int diceThree = rand.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;

Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDiceThree: {diceThree}\nOriginal Score: {originalScore}");

// Check if all dice have the same output
if (diceOne == diceTwo && diceTwo == diceThree)
{
    Console.WriteLine("You score a triple point");
    totalPoint = originalScore + TRIPPLEPOINT;
}
// Check if any two dice out of the three dice have the same output
else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
    Console.WriteLine("You score a double point");
    totalPoint = originalScore + DOUBLEPOINT;
}

else 
{
    totalPoint += originalScore;
    Console.WriteLine($"total point: {totalPoint}");
}

// assign gift to certain totalpoints
//Now for the 3 recieving of all items 
if(totalPoint >=22 && totalPoint <=24)
{
    Console.WriteLine("Congratultion!!!.. WOW, you just won all the gift in the whole game \nKeep this up and bring to us more customers \nYou can also contact us @BHARZHO");
}
 //Now for the samsung gift
else if (totalPoint == LUCKYNUMBER)
{
    Console.WriteLine("Congratulation!!!.. you just won a lucky shot \nAnd you are awarded with a gift of Samsung S49 version'2023");
}
 //Now for the silver bird ticket
else if (totalPoint >= 18 && totalPoint <= 20 )
{
    Console.WriteLine("Congratulation!!!.. You just won a ticket to Silver Bird at Ikeja Lagos");
}
 //Now for the Power Bank gift
else if (totalPoint == 17)
{
    Console.WriteLine("Congratulatoion!!!.. Wow you just won a 5000MAH Power Bank ");
}
 //Now for the exercise book gift
else if (totalPoint >= 14 && totalPoint <=16 )
{
    Console.WriteLine("Congratulation!!!.. You won an exercise book \nNice job... bring in more of this lol.");
}
 //Now for the baloon gift gift
else if (totalPoint >= 10 && totalPoint <= 13)
{
    Console.WriteLine("Congratulation!!!.. You won a baloon");
}

else 
{
    Console.WriteLine("Ohhhhhh sorry try again,we dont have price for this game you just played we so sorry and thanks for playing.");
}

