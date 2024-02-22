// See https://aka.ms/new-console-template for more information

using IntroR.Business;
using IntroR.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";

int term = 12;
double amount = 10000;

// Variables camelCase yazılır 
bool isAuthenticated = false; //DB den gelen bir değer

Console.WriteLine(message1);

//Condition
if (isAuthenticated==true) //isAuthenticated de sadece true demek
{
    Console.WriteLine("Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton --> Sisteme giriş yap.");
}

string[] loans = {"Kredi1","Kredi2","Kredi3","Kredi4","Kredi5","Kredi6"};  //DB den gelir bu 
//string[] loans2 = new string[6];
//loans2[0] = "Kredi1";

// start        condition    increment 
for(int i = 0; i<loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new CourseManager();  // Bir class ı kullanmak için onu NEW lemek gerek
// yani bir class ı new lediğimiz zaman CONSTRUCTOR ı çalışır ilk.
Course[] courses2 = courseManager.GetALL();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " " + courses2[i].Price);
}

Console.WriteLine("Kod bitti.");
