namespace AOEOCivilizationLibrary.DataServices;
public interface ICivilizationDataService
{
    public static bool IncludeIndians { get; set; }
    Task<BasicList<CivilizationBasicModel>> GetCivilizationsAsync();
}