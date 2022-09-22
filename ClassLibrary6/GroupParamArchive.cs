using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class GroupParamArchive
    {
        // must be public so that json serializer see it:
        private Hashtable parameterTable;

        [JsonPropertyName("parameterTable")]
        public SortedDictionary<string, object> MyHashtableSorted
        {
            get => new SortedDictionary<string, object>(
                         parameterTable
                         .Cast<DictionaryEntry>()
                         .ToDictionary(x => (string)x.Key, x => x.Value)
                    );
        }
        public GroupParamArchive()
        {
            parameterTable = new Hashtable(11);
        }
    }
}
