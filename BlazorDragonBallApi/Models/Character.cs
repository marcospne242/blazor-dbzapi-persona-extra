public class Character
{
    public string Name { get; set; }
    public string Race { get; set; } 
    public string Image { get; set; } 
    public OriginPlanet OriginPlanet { get; set; }
    public List<Transformation> Transformations { get; set; }
}

public class OriginPlanet
{
    public string Name { get; set; }
}

public class Transformation
{
    public string Name { get; set; }
}