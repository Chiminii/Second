//we can count from 1 to 10 
//using while loops, do--while loops and for loops
//but we would probably 
int counter = 1;

while (counter <= 10)
{
    Console.WriteLine(counter);
    counter++;
}

//An alternative use of while with break
counter = 1;
while (true)
{
    Console.WriteLine(counter);
    counter++;
    //you can break out of a loop using break
    if(counter == 10)
    {
        break;
    }
}

counter = 1;
do
{
    Console.WriteLine(counter);
    counter++;
}while ( counter <= 10);

//for-loop
//declare variable with initial value; condition; change to variable
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//If you want a for-loop to exist outside the loop block
//declare i outside the for-loop then dont 
//declare inside the for-statement

int count;
for(int count = 1; count <= 10; count++)
{
    Console.WriteLine(count);
}
Console.WriteLine($"The variable i exists here too and is {count}");