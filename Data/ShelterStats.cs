namespace ShelterApi.Data;

public sealed class ShelterStats
{
    private static ShelterStats? _instance;
    private static readonly object _lock = new();

    public int TotalAdoptions { get; private set; }
    public int TotalArrivals { get; private set; }

    private ShelterStats() { }

    public static ShelterStats Instance
    {
        get {
            if (_instance == null) {
                lock (_lock) {
                    _instance ??= new ShelterStats();
                }
            }
            return _instance;
        }
    }

    public void RecordAdoption() => TotalAdoptions++;
    public void RecordArrival() => TotalArrivals++;
}