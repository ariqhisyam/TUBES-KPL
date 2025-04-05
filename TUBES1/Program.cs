using System;
using System.Threading.Tasks;
using TUBES1;

class Program
{
    static async Task Main(string[] args)
    {
        var dataMahasiswa = new DataMahasiswa103022300034();
        var mahasiswaFilePath = "D:/Figma Hamda/Campursari/tp7_1_103022300034.json";
        await dataMahasiswa.ReadJsonAsync(mahasiswaFilePath);

        var kuliahMahasiswa = new KuliahMahasiswa103022300034();
        var kuliahFilePath = "D:/Figma Hamda/Campursari/tp7_2_103022300034.json";
        await kuliahMahasiswa.ReadJSON(kuliahFilePath);
    }
}
