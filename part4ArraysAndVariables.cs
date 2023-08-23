/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue}");
*/
/*
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");   
*/
//int[] data = new int[3];
/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
*/
/*
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
*/
/*
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
*/
/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");
*/
/*
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
*/
/*
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
*/
/*
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
*/
/*
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
*/
/*
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
    */
/*
string[] values = {"12.3","45","ABC","11","DEF"};
decimal myDecimal = 0m;
string myString = "";

for(int i = 0; i < values.Length;i++)
{
    var input = values[i];
    decimal potDecimal = 0m;

    if(decimal.TryParse(input,out potDecimal))
    {
        myDecimal += potDecimal;
    }
    else
    {
        myString += input;
    }
}

Console.WriteLine($"Message: {myString}");
Console.WriteLine($"Total: {myDecimal}");
*/
/*
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

//result1
decimal result1Test = (decimal)value1 / value2;
int result1 = Convert.ToInt32(result1Test);
//round result to nearest int
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//result2
decimal result2 = value2/(decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//result3
float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/
/*
string[] pallets = {"B14","A11","B12","A13"};

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
/*
string[] pallets = {"B14", "A11", "B12", "A13"};
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
/*
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");
*/
/*
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets,3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/
/*
string pangram = "The quick brown fox jumps over the lazy dog";
string[] holder = pangram.Split(" ");
string combined = "";
foreach (string word in holder)
{
    char[] charHolder = word.ToCharArray();
    Array.Reverse(charHolder);
    string toString = String.Join("", charHolder);
    combined += toString + " ";
}

Console.WriteLine(combined);
*/
/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderArray = orderStream.Split(",");

foreach (string order in orderArray)
{
    string orderOutput = "";
    if (order.Length != 4)
    {
        orderOutput = order + "\t - Error";
    }
    else
    {
        orderOutput = order;
    }
    Console.WriteLine(orderOutput);
}
*/
/*
string first = "Hello";
string second = "World";
//string result = string.Format("{0} {1}",first, second);
Console.WriteLine($"{first} {second}");
Console.WriteLine($"{second} {first}");
Console.WriteLine($"{first} {first} {first}");
*/
/*
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
*/
/*
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N2} units");
*/
/*
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
*/
/*
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ",(price - salePrice),price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";
Console.WriteLine(yourDiscount);
*/
/*
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Shares: {productShares:N3} Product");
Console.WriteLine($"    Sub Total: {subtotal:C}");
Console.WriteLine($"        Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");
*/
/*
string input = "Pad this";
//Console.WriteLine(input.PadLeft(12));

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
*/
/*
string paymentId = "769";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
*/
/*
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine("");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
Console.WriteLine("");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given, your current volume, your potential profit would be {newProfit:C2}.");
Console.WriteLine("");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

string currentPercentage = $"{currentReturn:P2}";
string newPercentage = $"{newReturn:P2}";

comparisonMessage += currentProduct.PadRight(20) + currentPercentage.PadRight(10) + $"{currentProfit:C2}" + "\n";
comparisonMessage += newProduct.PadRight(20) + newPercentage.PadRight(10) + $"{newProfit:C2}";

Console.WriteLine(comparisonMessage);
*/
/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/
/*
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1);
}
*/
/*
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = {'[','{','('};
int startPosition = 6;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH usinng startPosition: {message.Substring(openingPosition)}");
*/
/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
char[] openSymbols = { '[', '{', '('};

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition,1);

    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/
/*
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5,20);
Console.WriteLine(updatedData);
*/
/*
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-","");
Console.WriteLine(message);
*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string spanOpen = "<span>";
const string spanClose = "</span>";
int spanStart = input.IndexOf(spanOpen);
int spanEnd = input.IndexOf(spanClose);
quantity = input.Substring(spanStart, spanEnd - spanStart);
quantity = quantity.Replace("<span>","");
quantity = $"Quantity: {quantity}";

output = input.Replace("<div>","");
output = output.Replace("</div>","");
output = output.Replace("&trade","&reg");
output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);