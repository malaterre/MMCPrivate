using System;

namespace HitachiMedical.Platform.DataAccess.DicomAccess
{
    [Serializable()]
    public class DicomImagePrivatePS
    {
        public PrivateMainPS[] privateMainPSList;
        public PrivateInsetPS[] privateInsetPSList;
    }
}
