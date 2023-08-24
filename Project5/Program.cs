﻿/*
Console.WriteLine("Generating random numbers");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();

    for(int i = 0; i<5; i++)
    {
        Console.Write($"{random.Next(1,100)} ");
    }

    Console.WriteLine();
}
*/
/*
using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

DisplayTimes();

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");

DisplayTimes();

Console.WriteLine();

void DisplayTimes()
{
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}

void AdjustTimes()
{
    Adjust the times by adding the difference, keeping the value within 24 hours 
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
*/
/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 -255

then ipAddress is valid

else ipAddress is invalid
*/
/*
string[] ipv4Input = {"107.31.1.5","255.0.0.255","555..0.555","255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}


void ValidateLength() 
{    
    validLength = address.Length == 4;
}

void ValidateZeroes () 
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange () 
{
    foreach (string number in address)
    {
        if (int.Parse(number) > 255)
        {
            validRange = false;
            return;
        }
    }

    validRange = true;
}
*/
/*
Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

DisplayFortune();

void DisplayFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");

    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));

    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}
*/
/*
int[] schedule = {800,1200,1600,2000};

DisplayAdjustedTimes(schedule,6,-6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT)>12 || Math.Abs(currentGMT)>12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if ((newGMT <= 0 && currentGMT <= 0) || (newGMT >= 0 && currentGMT >= 0))
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
*/
/*
string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}
*/
/*
double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleArea(int radius)
{        
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}
*/
/*
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statment: {a} x {b} = {c}");

void Multiply(int a , int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}
*/
/*
using System.Runtime.InteropServices;

int[] array = {1,2,3,4,5};

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach(int a in array)
    {
        Console.Write($"{a} ");
    }
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}
*/
/*
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth (bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}

parameters
*/
/*
string[] guestList = {"Rebecca","Nadia","Noor","Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca");
RSVP("Nadia",2,"Nuts");
RSVP(name:"Linh",partySize:2,inviteOnly:false);
RSVP("Tony",inviteOnly: true, allergies: "Jackfruit");
RSVP("Noor",4,inviteOnly:false);
RSVP("Jonte",2,"Stone fruit",false);
ShowRSVPs();

void RSVP (string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}
*/
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string internalDomain = "contoso.com";
string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    string domain = internalDomain;
    string firstName = corporate[i,0].ToLower();
    string lastName = corporate[i,1].ToLower();

    EmailAddress(domain, firstName, lastName);
}
for (int i = 0; i < external.GetLength(0); i++) 
{
    string domain = externalDomain;
    string firstName = external[i,0].ToLower();
    string lastName = external[i,1].ToLower();

    EmailAddress(domain, firstName, lastName);
}

void EmailAddress(string domain, string firstName, string lastName)
{
    string firstNamePart = firstName.Substring(0,2);
    string address = firstNamePart + lastName;
    
    Console.WriteLine($"{address}@{domain}");    
}