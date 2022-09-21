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
                    public Object antiAliasingMode;
                    public string fOVFilter;
                    public string tuningValue;
                    public string h1Value;
                    public string gain;
                    public Object flipAngle2;
                    public string bandWidth;
                    public Object h1SpoilValue;
                    public string filterType;
                    public Object mTCIrradiatedTime;
                    public Object mTCIrradiatedPower;
                    public Object mTCOffsetFrequency;
                    public string fatSaturationIrradiatedPower;
                    public string fatSaturationOffsetFrequency;
                    public Object flowAxisDirection;
                    public Object cardiacGatingCount;
                    public Object cardiacGatingSliceOrder;
                    public string truncationArtifactFlag;
                    public string shadingCorrectionFilterFlag;
                    public string shadingCorrectionFilterType;
                    public Object shadingCorrectionStrength;
                    public Object shadingCorrectionMode;
                    public string fatSaturationPulseKind;
                    public float[] fSEThetaCorrectionValue;
                    public string dCLevel;
                    public Object correctPosition;
                    public Object distortionCorrection;
                    public string shadingCorrectionFilter;
                    public string f0Shift;
                    public string t2Correct;
                    public Object postScanFrequency;
                    public Object fatsepImageType;
                    public Object originalFatSepEcho;
                    public Object sequenceMode;
                    public Decimal[] twoDPresatList;
                    public Object reconType;
                    public Object bsiProcess;
                    public Object teEquivalent;
                    public Object excitationPulse;
                    public Object minRFA;
                    public Object centerRFA;
                    public Object maxRFA;
                    public Object gain2;
                    public Object gainBoundaryPhase;
                    public Object gainBoundarySlice;
                    public string actualTablePositionX;
                    public string actualTablePositionY;
                    public Object contrastPulse;
                    public Object flowReduction;
                    public Object flowReductionLevel;
                }
            }
        }
    }
}