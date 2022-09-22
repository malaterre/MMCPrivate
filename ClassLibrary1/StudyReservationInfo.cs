using System;

namespace HitachiMedical.Dream.Cabinet.ApplicationObjects
{
    [Serializable()]
    public class StudyReservationInfo
    {
        [Serializable()]
        public struct RFType
        {
            public int value__;
        }

        [Serializable()]
        public struct FPOLimitationType
        {
            public int value__;
        }
        public string operatingModeLimitation;
        public FPOLimitationType fpoLimitation;
        public RFType rf;
        public decimal B1PeakLimit { get; set; }
        public decimal B1RMSLimit { get; set; }
        public decimal DBdtPeakLimit { get; set; }
        public decimal DBdtRMSLimit { get; set; }
        public decimal WholeBodySARLimit { get; set; }
        public decimal PartialBodySARLimit { get; set; }
        public decimal HeadSARLimit { get; set; }
        public decimal DBdtLimit { get; set; }
    }

    [Serializable()]
    public class StudyAppData
    {
        public decimal sarLongTerm;
        public object sarLongTermList;
        public string controlledMode;
    }
}