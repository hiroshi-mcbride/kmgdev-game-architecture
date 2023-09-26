public interface IWeapon
{
    int Ammo { get; }
    float Damage { get; }
    float FireRate { get; }
    void Fire(float _delta);
}
