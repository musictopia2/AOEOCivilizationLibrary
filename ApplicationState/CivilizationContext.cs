namespace AOEOCivilizationLibrary.ApplicationState;
public class CivilizationContext : ICivilizationContext
{
    public CivilizationBasicModel CurrentCivilization { get; set; } = new("", "");
}