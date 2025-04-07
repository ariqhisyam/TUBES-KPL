using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace TUBES1
{
    internal class KuliahMahasiswa1030223000042
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class CourseList
        {
            public List<Course> courses { get; set; }
        }

        public async Task ReadJSON(string filePath)
        {
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                var courseList = await JsonSerializer.DeserializeAsync<CourseList>(openStream);

                if (courseList != null && courseList.courses != null)
                {
                    Console.WriteLine("Daftar mata kuliah yang diambil:");
                    for (int i = 0; i < courseList.courses.Count; i++)
                    {
                        var course = courseList.courses[i];
                        Console.WriteLine($"MK {i + 1} {course.code} - {course.name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the JSON file: {ex.Message}");
            }
        }
    }
}
