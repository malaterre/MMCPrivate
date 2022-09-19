using System;
using System.IO;
using System.Runtime.Serialization;
using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace HitachiMedical
{
    namespace Platform
    {
        namespace DataAccess
        {
            namespace DicomAccess
            {
                [Serializable()]
                public class DicomImagePrivatePS
                {
                    public string pAPEFlag;
                }
            }
        }
    }
}
