using UnityEngine;

namespace Scripts.Statics
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
