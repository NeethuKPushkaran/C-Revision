// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age = 30;
float height = 5.6f;
bool isAdmin = true;
char letter = 'A';

string name = "Jim";
int[] array1 = [1, 2, 3];
string[] array2 = ["hi", "Hello"];
int[] scores = {45, 42, 43};

Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height);
Console.WriteLine("isAdmin: " + isAdmin);
Console.WriteLine("letter: " +  letter);
Console.WriteLine("Name: " +  name);
Console.WriteLine("array1: " + string.Join(", ", array1));
Console.WriteLine("array2: " + string.Join(", ", array2));
Console.WriteLine("Scores: " + string.Join(", ", scores));
