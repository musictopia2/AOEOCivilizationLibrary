namespace AOEOCivilizationLibrary.Constants;

public static class CeltUnits
{
    public const string Spearman = "Ce_Inf_Spearman";
    public const string LongSwordsman = "Ce_Inf_LongSwordsman";
    public const string WoadRaider = "Ce_Inf_WoadRaider";
    public const string Champion = "Ce_Inf_Champion";
    public const string Slinger = "Ce_Arc_Slinger";
    public const string Bowman = "Ce_Arc_Bowman";
    public const string Scout = "Ce_Cav_Scout";
    public const string Horseman = "Ce_Cav_Horseman";
    public const string Swanship = "Ce_Shp_Warship";
    public const string Druid = "Ce_Spc_Druid";
    public const string Augur = "Ce_Spc_DruidAugur";
    public const string Villager = "Ce_Civ_Villager";
    public const string FishingBoat = "Ce_Civ_FishingBoat";
    public const string MerchantTransport = "Ce_Civ_UtilityBoat";
    public const string Caravan = "Ce_Civ_Caravan";
    public const string TownCenter = "Ce_Bldg_TownCenter";
    public const string Dock = "Ce_Bldg_Dock";
    public const string WatchPost = "Ce_Bldg_LookoutTower";
    public const string StoreHouse = "Ce_Bldg_StoreHouse";
    public const string House = "Ce_Bldg_House";
    public const string Barracks = "Ce_Bldg_Barracks";
    public const string Farm = "Ce_Bldg_Farm";
    public const string Market = "Ce_Bldg_Market";
    public const string GuardTower = "Ce_Bldg_GuardTower";
    public const string Armory = "Ce_Bldg_Armory";
    public const string ArcheryRange = "Ce_Bldg_ArcheryRange";
    public const string Stables = "Ce_Bldg_Stables";
    public const string SacredGrove = "Ce_Bldg_SacredGrove";
    public const string BardHall = "Ce_Bldg_BardHall";
    public const string Fortress = "Ce_Bldg_Fortress";
    public const string Ram = "Ce_Sie_Ram";
    public const string Wonder = "Ce_Bldg_Wonder";
    public const string Wall = "Ce_WallConnector";
    public const string Gate = "Ce_WallGate";
    public const string GoldMine = "Ce_Bldg_GoldMine";
    public const string Carpentom = "Ce_Arc_Carpentom";
    public const string StoneThrower = "Ce_Sie_Palintonon";



    private static BasicList<PermissionsModel> _permissions = [];
    static CeltUnits()
    {
        _permissions =
        [
            new PermissionsModel(){ TechName="Ce_Ct_UnitLongSwordsman1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitSpearman1", MainGroup=UnitGroupConstants.Infantry, MainRole=UnitGroupConstants.Spearman, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitChampion1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitBowman1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitSkirmisher1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitHorseman1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitCarpentom1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitWoadRaider1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_BldgBarracks1", MainGroup=UnitGroupConstants.Barracks, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgArchRange1", MainGroup=UnitGroupConstants.ArcheryRange, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgStable1", MainGroup=UnitGroupConstants.Stables, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgFort1", MainGroup=UnitGroupConstants.Fortress, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgWonder1", MainGroup=UnitGroupConstants.Wonder, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_UnitVillager1", MainGroup=UnitGroupConstants.Villager, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitFishingBoat1", MainGroup=UnitGroupConstants.FishingBoat, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_BldgFarm1", MainGroup=UnitGroupConstants.Farm, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgGoldMine1", MainGroup=UnitGroupConstants.Building, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgStorehouse1", MainGroup=UnitGroupConstants.Storehouse, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgWall1", MainGroup=UnitGroupConstants.Wall, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgWatchTower1", MainGroup=UnitGroupConstants.WatchPost, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgDock1", MainGroup=UnitGroupConstants.Dock, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgTownCenter1", MainGroup=UnitGroupConstants.TownCenter, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_UnitScout1", MainGroup=UnitGroupConstants.Scout, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitDruid1", MainGroup=UnitGroupConstants.Priest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitDruidAuger1", MainGroup=UnitGroupConstants.Priest, MainRole=OptionalUnitGroupConstants.ConvertingPriest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitCaravan1", MainGroup=UnitGroupConstants.Caravan, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_BldgArmory1", MainGroup=UnitGroupConstants.Armory, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgGuardTower1", MainGroup=UnitGroupConstants.GuardTower, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgSacredGrove1", MainGroup=UnitGroupConstants.Temple, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgBardHall1", MainGroup=UnitGroupConstants.Academy, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgHouse1", MainGroup=UnitGroupConstants.House, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_BldgMarket1", MainGroup=UnitGroupConstants.Market, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ce_Ct_UnitUtilityBoat1", MainGroup=UnitGroupConstants.MerchantTransport, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitWarship1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitRam1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.BatteringRam, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="CeltCapAge3", PreviousAge=2, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="CeltCapAge4", PreviousAge=3, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="Ce_Ct_UnitDeer1", MainGroup=UnitGroupConstants.Unit, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ce_Ct_UnitPalintonon1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.Palintonon, Category=EnumPermissionCategory.Unit }
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
    public static BasicList<string> GetFarmsAndHouses()
    {
        return
        [
            Farm,
            House
        ];
    }
    public static BasicList<string> GetSpecialBuildings()
    {
        return
        [
            Dock,
            StoreHouse,
            BardHall,
            Barracks,
            Market,
            Armory,
            ArcheryRange,
            SacredGrove,
            Stables,
            Wonder,
            GoldMine
        ];
    }
    public static BasicList<string> GetAllExceptWalls()
    {
        return
        [
            Spearman,
            LongSwordsman,
            WoadRaider,
            Champion,
            Slinger,
            Bowman,
            Scout,
            Horseman,
            Swanship,
            Druid,
            Augur,
            Villager,
            FishingBoat,
            MerchantTransport,
            Caravan,
            TownCenter,
            WatchPost,
            House,
            Farm,
            Market,
            GuardTower,
            Armory,
            ArcheryRange,
            Stables,
            SacredGrove,
            Fortress,
            Ram,
            Wonder,
            GoldMine,
            Carpentom,
            StoneThrower
        ];
    }
}