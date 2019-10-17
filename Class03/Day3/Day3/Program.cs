using System;
using System.IO; // Vinicio - IO stands for? Input / Output
using System.Security;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../../myFile.txt";
            //ReadAllLines(fileName);
            // ReadArrayOfLines(fileName);
            //WriteEntireFile(fileName);
            //AppendValuesInFile(fileName);
            //CreateFile(fileName);

            PracticeWithSplit();
        }
        #region Introduction
        static void WriteEntireFile(string path)
        {
            File.WriteAllText(path, "What is Love?");
        }

        static void ReadAllLines(string path)
        {
            string allLines = File.ReadAllText(path);
            Console.WriteLine(allLines);
        }

        static void ReadArrayOfLines(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static void AppendValuesInFile(string path)
        {
            // Vinicio - you may need to use this in your lab :)
            string[] newLines = { "", "I", "actually", "love VIM" };
            File.AppendAllLines(path, newLines);

            File.AppendAllText(path, "Also, Kali is cute");
        }
        #endregion

        #region BetterPractices
        static void CreateFile(string path)
        {
            try
            {
                string[] lines = { "THis", "Comes", "From", "a Stream" };
                using (StreamWriter stream = new StreamWriter(path))
                {
                    try
                    {
                        foreach (string line in lines)
                        {
                            stream.WriteLine(line);
                        }
                    }
                    catch(IOException e)
                    {
                        Console.WriteLine("An ERROR happened - We couldn't write to the file");                  
                    }

                } // stream.close();
            }
            catch(IOException e)
            {
                Console.WriteLine("An ERROR happened when trying to create the stream - Please call this number:");
            }
            catch (SecurityException e)
            {
                Console.WriteLine("An ERROR happened. You may not have permissions to read a file");

            }
            catch (Exception e)
            {
                Console.WriteLine("An ERROR happened when trying to create the stream - Please call this number:");
            }
        }
        #endregion

        static void PracticeWithSplit()
        {
            char[] separators = { ',','-' };
            string bigString = "1-4-5,7,8,1,Amanda,Bill Gates,Microsoft";

            string[] individualValues = bigString.Split(separators);

            foreach(string value in individualValues)
            {
                Console.WriteLine(value);
            }

        }
    }
}
