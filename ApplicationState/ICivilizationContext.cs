namespace AOEOCivilizationLibrary.ApplicationState;
public interface ICivilizationContext
{
    CivilizationBasicModel? CurrentCivilization { get; set; }
    string CivAbb
    {
        get
        {
            if (CurrentCivilization is null)
            {
                return "";
            }
            return CurrentCivilization.Abbreviation;
        }
    }
    string CivFullName
    {
        get
        {
            if (CurrentCivilization is null)
            {
                return "";
            }
            return CurrentCivilization.FullName;
        }
    }
    void PopulateCivilization(string civAbb, string fullName)
    {
        CurrentCivilization = new(civAbb, fullName);
    }
}