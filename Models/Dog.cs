using ShelterApi.Interfaces;

namespace ShelterApi.Models;
//Ingheritance ve Polymorphism burada gerçekleşir. Dog sınıfı Animal sınıfından türetilir ve IAdoptable arayüzünü uygular.
public class Dog : Animal, IAdoptable
{
    public string Breed { get; set; } = "";

    public Dog() { }
    public Dog(string name, int age, string breed)
        : base(name, age) { Breed = breed; }

    public override string MakeSound() => "Hav hav!";
    public override string GetInfo() =>
        $"Köpek: {Name} | Yaş: {Age} | Irk: {Breed} | Sahiplenildi: {IsAdopted}";
}