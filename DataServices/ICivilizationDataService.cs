namespace AOEOCivilizationLibrary.DataServices;
public interface ICivilizationDataService
{
    Task<BasicList<CivilizationBasicModel>> GetCivilizationsAsync();
}