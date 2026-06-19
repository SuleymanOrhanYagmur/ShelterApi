using ShelterApi.Interfaces;

namespace ShelterApi.Models;

public class Cat : Animal, IAdoptable
{
    public bool IsIndoor { get; set; }

    public Cat() { }
    public Cat(string name, int age, bool isIndoor)
        : base(name, age) { IsIndoor = isIndoor; }

    public override string MakeSound() => "Miyav!";
    public override string GetInfo() =>
        $"Kedi: {Name} | Yaş: {Age} | Ev kedisi: {IsIndoor} | Sahiplenildi: {IsAdopted}";
}