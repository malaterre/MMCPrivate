using HitachiMedical.Platform.DataAccess.DataObject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace HitachiMedical.Platform.DataAccess.DicomAccess
{
    [Serializable()]
    public class DicomImagePrivatePS
    {
        public PrivateMainPS[] privateMainPSList;
        public PrivateInsetPS[] privateInsetPSList;
    }
    [Serializable()]
    public class PrivateAnnotation { }
    [Serializable()]
    public class DicomSeriesCount
    {
        public int seriesCount;
    }
    [Serializable()]
    public class DicomImageCount
    {
        public int imageCount;
    }
    [Serializable()]
    public class PrivateBackgroundImage { }
    [Serializable()]
    public class PrivateInsetPS
    {
        public string sopClassUid;
        public string sopInstanceUid;
        public BasePresentationState.OutputColorType outputColor;
        public string imageDisplaySettingUid;
        public BasePresentationState.DisplayLocation caliperPosition;
        public BasePresentationState.OrientationMarkerPositions markerPosition;
        public bool expandToDisplay;
        public float windowWidth;
        public float windowLevel;
        public int displayWindowWidth;
        public int displayWindowLevel;
        public object nonLinearWidth;
        public object nonLinearLevel;
        public System.Drawing.Point topLeftHandCorner;
        public System.Drawing.Point bottomRightHandCorner;
        public bool whiteSuppression;
        public bool invertGrayscale;
        public float rotationAngle;
        public bool horizontalFlip;
        public bool verticalFlip;
        public float horizontalShift;
        public float verticalShift;
        public float resizePercentage;
        public bool clipRegion;
        public int gridSpacing;
        public int crossbarInterval;
        public bool isCrossScaleEditable;
        public bool isGrayScalebarDisplayed;
        public object filterTypes;
        public object colorFraction;
        public object colorValues;
        public object imageText;
        public object crossScalePosition;
        public float resize3dPrecentageEnable;
        public bool isResize3dPrecentageEnable;
        public byte[] appData;
        public object incompatibleAppData;
    }
    [Serializable()]
    public class PrivateMainPS
    {
        public PrivateAnnotation[] privateAnnotationList;
        public PrivateBackgroundImage[] privateBkImageList;
        public List<string> insetPSUidList;
        public string sopClassUid;
        public string sopInstanceUid;
        public BasePresentationState.OutputColorType outputColor;
        public string imageDisplaySettingUid;
        public BasePresentationState.DisplayLocation caliperPosition;
        public BasePresentationState.OrientationMarkerPositions markerPosition;
        public bool expandToDisplay;
        public float windowWidth;
        public float windowLevel;
        public int displayWindowWidth;
        public int displayWindowLevel;
        public object nonLinearWidth;
        public object nonLinearLevel;
        public System.Drawing.Point topLeftHandCorner;
        public System.Drawing.Point bottomRightHandCorner;
        public bool whiteSuppression;
        public bool invertGrayscale;
        public float rotationAngle;
        public bool horizontalFlip;
        public bool verticalFlip;
        public float horizontalShift;
        public float verticalShift;
        public float resizePercentage;
        public bool clipRegion;
        public int gridSpacing;
        public int crossbarInterval;
        public bool isCrossScaleEditable;
        public bool isGrayScalebarDisplayed;
        public object filterTypes;
        public object colorFraction;
        public object colorValues;
        public object imageText;
        public object crossScalePosition;
        public float resize3dPrecentageEnable;
        public bool isResize3dPrecentageEnable;
        private object /*byte[]*/ appData;
        public void run()
        {
            byte[] data = appData as byte[];
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(data);
            object obj = formatter.Deserialize(ms);
            //Debug.Assert(false);
        }
        [JsonPropertyName("appData")]
        public object MyAppData
        {
            get {
                byte[] data = appData as byte[];
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream ms = new MemoryStream(data);
                object obj = formatter.Deserialize(ms);
                return obj;
            }
        }
        public object incompatibleAppData;
    }

}
