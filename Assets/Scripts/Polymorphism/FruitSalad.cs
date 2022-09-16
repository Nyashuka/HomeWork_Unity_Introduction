using UnityEngine;

namespace Scripts.Polymorphism
{
    public class FruitSalad : MonoBehaviour
    {
        private void Start()
        {
            Fruit myFruit = new Apple();

            myFruit.SayHello();
            myFruit.Chop();

            Apple myApple = (Apple)myFruit;

            myApple.SayHello();
            myApple.Chop();
        }
    }
}