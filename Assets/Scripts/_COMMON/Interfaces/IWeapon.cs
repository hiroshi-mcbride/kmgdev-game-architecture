public interface IWeapon
{
    bool IsAutomatic { get; }
    void Fire();
    void RunFireRateTimer(float _delta);
}
