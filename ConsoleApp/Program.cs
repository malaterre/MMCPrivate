using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serialize();
            string input = "256.102f.raw";
            string output = "debug.raw";
            AppContext.SetSwitch("Switch.System.Runtime.Serialization.SerializationGuard.AllowFileWrites", true);
            if (args.Length > 0)
                input = args[0];
            if (args.Length > 1)
                output = args[1];
            byte[] array = File.ReadAllBytes(input);
            byte firstByte = array[0];
            {
                Debug.Assert(array.Length % 2 == 0);
                Debug.Assert(firstByte == 0 || firstByte == 1);
                if (firstByte == 1)
                    Debug.Assert(array[^1] == 0x0);
            }
            object oldObj = null;
            {
                var nrb = array.AsSpan(1, array.Length - 1 - firstByte);
                {
                    // prepare nrb:
                    var fs = new FileStream(input + ".nrb", FileMode.Create);
                    fs.Write(nrb);
                    fs.Close();
                }
                var ms = new MemoryStream(nrb.ToArray());
                try
                {
                    var formatter = new BinaryFormatter();
                    // formatter.Binder = new HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppDataDeserializationBinder();
                    oldObj = formatter.Deserialize(ms);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                    throw;
                }
                finally
                {
                    ms.Close();
                }
                /*
                Console.WriteLine("Debug: " + oldObj);
                Console.WriteLine("Type: " + oldObj.GetType());
                if (oldObj is Hashtable)
                {
                    Hashtable hashtable = (Hashtable)oldObj;
                    foreach (DictionaryEntry de in hashtable)
                    {
                        Console.WriteLine("{0} lives at {1}.", de.Key, de.Value);
                    }
                }*/
                {
                    var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
                    string jsonString = JsonSerializer.Serialize(oldObj, options);
                    File.WriteAllText(input + ".json", jsonString);
                }
            }
            object newObj = null;
            {
                var ms = new MemoryStream();
                try
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(ms, oldObj);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                    throw;
                }

                byte[] nrb = ms.ToArray();
                {
                    var fs = new FileStream(output, FileMode.Create);
                    if (nrb.Length % 2 == 1)
                        fs.WriteByte(1);
                    else
                        fs.WriteByte(0);
                    fs.Write(nrb);
                    if (nrb.Length % 2 == 1)
                        fs.WriteByte(0);
                    fs.Close();
                }
                {
                    var fs = new FileStream(output + ".nrb", FileMode.Create);
                    fs.Write(nrb);
                    fs.Close();
                }
                {
                    var fs = new FileStream(output + ".nrb", FileMode.Open);
                    try
                    {
                        var formatter = new BinaryFormatter();
                        newObj = formatter.Deserialize(fs);
                    }
                    catch (SerializationException e)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                        throw;
                    }
                    finally
                    {
                        fs.Close();
                    }

                    {
                        var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
                        string jsonString = JsonSerializer.Serialize(newObj, options);
                        File.WriteAllText(output + ".json", jsonString);
                    }
                }
                // check:
                long inputNrb = new FileInfo(input + ".nrb").Length;
                long outputNrb = new FileInfo(output + ".nrb").Length;
                Debug.Assert(inputNrb == outputNrb);
            }
        }
    }
}
