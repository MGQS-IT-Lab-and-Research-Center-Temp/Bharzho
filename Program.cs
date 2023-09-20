int doublePoint = 2;
int tripplePoint = 6;
int totalPoint;

Console.WriteLine("==========Dice Game========= \nType 'Start' or 'S' to roll the dice: ");

string startGame = Console.ReadLine()!;

if (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine("Now enter 'Start' or 'S' to start the game and roll the dice properly properly:");
    return;
}


Random random = new();
int diceOne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1, 7);
totalPoint = diceOne + diceTwo + diceThree;

Console.WriteLine($"Dice one {diceOne} \nDice Two {diceTwo} \nDice Three {diceThree}");

//This checks if the three die are equal
if (diceOne == diceTwo && diceTwo == diceThree)
{
    Console.WriteLine("You scored a bonus of 6 point");
    totalPoint += tripplePoint;
    
}

//This check if teo die are equal out of the three die
else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
    Console.WriteLine("You scored a bonus of 2 point");
    totalPoint += doublePoint;
    
}

//Now for the baloon gift gift
if (totalPoint >= 10 && totalPoint <= 13)
{
    Console.WriteLine("Congratulation!!!.. You won a baloon ");
      
}

//Now for the exercise book gift
else if (totalPoint >= 14 && totalPoint <= 16)
{
    Console.WriteLine("Congratulation!!!.. You won an exercise book \nNice job... bring in more of this lol");
    
}

//Now for the Power Bank gift
else if (totalPoint == 17)
{
    Console.WriteLine("Congratulatoion!!!.. Wow you just won a 5000MAH Power Bank");
    
}

//Now for the samsung gift
else if (totalPoint == 21)
{
    Console.WriteLine("Congratulation!!!.. you just won a lucky shot \nAnd you are awarded with a gift of Samsung S49 version'2023");
}

//Now for the silver bird ticket
else if (totalPoint >= 18 && totalPoint <= 20)
{
    Console.WriteLine("Congratulation!!!.. You just won a ticket to Silver Bird at Ikeja Lagos");
}
//Now for the3 recieving of all items 
else if (totalPoint >= 22 && totalPoint <= 24)
{
    Console.WriteLine("Congratultion!!!.. WOW, you just won all the gift in the whole game \nKeep this up and bring to us more customers \nYou can also contact us @BHARZHO");
}

//Now for the try again
else 
{
    Console.WriteLine("Ohhhhhh sorry try again,we dont have price for this game you just played we so sorry and thanks for playing.");
}