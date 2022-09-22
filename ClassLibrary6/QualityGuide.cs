using System;
using System.Collections;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class QualityGuide
    {
        public decimal iScanTime;
        public decimal iCNR;
        public decimal iSNR;
        public decimal iSAR;
        public decimal iSARLimit;
        public decimal iSARLimit2;
        public decimal iB1RMS;
        public decimal idBdt;
        public decimal idBdtLimit;
        public Resolution[] iResolutionInfo;
        public decimal iB1Peak;
        public decimal iDBdtPeak;
        public decimal iDBdtRMS;
        public decimal iSlewPercentage;
    }
}
