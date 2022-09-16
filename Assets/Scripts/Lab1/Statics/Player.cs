using UnityEngine;

namespace Scripts.Lab1.Statics
{
    public class Player : MonoBehaviour
    { 
        public static int playerCount = 0;

        void Start()
        {
            playerCount++;
        }
    }
}
