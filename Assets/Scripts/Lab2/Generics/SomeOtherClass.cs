using UnityEngine;

namespace Scripts.Lab2.Generics
{
    public class SomeOtherClass : MonoBehaviour
    {
        void Start()
        {
            SomeClass myClass = new SomeClass();

            myClass.GenericMethod<int>(5);
        }
    }
}