using System; // Vinicio - using DIRECTIVE. Brings names from a different namespace
using System.IO; // Vinicio - IO stands for Input/Output

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../myFile.txt";

            //ReadAllText(path);
            //ReadAllLines(path);
            //WriteAllText(path);
            //AppendLinesToFile(path);

            //GenerateCSVFile(path);
            //CreateFileWithStreams(path);
            //ReadFileWithStreams(path);
            // PraticeUsingSplit();
            DeleteFile(path);
        }


        static void DeleteFile(string path)
        {
            File.Delete(path);
        }


        static void PraticeUsingSplit()
        {
            char[] delimiters = {','}; // Vinicio - Rememeber, this is an array, and you can have mary delimiters
            string sampleText = "Gregor,1,Tuxedo";
            string[] individualValues = sampleText.Split(delimiters);
               
            //for(int i = 0; i < individualValues.Length; i++)
            //{
            //    Console.WriteLine(individualValues[i]);
            //}
            foreach(string currentValue in individualValues)
            {
                Console.WriteLine(currentValue);
            }
        }

        static void ReadFileWithStreams(string path)
        {
            try
            {
                using(StreamReader reader = File.OpenText(path))
                {
                    // -----------------------------------------------------------------------------
                    // METHOD ONE
                    // -----------------------------------------------------------------------------
                    //string currentLine = "";
                    //while((currentLine = reader.ReadLine()) != null)
                    //{
                    //    Console.WriteLine(currentLine);
                    //}
                    // -----------------------------------------------------------------------------
                    // METHOD TWO
                    // -----------------------------------------------------------------------------
                    string lines = reader.ReadToEnd();
                    Console.WriteLine(lines);
                    // -----------------------------------------------------------------------------
                }
            }
            // Vinicio - we can always make this catch more specific to the functions we are using
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("File Read :)");
            }
        }

        static void CreateFileWithStreams(string path)
        {
            string[] lines = {"I", "LOVE", "Kali"};

            try
            {
                // we are going to use our stream
                using (StreamWriter writer = new StreamWriter(path))
                {// Using statement. This makes sure that we close/dispose a resource
                    for(int i =0; i < lines.Length; i++)
                    {
                        try
                        {
                            //writer.Write(lines[i]);
                            //writer.Write("\n");
                            writer.WriteLine(lines[i]);
                        }
                        catch(IOException e )
                        {
                            Console.WriteLine("We couldn't write to the file");
                        }
                    }
                } 
            }
            // Vincio - I could catch all the exceptions right here, for ALL The code
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Please Enter a correct path");
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("The Path is way too long");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw; // .NET will find ANOTHER try and ANOTHER catch tu run
            }
        }

        static void WriteAllText(string path)
        {
            // Vinicio - Dune is a really cool book :)
            string fileContents = "I shall not fear, fear is the mind killer.\n";
            File.WriteAllText(path, fileContents);
        }

        static void GenerateCSVFile(string path)
        {
            string csvValues = "Name,Age,Color\n";
            csvValues += "Gregor,1,Tuxedo\n";
            csvValues += "Hound,1,Tabby\n";
            csvValues += "Kali,2,Dark Brown\n";

            // Vinicio - let's remember to use try-catches in these lines
            File.WriteAllText(path, csvValues);
        }

        static void AppendLinesToFile(string path)
        {
            string[] lines =
            {
                "Gregor",
                "The Hound",
                "Khal Basil",
                "Kali"
            };
            File.AppendAllLines(path, lines);

            string[] moreLines =
            {
                "Gregor is Cute",
                "Hound is Cute"
            };
            File.AppendAllLines(path, moreLines);

        }

        static void ReadAllText(string path)
        {
            string myFile = File.ReadAllText(path);
            Console.WriteLine(myFile);
        }

        static void ReadAllLines(string path)
        {
            string[] myLinesInFile = File.ReadAllLines(path);

            for(int i = 0; i < myLinesInFile.Length; i++)
            {
                Console.WriteLine(myLinesInFile[i]);
            }
        }

        //static void LinearTime(int[] input) // O(n)
        //{
        //    int[] myAarray = new int[19];  // O(1) space
        //    int counter = 0;
        //    for(int i = 0; i < input.Length; i++)
        //    {
        //        Console.WriteLine(input[i]);
        //        counter++;
        //    }
        //    Console.WriteLine("The final operation counter is: " +counter);
        //}

        //static void QuadraticTime(int[] input) // O(n^2)
        //{
        //    int counter = 0;
        //    for(int i = 0; i < input.Length; i++) // 10 times
        //    {
        //        Console.WriteLine(input[i]);
        //        for(int j = 0; j < input.Length; j++) // 10 times
        //        {
        //            Console.WriteLine(input[j]);
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine("The final operation counter is: " +counter);
        //}
    }
}
