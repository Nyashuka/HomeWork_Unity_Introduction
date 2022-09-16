using UnityEngine;

namespace Scripts.CreatingProperties
{
    public class Game : MonoBehaviour
    {
        private void Start()
        {
            Player myPlayer = new Player();

            myPlayer.Experience = 5;

            Debug.Log("Player has " + myPlayer.Experience + " points of exp.");
        }
    }
}