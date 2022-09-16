namespace Scripts.Lab2.Interfaces
{
    public interface IKillable
    {
        void Kill();
    }

    public interface IDamageable<T>
    {
        void Damage(T damageTaken);
    }
}