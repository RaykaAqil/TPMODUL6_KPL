public class SayaMusicTrack
{
    private int id;
    private string playCount, title; 

    public SayaMusicTrack(string title)
    {
        this.title = title;

        Random random = new Random();
        this.id = random.Next(10000, 100000);

        this.playCount = "0";
    }

    public void IncreasePlayCount(int count)
    {
        int currentCount = int.Parse(this.playCount);
        currentCount += count;
        this.playCount = currentCount.ToString();
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("=== Detail Music Track ===");
        Console.WriteLine("ID : " + this.id);
        Console.WriteLine("Judul Lagu : " + this.title);
        Console.WriteLine("Play Count : " + this.playCount);
        Console.WriteLine("--------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack laguBaru = new SayaMusicTrack("Pandangan Pertama");

        Console.WriteLine("Detail Awal:");
        laguBaru.PrintTrackDetails();

        laguBaru.IncreasePlayCount(150);

        Console.WriteLine("\nDetail Setelah Update:");
        laguBaru.PrintTrackDetails();
    }
}