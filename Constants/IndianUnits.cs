using System.Security;

namespace AOEOCivilizationLibrary.Constants;
public static class IndianUnits
{
    public const string Farm = "In_Bldg_Farm";
    public const string House = "In_Bldg_House";
    public const string Storehouse = "In_Bldg_StoreHouse";
    public const string Monastery = "In_Bldg_Monastery";
    public const string Market = "In_Bldg_Market";
    public const string Shrine = "In_Bldg_Shrine";
    public const string GuardTower = "In_Bldg_GuardTower";
    public const string Wall = "In_WallConnector";
    public const string Gate = "In_WallGate";
    public const string Dock = "In_Bldg_Dock";
    public const string WatchPost = "In_Bldg_LookoutTower";
    public const string Wonder = "In_Bldg_Wonder";
    public const string Villager = "In_Civ_Villager";
    public const string GathererElephant = "In_Civ_GathererElephant";
    public const string Guru = "In_Spc_Guru";
    public const string Caravan = "In_Civ_Caravan";
    public const string FishingBoat = "In_Civ_FishingBoat";
    public const string MerchantTransport = "In_Civ_UtilityBoat";
    public const string Vimana = "In_Shp_Vimana";
    public const string Fireship = "In_Shp_FireShip";
    public const string Spearman = "In_Inf_Spearman";
    public const string GadaWarrior = "In_Inf_GadaWarrior";
    public const string Bowman = "In_Arc_Bowman";
    public const string Ranger = "In_Arc_Ranger";
    public const string Turanga = "In_Cav_Turanga";
    public const string BladeChariot = "In_Arc_BladeChariot";
    public const string WarElephant = "In_Cav_WarElephant";
    public const string ElephantArcher = "In_Arc_ElephantArcher";
    public const string Juggernaut = "In_Cav_Juggernaut";
    public const string Ram = "In_Sie_Ram";
    public const string Palintonon = "In_Sie_Palintonon";
    public const string Scout = "In_Inf_Scout";
    public const string SacredCow = "In_SacredCow";
    public const string ClubMonkey = "In_Inf_Monkey1";
    public const string FireMonkey = "In_Arc_Monkey2";

    private static BasicList<PermissionsModel> _permissions = [];
    static IndianUnits()
    {
        _permissions =
        [
            new PermissionsModel(){ TechName="In_Ct_BldgArcheryRange1", MainGroup=UnitGroupConstants.ArcheryRange, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgArmory1", MainGroup=UnitGroupConstants.Armory, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgBarracks1", MainGroup=UnitGroupConstants.Barracks, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgDock1", MainGroup=UnitGroupConstants.Dock, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgFarm1", MainGroup=UnitGroupConstants.Farm, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgFortress1", MainGroup=UnitGroupConstants.Fortress, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgGuardTower1", MainGroup=UnitGroupConstants.GuardTower, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgHouse1", MainGroup=UnitGroupConstants.House, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgMahoutCamp1", MainGroup=UnitGroupConstants.Building, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgMarket1", MainGroup=UnitGroupConstants.Market, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgMonastery1", MainGroup=UnitGroupConstants.Academy, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgShrine1", MainGroup=UnitGroupConstants.Building, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgStables1", MainGroup=UnitGroupConstants.Stables, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgStorehouse1", MainGroup=UnitGroupConstants.Storehouse, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgTownCenter1", MainGroup=UnitGroupConstants.TownCenter, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgWall1", MainGroup=UnitGroupConstants.Wall, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgWatchPost1", MainGroup=UnitGroupConstants.WatchPost, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_BldgWonder1", MainGroup=UnitGroupConstants.Wonder, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="In_Ct_UnitBladeChariot1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitBowman1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitCaravan1", MainGroup=UnitGroupConstants.Caravan, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitElephantArcher1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitFireship1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitFishingBoat1", MainGroup=UnitGroupConstants.FishingBoat, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitGadaWarrior1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitGathererElephant1", MainGroup=UnitGroupConstants.Unit, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitGuru1", MainGroup=UnitGroupConstants.Priest, MainRole=OptionalUnitGroupConstants.ConvertingPriest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitJuggernaut1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitMerchantTransport1", MainGroup=UnitGroupConstants.MerchantTransport, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitMonkey1", MainGroup=UnitGroupConstants.Unit, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitMonkey2", MainGroup=UnitGroupConstants.Unit, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitPalintonon1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.Palintonon, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitRam1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.BatteringRam, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitRanger1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitSacredCow1", MainGroup=UnitGroupConstants.Unit, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitScout1", MainGroup=UnitGroupConstants.Scout, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitSpearman1", MainGroup=UnitGroupConstants.Infantry, MainRole=UnitGroupConstants.Spearman, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitTuranga1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitVillager1", MainGroup=UnitGroupConstants.Villager, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitVimana1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="In_Ct_UnitWarElephant1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="IndiaCapAge3", PreviousAge=2, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="IndiaCapAge4", PreviousAge=3, Category=EnumPermissionCategory.AgeUpTech }
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
    public static BasicList<string> GetAllExceptWalls()
    {
        return
        [
            Farm,
            House,
            Storehouse,
            Monastery,
            Market,
            Shrine,
            GuardTower,
            Dock,
            WatchPost,
            House,
            Wonder,
            Villager,
            GathererElephant,
            Guru,
            Caravan,
            FishingBoat,
            MerchantTransport,
            Vimana,
            Fireship,
            Spearman,
            GadaWarrior,
            Bowman,
            Ranger,
            Turanga,
            BladeChariot,
            WarElephant,
            ElephantArcher,
            Juggernaut,
            Ram,
            Palintonon,
            Scout,
            ClubMonkey,
            FireMonkey
        ];
    }
}