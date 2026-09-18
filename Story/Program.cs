Console.WriteLine("Hej");
Console.WriteLine("Du har två val du gå med hugo in i en mörk grotta eller så går du hem");
string svar1 = "";
svar1 = Console.ReadLine();
if (svar1 == "gå hem")
{
    Console.WriteLine("Du går hem säkert och går och lägger dig .... you win ");
}
else if (svar1 == "hugo")
{
    Console.WriteLine("Så du går ned i grottan och du ser är svärd tar du det och mördar hugo eller går vidare");
    string svar2 = Console.ReadLine();
    if (svar2 == "gå vidare")
    {
        Console.WriteLine("du forsätter att gå och vänder dig om ser hugo springa emot dig med svärdet ....... Game over )= ");
    }
    else if (svar1 == "Döda hugo")
    {
        Console.WriteLine("Du dödar hugo och går hem och sove...... You win");
    }
}
Console.ReadLine();