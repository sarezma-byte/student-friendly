
Console.Write("Enter the two exam scores: ");

short score1 = Convert.ToInt16(Console.ReadLine());
short score2 = Convert.ToInt16(Console.ReadLine());
float average = (score1 + score2) / 2.0f;
Console.WriteLine("Bro you scored " + average);
if (average > 50)
{
    Console.WriteLine("Bro passed school!");
}
else
{
    Console.WriteLine("R.İ.P(bro not passed school called mom)");
}