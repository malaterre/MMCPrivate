using System;
using System.Collections;

namespace HitachiMedical.Dream.ScanInterface
{
    [Serializable()]
    public class GroupParamArchive
    {
        private Hashtable parameterTable;
        public GroupParamArchive()
        {
            parameterTable = new Hashtable(11);
        }
    }
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
    [Serializable()]
    public class AslPerfusionPosition { }
    [Serializable()]
    public class SelectiveIRPosition { }
    [Serializable()]
    public class ShimmingPosition { }
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
    [Serializable()]
    public class PresatPlane
    {

        public Position iPos;
        public decimal iPresatThickness;
        public decimal iPresatIntermittent;
    }
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
    [Serializable()]
    public class Position
    {
        public decimal iColumnFH;
        public decimal iColumnAP;
        public decimal iColumnRL;
        public decimal iRowFH;
        public decimal iRowAP;
        public decimal iRowRL;
        public decimal iPositionFH;
        public decimal iPositionAP;
        public decimal iPositionRL;
    }
    [Serializable()]
    public class Resolution
    {
        public decimal iResolutionAP;
        public decimal iResolutionRL;
        public decimal iResolutionFH;
    }

}
