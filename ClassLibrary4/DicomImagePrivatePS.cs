using System;

namespace HitachiMedical.Platform.DataAccess.DicomAccess
{
    [Serializable()]
    public class DicomImagePrivatePS
    {
        public Object privateMainPSList;
        public Object privateInsetPSList;
    }
    [Serializable()]
    public class PrivateAnnotation { }
    [Serializable()]
    public class PrivateBackgroundImage { }
    [Serializable()]
    public class PrivateInsetPS { }
    [Serializable()]
    public class PrivateMainPS { }

}
