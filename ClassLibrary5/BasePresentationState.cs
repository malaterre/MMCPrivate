using System;

namespace HitachiMedical.Platform.DataAccess.DataObject
{
    [Serializable()]
    public class BasePresentationState
    {
        [Serializable()]
        public struct OutputColorType
        {
            public int value__;
        }

        [Serializable()]
        public struct DisplayLocation
        {
            public int value__;
        }
        [Serializable()]
        public struct OrientationMarkerPositions
        {
            public int value__;
        }
    }

}
