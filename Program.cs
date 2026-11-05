using RollerKolcsonzo;
using System.IO;

string[] sorok = File.ReadAllLines("rollerek.txt");
List<RollerUtazas> rollerek = new List<RollerUtazas>();

Console.WriteLine("Adatok beolvasása a rollerek.txt fájlból...\n");
foreach (string sor in sorok) 
{ 
    rollerek.Add(new RollerUtazas(sor));
    RollerUtazas peldany = new RollerUtazas(sor);
    Console.WriteLine(peldany);
}

Console.WriteLine();
Console.WriteLine("Statisztika:");
Console.WriteLine($"Kölcsönző teljes napi bevétele: {rollerek.Sum(x=>x.FizetendoDij())} Ft");
Console.WriteLine($"Leghosszabb utazás: {rollerek.MaxBy(x=>x.UtazasIdoPerc).FelhasznaloNev} ({rollerek.Max(x => x.UtazasIdoPerc)} perc)");

