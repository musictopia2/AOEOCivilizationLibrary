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
    void Reset() => CurrentCivilization = new("", "");
}