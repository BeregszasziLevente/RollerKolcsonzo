using RollerKolcsonzo;
using System.IO;

string[] sorok = File.ReadAllLines("rollerek.txt");
List<RollerUtazas> rollerek = new List<RollerUtazas>();

foreach (string sor in sorok) rollerek.Add(new RollerUtazas(sor));

