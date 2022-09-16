namespace Scripts.Lab2.Generics
{
    public class GenericClass<T>
    {
        T item;

        public void UpdateItem(T newItem)
        {
            item = newItem;
        }
    }
}