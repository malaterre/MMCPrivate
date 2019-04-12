using System;
using System.IO;
using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Soap;
using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace HitachiMedical
{
namespace Dream
{
namespace Cabinet
{
namespace ApplicationObjects
{
  [Serializable()]
  public class ImageAppData
  {
    public int pAPEFlag;
    public int antiAliasingMode;
    public int fOVFilter;
    public int tuningValue;
    public int h1Value;
    public int gain;
    public int flipAngle2;
    public int bandWidth;
    public int h1SpoilValue;
    public int filterType;
    public int mTCIrradiatedTime;
    public int mTCIrradiatedPower;
    public int mTCOffsetFrequency;
    public int fatSaturationIrradiatedPower;
    public int fatSaturationOffsetFrequency;
    public int flowAxisDirection;
    public int cardiacGatingCount;
    public int cardiacGatingSliceOrder;
    public int truncationArtifactFlag;
    public int shadingCorrectionFilterFlag;
    public int shadingCorrectionFilterType;
    public int shadingCorrectionStrength;
    public int shadingCorrectionMode;
    public int fatSaturationPulseKind;
    public int fSEThetaCorrectionValue;
    public int dCLevel;
    public int correctPosition;
    public int distortionCorrection;
    public int shadingCorrectionFilter;
    public int f0Shift;
    public int t2Correct;
    public int postScanFrequency;
    public int fatsepImageType;
    public int originalFatSepEcho;
    public int sequenceMode;
  }

public class MM
{
  [STAThread]
  static void Main() 
  {
      Serialize();
  }

  static void Serialize() 
  {
      // Create a hashtable of values that will eventually be serialized.
      Hashtable addresses = new Hashtable();
      HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData o = new HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData();
      addresses.Add("HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData", o);
      //addresses.Add(o, 0);
      //addresses.Add("Jeff", "123 Main Street, Redmond, WA 98052");
      //addresses.Add("Fred", "987 Pine Road, Phila., PA 19116");
      //addresses.Add("Mary", "PO Box 112233, Palo Alto, CA 94301");
   
      // To serialize the hashtable and its key/value pairs,  
      // you must first open a stream for writing. 
      // In this case, use a file stream.
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
}
}
}
