using System.Security;

namespace AOEOCivilizationLibrary.Constants;
public static class PersianUnits
{
    public const string Sparabara = "Pe_Inf_Sparabara";
    public const string Spearman = "Pe_Inf_Spearman";
    public const string Immortal = "Pe_Inf_Immortal";
    public const string Bowman = "Pe_Arc_Bowman";
    public const string Takabara = "Pe_Arc_Takabara";
    public const string Scout = "Pe_Cav_Scout";
    public const string Asabara = "Pe_Cav_Asabara";
    public const string MountedArcher = "Pe_Arc_MountedArcher";
    public const string Cataphract = "Pe_Cav_Cataphract";
    public const string BatteringRam = "Pe_Sie_BatteringRam";
    public const string WarWagon = "Pe_Sie_WarWagon";
    public const string Palintonon = "Pe_Sie_Palintonon";
    public const string Galley = "Pe_Shp_Galley";
    public const string RamShip = "Pe_Shp_RamShip";
    public const string Magus = "Pe_Spc_Magus";
    public const string Villager = "Pe_Civ_Villager";
    public const string FishingBoat = "Pe_Civ_FishingBoat";
    public const string Caravan = "Pe_Civ_Caravan";
    public const string MerchantTransport = "Pe_Civ_UtilityBoat";
    public const string MangonelGalley = "Pe_Shp_MangonelGalley";
    public const string WarAcademy = "Pe_Bldg_WarAcademy";
    public const string ArcheryRange = "Pe_Bldg_ArcheryRange";
    public const string Armory = "Pe_Bldg_Armory";
    public const string Barracks = "Pe_Bldg_Barracks";
    public const string Dock = "Pe_Bldg_Dock";
    public const string Farm = "Pe_Bldg_Farm";
    public const string Fortress = "Pe_Bldg_Fortress";
    public const string GuardTower = "Pe_Bldg_GuardTower";
    public const string House = "Pe_Bldg_House";
    public const string WatchPost = "Pe_Bldg_LookoutTower";
    public const string Market = "Pe_Bldg_Market";
    public const string SiegeWorkshop = "Pe_Bldg_SiegeWorkshop";
    public const string Stables = "Pe_Bldg_Stables";
    public const string Storehouse = "Pe_Bldg_StoreHouse";
    public const string TownCenter = "Pe_Bldg_TownCenter";
    public const string Wonder = "Pe_Bldg_Wonder";
    public const string Wall = "Pe_WallConnector";
    public const string Gate = "Pe_WallGate";
    public const string ImmortalCamp = "Pe_Bldg_ImmortalCamp";
    private static BasicList<PermissionsModel> _permissions = [];
    static PersianUnits()
    {
        _permissions =
        [
            new PermissionsModel(){ TechName="Pe_Ct_BldgBarracks1", MainGroup=UnitGroupConstants.Barracks, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitSparabara1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_UnitSpearman1", MainGroup=UnitGroupConstants.Infantry, MainRole=UnitGroupConstants.Spearman, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgImmortalCamp1", MainGroup=UnitGroupConstants.Building, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitImmortal1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgArcheryRange1", MainGroup=UnitGroupConstants.ArcheryRange, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitBowman1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_UnitTakabara1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgStable1", MainGroup=UnitGroupConstants.Stables, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitAsabara1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_UnitMountedArcher1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_UnitCataphract1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgSiegeWorkshop1", MainGroup=UnitGroupConstants.SiegeWorkshop, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitBatteringRam1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.BatteringRam, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_UnitWarWagon1", MainGroup=UnitGroupConstants.Siege, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgWonder1", MainGroup=UnitGroupConstants.Wonder, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_BldgStorehouse1", MainGroup=UnitGroupConstants.Storehouse, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_BldgFarm1", MainGroup=UnitGroupConstants.Farm, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_BldgWall1", MainGroup=UnitGroupConstants.Wall, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_BldgWatchPost1", MainGroup=UnitGroupConstants.WatchPost, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_BldgDock1", MainGroup=UnitGroupConstants.Dock, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitFishingBoat1", MainGroup=UnitGroupConstants.FishingBoat, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_UnitMerchantTransport1", MainGroup=UnitGroupConstants.MerchantTransport, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_UnitGalley1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_UnitRamship1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_UnitMangonelGalley1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgTownCenter1", MainGroup=UnitGroupConstants.TownCenter, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitVillager1", MainGroup=UnitGroupConstants.Villager, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgHouse1", MainGroup=UnitGroupConstants.House, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitScout1", MainGroup=UnitGroupConstants.Scout, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgArmory1", MainGroup=UnitGroupConstants.Armory, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_BldgGuardTower1", MainGroup=UnitGroupConstants.GuardTower, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_BldgFortress1", MainGroup=UnitGroupConstants.Fortress, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitPalintonin1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.Palintonon, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgWarAcademy1", MainGroup=UnitGroupConstants.Academy, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitMagus1", MainGroup=UnitGroupConstants.Priest, MainRole=OptionalUnitGroupConstants.ConvertingPriest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Pe_Ct_BldgMarket1", MainGroup=UnitGroupConstants.Market, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Pe_Ct_UnitCaravan1", MainGroup=UnitGroupConstants.Caravan, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="PersiaCapAge3", PreviousAge=2, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="PersiaCapAge4", PreviousAge=3, Category=EnumPermissionCategory.AgeUpTech }
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
            WarAcademy,
            ImmortalCamp,
            Barracks,
            Market,
            ArcheryRange,
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
            Sparabara,
            Spearman,
            Immortal,
            Bowman,
            Takabara,
            Scout,
            Asabara,
            MountedArcher,
            Cataphract,
            BatteringRam,
            WarWagon,
            Palintonon,
            Galley,
            RamShip,
            Magus,
            Villager,
            FishingBoat,
            Caravan,
            MerchantTransport,
            MangonelGalley,
            WarAcademy,
            ArcheryRange,
            Armory,
            Barracks,
            Dock,
            Fortress,
            GuardTower,
            WatchPost,
            House,
            Market,
            SiegeWorkshop,
            Stables,
            Storehouse,
            TownCenter,
            Wonder,
            ImmortalCamp
        ];
    }
}