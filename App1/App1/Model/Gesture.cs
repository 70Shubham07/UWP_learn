using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    public class Gesture
    {
        public int GestureId { get; set; }
        public string GestureImage { get; set; }
        public string GestureName { get; set; }
        public string GestureFunc { get; set; }

    }

    public class GestureManager
    {
        public static List<Gesture> GetGestures()
        {
            var gestures = new List<Gesture>();

            gestures.Add(new Gesture { GestureId=1, GestureName = "Swipe Up", GestureFunc="", GestureImage= "Assets/-2-x-swipe-down@3x.png" });
            gestures.Add(new Gesture { GestureId=2, GestureName = "Swipe Don", GestureFunc = "", GestureImage = "Assets/-2-x-swipe-down@3x.png" });
            gestures.Add(new Gesture { GestureId=3, GestureName = "Swipe Left", GestureFunc = "", GestureImage = "Assets/-2-x-swipe-down@3x.png" });
            gestures.Add(new Gesture { GestureId=4, GestureName = "Swipe Right", GestureFunc = "", GestureImage = "Assets/-2-x-swipe-down@3x.png" });
            gestures.Add(new Gesture { GestureId=5, GestureName = "Swipe Up Sideways", GestureFunc = "", GestureImage = "Assets/-2-x-swipe-down@3x.png" });
            gestures.Add(new Gesture { GestureId=6, GestureName = "Swipe Down Sideways", GestureFunc = "", GestureImage = "Assets/-2-x-swipe-down@3x.png" });
            gestures.Add(new Gesture { GestureId=7, GestureName = "Swipe Left Sideways", GestureFunc = "", GestureImage = "Assets/-2-x-swipe-down@3x.png" });
            gestures.Add(new Gesture { GestureId=8, GestureName = "Swipe Right Sideways", GestureFunc = "", GestureImage = "Assets/-2-x-swipe-down@3x.png" });
            gestures.Add(new Gesture { GestureId=9, GestureName = "Pinch", GestureFunc = "", GestureImage = "Assets/-2-x-swipe-down@3x.png" });
            gestures.Add(new Gesture { GestureId=10, GestureName = "Grab", GestureFunc = "", GestureImage = "Assets/-2-x-swipe-down@3x.png" });
            return gestures;
        }
    }
}
