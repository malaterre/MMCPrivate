using System;
using System.Collections;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class ScanParamArchive
    {
        private Hashtable parameterTable;
        //public Hashtable GetParameterTable() { return parameterTable;  }
        
        public ScanParamArchive()
        {
            parameterTable = new Hashtable(464);
            //parameterTable = new SortedDictionary<string, object>();
        }
    }
}
