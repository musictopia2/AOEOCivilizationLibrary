namespace AOEOCivilizationLibrary.Constants;
public static class NorseUnits
{
    private static BasicList<PermissionsModel> _permissions = [];
    static NorseUnits()
    {
        _permissions =
        [
            // Barracks
            new PermissionsModel(){ TechName="No_Ct_BldgBarracks1", MainGroup=UnitGroupConstants.Barracks, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_UnitSpearman1", MainGroup=UnitGroupConstants.Infantry, MainRole = UnitGroupConstants.Spearman
               , Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitThrowingAxeman1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitAxeman1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitBerserker1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitUlfhednar1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },

            // Archery Range
            new PermissionsModel(){ TechName="No_Ct_BldgArcheryRange1", MainGroup = UnitGroupConstants.ArcheryRange, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_UnitSkirmisher1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitBowman1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },

            // Stables
            new PermissionsModel(){ TechName="No_Ct_BldgStables1", MainGroup = UnitGroupConstants.Stables,  Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_UnitRaider1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitHorseman1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },

            // Fortress
            new PermissionsModel(){ TechName="No_Ct_BldgFortress1", MainGroup=UnitGroupConstants.Fortress, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_UnitRam1", MainGroup=UnitGroupConstants.Siege, 
                MainRole=UnitGroupConstants.BatteringRam, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitStoneThrower1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.Palintonon, Category=EnumPermissionCategory.Unit },

            // Economy
            new PermissionsModel(){ TechName="No_Ct_BldgStorehouse1", MainGroup=UnitGroupConstants.Storehouse, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_BldgFarm1", MainGroup=UnitGroupConstants.Farm, Category=EnumPermissionCategory.Building },

            // Dock
            new PermissionsModel(){ TechName="No_Ct_BldgDock1", MainGroup=UnitGroupConstants.Dock, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_UnitFishingBoat1", MainGroup=UnitGroupConstants.FishingBoat, Exception=true, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitLongship1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitMerchantTransport1", MainGroup=UnitGroupConstants.MerchantTransport, Exception=true, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitFireship1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },

            // Market
    
            new PermissionsModel(){ TechName="No_Ct_BldgMarket1", MainGroup=UnitGroupConstants.Market, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_UnitCaravan1", MainGroup=UnitGroupConstants.Caravan, Exception=true, Category=EnumPermissionCategory.Unit },

            // Town Center
            new PermissionsModel(){ TechName="No_Ct_BldgTownCenter1", MainGroup=UnitGroupConstants.TownCenter, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_UnitVillager1", MainGroup=UnitGroupConstants.Villager, Exception=true, Category=EnumPermissionCategory.Unit },

            // Special buildings
            new PermissionsModel(){ TechName="No_Ct_BldgWonder1", MainGroup=UnitGroupConstants.Wonder, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_BldgArmory1", MainGroup=UnitGroupConstants.Armory, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_BldgHouse1", MainGroup=UnitGroupConstants.House, Category=EnumPermissionCategory.Building },

            // Great Hall
            new PermissionsModel(){ TechName="No_Ct_BldgGreatHall1", MainGroup = UnitGroupConstants.Temple, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_UnitSeer1", MainGroup=UnitGroupConstants.Priest,
                MainRole=OptionalUnitGroupConstants.ConvertingPriest, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitChief1", Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitBard1", MainGroup=UnitGroupConstants.Priest, 
                MainRole=OptionalUnitGroupConstants.ConvertingPriest, Category=EnumPermissionCategory.Unit },

            // Defense
            new PermissionsModel(){ TechName="No_Ct_BldgWatchPost1", MainGroup=UnitGroupConstants.WatchPost, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_UnitWarDog1", Exception=true, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitScout1", MainGroup=UnitGroupConstants.Scout, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_UnitScout2", MainGroup=UnitGroupConstants.Scout, Category=EnumPermissionCategory.Unit },
            new PermissionsModel(){ TechName="No_Ct_BldgGuardTower1", MainGroup=UnitGroupConstants.GuardTower, Category=EnumPermissionCategory.Building },
            new PermissionsModel(){ TechName="No_Ct_BldgWall1", MainGroup=UnitGroupConstants.Wall, Category=EnumPermissionCategory.Building },

            // Age caps
            new PermissionsModel(){ TechName="NorseCapAge3", PreviousAge=2, Category=EnumPermissionCategory.AgeUpTech },
            new PermissionsModel(){ TechName="NorseCapAge4", PreviousAge=3, Category=EnumPermissionCategory.AgeUpTech },
        ];
    }
    public static string GetExcludedAgeUpTech(int maxAge)
    {
        foreach (var p in _permissions)
        {
            if (p.Category == EnumPermissionCategory.AgeUpTech && p.PreviousAge!.Value == maxAge)
            {
                return p.TechName;
            }
        }
        throw new CustomBasicException($"No age up tech found for age {maxAge}");
    }

    public static string GetExcludedBuildingTech(string buildingName)
    {
        foreach (var p in _permissions)
        {
            if (p.Category == EnumPermissionCategory.Building && (p.MainGroup == buildingName || p.MainRole == buildingName))
            {
                return p.TechName;
            }
        }
        throw new CustomBasicException($"No building tech found for {buildingName}");
    }
    public static BasicList<string> GetExcludedFromBlockedUnits(BasicList<string> blockUnits)
    {
        BasicList<string> output = [];
        foreach (var p in _permissions)
        {
            if (p.Category == EnumPermissionCategory.Unit && blockUnits.Contains(p.MainGroup))
            {
                output.Add(p.TechName);
            }
            if (p.Category == EnumPermissionCategory.Unit && blockUnits.Contains(p.MainRole))
            {
                output.Add(p.TechName);
            }
        }
        return output;
    }
    public static BasicList<string> GetExcludedFromAllowedUnits(BasicList<string> allowUnits)
    {
        BasicList<string> output = [];
        foreach (var p in _permissions)
        {
            if (p.Category == EnumPermissionCategory.Unit && allowUnits.Contains(p.MainGroup) == false && allowUnits.Contains(p.MainRole) == false && p.Exception == false)
            {
                output.Add(p.TechName);
            }
        }
        return output;
    }



    public const string Villager = "No_Civ_Villager";
    public const string FishingBoat = "No_Civ_FishingBoat";
    public const string Caravan = "No_Civ_Caravan";
    public const string MerchantTransport = "No_Civ_UtilityBoat";
    public const string Scout1 = "No_Inf_Scout1";
    public const string Scout2 = "No_Inf_Scout2";
    public const string Skirmisher = "No_Arc_Skirmisher";
    public const string Harjar = "No_Inf_Axeman";
    public const string Berzerker = "No_Inf_Berserker";
    public const string Ulfhednar = "No_Inf_Ulfhednar";
    public const string Chief = "No_Inf_Chief";
    public const string Bowman = "No_Arc_Bowman";
    public const string Raider = "No_Cav_Raider";
    public const string Horseman = "No_Cav_Horseman";
    public const string Farbjor = "No_Sie_Ram";
    public const string LogThrower = "No_Sie_Palintonon";
    public const string Rhapsode = "No_Spc_Bard";
    public const string Longship = "No_Shp_Longship";
    public const string Fireship = "No_Shp_FireShip";
    public const string Seer = "No_Spc_Seer";
    public const string ThrowingAxeman = "No_Inf_ThrowingAxeman";
    public const string WarDog = "No_Cav_WarDog";
    public const string TownCenter = "No_Bldg_TownCenter";
    public const string Dock = "No_Bldg_Dock";
    public const string Outpost = "No_Bldg_LookoutTower";
    public const string Storehouse = "No_Bldg_StoreHouse";
    public const string Longhouse = "No_Bldg_House";
    public const string Barracks = "No_Bldg_Barracks";
    public const string Farm = "No_Bldg_Farm";
    public const string Market = "No_Bldg_Market";
    public const string GuardTower = "No_Bldg_GuardTower";
    public const string Armory = "No_Bldg_Armory";
    public const string ArcheryRange = "No_Bldg_ArcheryRange";
    public const string Stables = "No_Bldg_Stables";
    public const string GreatHall = "No_Bldg_GreatHall";
    public const string Fortress = "No_Bldg_Fortress";
    public const string Wonder = "No_Bldg_Wonder";
    public const string Wall = "No_WallConnector";
    public const string Gate = "No_WallGate";
    public const string Spearman = "No_Inf_Spearman";
    public const string Raven = "No_Raven";
    public static BasicList<string> GetFarmsAndHouses()
    {
        return
        [
            Farm,
            Longhouse
        ];
    }
    public static BasicList<string> GetSpecialBuildings()
    {
        return
        [
            Dock,
            GreatHall,
            Barracks,
            Market,
            Armory,
            ArcheryRange,
            Stables,
            Wonder,
            Storehouse,
        ];
    }
    public static BasicList<string> GetAllExceptWalls()
    {
        return
        [
            Villager,
            FishingBoat,
            Caravan,
            MerchantTransport,
            Scout1,
            Scout2,
            Skirmisher,
            Harjar,
            Berzerker,
            Ulfhednar,
            Chief,
            Bowman,
            Raider,
            Horseman,
            Farbjor,
            LogThrower,
            Rhapsode,
            Longship,
            Fireship,
            Seer,
            ThrowingAxeman,
            WarDog,
            TownCenter,
            Outpost,
            Market,
            GuardTower,
            Spearman,
            Farm,
            Barracks,
            Armory,
            ArcheryRange,
            Stables,
            GreatHall,
            Fortress,
            Wonder,
            Storehouse,
            Longhouse,
        ];
    }
}