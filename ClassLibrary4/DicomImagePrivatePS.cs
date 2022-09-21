using HitachiMedical.Platform.DataAccess.DataObject;
using System;
using System.Collections.Generic;

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
    public class PrivateBackgroundImage { }
    [Serializable()]
    public class PrivateInsetPS { }
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
        public byte[] appData;
    }

}
