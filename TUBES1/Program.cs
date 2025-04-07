using System;
using System.IO;
using System.Threading.Tasks;
using TUBES1;

class Program
{
    static async Task Main(string[] args)
    {
        var projectRoot = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
        var jsonFolderPath = Path.Combine(projectRoot, "JSON");

        Console.WriteLine("=== Json Ariq Hisyam Nabil ===");
        var mahasiswaFilePath_103022300034 = Path.Combine(jsonFolderPath, "tp7_1_103022300034.json");
        var kuliahFilePath_103022300034 = Path.Combine(jsonFolderPath, "tp7_2_103022300034.json");

        var dataMahasiswa_103022300034 = new DataMahasiswa103022300034();
        await dataMahasiswa_103022300034.ReadJsonAsync(mahasiswaFilePath_103022300034);

        var kuliahMahasiswa_103022300034 = new KuliahMahasiswa103022300034();
        await kuliahMahasiswa_103022300034.ReadJSON(kuliahFilePath_103022300034);


        Console.WriteLine();
        Console.WriteLine("=== Json Relingga Aditya ===");
        var mahasiswaFilePath_103022300107 = Path.Combine(jsonFolderPath, "tp7_1_103022300107.json");
        var kuliahFilePath_103022300107 = Path.Combine(jsonFolderPath, "tp7_2_103022300107.json");

        var dataMahasiswa_103022300107 = new DataMahasiswa103022300034();
        await dataMahasiswa_103022300107.ReadJsonAsync(mahasiswaFilePath_103022300107);

        var kuliahMahasiswa_103022300107 = new KuliahMahasiswa103022300034();
        await kuliahMahasiswa_103022300107.ReadJSON(kuliahFilePath_103022300107);
    }
}
