var name = "Ewa";
var gender = "kobieta";
var age = 33;

if (gender == "women" && age == 33)

{
    Console.WriteLine("kobieta poniżej 35 lat");
}
else if (age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == "men" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
