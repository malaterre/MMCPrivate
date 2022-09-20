using System;
using System.IO;
using System.Runtime.Serialization;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ns
{
    public class MM
    {
        [STAThread]
        static void Main()
        {
            Serialize();
            Deserialize();
        }

        static void Deserialize()
        {
            // Declare the hashtable reference.
            Hashtable oldObj = null;
            Hashtable newObj = null;

            // Open the file containing the data that you want to deserialize.
            FileStream oldfs = new FileStream("input.nrb", FileMode.Open);
            FileStream newfs = new FileStream("DataFile.nrb", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and 
                // assign the reference to the local variable.
                oldObj = (Hashtable)formatter.Deserialize(oldfs);
                newObj = (Hashtable)formatter.Deserialize(newfs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                oldfs.Close();
                newfs.Close();
            }

            // To prove that the table deserialized correctly, 
            // display the key/value pairs.
            foreach (DictionaryEntry de in oldObj)
            {
                Console.WriteLine("{0} lives at {1}.", de.Key, de.Value);
            }
        }

        static string MakeACopy(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input);
            return sb.ToString();
        }

        static void SerializeNew()
        {
            // Create a hashtable of values that will eventually be serialized.
            HitachiMedical.Platform.DataAccess.DicomAccess.DicomImagePrivatePS dicomImagePrivatePS = new HitachiMedical.Platform.DataAccess.DicomAccess.DicomImagePrivatePS
            {
                pAPEFlag = MakeACopy("off")
            };
            FileStream fs = new FileStream("DataFile.nrb", FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, dicomImagePrivatePS);
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

        static void Serialize()
        {
            // Create a hashtable of values that will eventually be serialized.
            Hashtable hashtable = new Hashtable(6);

            // the actual imageAppData object
            HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData imageAppData = new HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData
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
            FileStream fs = new FileStream("DataFile.nrb", FileMode.Create);
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
    }
}
