using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace HitachiMedical.Platform.DataAccess.DicomAccess
{
    [Serializable()]
    public class PrivateInsetPS : ISerializable
    {
        public string sopClassUid;
        public string sopInstanceUid;
        public DataObject.BasePresentationState.OutputColorType outputColor;
        public string imageDisplaySettingUid;
        public DataObject.BasePresentationState.DisplayLocation caliperPosition;
        public DataObject.BasePresentationState.OrientationMarkerPositions markerPosition;
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
        public Hashtable appData;
        public object incompatibleAppData;
        protected PrivateInsetPS(SerializationInfo info, StreamingContext context)
        {
            // TODO: SerializationInfoEnumerator GetEnumerator();
            sopClassUid = info.GetString("sopClassUid");
            sopInstanceUid = info.GetString("sopInstanceUid");
            outputColor = (DataObject.BasePresentationState.OutputColorType)info.GetValue("outputColor", typeof(DataObject.BasePresentationState.OutputColorType));
            imageDisplaySettingUid = info.GetString("imageDisplaySettingUid");
            caliperPosition = (DataObject.BasePresentationState.DisplayLocation)info.GetValue("caliperPosition", typeof(DataObject.BasePresentationState.DisplayLocation));
            markerPosition = (DataObject.BasePresentationState.OrientationMarkerPositions)info.GetValue("markerPosition", typeof(DataObject.BasePresentationState.OrientationMarkerPositions));
            expandToDisplay = info.GetBoolean("expandToDisplay");
            windowWidth = info.GetSingle("windowWidth");
            windowLevel = info.GetSingle("windowLevel");
            displayWindowWidth = info.GetInt32("displayWindowWidth");
            displayWindowLevel = info.GetInt32("displayWindowLevel");
            nonLinearWidth = info.GetValue("nonLinearWidth", typeof(object));
            nonLinearLevel = info.GetValue("nonLinearLevel", typeof(object));
            topLeftHandCorner = (System.Drawing.Point)info.GetValue("topLeftHandCorner", typeof(System.Drawing.Point));
            bottomRightHandCorner = (System.Drawing.Point)info.GetValue("topLeftHandCorner", typeof(System.Drawing.Point));
            whiteSuppression = info.GetBoolean("whiteSuppression");
            invertGrayscale = info.GetBoolean("invertGrayscale");
            rotationAngle = info.GetSingle("rotationAngle");
            horizontalFlip = info.GetBoolean("horizontalFlip");
            verticalFlip = info.GetBoolean("verticalFlip");
            horizontalShift = info.GetSingle("horizontalShift");
            verticalShift = info.GetSingle("verticalShift");
            resizePercentage = info.GetSingle("resizePercentage");
            clipRegion = info.GetBoolean("clipRegion");
            gridSpacing = info.GetInt32("gridSpacing");
            crossbarInterval = info.GetInt32("crossbarInterval");
            isCrossScaleEditable = info.GetBoolean("isCrossScaleEditable");
            isGrayScalebarDisplayed = info.GetBoolean("isGrayScalebarDisplayed");
            filterTypes = info.GetValue("filterTypes", typeof(object));
            colorFraction = info.GetValue("colorFraction", typeof(object));
            colorValues = info.GetValue("colorValues", typeof(object));
            imageText = info.GetValue("imageText", typeof(object));
            crossScalePosition = info.GetValue("crossScalePosition", typeof(object));
            resize3dPrecentageEnable = info.GetSingle("resize3dPrecentageEnable");
            isResize3dPrecentageEnable = info.GetBoolean("isResize3dPrecentageEnable");
            var tmp = info.GetValue("appData", typeof(object));
            if (tmp is byte[] v)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream ms = new MemoryStream(v);
                object obj = formatter.Deserialize(ms);
                Debug.Assert(obj is Hashtable);
                appData = (Hashtable)obj;
            }
            else
            {
                Debug.Assert(tmp == null);
                appData = null;
            }
            incompatibleAppData = info.GetValue("incompatibleAppData", typeof(object));
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("sopClassUid", sopClassUid);
            info.AddValue("sopInstanceUid", sopInstanceUid);
            info.AddValue("outputColor", outputColor);
            info.AddValue("imageDisplaySettingUid", imageDisplaySettingUid);
            info.AddValue("caliperPosition", caliperPosition);
            info.AddValue("markerPosition", markerPosition);
            info.AddValue("expandToDisplay", expandToDisplay);
            info.AddValue("windowWidth", windowWidth);
            info.AddValue("windowLevel", windowLevel);
            info.AddValue("displayWindowWidth", displayWindowWidth);
            info.AddValue("displayWindowLevel", displayWindowLevel);
            info.AddValue("nonLinearWidth", nonLinearWidth);
            info.AddValue("nonLinearLevel", nonLinearLevel);
            info.AddValue("topLeftHandCorner", topLeftHandCorner);
            info.AddValue("bottomRightHandCorner", bottomRightHandCorner);
            info.AddValue("whiteSuppression", whiteSuppression);
            info.AddValue("invertGrayscale", invertGrayscale);
            info.AddValue("rotationAngle", rotationAngle);
            info.AddValue("horizontalFlip", horizontalFlip);
            info.AddValue("verticalFlip", verticalFlip);
            info.AddValue("horizontalShift", horizontalShift);
            info.AddValue("verticalShift", verticalShift);
            info.AddValue("resizePercentage", resizePercentage);
            info.AddValue("clipRegion", clipRegion);
            info.AddValue("gridSpacing", gridSpacing);
            info.AddValue("crossbarInterval", crossbarInterval);
            info.AddValue("isCrossScaleEditable", isCrossScaleEditable);
            info.AddValue("isGrayScalebarDisplayed", isGrayScalebarDisplayed);
            info.AddValue("filterTypes", filterTypes);
            info.AddValue("colorFraction", colorFraction);
            info.AddValue("colorValues", colorValues);
            info.AddValue("imageText", imageText);
            info.AddValue("crossScalePosition", crossScalePosition);
            info.AddValue("resize3dPrecentageEnable", resize3dPrecentageEnable);
            info.AddValue("isResize3dPrecentageEnable", isResize3dPrecentageEnable);
            if (appData is Hashtable)
            {
                Debug.Assert(appData != null);
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                formatter.Serialize(ms, appData);
                var bytes = ms.ToArray();
                info.AddValue("appData", bytes);
            }
            else
            {
                Debug.Assert(appData == null);
                info.AddValue("appData", null);
            }
            info.AddValue("incompatibleAppData", incompatibleAppData);
        }
    }
}
