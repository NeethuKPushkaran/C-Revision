// See https://aka.ms/new-console-template for more information

//Basics

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

//Operators

//Arithmetic Operators
int a = 10;
int b = 3;
Console.WriteLine(a + b); // 13
Console.WriteLine(a - b); // 7
Console.WriteLine(a * b); // 30
Console.WriteLine(a / b); // 3
Console.WriteLine(a % b); // 1

//Assignment Operators
int c = 5;
c += 2; // c = c + 2; c is now 7
c -= 3; // c = c - 3; c is now 4
c *= 2; // c = c * 2; c is now 8
c /= 4; // c = c / 4; c is now 2
c %= 2; // c = c % 2; c is now 0

//Comparison Operators
int d = 10;
int e = 20;
Console.WriteLine(d == e); // false
Console.WriteLine(d != e); // true
Console.WriteLine(d > e);  // false
Console.WriteLine(d < e);  // true
Console.WriteLine(d >= e); // false
Console.WriteLine(d <= e); // true

//Logical Operators
bool x = true;
bool y = false;
Console.WriteLine(x && y); // false
Console.WriteLine(x || y); // true
Console.WriteLine(!x);     // false

//Bitwise Operators
int f = 5;  // 0101 in binary
int g = 3;  // 0011 in binary
Console.WriteLine(f & g); // 0001 in binary, which is 1
Console.WriteLine(f | g); // 0111 in binary, which is 7
Console.WriteLine(f ^ g); // 0110 in binary, which is 6
Console.WriteLine(~f);    // 11111111111111111111111111111010 in binary, which is -6
Console.WriteLine(f << 1);// 1010 in binary, which is 10
Console.WriteLine(f >> 1);// 0010 in binary, which is 2

//Unary Operators
int h = 5;
Console.WriteLine(+h); // 5
Console.WriteLine(-h); // -5
Console.WriteLine(++h); // 6 (pre-increment)
Console.WriteLine(h++); // 6 (post-increment), h is now 7
Console.WriteLine(--h); // 6 (pre-decrement)
Console.WriteLine(h--); // 6 (post-decrement), h is now 5

//Ternary Operators
int i = 10;
int j = 20;
int max = (i > j) ? i : j; // max is 20
Console.WriteLine(max);

//Null-Coalescing Operator
int? k = null;
int l = k ?? 5; // l is 5
Console.WriteLine(l);