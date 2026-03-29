namespace AOEOCivilizationLibrary.Helpers;
public static class Extensions
{
    extension(string milestoneName)
    {
        public string CivAbb
        {
            get
            {
                if (milestoneName.StartsWith("C01"))
                {
                    return AllCivAbbreviations.Greek;
                }
                if (milestoneName.StartsWith("C02"))
                {
                    return AllCivAbbreviations.Egyptian;
                }
                if (milestoneName.StartsWith("C03"))
                {
                    return AllCivAbbreviations.Celt;
                }
                if (milestoneName.StartsWith("C04"))
                {
                    return AllCivAbbreviations.Persian;
                }
                if (milestoneName.StartsWith("C05"))
                {
                    return AllCivAbbreviations.Roman;
                }
                if (milestoneName.StartsWith("C06"))
                {
                    return AllCivAbbreviations.Babylonian;
                }
                if (milestoneName.StartsWith("C07"))
                {
                    return AllCivAbbreviations.Norse;
                }
                if (milestoneName.StartsWith("C08"))
                {
                    return AllCivAbbreviations.Indian;
                }
                throw new CustomBasicException("No civilization was found for the milestone");
            }
        }
    }
}
