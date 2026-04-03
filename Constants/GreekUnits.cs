using System.Security;

namespace AOEOCivilizationLibrary.Constants;
public static class GreekUnits
{
    public const string Farm = "Gr_Bldg_Farm";
    public const string Gate = "CWallGate";
    public const string Wall = "WallConnector";
    public const string TownCenter = "Gr_Bldg_TownCenter";
    public const string Villager = "Gr_Civ_Villager";
    public const string Spearman = "Gr_Inf_Spearman";
    public const string Hoplite = "Gr_Inf_Hoplite";
    public const string Hypaspist = "Gr_Inf_Hypaspist";
    public const string Toxotes = "Gr_Arc_Toxotai";
    public const string Hippikon = "Gr_Cav_Hippikon";
    public const string Peltast = "Gr_Arc_Peltast";
    public const string Prodromos = "Gr_Cav_Podromos";
    public const string Ballista = "Gr_Sie_Ballista";
    public const string BatteringRam = "Gr_Sie_BatteringRam";
    public const string Barracks = "Gr_Bldg_Barracks";
    public const string Academy = "Gr_Bldg_Academy";
    public const string ArcheryRange = "Gr_Bldg_ArcheryRange";
    public const string Dock = "Gr_Bldg_Dock";
    public const string House = "Gr_Bldg_House";
    public const string Market = "Gr_Bldg_Market";
    public const string SiegeWorkshop = "Gr_Bldg_SiegeWorkshop";
    public const string Storehouse = "Gr_Bldg_StoreHouse";
    public const string Temple = "Gr_Bldg_Temple";
    public const string WatchPost = "Gr_Bldg_LookoutTower";
    public const string GuardTower = "Gr_Bldg_GuardTower";
    public const string Armory = "Gr_Bldg_Armory";
    public const string Stables = "Gr_Bldg_Stables";
    public const string Caravan = "Gr_Civ_Caravan";
    public const string FishingBoat = "Gr_Civ_FishingBoat";
    public const string MerchantTransport = "Gr_Civ_UtilityBoat";
    public const string Priest = "Gr_Spc_Priest";
    public const string Trireme = "Gr_Shp_Trireme";
    public const string BallistaTrireme = "Gr_Shp_CatTrireme";
    public const string Fortress = "Gr_Bldg_Fortress";
    public const string Palintonon = "Gr_Sie_Palintonon";
    public const string Scout = "Gr_Cav_Scout";
    public const string Wonder = "Gr_Bldg_Wonder";
    public const string Sarissophoroi = "Gr_Cav_Sarissophoroi";
    public const string Gastraphetes = "Gr_Arc_Gastrophes";
    public const string FireShip = "Gr_Shp_FireShip";
    private static BasicList<PermissionsModel> _permissions = [];
    static GreekUnits()
    {
        _permissions =
        [
            new PermissionsModel(){ TechName="GrE_GreekBldgBarracks1", MainGroup=UnitGroupConstants.Barracks, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitSpearman1", MainGroup=UnitGroupConstants.Infantry, MainRole=UnitGroupConstants.Spearman, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitHoplite1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitHypastpist1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekBldgArchRange1", MainGroup=UnitGroupConstants.ArcheryRange, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitToxotai1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitPeltast1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitGastrophes1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekBldgStable1", MainGroup=UnitGroupConstants.Stables, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitSSarissophoroi1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitHippikon1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitPodromo1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekBldgSiegeWorkshop1", MainGroup=UnitGroupConstants.SiegeWorkshop, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitRam1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.BatteringRam, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitBalista1", MainGroup=UnitGroupConstants.Siege, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekBldgStorehouse1", MainGroup=UnitGroupConstants.Storehouse, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekBldgWall1", MainGroup=UnitGroupConstants.Wall, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekBldgWatchTower1", MainGroup=UnitGroupConstants.WatchPost, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekBldgGuardTower1", MainGroup=UnitGroupConstants.GuardTower, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekBldgDock1", MainGroup=UnitGroupConstants.Dock, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitFishingBoat1", MainGroup=UnitGroupConstants.FishingBoat, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitTrireme1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitFireShip1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekUnitUtilityBoat1", MainGroup=UnitGroupConstants.MerchantTransport, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekBldgMarket1", MainGroup=UnitGroupConstants.Market, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitCaravan1", MainGroup=UnitGroupConstants.Caravan, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekBldgArmory1", MainGroup=UnitGroupConstants.Armory, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekBldgFort1", MainGroup=UnitGroupConstants.Fortress, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitPalitonon1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.Palintonon, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekBldgTemple1", MainGroup=UnitGroupConstants.Temple, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitPriest1", MainGroup=UnitGroupConstants.Priest, MainRole=OptionalUnitGroupConstants.ConvertingPriest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekBldgAcademy1", MainGroup=UnitGroupConstants.Academy, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekBldgFarm1", MainGroup=UnitGroupConstants.Farm, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitCataTrireme1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GrE_GreekBldgTownCenter1", MainGroup=UnitGroupConstants.TownCenter, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitVillager1", MainGroup=UnitGroupConstants.Villager, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="GreekCapAge3", PreviousAge=2, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="GreekCapAge4", PreviousAge=3, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="GrE_GreekBldgHouse1", MainGroup=UnitGroupConstants.House, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekBldgWonder1", MainGroup=UnitGroupConstants.Wonder, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="GrE_GreekUnitScout1", MainGroup=UnitGroupConstants.Scout, Category=EnumPermissionCategory.Unit }
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
            Temple,
            Academy,
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
            Farm,
            TownCenter,
            Villager,
            Spearman,
            Hoplite,
            Hypaspist,
            Toxotes,
            Hippikon,
            Peltast,
            Prodromos,
            Ballista,
            BatteringRam,
            Barracks,
            Academy,
            ArcheryRange,
            Dock,
            Market,
            SiegeWorkshop,
            Storehouse,
            Temple,
            WatchPost,
            GuardTower,
            Armory,
            Stables,
            Caravan,
            FishingBoat,
            MerchantTransport,
            Priest,
            Trireme,
            BallistaTrireme,
            Fortress,
            Palintonon,
            Scout,
            Wonder,
            Sarissophoroi,
            Gastraphetes,
            FireShip
        ];
    }
}