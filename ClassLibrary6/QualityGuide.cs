using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class QualityGuideOld
    {
        public decimal iScanTime;
        public decimal iCNR;
        public decimal iSNR;
        public decimal iSAR;
        public decimal iSARLimit;
        public decimal iSARLimit2;
        public decimal iB1RMS;
        public decimal idBdt;
        public decimal idBdtLimit;
        public Resolution[] iResolutionInfo;
    }

    [Serializable()]
    public class QualityGuide : ISerializable
    {
        public decimal iScanTime;
        public decimal iCNR;
        public decimal iSNR;
        public decimal iSAR;
        public decimal iSARLimit;
        public decimal iSARLimit2;
        public decimal iB1RMS;
        public decimal idBdt;
        public decimal idBdtLimit;
        public Resolution[] iResolutionInfo;
        public decimal iB1Peak;
        public decimal iDBdtPeak;
        public decimal iDBdtRMS;
        public decimal iSlewPercentage;

        // versioning:
        private int memberCount;
        protected QualityGuide(SerializationInfo info, StreamingContext context)
        {
            memberCount = info.MemberCount;
            Debug.Assert(memberCount == 10 || memberCount == 14);
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
                ((FieldInfo)memberInfo).SetValue(this, value);
            }


        }
        List<string> GetFieldNames()
        {
            Debug.Assert(memberCount == 10 || memberCount == 14);
            if (memberCount == 10)
            {
                Type oldType = typeof(QualityGuideOld);
                MemberInfo[] oldMembers = oldType.GetMembers();
                var oldNames = oldMembers.Where(member => member.MemberType == MemberTypes.Field).
                    Select(member => member.Name);
                return oldNames.ToList();
            }
            else if (memberCount == 14)
            {
                Type oldType = typeof(QualityGuide);
                MemberInfo[] oldMembers = oldType.GetMembers();
                var oldNames = oldMembers.Where(member => member.MemberType == MemberTypes.Field).
                    Select(member => member.Name);
                return oldNames.ToList();
            }
            throw new NotImplementedException();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
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
}
