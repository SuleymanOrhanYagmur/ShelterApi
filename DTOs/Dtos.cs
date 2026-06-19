namespace ShelterApi.DTOs;

public class CreateDogDto
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Breed { get; set; } = "";
}

public class CreateCatDto
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public bool IsIndoor { get; set; }
}

public class CreateBirdDto
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Species { get; set; } = "";
    public bool CanTalk { get; set; }
}