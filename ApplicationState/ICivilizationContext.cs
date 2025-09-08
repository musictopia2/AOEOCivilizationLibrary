namespace AOEOCivilizationLibrary.ApplicationState;
public interface ICivilizationContext
{
    CivilizationBasicModel CurrentCivilization { get; set; }
    string CivAbb
    {
        get
        {
            return CurrentCivilization.Abbreviation;
        }
    }
    string CivFullName
    {
        get
        {
            return CurrentCivilization.FullName;
        }
    }
    void PopulateCivilization(string civAbb, string fullName)
    {
        CurrentCivilization = new(civAbb, fullName);
    }
    async Task PopulateCivilizationAsync(string civAbb, ICivilizationDataService service)
    {
        var list = await service.GetCivilizationsAsync();
        var civ = list.FirstOrDefault(x => string.Equals(x.Abbreviation, civAbb, StringComparison.OrdinalIgnoreCase)) ?? throw new KeyNotFoundException($"Civilization abbreviation '{civAbb}' not found.");
        CurrentCivilization = civ;
    }
    void Reset() => CurrentCivilization = new("", "");
}