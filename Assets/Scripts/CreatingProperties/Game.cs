using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        Player myPlayer = new Player();

        myPlayer.Experience = 5;

        Debug.Log("Player has " + myPlayer.Experience + " points of exp.");
    }
}