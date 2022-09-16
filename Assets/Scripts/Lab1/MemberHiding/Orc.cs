using UnityEngine;

namespace Scripts.Lab1.MemberHiding
{
    public class Orc : Enemy
    {
        new public void Yell()
        {
            Debug.Log("Orc version of the Yell() method");
        }
    }
}