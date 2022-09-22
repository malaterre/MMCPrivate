using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class ScanParamArchive
    {
        private Hashtable parameterTable;
        //public Hashtable GetParameterTable() { return parameterTable;  }

        [JsonPropertyName("parameterTable")]
        public SortedDictionary<string, object> MyHashtableSorted
        {
            get => new SortedDictionary<string, object>(
                         parameterTable
                         .Cast<DictionaryEntry>()
                         .ToDictionary(x => (string)x.Key, x => x.Value)
                    );
        }

        public ScanParamArchive()
        {
            parameterTable = new Hashtable(464);
        }
    }
}
