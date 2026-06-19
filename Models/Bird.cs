using ShelterApi.Interfaces;

namespace ShelterApi.Models;

public class Bird : Animal, IAdoptable
{
    public string Species { get; set; } = "";
    public bool CanTalk { get; set; }

    public Bird() { }
    public Bird(string name, int age, string species, bool canTalk)
        : base(name, age) { Species = species; CanTalk = canTalk; }

    public override string MakeSound() => CanTalk ? "Merhaba!" : "Cik cik!";
    public override string GetInfo() =>
        $"Kuş: {Name} | Tür: {Species} | Konuşur mu: {CanTalk} | Sahiplenildi: {IsAdopted}";
}