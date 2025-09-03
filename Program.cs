// Console.WriteLine("Välkommen till min frågesport!");
// Console.WriteLine("Vad heter du?");
// string namn = Console.ReadLine();
// Console.WriteLine($"Hej {namn}, är du redo att börja? (ja/nej)");
// string svar = Console.ReadLine()!.ToLower();
// if (svar == "ja")
// {
//     Console.WriteLine("Vad är huvudstaden i Sverige?");
//     string frag1 = Console.ReadLine()!.ToLower();
//     if (frag1 == "stockholm")
//     {
//         Console.WriteLine("Rätt svar!");
//     }
//     else
//     {
//         Console.WriteLine("Fel svar, rätt svar är Stockholm");
//     }

//     Console.WriteLine("Hur många invånare har Sverige?");
//     string frag2 = Console.ReadLine()!.ToLower();
//     if (frag2 == "10 miljoner" || frag2 == "10 000 000" || frag2 == "10,000,000")
//     {
//         Console.WriteLine("Rätt svar!");
//     }
//     else
//     {
//         Console.WriteLine("Fel svar, rätt svar är 10 miljoner");
//     }

//     Console.WriteLine("Vilket år blev Sverige medlem i EU?");
//     string frag3 = Console.ReadLine()!.ToLower();
//     if (frag3 == "1995")
//     {
//         Console.WriteLine("Rätt svar!");
//     }
//     else
//     {
//         Console.WriteLine("Fel svar, rätt svar är 1995");
//     }

//     Console.WriteLine("Tack för att du deltog i frågesporten!");
// }
// else
// {
//     Console.WriteLine("Okej, kanske en annan gång.");
// }

Console.WriteLine("Välkommen till min frågesport!");
Console.WriteLine("Vad heter du?");
String namn = Console.ReadLine();
Console.WriteLine($"Hej {namn}, är du redo att börja? (ja/nej)");
string svar = Console.ReadLine()!.ToLower();
if (svar == "ja")
Console.WriteLine("vilka färger har den svenska flaggan?");
string frag1 = Console.ReadLine()!.ToLower();
if (frag1 == "blå och gul")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, rätt svar är blå och gul");
}
Console.WriteLine("Hur många landskap finns det i Sverige?");
string frag2 = Console.ReadLine()!.ToLower();
if (frag2 == "25")
{
Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, rätt svar är 25");
}
Console.WriteLine("Vilket år blev Sverige medlem i FN?");
String frag3 = Console.ReadLine()!.ToLower();
if (frag3 == "1946")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, rätt svar är 1946");
}
Console.WriteLine("I Vilken värdsdel ligger Ryssland?");
string frag4 = Console.ReadLine()!.ToLower();
if (frag4 == "asien och europa")
{
    Console.WriteLine("Rätt svar!");
}
else
{
Console.WriteLine("Fel svar, rätt svar är asien och europa");
}
Console.WriteLine("Vilka färger har den Finlands flagga?Färg\n 1:");

string color1 = Console.ReadLine();
Console.WriteLine("Färg 2:");
string color2 = Console.ReadLine();
if (color1 == "blå" && color2 == "vit" || color1 == "vit" && color2 == "blå")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, rätt svar är blå och vit");
}

Console.WriteLine("Vilket tal tänker jag på?");
string inm1 = Console.ReadLine();
int tal1 = Convert.ToInt32(inm1);
if (tal1 == 23)
    Console.WriteLine("Rätt svar!");

else if (tal1 > 20 && tal1 < 30)
{
    Console.WriteLine("Du är väldigt nära!");
}
else if (tal1 > 10 && tal1 < 40)
{
    Console.WriteLine("Du är ganska nära!");
}
else

Console.WriteLine("fel svar, försök igen!");


Console.WriteLine("Vilket år hände boston tea party?");
string frag = Console.ReadLine()!.ToLower();
if (frag4 == "1773")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, rätt svar är 1773");
}
Console.WriteLine("Vilket år dog den sista pungvargen?");
string frag5 = Console.ReadLine()!.ToLower();
if (frag5 == "1936")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, rätt svar är 1936");
}
Console.WriteLine("Vilket land fick 2 atom bomber på sig under andra världskriget?");
string frag6 = Console.ReadLine()!.ToLower();
if (frag6 == "japan")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, rätt svar är japan");
}

