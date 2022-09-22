using System;

namespace HitachiMedical
{
    namespace Dream
    {
        namespace Cabinet
        {
            namespace ApplicationObjects
            {
                [Serializable()]
                public class ImageAppData
                {
                    public string pAPEFlag;
                    public string antiAliasingMode;
                    public string fOVFilter;
                    public string tuningValue;
                    public string h1Value;
                    public string gain;
                    public object flipAngle2;
                    public string bandWidth;
                    public object h1SpoilValue;
                    public object /*string*/ filterType;
                    public object mTCIrradiatedTime;
                    public object mTCIrradiatedPower;
                    public object mTCOffsetFrequency;
                    public string fatSaturationIrradiatedPower;
                    public string fatSaturationOffsetFrequency;
                    public object flowAxisDirection;
                    public object cardiacGatingCount;
                    public object cardiacGatingSliceOrder;
                    public string truncationArtifactFlag;
                    public string shadingCorrectionFilterFlag;
                    public string shadingCorrectionFilterType;
                    public object shadingCorrectionStrength;
                    public object shadingCorrectionMode;
                    public string fatSaturationPulseKind;
                    public float[] fSEThetaCorrectionValue;
                    public string dCLevel;
                    public object correctPosition;
                    public object distortionCorrection;
                    public string shadingCorrectionFilter;
                    public string f0Shift;
                    public string t2Correct;
                    public object postScanFrequency;
                    public object fatsepImageType;
                    public object originalFatSepEcho;
                    public object sequenceMode;
                    public decimal[] twoDPresatList;
                    public object reconType;
                    public object bsiProcess;
                    public object teEquivalent;
                    public object excitationPulse;
                    public object minRFA;
                    public object centerRFA;
                    public object maxRFA;
                    public object gain2;
                    public object gainBoundaryPhase;
                    public object gainBoundarySlice;
                    public string actualTablePositionX;
                    public string actualTablePositionY;
                    public object sarShortTerm;
                    public object sarMiddleTerm;
                    public object controlledMode;
                    public string contrastPulse;
                    public object flowReduction;
                    public object flowReductionLevel;
                    public object verse;
                    public object lowSAR;
                    public string rfShimMode;
                    public float[] transmitAmplifier;
                    public float[] transmitPhase;
                    public object fatSepStrength;
                    public string rapidMode;
                    public object asl;
                    public string vividImage;
                    public string noiseCorrectType;
                    public object numSpectralBins;
                    public object binNumber;
                    public object mars;
                    public string b1RMS;
                    public object b1Peak;
                    public object dbdtRMS;
                    public object dbdtPeak;
                    public object slewPercentage;
                    public decimal rapidIP;
                    public string rapidIPMode;
                    public float[] magnetDirection;
                }


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
        }
    }
}