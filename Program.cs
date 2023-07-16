namespace LabExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                WriteToTextFile();
                Console.WriteLine("Here is the content of the file mytest.txt:");
                ReadFromTextFile();
            }

            static void WriteToTextFile()
            {
                // Path to the text file
                StreamWriter writer = File.CreateText("D:\\mytest.txt");
                writer.WriteLine("Hello and Welcome");
                writer.WriteLine("It is the first content");
                writer.WriteLine("Of the text file mytest.txt");
                writer.Close();
            }

            static void ReadFromTextFile()
            {
                string? s;
                StreamReader reader = File.OpenText("D:\\mytest.txt");
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                reader.Close();

            }
        }
    }
}
