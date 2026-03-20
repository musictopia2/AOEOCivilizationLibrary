namespace AOEOCivilizationLibrary.Helpers;
public static class CivGearableUnits
{
    public static BasicList<string> GetGearable(string civAbb)
    {
        if (civAbb == AllCivAbbreviations.Greek)
        {
            return GreekUnits.GetAllExceptWalls();
        }
        if (civAbb == AllCivAbbreviations.Egyptian)
        {
            return EgyptianUnits.GetAllExceptWalls();
        }
        if (civAbb == AllCivAbbreviations.Norse)
        {
            return NorseUnits.GetAllExceptWalls();
        }
        if (civAbb == AllCivAbbreviations.Indian)
        {
            return IndianUnits.GetAllExceptWalls();
        }
        if (civAbb == AllCivAbbreviations.Celt)
        {
            return CeltUnits.GetAllExceptWalls();
        }
        if (civAbb == AllCivAbbreviations.Babylonian)
        {
            return BabylonUnits.GetAllExceptWalls();
        }
        if (civAbb == AllCivAbbreviations.Persian)
        {
            return PersianUnits.GetAllExceptWalls();
        }
        if (civAbb == AllCivAbbreviations.Roman)
        {
            return RomanUnits.GetAllExceptWalls();
        }
        throw new CustomBasicException($"No units found for civilizatoin {civAbb}");

    }
}