Console.WriteLine("vilket år splittrades sovjetunionen?");
string frag7 = Console.ReadLine()!.ToLower();
if (frag7 == "1991")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, rätt svar är 1991");
}
Console.WriteLine("Hur många krig startade napoleon?");
string frag8 = Console.ReadLine()!.ToLower();
if (frag8 == "4")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, rätt svar är 4");
}







// Console.WriteLine("Välkommen Ben. Skriv ett tal");


// string im1 = Console.ReadLine();
// Console.WriteLine("ett till tal");
// string inm2 = Console.ReadLine();

// int tal1 = Convert.ToInt32(im1);

// int tal2 = Convert.ToInt32(inm2);

// int summa = tal1 + tal2;

// Console.WriteLine("" + summa);

// Console.WriteLine("Välkommen Ost. Skriv ett tal");

// string inm1 = Console.ReadLine();
// Console.WriteLine("ett til tal");
// string inm2 = Console.ReadLine();

// int tal1 = Convert.ToInt32(inm1);

// int tal2 = Convert.ToInt32(inm2);
// int summa = tal1 - tal2;
// Console.WriteLine("" + summa);

// Console.WriteLine("Välkommen Hank. Skriv ett tal");

// string inm1 = Console.ReadLine();
// Console.WriteLine("skriv ett till tal");
// string inm2 = Console.ReadLine();

// int tal1 = Convert.ToInt32(inm1);
// int tal2 = Convert.ToInt32(inm2);
// int summa = tal1 / tal2;
// Console.WriteLine("" + summa);

// Console.WriteLine("Välkommen Baam, skriv ett tal");

// String inm1 = Console.ReadLine();
// Console.WriteLine("skriv ett till tal");
// string inm2 = Console.ReadLine();
// int tal1 = Convert.ToInt32(inm1);
// int tal2 = Convert.ToInt32(inm2);
// int summa = tal1 * tal2;
// Console.WriteLine("" + summa);

// Console.WriteLine("Välkommen Baam, skriv ett tal");

// String inm1 = Console.ReadLine();
// Console.WriteLine("skriv ett till tal");
// string inm2 = Console.ReadLine();

// double tal1 = Convert.ToDouble(inm1);
// double tal2 = Convert.ToDouble(inm2);

// double div = tal1 / tal2;
// Console.WriteLine("" + div);

// Console.WriteLine("Välkommen Baam, skriv ett tal");
// string inm1 = Console.ReadLine();
// Console.WriteLine("skriv ett till tal");
// string inm2 = Console.ReadLine();
// int tal1 = Convert.ToInt32(inm1);
// int tal2 = Convert.ToInt32(inm2);
// int summa = tal1 + tal2;
// Console.WriteLine("" + summa);

// Console.WriteLine("Välkommen till mitt pogram.");
// Console.WriteLine("Vad heter du?");
// string namn = Console.ReadLine();
// Console.WriteLine($"hej {namn}, hur gammal är du?");
// string alder = Console.ReadLine();
// int age = Convert.ToInt32(alder);
// Console.WriteLine($"om ett år är du {age + 1} år gammal");
// // Console.WriteLine("Välkommen!\nVad heter du?");

// // string namn = Console.ReadLine();

// // Console.WriteLine("Hej " + namn);
// // Console.WriteLine("Vart bor du?");
// // String plats = Console.ReadLine();

// // Console.WriteLine("Vad gillar du att se på netflix?");
// // String netflix = Console.ReadLine();

// // Console.WriteLine($"Välkommen {namn}. Jag ser att du bor i/på {plats}.\n"
// // + $"Ikväll tycker jag du ska kolla på {netflix}"); 


// // Console.WriteLine("Hur gammal är du på riktigt");

// // string inm = Console.ReadLine();
// // int age = Convert.ToInt32(inm);

// // if (age > 17)
// // {
// //     Console.WriteLine("Välkommen till krogen");
// // }
// // Console.WriteLine("skriv in ett heltal");
// // string inm1 = Console.ReadLine();
// // Console.WriteLine("skriv in ett till heltal");
// // string inm2 = Console.ReadLine();

// // int tal1 = Convert.ToInt32(inm1);
// // int tal2 = Convert.ToInt32(inm2);

// // int summa = tal1 + tal2;

// // Console.WriteLine($"{tal1} + {tal2} = {summa}");