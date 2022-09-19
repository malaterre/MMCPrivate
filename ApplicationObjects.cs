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
            FileStream oldfs = new FileStream("input.dat", FileMode.Open);
            FileStream newfs = new FileStream("DataFile.dat", FileMode.Open);
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
            HitachiMedical.Platform.DataAccess.DicomAccess.DicomImagePrivatePS o = new HitachiMedical.Platform.DataAccess.DicomAccess.DicomImagePrivatePS();
            o.pAPEFlag = MakeACopy("off");
            FileStream fs = new FileStream("DataFile.dat", FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, o);
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
            Hashtable addresses = new Hashtable(6);
            HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData o = new HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData();
            o.pAPEFlag = MakeACopy("off");
            o.antiAliasingMode = null;
            o.fOVFilter = MakeACopy("off");
            o.tuningValue = MakeACopy("0");
            o.h1Value = MakeACopy("146");
            o.gain = MakeACopy("14");
            o.flipAngle2 = null;
            o.bandWidth = MakeACopy("15.6");
            o.h1SpoilValue = null;
            o.filterType = null;
            o.mTCIrradiatedTime = null;
            o.mTCIrradiatedPower = null;
            o.mTCOffsetFrequency = null;
            o.fatSaturationIrradiatedPower = null;
            o.fatSaturationOffsetFrequency = null;
            o.flowAxisDirection = null;
            o.cardiacGatingCount = null;
            o.cardiacGatingSliceOrder = null;
            o.truncationArtifactFlag = MakeACopy("on");
            o.shadingCorrectionFilterFlag = MakeACopy("s-map");
            o.shadingCorrectionFilterType = MakeACopy("off");
            o.shadingCorrectionStrength = null;
            o.shadingCorrectionMode = null;
            o.fatSaturationPulseKind = null;
            o.fSEThetaCorrectionValue = new float[] { 0.0f, 0.0f, 0.0f };
            o.dCLevel = MakeACopy("off");
            o.correctPosition = null;
            o.distortionCorrection = null;
            o.shadingCorrectionFilter = MakeACopy("s-map,off");
            o.f0Shift = MakeACopy("0");
            o.t2Correct = MakeACopy("off");
            o.postScanFrequency = null;
            o.fatsepImageType = null;
            o.originalFatSepEcho = null;
            o.sequenceMode = null;

            addresses.Add("HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData", o);
            FileStream fs = new FileStream("DataFile.dat", FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, addresses);
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
