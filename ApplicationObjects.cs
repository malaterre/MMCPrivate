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

                    static void Serialize()
                    {
                        // Create a hashtable of values that will eventually be serialized.
                        Hashtable addresses = new Hashtable(6);
                        HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData o = new HitachiMedical.Dream.Cabinet.ApplicationObjects.ImageAppData();
                        //o.pAPEFlag = 321;
                        //o.sequenceMode = "coucou";
                        o.pAPEFlag = new String("off");
                        o.antiAliasingMode = null;
                        o.fOVFilter = new String("off");
                        o.tuningValue = new String("0");
                        o.h1Value = new String("146");
                        o.gain = new String("14");
                        o.flipAngle2 = null;
                        o.bandWidth = new String("15.6");
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
                        o.truncationArtifactFlag = new String("on");
                        o.shadingCorrectionFilterFlag = new String("s-map");
                        o.shadingCorrectionFilterType = new String("off");
                        o.shadingCorrectionStrength = null;
                        o.shadingCorrectionMode = null;
                        o.fatSaturationPulseKind = null;
                        o.fSEThetaCorrectionValue = new float[] { 0.0f, 0.0f, 0.0f };
                        o.dCLevel = new String("off");
                        o.correctPosition = null;
                        o.distortionCorrection = null;
                        o.shadingCorrectionFilter = new String("s-map,off");
                        o.f0Shift = new String("0");
                        o.t2Correct = new String("off");
                        o.postScanFrequency = null;
                        o.fatsepImageType = null;
                        o.originalFatSepEcho = null;
                        o.sequenceMode = null;

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
