using UnityEngine;

namespace Scripts.Lab1.CreatingProperties
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