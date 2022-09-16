using UnityEngine;

namespace Scripts.Lab2.Interfaces
{
    public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
    {
        public void Kill()
        {
            Debug.Log(this.name + " was kill!");
        }


        public void Damage(float damageTaken)
        {
            Debug.Log(damageTaken + " was taken!");
        }
    }
}