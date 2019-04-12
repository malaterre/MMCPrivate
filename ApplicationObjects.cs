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
    //public ImageAppData() {}
    public string pAPEFlag;
    public Object antiAliasingMode;
    public string fOVFilter;
    public string tuningValue;
    public string h1Value;
    public string gain;
    public Object flipAngle2;
    public string bandWidth;
    public Object h1SpoilValue;
    public Object filterType;
    public Object mTCIrradiatedTime;
    public Object mTCIrradiatedPower;
    public Object mTCOffsetFrequency;
    public Object fatSaturationIrradiatedPower;
    public Object fatSaturationOffsetFrequency;
    public Object flowAxisDirection;
    public Object cardiacGatingCount;
    public Object cardiacGatingSliceOrder;
    public string truncationArtifactFlag;
    public string shadingCorrectionFilterFlag;
    public string shadingCorrectionFilterType;
    public Object shadingCorrectionStrength;
    public Object shadingCorrectionMode;
    public Object fatSaturationPulseKind;
    public int[] fSEThetaCorrectionValue;
    public string dCLevel;
    public Object correctPosition;
    public Object distortionCorrection;
    public string shadingCorrectionFilter;
    public string f0Shift;
    public string t2Correct;
    public Object postScanFrequency;
    public Object fatsepImageType;
    public Object originalFatSepEcho;
    public Object sequenceMode;
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
      //o.pAPEFlag = 321;
      //o.sequenceMode = "coucou";
    o.pAPEFlag = "off";
    //o.antiAliasingMode = " ";
    o.fOVFilter = "off ";
    o.tuningValue = "";
    o.h1Value = "bla";
    o.gain = "bla";
    //o.flipAngle2 = "bla";
    o.bandWidth = "bla";
    o.h1SpoilValue = "bla";
    o.filterType = "bla";
    o.mTCIrradiatedTime = "bla";
    o.mTCIrradiatedPower = "bla";
    o.mTCOffsetFrequency = "bla";
    o.fatSaturationIrradiatedPower = "bla";
    o.fatSaturationOffsetFrequency = "bla";
    o.flowAxisDirection = "bla";
    o.cardiacGatingCount = "bla";
    o.cardiacGatingSliceOrder = "bla";
    o.truncationArtifactFlag = "bla";
    o.shadingCorrectionFilterFlag = "bla";
    o.shadingCorrectionFilterType = "bla";
    o.shadingCorrectionStrength = "bla";
    o.shadingCorrectionMode = "bla";
    o.fatSaturationPulseKind = "bla";
    //o.fSEThetaCorrectionValue = "bla";
    o.dCLevel = "bla";
    o.correctPosition = "bla";
    o.distortionCorrection = "bla";
    o.shadingCorrectionFilter = "bla";
    o.f0Shift = "bla";
    o.t2Correct = "bla";
    o.postScanFrequency = "bla";
    o.fatsepImageType = "bla";
    o.originalFatSepEcho = "bla";
    o.sequenceMode = "bla";
 
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
