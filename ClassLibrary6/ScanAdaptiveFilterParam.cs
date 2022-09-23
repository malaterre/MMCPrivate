using System;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class ScanAdaptiveFilterParam {
        public decimal m_NoiseLevel;
        public decimal m_Factor;
        public decimal m_MatrixForDirectionDetection;
        public decimal m_MatrixForSmoothingFilter;
        public decimal m_EdgeFactor;
        public double m_Level;
        public double m_Noise;
        public double m_Lambda;
        public double m_Kappa;
    }
}
