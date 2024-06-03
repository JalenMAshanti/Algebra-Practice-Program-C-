
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;
using MathGameProgram;

var menu = new Menu();
var getName = new Name();
var date = DateTime.UtcNow;
string name = getName.GetName();


menu.ShowMenu(name, date);







