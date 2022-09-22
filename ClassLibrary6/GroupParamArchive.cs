using System;
using System.Collections;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class GroupParamArchive
    {
        private Hashtable parameterTable;
        public GroupParamArchive()
        {
            parameterTable = new Hashtable(11);
        }
    }
}
