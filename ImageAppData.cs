using System;
using System.IO;
using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Soap;
using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


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
                    public Object flipAngle2; // 02
                    public string bandWidth; // 01
                    public Object h1SpoilValue; // 02
                    public Object filterType; // 02
                    public Object mTCIrradiatedTime; // 02
                    public Object mTCIrradiatedPower; // 02
                    public Object mTCOffsetFrequency; // 02
                    public Object fatSaturationIrradiatedPower; // 02
                    public Object fatSaturationOffsetFrequency; // 02
                    public Object flowAxisDirection; // 02
                    public Object cardiacGatingCount; // 02
                    public Object cardiacGatingSliceOrder; // 02
                    public string truncationArtifactFlag;
                    public string shadingCorrectionFilterFlag;
                    public string shadingCorrectionFilterType;
                    public Object shadingCorrectionStrength;  // 02
                    public Object shadingCorrectionMode;  // 02
                    public Object fatSaturationPulseKind;  // 02
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
                }
            }
        }
    }
}
