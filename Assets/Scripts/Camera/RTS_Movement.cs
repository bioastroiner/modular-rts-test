using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MyCamera
{
    public class RTS_Movement : MonoBehaviour
    {
        public float xspeed;
        public float zspeed;

        public float zoom_speed = 3;

        public int hoverSidePad = 30;

        public Transform objectTransform;

        private void Awake()
        {
            
        }

        private void Update()
        {
            hoverMovement();

            Vector2 scroll = Input.mouseScrollDelta;
            Debug.Log(scroll);
        }

        private void hoverMovement()
        {
            float x = 0;
            float y = 0;

            Rect upRect = new Rect(0, 0, Camera.main.pixelWidth, Camera.main.pixelHeight);

            if (Utils.MathUtils.IsWithinBox(Input.mousePosition.x, Input.mousePosition.y, new Rect(0, 0, Camera.main.pixelWidth, hoverSidePad)))
            {
                Debug.Log("hello");
                y = -1 * zspeed;
            }
            if (Utils.MathUtils.IsWithinBox(Input.mousePosition.x, Input.mousePosition.y, new Rect(0, 0, hoverSidePad, Camera.main.pixelHeight)))
            {
                x = 1 * xspeed;
            }
            if (Utils.MathUtils.IsWithinBox(Input.mousePosition.x, Input.mousePosition.y, new Rect(0, Camera.main.pixelHeight - hoverSidePad, Camera.main.pixelWidth, hoverSidePad)))
            {
                y = 1 * zspeed;
            }
            if (Utils.MathUtils.IsWithinBox(Input.mousePosition.x, Input.mousePosition.y, new Rect(Camera.main.pixelWidth - hoverSidePad, 0, hoverSidePad, Camera.main.pixelHeight)))
            {
                x = -1 * xspeed;
            }

            objectTransform.Translate(y, 0, x);
        }

        private void OnGUI()
        {
            GUI.Box(new Rect(0, 0, Camera.main.pixelWidth, 10),"");
            GUI.Box(new Rect(0, 0, 10, Camera.main.pixelHeight), "");

            GUI.Box(new Rect(0, Camera.main.pixelHeight - 10, Camera.main.pixelWidth, 10), "");
            GUI.Box(new Rect(Camera.main.pixelWidth - 10, 0, 10, Camera.main.pixelHeight), "");

        }
    }
}
