//create the following variables
// string firstName = "Zainab";
// string lastName = "Opaleke";
// int age = 20;
// char gender = 'F';
// string name = ("My name is:" + firstName + lastName + "I am age:" + age + "My gender is:" + gender);
// Console.WriteLine(name);
// string names = ($"My name is {firstName} {lastName} my age is {age} and my gender is {gender}");
// Console.WriteLine(names);

// 1. Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.
sbyte mySbyte = -115;
byte mybyte = 224;
short myshort = -10000;
ushort myushort = 20000;
int myint = 52130;
uint myuint = 4825932;
long mylong = 123456789123456789;
ulong myulong = 970700000;

Console.WriteLine(mySbyte);
Console.WriteLine(mybyte);
Console.WriteLine(myshort);
Console.WriteLine(myushort);
Console.WriteLine(myint);
Console.WriteLine(myuint);
Console.WriteLine(mylong);
Console.WriteLine(myulong);

//2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
float myfloat = 34.567839023F;
double mydouble = 3456.091124875956542151256683467;
decimal mydecimal = -5.01m;

Console.WriteLine(myfloat);
Console.WriteLine(mydouble);
Console.WriteLine(mydecimal);

//3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.

int j = 11;
int i = 11;
if ((j - i < 0.000001) && (i - j < 0.000001))
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

//4. Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
int num = 256;
int numHex = 0x256;
Console.WriteLine(num);
Console.WriteLine(numHex);

//5. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
char character = 's';
char charactercode = '\u0072';
Console.WriteLine(character);
Console.WriteLine(charactercode);


// 6. Declare a variable isMale of type bool and assign a value to it depending on your gender.

bool isMale = false;
Console.WriteLine(isMale);


// 7. Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.
string str1 = "Hello";
string str2 = "World";
object obj = "car";
string name = ("My name is:" + str1 + " " + str2);
object objs = ("The obect is:" + obj);
Console.WriteLine(obj);

// 8. Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).
//To cast from object to string use typecasting.

string firstName = "Hello";
string lastName = "World";
string fullName = ("My name is:" + firstName + " " + lastName);
object car = "volvo";
string first = (string)car;
Console.WriteLine(first);

// 9. Declare two variable of type string and assign them a value "The "use" of quotations causes difficulties". (without the outer qoutes). In one of the variables use qouted string in the other do not use it.
string quotation1 = "The 'use' of quotation causes difficulties";
string quotation2 = "The use of quotation causes difficulties";
Console.WriteLine(quotation1);
Console.WriteLine(quotation2);


// 10. Write a program to print a figure in the shape of a heart by the sign "o".


Console.WriteLine("o o     o o");
Console.WriteLine(" o o o o o");
Console.WriteLine("  o     o");
Console.WriteLine("   o   o");
Console.WriteLine("    o o");
Console.WriteLine("     o ");

// 11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character "c"

Console.WriteLine("       c c c");
Console.WriteLine("     c        c");
Console.WriteLine("   c           c");
Console.WriteLine("  c              c");
Console.WriteLine("c cc cc cc cc cc  c");

//12. A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic: firstName, lastName, age, gender ('m' or 'f') and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.

string name1 = "Abiodun";
string name2 = "Abisoye";
int age = 42;
char gender = 'F';
int number1 = 27560000;
int number2 = 27569999;
string names = $"My name is {name1} {name2} my age is {age} and my gender is {gender} my number is: {number1} {number2}";
Console.WriteLine(names);


// 13. Declare two variable of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.
int a = 5;
int b = 10;
Console.WriteLine(b = b - a);
Console.WriteLine(a = b + a);













