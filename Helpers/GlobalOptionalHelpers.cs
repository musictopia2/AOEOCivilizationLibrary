namespace AOEOCivilizationLibrary.Helpers;
public static class GlobalOptionalHelpers
{
    public static string GetExcludedAgeUpTech(string civAbb, int maxAge)
    {
        if (civAbb == AllCivAbbreviations.Greek)
        {
            return GreekUnits.GetExcludedAgeUpTech(maxAge);
        }
        if (civAbb == AllCivAbbreviations.Egyptian)
        {
            return EgyptianUnits.GetExcludedAgeUpTech(maxAge);
        }
        if (civAbb == AllCivAbbreviations.Norse)
        {
            return NorseUnits.GetExcludedAgeUpTech(maxAge);
        }
        if (civAbb == AllCivAbbreviations.Indian)
        {
            return IndianUnits.GetExcludedAgeUpTech(maxAge);
        }
        if (civAbb == AllCivAbbreviations.Celt)
        {
            return CeltUnits.GetExcludedAgeUpTech(maxAge);
        }
        if (civAbb == AllCivAbbreviations.Babylonian)
        {
            return BabylonUnits.GetExcludedAgeUpTech(maxAge);
        }
        if (civAbb == AllCivAbbreviations.Persian)
        {
            return PersianUnits.GetExcludedAgeUpTech(maxAge);
        }
        if (civAbb == AllCivAbbreviations.Roman)
        {
            return RomanUnits.GetExcludedAgeUpTech(maxAge);
        }

        throw new CustomBasicException($"No age up tech found for civilization {civAbb}");
    }

    public static string GetExcludedBuildingTech(string civAbb, string buildingName)
    {
        if (civAbb == AllCivAbbreviations.Greek)
        {
            return GreekUnits.GetExcludedBuildingTech(buildingName);
        }
        if (civAbb == AllCivAbbreviations.Egyptian)
        {
            return EgyptianUnits.GetExcludedBuildingTech(buildingName);
        }
        if (civAbb == AllCivAbbreviations.Norse)
        {
            return NorseUnits.GetExcludedBuildingTech(buildingName);
        }
        if (civAbb == AllCivAbbreviations.Indian)
        {
            return IndianUnits.GetExcludedBuildingTech(buildingName);
        }
        if (civAbb == AllCivAbbreviations.Celt)
        {
            return CeltUnits.GetExcludedBuildingTech(buildingName);
        }
        if (civAbb == AllCivAbbreviations.Babylonian)
        {
            return BabylonUnits.GetExcludedBuildingTech(buildingName);
        }
        if (civAbb == AllCivAbbreviations.Persian)
        {
            return PersianUnits.GetExcludedBuildingTech(buildingName);
        }
        if (civAbb == AllCivAbbreviations.Roman)
        {
            return RomanUnits.GetExcludedBuildingTech(buildingName);
        }

        throw new CustomBasicException($"No building tech found for civilization {civAbb}");
    }

    public static BasicList<string> GetExcludedFromBlockedUnits(string civAbb, BasicList<string> blockUnits)
    {
        if (civAbb == AllCivAbbreviations.Greek)
        {
            return GreekUnits.GetExcludedFromBlockedUnits(blockUnits);
        }
        if (civAbb == AllCivAbbreviations.Egyptian)
        {
            return EgyptianUnits.GetExcludedFromBlockedUnits(blockUnits);
        }
        if (civAbb == AllCivAbbreviations.Norse)
        {
            return NorseUnits.GetExcludedFromBlockedUnits(blockUnits);
        }
        if (civAbb == AllCivAbbreviations.Indian)
        {
            return IndianUnits.GetExcludedFromBlockedUnits(blockUnits);
        }
        if (civAbb == AllCivAbbreviations.Celt)
        {
            return CeltUnits.GetExcludedFromBlockedUnits(blockUnits);
        }
        if (civAbb == AllCivAbbreviations.Babylonian)
        {
            return BabylonUnits.GetExcludedFromBlockedUnits(blockUnits);
        }
        if (civAbb == AllCivAbbreviations.Persian)
        {
            return PersianUnits.GetExcludedFromBlockedUnits(blockUnits);
        }
        if (civAbb == AllCivAbbreviations.Roman)
        {
            return RomanUnits.GetExcludedFromBlockedUnits(blockUnits);
        }

        throw new CustomBasicException($"No blocked unit exclusions found for civilization {civAbb}");
    }

    public static BasicList<string> GetExcludedFromAllowedUnits(string civAbb, BasicList<string> allowUnits)
    {
        if (civAbb == AllCivAbbreviations.Greek)
        {
            return GreekUnits.GetExcludedFromAllowedUnits(allowUnits);
        }
        if (civAbb == AllCivAbbreviations.Egyptian)
        {
            return EgyptianUnits.GetExcludedFromAllowedUnits(allowUnits);
        }
        if (civAbb == AllCivAbbreviations.Norse)
        {
            return NorseUnits.GetExcludedFromAllowedUnits(allowUnits);
        }
        if (civAbb == AllCivAbbreviations.Indian)
        {
            return IndianUnits.GetExcludedFromAllowedUnits(allowUnits);
        }
        if (civAbb == AllCivAbbreviations.Celt)
        {
            return CeltUnits.GetExcludedFromAllowedUnits(allowUnits);
        }
        if (civAbb == AllCivAbbreviations.Babylonian)
        {
            return BabylonUnits.GetExcludedFromAllowedUnits(allowUnits);
        }
        if (civAbb == AllCivAbbreviations.Persian)
        {
            return PersianUnits.GetExcludedFromAllowedUnits(allowUnits);
        }
        if (civAbb == AllCivAbbreviations.Roman)
        {
            return RomanUnits.GetExcludedFromAllowedUnits(allowUnits);
        }

        throw new CustomBasicException($"No allowed unit exclusions found for civilization {civAbb}");
    }
}
