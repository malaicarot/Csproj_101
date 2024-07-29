//Part 1 Print a string to the console
//hint: Console.WriteLine("Hello World!");
Console.WriteLine("Welcome to your first practice!!!");
//Part 2 Get user input and print it to the console
//hint: Console.ReadLine();
Console.WriteLine("Pls enter your name: ");
var name = Console.ReadLine();
Console.Write($"Hello {name}\n");

// //Part 3 Get two inputs from the user and print them on separate lines
// //hint: use \n to create a new line
Console.WriteLine("Pls enter your age: ");
var age = Console.ReadLine();

Console.WriteLine("Pls enter your work: ");
var subj = Console.ReadLine();

Console.WriteLine($"Your age: {age} \nYour work: {subj}");



Console.WriteLine("Press any key to exit...");
Console.ReadKey(true);



