using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace HitachiMedical.Dream.Cabinet.ApplicationObjects
{
    [Serializable()]
    public class ImageAppDataOld
    {
        public string pAPEFlag;
        public string antiAliasingMode;
        public string fOVFilter;
        public string tuningValue;
        public string h1Value;
        public string gain;
        public object flipAngle2;
        public string bandWidth;
        public object h1SpoilValue;
        public object /*string*/ filterType;
        public object mTCIrradiatedTime;
        public object mTCIrradiatedPower;
        public object mTCOffsetFrequency;
        public string fatSaturationIrradiatedPower;
        public string fatSaturationOffsetFrequency;
        public object flowAxisDirection;
        public object cardiacGatingCount;
        public object cardiacGatingSliceOrder;
        public string truncationArtifactFlag;
        public string shadingCorrectionFilterFlag;
        public string shadingCorrectionFilterType;
        public object shadingCorrectionStrength;
        public object shadingCorrectionMode;
        public string fatSaturationPulseKind;
        public float[] fSEThetaCorrectionValue;
        public string dCLevel;
        public object correctPosition;
        public object distortionCorrection;
        public string shadingCorrectionFilter;
        public string f0Shift;
        public string t2Correct;
        public object postScanFrequency;
        public object fatsepImageType;
        public object originalFatSepEcho;
        public object sequenceMode;
        public decimal[] twoDPresatList;
        public object reconType;
        public object bsiProcess;
        public object teEquivalent;
        public object excitationPulse;
        public object minRFA;
        public object centerRFA;
        public object maxRFA;
        public object gain2;
        public object gainBoundaryPhase;
        public object gainBoundarySlice;
        public string actualTablePositionX;
        public string actualTablePositionY;
        public string contrastPulse;
        public object flowReduction;
        public object flowReductionLevel;
    }

    [Serializable()]
    public class ImageAppData : ISerializable
    {
        public string pAPEFlag;
        public string antiAliasingMode;
        public string fOVFilter;
        public string tuningValue;
        public string h1Value;
        public string gain;
        public object flipAngle2;
        public string bandWidth;
        public object h1SpoilValue;
        public object /*string*/ filterType;
        public object mTCIrradiatedTime;
        public object mTCIrradiatedPower;
        public object mTCOffsetFrequency;
        public string fatSaturationIrradiatedPower;
        public string fatSaturationOffsetFrequency;
        public object flowAxisDirection;
        public object cardiacGatingCount;
        public object cardiacGatingSliceOrder;
        public string truncationArtifactFlag;
        public string shadingCorrectionFilterFlag;
        public string shadingCorrectionFilterType;
        public object shadingCorrectionStrength;
        public object shadingCorrectionMode;
        public string fatSaturationPulseKind;
        public float[] fSEThetaCorrectionValue;
        public string dCLevel;
        public object correctPosition;
        public object distortionCorrection;
        public string shadingCorrectionFilter;
        public string f0Shift;
        public string t2Correct;
        public object postScanFrequency;
        public object fatsepImageType;
        public object originalFatSepEcho;
        public object sequenceMode;
        public decimal[] twoDPresatList;
        public object reconType;
        public object bsiProcess;
        public object teEquivalent;
        public object excitationPulse;
        public object minRFA;
        public object centerRFA;
        public object maxRFA;
        public object gain2;
        public object gainBoundaryPhase;
        public object gainBoundarySlice;
        public string actualTablePositionX;
        public string actualTablePositionY;
        public object sarShortTerm;
        public object sarMiddleTerm;
        public object controlledMode;
        public string contrastPulse;
        public object flowReduction;
        public object flowReductionLevel;
        public object verse;
        public object lowSAR;
        public string rfShimMode;
        public float[] transmitAmplifier;
        public float[] transmitPhase;
        public object fatSepStrength;
        public string rapidMode;
        public object asl;
        public string vividImage;
        public string noiseCorrectType;
        public object numSpectralBins;
        public object binNumber;
        public object mars;
        public string b1RMS;
        public object b1Peak;
        public object dbdtRMS;
        public object dbdtPeak;
        public object slewPercentage;
        public decimal rapidIP;
        public string rapidIPMode;
        public float[] magnetDirection;

        // versioning:
        private int memberCount;
        protected ImageAppData(SerializationInfo info, StreamingContext context)
        {
            memberCount = info.MemberCount;
            Debug.Assert(memberCount == 51 || memberCount == 75);

            foreach (SerializationEntry entry in info)
            {
                string name = entry.Name;
                object value = entry.Value;
                Type type = this.GetType();
                PropertyInfo[] dbg1 = type.GetProperties();
                MemberInfo[] dbg2 = type.GetMembers();
                PropertyInfo propInfo = this.GetType().GetProperty(name);
                MemberInfo[] propInfo2 = this.GetType().GetMember(name);
                Debug.Assert(propInfo2.Length == 1);
                MemberInfo memberInfo = propInfo2[0];
                Debug.Assert(memberInfo.MemberType == MemberTypes.Field);
                FieldInfo fieldInfo = (FieldInfo)memberInfo;
                //Debug.Assert(fieldInfo.FieldType.Equals(entry.ObjectType));
                ((FieldInfo)memberInfo).SetValue(this, value);
            }

        }
        List<string> GetFieldNames()
        {
            Debug.Assert(memberCount == 51 || memberCount == 75);
            if (memberCount == 51)
            {
                Type oldType = typeof(ImageAppDataOld);
                MemberInfo[] oldMembers = oldType.GetMembers();
                var oldNames = oldMembers.Where(member => member.MemberType == MemberTypes.Field).
                    Select(member => member.Name);
                return oldNames.ToList();
            }
            else if (memberCount == 75)
            {
                Type oldType = typeof(ImageAppData);
                MemberInfo[] oldMembers = oldType.GetMembers();
                var oldNames = oldMembers.Where(member => member.MemberType == MemberTypes.Field).
                    Select(member => member.Name);
                return oldNames.ToList();
            }
            throw new NotImplementedException();
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            List<string> fieldNames = GetFieldNames();

            Type type = this.GetType();
            {
                MemberInfo[] members = type.GetMembers();
                foreach (var member in members)
                {
                    if (member.MemberType == MemberTypes.Field)
                    {
                        FieldInfo field = ((FieldInfo)member);
                        string name = member.Name;
                        if (fieldNames.Contains(name))
                        {
                            Debug.Assert(!name.Equals("memberCount"));
                            object value = field.GetValue(this);
                            info.AddValue(name, value);
                        }
                    }
                }
            }
        }
    }

    // https://learn.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter.binder
    sealed public class ImageAppDataDeserializationBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            Type typeToDeserialize = Type.GetType(String.Format("{0}, {1}",
                typeName, assemblyName));

            Console.WriteLine(String.Format("Input is {0}, {1}", typeName, assemblyName));
            Console.WriteLine(String.Format("Output is {0}", typeToDeserialize.AssemblyQualifiedName));

            return typeToDeserialize;
        }
    }
}