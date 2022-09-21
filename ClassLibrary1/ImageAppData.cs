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
                public class StudyAppData { }
                [Serializable()]
                public class StudyReservationInfo
                {
                    [Serializable()]
                    public class RFType { }
                    [Serializable()]
                    public class FPOLimitationType { }
                }


                [Serializable()]
                public class ImageAppData
                {
                    public string pAPEFlag;
                    public object antiAliasingMode;
                    public string fOVFilter;
                    public string tuningValue;
                    public string h1Value;
                    public string gain;
                    public object flipAngle2;
                    public string bandWidth;
                    public object h1SpoilValue;
                    public string filterType;
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
                    public Decimal[] twoDPresatList;
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
                    public Decimal rapidIP;
                    public string rapidIPMode;
                    public float[] magnetDirection;
                }
            }
        }
    }
}