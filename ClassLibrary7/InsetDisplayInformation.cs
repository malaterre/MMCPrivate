using System;

namespace HitachiMedical.Dream.Visualization
{
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
}
