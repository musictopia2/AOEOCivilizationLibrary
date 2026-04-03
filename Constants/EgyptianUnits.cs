using System.Security;

namespace AOEOCivilizationLibrary.Constants;

public static class EgyptianUnits
{
    public const string TempleOfRa = "Eg_Bldg_Temple1";
    public const string PriestOfRa = "Eg_Spc_PriestRa";
    public const string TempleOfSet = "Eg_Bldg_Temple2";
    public const string TempleOfPtah = "Eg_Bldg_Temple3";
    public const string PriestOfPtah = "Eg_Spc_PriestPtah";
    public const string PriestOfSet = "Eg_Spc_PriestSet";
    public const string ChariotArcher = "Eg_Arc_ChariotArcher";
    public const string ElephantArcher = "Eg_Arc_ElephantArcher";
    public const string Slinger = "Eg_Arc_Slinger"; //since i can't use archery range as egyptians, decided to not have that one.
    public const string Armory = "Eg_Bldg_Armory";
    public const string Barracks = "Eg_Bldg_Barracks";
    public const string Dock = "Eg_Bldg_Dock";
    public const string Farm = "Eg_Bldg_Farm";
    public const string Fortress = "Eg_Bldg_Fortress";
    public const string GuardTower = "Eg_Bldg_GuardTower";
    public const string House = "Eg_Bldg_House";
    public const string WatchPost = "Eg_Bldg_LookoutTower";
    public const string Market = "Eg_Bldg_Market";
    public const string SiegeWorkshop = "Eg_Bldg_SiegeWorkshop";
    public const string Stables = "Eg_Bldg_Stables";
    public const string TownCenter = "Eg_Bldg_TownCenter";
    public const string Wonder = "Eg_Bldg_Wonder";
    public const string Storehouse = "Eg_Bldg_StoreHouse";
    public const string Scout = "Eg_Cav_Scout";
    public const string CamelRider = "Eg_Cav_CamelRider";
    public const string WarElephant = "Eg_Cav_WarElephant";
    public const string Caravan = "Eg_Civ_Caravan";
    public const string FishingBoat = "Eg_Civ_FishingBoat";
    public const string MerchantTransport = "Eg_Civ_UtilityBoat";
    public const string Villager = "Eg_Civ_Villager";
    public const string Axeman = "Eg_Inf_Axeman";
    public const string Spearman = "Eg_Inf_Spearman";
    public const string CatapultTrireme = "Eg_Shp_CatTrireme";
    public const string Trireme = "Eg_Shp_Trireme";
    public const string FireShip = "Eg_Shp_FireShip";
    public const string SiegeTower = "Eg_Sie_SiegeTower";
    public const string Catapult = "Eg_Sie_Catapult";
    public const string Palintonon = "Eg_Sie_Trebuchet";
    public const string Wall = "Eg_WallConnector";
    public const string Gate = "Eg_WallGate";
    private static BasicList<PermissionsModel> _permissions = [];
    static EgyptianUnits()
    {
        _permissions =
        [
            new PermissionsModel(){ TechName="Eg_Ct_BldgBarracks1", MainGroup=UnitGroupConstants.Barracks, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_UnitSpearman1", MainGroup=UnitGroupConstants.Infantry, MainRole=UnitGroupConstants.Spearman, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitSlinger1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitAxeman1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgStable1", MainGroup=UnitGroupConstants.Stables, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_UnitChariotArcher1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitCamelRider1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitWarElephant1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitElephantArcher1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgSiegeWorkshop1", MainGroup=UnitGroupConstants.SiegeWorkshop, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_UnitSiegeTower1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.BatteringRam, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitCatapult1", MainGroup=UnitGroupConstants.Siege, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgWall1", MainGroup=UnitGroupConstants.Wall, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_BldgWatchTower1", MainGroup=UnitGroupConstants.WatchPost, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_BldgDock1", MainGroup=UnitGroupConstants.Dock, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_UnitFishingBoat1", MainGroup=UnitGroupConstants.FishingBoat, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitTrireme1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitFireShip1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitUtilityBoat1", MainGroup=UnitGroupConstants.MerchantTransport, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_UnitCatapultTrireme1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgFarm1", MainGroup=UnitGroupConstants.Farm, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_BldgArmory1", MainGroup=UnitGroupConstants.Armory, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_BldgGuardTower1", MainGroup=UnitGroupConstants.GuardTower, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_BldgFort1", MainGroup=UnitGroupConstants.Fortress, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_UnitTrebuchet1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.Palintonon, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgMarket1", MainGroup=UnitGroupConstants.Market, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_UnitCaravan1", MainGroup=UnitGroupConstants.Caravan, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgTemple1", MainGroup=UnitGroupConstants.Temple, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_UnitPriestRa1", MainGroup=UnitGroupConstants.Priest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgTemple2", PreviousAge=2, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="Eg_Ct_UnitPriestSet1", MainGroup=UnitGroupConstants.Priest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgTemple3", PreviousAge=3, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="Eg_Ct_UnitPriestPtah1", MainGroup=UnitGroupConstants.Priest, MainRole=OptionalUnitGroupConstants.ConvertingPriest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgTownCenter1", MainGroup=UnitGroupConstants.TownCenter, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_UnitVillager1", MainGroup=UnitGroupConstants.Villager, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Eg_Ct_BldgHouse1", MainGroup=UnitGroupConstants.House, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_BldgWonder1", MainGroup=UnitGroupConstants.Wonder, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Eg_Ct_UnitScout1", MainGroup=UnitGroupConstants.Scout, Category=EnumPermissionCategory.Unit }
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
            TempleOfPtah,
            TempleOfRa,
            TempleOfSet,
            Barracks,
            Market,
            Armory,
            Stables,
            Wonder,
            Storehouse,
            SiegeWorkshop
        ];
    }
    public static BasicList<string> GetAllExceptWalls()
    {
        return
        [
            TempleOfRa,
            PriestOfRa,
            TempleOfSet,
            TempleOfPtah,
            PriestOfPtah,
            PriestOfSet,
            ChariotArcher,
            ElephantArcher,
            Slinger,
            Armory,
            Barracks,
            Dock,
            Farm,
            Fortress,
            GuardTower,
            Market,
            SiegeWorkshop,
            Stables,
            TownCenter,
            Wonder,
            Storehouse,
            House,
            Scout,
            CamelRider,
            WarElephant,
            Caravan,
            FishingBoat,
            MerchantTransport,
            Villager,
            Axeman,
            Spearman,
            CatapultTrireme,
            Trireme,
            FireShip,
            SiegeTower,
            Catapult,
            Palintonon,
            WatchPost
        ];
    }
}