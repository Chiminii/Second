/*
    It's common when you program
    that you want to change the value
    of a variable
    (add, subtract, multiple, divide, etc)

 */


int counter = 1;

Console.WriteLine(counter);

//Add 1 to counter

// ---------- ADDING ------------//

counter = counter + 1;
Console.WriteLine(counter);

//Add 1 to counter - shorter assignment
counter += 1;

Console.WriteLine(counter);

//Add ONLY 1 to counter - shortest way
//Only works when added exactly 1
counter++;

Console.WriteLine(counter);

//Add 2 to counter - the long way
counter = counter + 2;

Console.WriteLine(counter);
//Add 2 to counter - the shortest way
counter += 2;

Console.WriteLine(counter);

// ---------- SUBTRACTING ------------//

//Subtract 1 to counter

counter = counter - 1;
Console.WriteLine(counter);

//Subtract 1 to counter - shorter assignment
counter -= 1;

Console.WriteLine(counter);

//Subtract ONLY 1 to counter - shortest way
//Only works when Subtracted exactly 1
counter--;

Console.WriteLine(counter);

//Subtract 2 to counter - the long way
counter = counter - 2;

Console.WriteLine(counter);
//Subtract 2 to counter - the shortest way
counter -= 2;

Console.WriteLine(counter);

/* alt+shift+a */


//Multiplication - long way
counter = counter * 2;

Console.WriteLine(counter);


//Multiplication - short way
counter *= 2;

Console.WriteLine(counter);


//Division - long way
counter = counter / 2;

Console.WriteLine(counter);


//Division - short way 
counter /= 2;

Console.WriteLine(counter);

//The + operator can be used with strings too
//This is called string concatenation
string a = "Hej ";
string b = "då";

a += b; // could have been written a = a + b

Console.WriteLine(a);

