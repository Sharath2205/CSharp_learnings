using System;
using System.IO;

namespace ExcpetionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Sharath.Chandra\Desktop\C# Helpers\Logs\ExceptionHandlingLog.txt";
            StreamReader? streamReader = null;
            StreamWriter streamWriter = new StreamWriter(filePath);
            try
            {
                streamReader = new StreamReader(@"C:\Users\Sharath.Chandra\Desktop\C# Helpers\Sample texts\Lorem.txt");
                //streamReader.ReadToEnd();
                Console.WriteLine(streamReader.ReadToEnd());
            } catch (FileNotFoundException ex)
            {   
                if(!File.Exists(filePath)) { throw new FileNotFoundException();  }
                Console.WriteLine("1 " + ex.Message);
                streamWriter.Write(ex.GetType().Name);
                Console.WriteLine();
                streamWriter.Write("1 " + ex.Message);
            } catch (DirectoryNotFoundException ex)
            {
                if (File.Exists(filePath)) {
                    Console.WriteLine("2 " + ex.Message);
                    streamWriter.WriteLine(ex.GetType().Name);
                    Console.WriteLine();
                    streamWriter.WriteLine(ex.Message);
                }
                else
                    Console.WriteLine("Output File not found");
                
            } catch(Exception ex)
            {
                Console.WriteLine("3 " + ex.Message);
                streamWriter.Write(ex.GetType().Name);
                Console.WriteLine();
                streamWriter.Write(ex.Message);
            }
            finally
            {
                streamReader?.Close();
                streamWriter?.Close();
                Console.WriteLine("In finally block");
            }
            
        }
    }
}