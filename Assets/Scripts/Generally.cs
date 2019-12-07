using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    static class Generally
    {
        public static float speed = 0.1f;
        public static float deltaSpeed = 0.01f;
        public static float ObjectSpeed = 0.1f;
        public static Vector2 ObjectVecor = new Vector2(-5, 0);
        public static float heigth = Camera.main.orthographicSize * 2f;
        public static float width = heigth * Screen.width / Screen.height;
    }
}
