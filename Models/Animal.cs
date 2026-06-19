namespace ShelterApi.Models;
//Abstract class olarak tanımlanır çünkü doğrudan örneği oluşturulmaz, sadece türetilir.
//Abstraction ve Encaapsulation burada gerçekleşti
public abstract class Animal
{
    public int Id { get; set; }
    public string Name { get; private set; } = "";
    public int Age { get; private set; }
    public bool IsAdopted { get; private set; } = false;
    public DateTime ArrivedAt { get; private set; } = DateTime.UtcNow;

    protected Animal() { }

    protected Animal(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("İsim boş olamaz.");
        Name = name;
        Age = age;
    }

    public void Adopt()
    {
        if (IsAdopted) throw new InvalidOperationException("Hayvan zaten sahiplendirilmiş.");
        IsAdopted = true;
    }

    public abstract string MakeSound();
    public abstract string GetInfo();
}