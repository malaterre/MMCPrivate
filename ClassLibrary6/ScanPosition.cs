using System;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class ScanPosition
    {
        public string iPlaneName;
        public Position iPos;
        public decimal iFOV;
        public string iPhaseDirection;
        public decimal iRectangularRatio;
        public decimal iAntiAliasingRatio;
        public decimal iNumberOfSlices;
        public string iSliceDirection;
        public decimal iSliceInterval;
        public decimal iSliceThickness;
    }
}
