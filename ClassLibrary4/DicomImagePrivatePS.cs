using System;

namespace HitachiMedical.Platform.DataAccess.DicomAccess
{
    [Serializable()]
    public class DicomImagePrivatePS
    {
        public PrivateMainPS[] privateMainPSList;
        public PrivateInsetPS[] privateInsetPSList;
    }
    [Serializable()]
    public class PrivateAnnotation { }
    [Serializable()]
    public class DicomSeriesCount
    {
        public int seriesCount;
    }
    [Serializable()]
    public class DicomImageCount
    {
        public int imageCount;
    }
    [Serializable()]
    public class PrivateBackgroundImage { }
}
