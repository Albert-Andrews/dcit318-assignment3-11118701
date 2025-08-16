using System;
using System.Collections.Generic;
using System.IO;

namespace Question4
{
    public class StudentResultProcessor
    {
        public List<Student> ReadStudentsFromFile(string inputFilePath)
        {
            var students = new List<Student>();
            using var reader = new StreamReader(inputFilePath);

            string? line;
            int lineNo = 0;
            while ((line = reader.ReadLine()) != null)
            {
                lineNo++;
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');
                if (parts.Length != 3)
                    throw new MissingFieldException($"Line {lineNo}: Missing fields");

                if (!int.TryParse(parts[0].Trim(), out int id))
                    throw new FormatException($"Line {lineNo}: Invalid ID format");

                string name = parts[1].Trim();

                if (!int.TryParse(parts[2].Trim(), out int score))
                    throw new InvalidScoreFormatException($"Line {lineNo}: Invalid score '{parts[2]}'");

                students.Add(new Student(id, name, score));
            }

            return students;
        }

        public void WriteReportToFile(List<Student> students, string outputFilePath)
        {
            using var writer = new StreamWriter(outputFilePath);
            foreach (var s in students)
            {
                writer.WriteLine(s.ToString());
            }
        }

        public void Run()
        {
            string input = "Question4/students_input.txt";
            string output = "Question4/students_report.txt";

            try
            {
                var students = ReadStudentsFromFile(input);
                WriteReportToFile(students, output);
                Console.WriteLine($"Report generated successfully: {output}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error] " + ex.Message);
            }
        }
    }
}
