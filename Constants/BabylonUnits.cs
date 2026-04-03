namespace AOEOCivilizationLibrary.Constants;
public static class BabylonUnits
{
    private static BasicList<PermissionsModel> _permissions = [];
    static BabylonUnits()
    {
        _permissions =
        [
            new PermissionsModel(){ TechName="Ba_Ct_BldgBarracks1", MainGroup=UnitGroupConstants.Barracks, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitSpearman1", MainGroup=UnitGroupConstants.Infantry, MainRole=UnitGroupConstants.Spearman, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitShieldBearer1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitSapper1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitRoyalGuard1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgArcheryRange1", MainGroup=UnitGroupConstants.ArcheryRange, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitSlinger1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitBowman1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgStables1", MainGroup=UnitGroupConstants.Stables, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitLancer1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitChariotArcher1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitMountedArcher1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitWarChariot1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgSiegeWorkshop1", MainGroup=UnitGroupConstants.SiegeWorkshop, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitSiegeTower1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.BatteringRam, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgTownCenter1", MainGroup=UnitGroupConstants.TownCenter, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitVillager1", MainGroup=UnitGroupConstants.Villager, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitOxCart1", MainGroup=UnitGroupConstants.Unit, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgFarm1", MainGroup=UnitGroupConstants.Farm, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_BldgGarden1", MainGroup=UnitGroupConstants.Building, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_BldgDock1", MainGroup=UnitGroupConstants.Dock, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitFishingBoat1", MainGroup=UnitGroupConstants.FishingBoat, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitBireme1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitMerchantTransport1", MainGroup=UnitGroupConstants.MerchantTransport, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_UnitRamship1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgHouse1", MainGroup=UnitGroupConstants.House, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_BldgMarket1", MainGroup=UnitGroupConstants.Market, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitCaravan1", MainGroup=UnitGroupConstants.Caravan, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgWonder1", MainGroup=UnitGroupConstants.Wonder, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_BldgArmory1", MainGroup=UnitGroupConstants.Armory, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_BldgZiggurat1", MainGroup=UnitGroupConstants.Temple, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitPriest1", MainGroup=UnitGroupConstants.Priest, MainRole=OptionalUnitGroupConstants.ConvertingPriest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgFortress1", MainGroup=UnitGroupConstants.Fortress, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitPalintonin1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.Palintonon, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgWatchPost1", MainGroup=UnitGroupConstants.WatchPost, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_UnitScout1", MainGroup=UnitGroupConstants.Scout, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ba_Ct_BldgGuardTower1", MainGroup=UnitGroupConstants.GuardTower, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ba_Ct_BldgWall1", MainGroup=UnitGroupConstants.Wall, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="BabylonCapAge3", PreviousAge=2, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="BabylonCapAge4", PreviousAge=3, Category=EnumPermissionCategory.AgeUpTech }
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


    public const string Villager = "Ba_Civ_Villager";
    public const string FishingBoat = "Ba_Civ_FishingBoat";
    public const string Caravan = "Ba_Civ_Caravan";
    public const string MerchantTransport = "Ba_Civ_UtilityBoat";
    public const string OxCart = "Ba_Civ_OxCart";
    public const string Spearman = "Ba_Inf_Spearman";
    public const string RoyalGuard = "Ba_Inf_RoyalGuard";
    public const string Bowman = "Ba_Arc_Bowman";
    public const string Scout = "Ba_Cav_Scout";
    public const string Lancer = "Ba_Cav_Lancer";
    public const string Palintonon = "Ba_Sie_Palintonon";
    public const string Priest = "Ba_Spc_Priest";
    public const string TownCenter = "Ba_Bldg_TownCenter";
    public const string Dock = "Ba_Bldg_Dock";
    public const string WatchPost = "Ba_Bldg_LookoutTower";
    public const string House = "Ba_Bldg_House";
    public const string Barracks = "Ba_Bldg_Barracks";
    public const string Farm = "Ba_Bldg_Farm";
    public const string Market = "Ba_Bldg_Market";
    public const string GuardTower = "Ba_Bldg_GuardTower";
    public const string Armory = "Ba_Bldg_Armory";
    public const string ArcheryRange = "Ba_Bldg_ArcheryRange";
    public const string Stables = "Ba_Bldg_Stables";
    public const string Ziggurat = "Ba_Bldg_Ziggurat";
    public const string SiegeWorkshop = "Ba_Bldg_SiegeWorkshop";
    public const string Fortress = "Ba_Bldg_Fortress";
    public const string Wonder = "Ba_Bldg_Wonder";
    public const string ClayWall = "Ba_WallConnector";
    public const string Gate = "Ba_WallGate";
    public const string Slinger = "Ba_Arc_Slinger";
    public const string ChariotArcher = "Ba_Arc_ChariotArcher";
    public const string Sapper = "Ba_Inf_Sapper";
    public const string SiegeTower = "Ba_Sie_SiegeTower";
    public const string WarChariot = "Ba_Arc_WarChariot";
    public const string MountedArcher = "Ba_Arc_MountedArcher";
    public const string Bireme = "Ba_Shp_Bireme";
    public const string RamShip = "Ba_Shp_RamShip";
    public const string ShieldBearer = "Ba_Inf_ShieldBearer";
    public const string Garden = "Ba_Bldg_Garden"; //since the babylon storehouse is not valid, then ignore that one.
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
            Ziggurat,
            Barracks,
            Market,
            Armory,
            ArcheryRange,
            Stables,
            Wonder,
            Garden,
            SiegeWorkshop
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
            OxCart,
            Spearman,
            RoyalGuard,
            Bowman,
            Scout,
            Lancer,
            Palintonon,
            Priest,
            TownCenter,
            WatchPost,
            GuardTower,
            House,
            Fortress,
            Slinger,
            ChariotArcher,
            Sapper,
            WarChariot,
            MountedArcher,
            Bireme,
            RamShip,
            ShieldBearer,
            Farm,
            Market,
            Armory,
            ArcheryRange,
            Stables,
            Wonder,
            Garden,
            SiegeWorkshop
        ];
    }
}