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
                    public Object filterType;
                    public Object mTCIrradiatedTime;
                    public Object mTCIrradiatedPower;
                    public Object mTCOffsetFrequency;
                    public Object fatSaturationIrradiatedPower;
                    public Object fatSaturationOffsetFrequency;
                    public Object flowAxisDirection;
                    public Object cardiacGatingCount;
                    public Object cardiacGatingSliceOrder;
                    public string truncationArtifactFlag;
                    public string shadingCorrectionFilterFlag;
                    public string shadingCorrectionFilterType;
                    public Object shadingCorrectionStrength;
                    public Object shadingCorrectionMode;
                    public Object fatSaturationPulseKind;
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
                }
            }
        }
    }
}