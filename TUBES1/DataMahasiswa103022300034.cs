using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace TUBES1
{
    internal class DataMahasiswa103022300034
    {
        public async Task<Mahasiswa> ReadJsonAsync(string filePath)
        {
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                var mahasiswa = await JsonSerializer.DeserializeAsync<Mahasiswa>(openStream);

                if (mahasiswa != null)
                {
                    Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
                }

                return mahasiswa;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the JSON file: {ex.Message}");
                return null;
            }
        }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
}
