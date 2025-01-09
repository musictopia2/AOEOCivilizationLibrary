﻿        namespace AOEOCivilizationLibrary.DataServices;
public class InMemoryCivilizationDataService : ICivilizationDataService
{
    Task<BasicList<CivilizationBasicModel>> ICivilizationDataService.GetCivilizationsAsync()
    {
        BasicList<CivilizationBasicModel> output =
        [
            new("Gr", "Greek"),
            new("Eg", "Egyptian"),
            new("Ce", "Celtic"),
            new("Pe", "Persian"),
            new("Ba", "Babylonian"),
            new("No", "Norse"),
            new("Ro", "Roman"),
            new("In", "Indian")
        ];
        //since indians has been released, no more workaround needed.
        output = output.OrderBy(xx => xx.FullName).ToBasicList(); //so it can work with my combo box.
        return Task.FromResult(output);
    }
}