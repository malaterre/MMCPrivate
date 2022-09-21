extern alias bla;

using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace ConsoleApp
{
    class Program
    {
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

        static void Main(string[] args)
        {
            Serialize();
            // Console.WriteLine("Hello World!");
            object obj = null;
            FileStream fs = new FileStream("template.nrb", FileMode.Open);
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
            Console.WriteLine("Debug: " + obj);
        }
    }
}
