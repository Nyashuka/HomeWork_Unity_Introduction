using UnityEngine;

namespace Scripts.Lab1.MemberHiding
{
    public class WarBand : MonoBehaviour
    {
        private void Start()
        {
            Humanoid human = new Humanoid();
            Humanoid enemy = new Enemy();
            Humanoid orc = new Orc();

            human.Yell();
            enemy.Yell();
            orc.Yell();
        }
    }
}
