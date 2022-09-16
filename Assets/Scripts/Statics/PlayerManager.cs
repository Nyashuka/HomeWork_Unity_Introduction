using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Statics
{
    public class PlayerManager : MonoBehaviour
    {
        void Start()
        {
            int playersCount = Player.playerCount;
        }
    }
}