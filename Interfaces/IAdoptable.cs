namespace ShelterApi.Interfaces;

public interface IAdoptable
{
    bool IsAdopted { get; }
    void Adopt();
}