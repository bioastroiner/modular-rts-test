using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    public class MathUtils
    {
        public static bool IsWithinBox(float x,float y,Rect rect)
        {
            Vector2 vector = new Vector2(x, y);

            float x1 = rect.position.x;
            float y1 = rect.position.y;

            float x2 = x1 + rect.width;
            float y2 = y1 + rect.height;

            return (x < x2) && (x > x1) && (y < y2) && (y > y1);
        }
    }
}
