using UnityEngine;

namespace Scripts.Lab2.Generics
{
    public class GenericClassExample : MonoBehaviour
    {
        private void Start()
        {
            GenericClass<int> myClass = new GenericClass<int>();

            myClass.UpdateItem(5);
        }
    }
}
