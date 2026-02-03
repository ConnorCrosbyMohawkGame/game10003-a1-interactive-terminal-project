/* This code is a simple introduction that welcomes the user to the store by printing text to the screen.
   The text also asks how much money the shopper has on hand which will soon help inform the program of what they can afford
*/
Console.WriteLine("Welcome to DigiMart, the best digital grocery store to ever grace your memory!");
Console.WriteLine("Before we take you around the store may we ask how much money you have on hand?");

//This code will recieve the user's current held funds and save it for later use
float heldFunds = float.Parse(Console.ReadLine());

//This code sets the prices for our dairy products, milk is $4 and cheese is $2.50!
int milkPrice = 4;
float cheesePrice = 2.50f;

//Here we inform the user they can buy either milk or cheese and give them instructions on how to make a choice.
Console.WriteLine("-----------");
Console.WriteLine($"You walk up to the dairy section and see milk for ${milkPrice} and cheese for ${cheesePrice}.");
Console.WriteLine("If you want milk please type milk! Type cheese for cheese and say none for neither!");

//This code reads user input to detect if the shopper wants some milk
string dairyChoice = Console.ReadLine();
if (dairyChoice == "milk")
{   
    /*Below is code that compares current funds to the milk price. 
     * If the shopper has more money than the required milk price, they can get the milk
     */
    if (heldFunds >= milkPrice)
    {
        heldFunds -= 4;
        
        //Text printed to the screen that informs the shopper the milk purchase was successful
        Console.WriteLine($"You got the milk! Your current funds are now ${heldFunds}. Lets look for meat now.");
    }
    else
    {
        //Alternate text that will be printed if the shopper can't afford the milk.
        Console.WriteLine("You cannot afford the milk right now! Let's go to the meat department.");
    }

  
}
//This code is pretty identical to the milk code, just for cheese this time.
if (dairyChoice == "cheese")
{
    if (heldFunds >= cheesePrice)
    {
        heldFunds -= 2.50f;

        Console.WriteLine($"You got the cheese! You now have ${heldFunds} in your pocket. Lets get some meat.");
    }
    else
    {
        Console.WriteLine("No cheese for you if you cannot afford it! Let's try going to the meat department.");
    }
}
//Less involved code that informs the user they didn't buy anything. Thus, their funds don't decrease!
if (dairyChoice == "none")
{
    Console.WriteLine("You did not buy any dairy products. Let's move on to the meat section.");
}

float chickenPrice = 10.50f;
int beefPrice = 8;

Console.WriteLine("-----------");
Console.WriteLine($"You now walk up to the meat section and see chicken for ${chickenPrice} and beef for ${beefPrice}.");
Console.WriteLine("If you want chicken please type chicken! Type beef for beef and say none for neither!");

//This code reads user input to detect if the shopper wants some chicken
string meatChoice = Console.ReadLine();
if (meatChoice == "chicken")
{   /*Here is code that compares current funds to the chicken price. 
     * If the shopper has more money than the required chicken price, they can get the chicken
     */
    if (heldFunds >= chickenPrice)
    {
        heldFunds -= 10.50f;

        //Text printed to the screen that informs the shopper the chicken purchase was successful
        Console.WriteLine($"You got the chicken! Your current funds are now ${heldFunds}. Let's wrap up.");
    }
    else
    {
        //Alternate text that will be printed if the shopper can't afford the chicken.
        Console.WriteLine("You chickened out from buying the chicken! Let's see some final results.");
    }


}
//This code is pretty identical to the chicken code, just for beef this time.
if (meatChoice == "beef")
{
    if (heldFunds >= beefPrice)
    {
        heldFunds -= 8;

        Console.WriteLine($"You don't have beef with the beef! You now have ${heldFunds} in your pocket. Lets see final results.");
    }
    else
    {
        Console.WriteLine("Your wallet has beef with the beef. Let's see the final results!");
    }
}
//Less involved code that informs the user they didn't buy anything. Thus, their funds don't decrease!
if (meatChoice == "none")
{
    Console.WriteLine("You did not buy any meat products. Let's move on.");
}


