// https://stackoverflow.com/a/51633221/136285
using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class Dump
{
    [STAThread]
    static void Main() 
    {
        Deserialize();
    }

static void Deserialize() 
{
    // Declare the hashtable reference.
    Hashtable addresses  = null;

    // Open the file containing the data that you want to deserialize.
    FileStream fs = new FileStream("input.dat", FileMode.Open);
    try 
    {
        BinaryFormatter formatter = new BinaryFormatter();

        // Deserialize the hashtable from the file and 
        // assign the reference to the local variable.
        addresses = (Hashtable) formatter.Deserialize(fs);
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

    // To prove that the table deserialized correctly, 
    // display the key/value pairs.
    foreach (DictionaryEntry de in addresses) 
    {
            Object o = de.Value;
        Console.WriteLine("{0} lives at {1}.", de.Key, de.Value);
    }
}
}
