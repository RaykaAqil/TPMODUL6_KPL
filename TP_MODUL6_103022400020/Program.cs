using System.Diagnostics.Contracts;

public class SayaMusicTrack
{
    private int id;
    private string playCount, title;

    public SayaMusicTrack(string title)
    {
        Contract.Requires(title != null, "Judul tidak boleh null.");
        Contract.Requires(title.Length <= 100, "Judul maksimal 100 karakter.");

        this.title = title;
        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.playCount = "0";
    }

    public void IncreasePlayCount(int count)
    {
        Contract.Requires(count <= 10000000, "Input maksimal 10.000.000.");

        try
        {
            int currentCount = int.Parse(this.playCount);

            checked
            {
                currentCount += count;
            }

            this.playCount = currentCount.ToString();
        }
        catch (OverflowException)
        {
            Console.WriteLine("Peringatan!! Terjadi Overflow saat penambahan!");
        }
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

class main
{
    static void Main()
    {
        SayaMusicTrack lagu = new SayaMusicTrack("Pandangan Pertama");
        lagu.PrintTrackDetails();

        Console.WriteLine("\nMenambahkan 10jt berkali-kali");
        for (int i = 0; i < 220; i++)
        {
            lagu.IncreasePlayCount(10000000);
        }

        Console.WriteLine();
        lagu.PrintTrackDetails();

        SayaMusicTrack lagu2 = new SayaMusicTrack(null);
    }
}