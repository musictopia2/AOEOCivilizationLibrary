namespace AOEOCivilizationLibrary.ViewModels;
public class ChooseCivViewModel(ICivilizationDataService dataService) : IChooseCivViewModel
{
    public BasicList<CivilizationBasicModel> Civilizations { get; set; } = [];
    public CivilizationBasicModel? CivilizationChosen { get; set; }
    public async Task InitAsync()
    {
        Civilizations = await dataService.GetCivilizationsAsync();
    }
}