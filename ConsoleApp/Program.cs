using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace ConsoleApp
{
    class Program
    {
        /*
        static string MakeACopy(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input);
            return sb.ToString();
        }
        static void Serialize()
        {
            // Create a hashtable of values that will eventually be serialized.
            Hashtable hashtable = new Hashtable(6);

            // the actual imageAppData object
            bla::HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData imageAppData = new bla::HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData
            {
                pAPEFlag = MakeACopy("off"),
                antiAliasingMode = null,
                fOVFilter = MakeACopy("off"),
                tuningValue = MakeACopy("0"),
                h1Value = MakeACopy("146"),
                gain = MakeACopy("14"),
                flipAngle2 = null,
                bandWidth = MakeACopy("15.6"),
                h1SpoilValue = null,
                filterType = null,
                mTCIrradiatedTime = null,
                mTCIrradiatedPower = null,
                mTCOffsetFrequency = null,
                fatSaturationIrradiatedPower = null,
                fatSaturationOffsetFrequency = null,
                flowAxisDirection = null,
                cardiacGatingCount = null,
                cardiacGatingSliceOrder = null,
                truncationArtifactFlag = MakeACopy("on"),
                shadingCorrectionFilterFlag = MakeACopy("s-map"),
                shadingCorrectionFilterType = MakeACopy("off"),
                shadingCorrectionStrength = null,
                shadingCorrectionMode = null,
                fatSaturationPulseKind = null,
                fSEThetaCorrectionValue = new float[] { 0.0f, 0.0f, 0.0f },
                dCLevel = MakeACopy("off"),
                correctPosition = null,
                distortionCorrection = null,
                shadingCorrectionFilter = MakeACopy("s-map,off"),
                f0Shift = MakeACopy("0"),
                t2Correct = MakeACopy("off"),
                postScanFrequency = null,
                fatsepImageType = null,
                originalFatSepEcho = null,
                sequenceMode = null
            };
            hashtable.Add("HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData", imageAppData);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            FileStream fs = new FileStream("debug.nrb", FileMode.Create);
            //fs.WriteByte(0);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, hashtable);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
        */

        static void Main(string[] args)
        {
            //Serialize();
            string input = "100.1050.raw";
            string output = "debug.raw";
            if (args.Length > 0)
                input = args[0];
            if (args.Length > 1)
                output = args[1];
            //Console.WriteLine("Process: " + input);
            byte[] array = File.ReadAllBytes(input);
            var firstByte = array[0];
            Debug.Assert(firstByte == 0 || firstByte == 1);
            var lastByte = array[^1];
            var offset = lastByte == 0 ? 1 : 0;
            if (firstByte == 1)
                Debug.Assert(offset == 1);
            var nrb = array.AsSpan(1, array.Length - 1 - offset);
            {
                // prepare debug:
                FileStream fs = new FileStream(input+ ".nrb", FileMode.Create);
                fs.Write(nrb);
                fs.Close();
            }
            object obj = null;
            {
                //FileStream fs = new FileStream(input, FileMode.Open);
                // Array.Resize(array, array.Length - 1);
                MemoryStream ms = new MemoryStream(nrb.ToArray());
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    obj = formatter.Deserialize(ms);
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
                Console.WriteLine("Debug: " + obj);
                Console.WriteLine("Type: " + obj.GetType());
                if (obj is Hashtable)
                {
                    Hashtable hashtable = (Hashtable)obj;
                    foreach (DictionaryEntry de in hashtable)
                    {
                        //Type type = de.Value.GetType();
                        //Console.WriteLine("Type: " + type);
                        //Console.WriteLine("AssemblyQualifiedName: " + type.AssemblyQualifiedName);
                        Console.WriteLine("{0} lives at {1}.", de.Key, de.Value);
                    }
                }
                {
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonString = JsonSerializer.Serialize(obj, options);
                    File.WriteAllText(input + ".json", jsonString);
                }
            }
            {
                MemoryStream ms = new MemoryStream();
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(ms, obj);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                    throw;
                }

                {
                    FileStream fs = new FileStream(output, FileMode.Create);
                    if (offset == 1)
                        fs.WriteByte(1);
                    else
                        fs.WriteByte(0);
                    ms.WriteTo(fs);
                    if (offset == 1)
                        fs.WriteByte(0);
                    fs.Close();
                }
                {
                    FileStream fs = new FileStream(output + ".nrb", FileMode.Create);
                    ms.WriteTo(fs);
                    fs.Close();
                }
                {
                    FileStream fs = new FileStream(output + ".nrb", FileMode.Open);
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        obj = formatter.Deserialize(fs);
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
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonString = JsonSerializer.Serialize(obj, options);
                    File.WriteAllText(output + ".json", jsonString);
                }
            }
        }
    }
}
