int suhu;

do
{
    Console.WriteLine("input you temperature(between -50 until 150)");
    suhu = int.Parse(Console.ReadLine());
} while (suhu <-50 || suhu > 150);

console