using UnityEngine;

namespace Scripts.Lab2.Overriding
{
    public class FruitSalad : MonoBehaviour
    {
        private void Start()
        {
            Apple myApple = new Apple();

            myApple.SayHello();
            myApple.Chop();

            Fruit myFruit = new Apple();
            myFruit.SayHello();
            myFruit.Chop();
        }
    }
}