using System;
using System.Collections;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class ScanParamArchive
    {

        public Hashtable parameterTable;
    }
    [Serializable()]
    public class GroupParamArchive
    {
        public Hashtable parameterTable;
    }
    [Serializable()]
    public class AslPerfusionPosition { }
    [Serializable()]
    public class SelectiveIRPosition { }
    [Serializable()]
    public class ShimmingPosition { }
    [Serializable()]
    public class QualityGuide
    {
        public Decimal iScanTime;
        public Decimal iCNR;
        public Decimal iSNR;
        public Decimal iSAR;
        public Decimal iSARLimit;
        public Decimal iSARLimit2;
        public Decimal iB1RMS;
        public Decimal idBdt;
        public Decimal idBdtLimit;
        public Resolution[] iResolutionInfo;
        public Decimal iB1Peak;
        public Decimal iDBdtPeak;
        public Decimal iDBdtRMS;
        public Decimal iSlewPercentage;
    }
    [Serializable()]
    public class PresatPlane
    {

        public Position iPos;
        public Decimal iPresatThickness;
        public Decimal iPresatIntermittent;
    }
    [Serializable()]
    public class ScanPosition
    {
        public string iPlaneName;
        public Position iPos;
        public Decimal iFOV;
        public string iPhaseDirection;
        public Decimal iRectangularRatio;
        public Decimal iAntiAliasingRatio;
        public Decimal iNumberOfSlices;
        public string iSliceDirection;
        public Decimal iSliceInterval;
        public Decimal iSliceThickness;
    }
    [Serializable()]
    public class Position
    {
        public Decimal iColumnFH;
        public Decimal iColumnAP;
        public Decimal iColumnRL;
        public Decimal iRowFH;
        public Decimal iRowAP;
        public Decimal iRowRL;
        public Decimal iPositionFH;
        public Decimal iPositionAP;
        public Decimal iPositionRL;
    }
    [Serializable()]
    public class Resolution
    {
        public Decimal iResolutionAP;
        public Decimal iResolutionRL;
        public Decimal iResolutionFH;
    }

}
