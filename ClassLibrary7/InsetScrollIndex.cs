using System;
using System.Collections;

namespace HitachiMedical.Dream.Visualization
{
    [Serializable()]
    public class InsetScrollIndex
    {
        public ArrayList insetIndexList;
    }
    [Serializable()]
    public class InsetDisplayInformation
    {
        public InsetImageLocationType insetImagePosition;
        public InsetImageSizeType insetImageSize;
        public bool isVisible;
        public bool isPresatRegionVisible;
        public int displayedInsetImageNumber;
        public bool isSelectiveIRRegionVisible;
    }
    [Serializable()]
    public struct InsetImageSizeType
    {
        public int value__;
    }
    [Serializable()]
    public struct InsetImageLocationType
    {
        public int value__;
    }

}
