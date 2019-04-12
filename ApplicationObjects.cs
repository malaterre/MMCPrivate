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
    public int foo {get; set;}
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
