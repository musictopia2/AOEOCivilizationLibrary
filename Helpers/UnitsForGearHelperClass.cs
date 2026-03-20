namespace AOEOCivilizationLibrary.Helpers;
public static class CivGearableEntities
{
    private static readonly HashSet<string> _starterLineOfSightGearUnits =
    [
        GreekUnits.Farm,
        GreekUnits.GuardTower,
        GreekUnits.House,
        GreekUnits.WatchPost,
        GreekUnits.Wonder,

        EgyptianUnits.Farm,
        EgyptianUnits.GuardTower,
        EgyptianUnits.House,
        EgyptianUnits.WatchPost,
        EgyptianUnits.Wonder,

        CeltUnits.Farm,
        CeltUnits.GuardTower,
        CeltUnits.House,
        CeltUnits.WatchPost,
        CeltUnits.Wonder,
        CeltUnits.GoldMine,

        PersianUnits.Farm,
        PersianUnits.GuardTower,
        PersianUnits.House,
        PersianUnits.WatchPost,
        PersianUnits.Wonder,

        BabylonUnits.Farm,
        BabylonUnits.GuardTower,
        BabylonUnits.House,
        BabylonUnits.WatchPost,
        BabylonUnits.Wonder,

        NorseUnits.Farm,
        NorseUnits.GuardTower,
        NorseUnits.Longhouse,
        NorseUnits.Outpost,
        NorseUnits.Wonder,

        RomanUnits.Farm,
        RomanUnits.GuardTower,
        RomanUnits.House,
        RomanUnits.WatchPost,
        RomanUnits.Wonder,

        IndianUnits.Farm,
        IndianUnits.GuardTower,
        IndianUnits.House,
        IndianUnits.WatchPost,
        IndianUnits.Wonder
    ];

    public static bool UsesStarterLineOfSightGear(string protoUnit) =>
        _starterLineOfSightGearUnits.Contains(protoUnit);

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