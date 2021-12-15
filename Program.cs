int age;
string gender;
Console.WriteLine("Veuillez indiquer votre âge");
age = int.Parse(Console.ReadLine());
Console.WriteLine("Êtes-vous un homme ou une femme?");
gender = Console.ReadLine();
if(gender == "homme")
{
    if(age >= 18)
    {
        Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
    }
    else
    {
        Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
    }
}
if(gender == "femme")
{
    if (age >= 18)
    {
        Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
    }
    else
    {
        Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
    }
}