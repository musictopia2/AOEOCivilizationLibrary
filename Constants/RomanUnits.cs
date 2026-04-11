namespace AOEOCivilizationLibrary.Constants;

public static class RomanUnits
{
    public const string House = "Ro_Bldg_House";
    public const string Fortress = "Ro_Bldg_Fortress";
    public const string TownCenter = "Ro_Bldg_TownCenter";
    public const string Castellum = "Ro_Bldg_Barracks";
    public const string AuxiliaCamp = "Ro_Bldg_AuxiliaCamp";
    public const string Praetorium = "Ro_Bldg_OfficerTent";
    public const string SiegeWorkshop = "Ro_Bldg_SiegeWorkshop";
    public const string Armory = "Ro_Bldg_Armory";
    public const string Farm = "Ro_Bldg_Farm";
    public const string Storehouse = "Ro_Bldg_StoreHouse";
    public const string Forum = "Ro_Bldg_Forum";
    public const string Market = "Ro_Bldg_Market";
    public const string Templum = "Ro_Bldg_Templum";
    public const string GuardTower = "Ro_Bldg_GuardTower";
    public const string Wall = "Ro_WallConnector";
    public const string Gate = "Ro_WallGate";
    public const string Dock = "Ro_Bldg_Dock";
    public const string WatchPost = "Ro_Bldg_LookoutTower";
    public const string Wonder = "Ro_Bldg_Wonder";
    public const string Villager = "Ro_Civ_Villager";
    public const string Engineer = "Ro_Civ_Engineer";
    public const string Clinicus = "Ro_Spc_Clinicus";
    public const string Caravan = "Ro_Civ_Caravan";
    public const string FishingBoat = "Ro_Civ_FishingBoat";
    public const string MerchantTransport = "Ro_Civ_UtilityBoat";
    public const string Liburnian = "Ro_Shp_Liburnian";
    public const string Enneris = "Ro_Shp_Enneris";
    public const string Spearman = "Ro_Inf_Spearman";
    public const string Legionary = "Ro_Inf_Legionary";
    public const string Eques = "Ro_Cav_Eques";
    public const string BalearicSlinger = "Ro_Arc_Slinger";
    public const string CretanBowman = "Ro_Arc_Bowman";
    public const string GallicHorseman = "Ro_Cav_Horseman";
    public const string Aquilifer = "Ro_Inf_Aquilifer";
    public const string Centurion = "Ro_Inf_Centurion";
    public const string Decurion = "Ro_Cav_Decurion";
    public const string PrimusPilus = "Ro_Cav_PrimusPilus";
    public const string BatteringRam = "Ro_Sie_BatteringRam";
    public const string Scorpio = "Ro_Sie_Scorpio";
    public const string Onager = "Ro_Sie_Onager";
    public const string Palintonon = "Ro_Sie_Palintonon";
    public const string Pontifex = "Ro_Spc_Priest";
    public const string Scout = "Ro_Cav_Scout";
    public const string Millarium = "Ro_Bldg_Millarium";
    private static BasicList<PermissionsModel> _permissions = [];
    static RomanUnits()
    {
        _permissions =
        [
            new PermissionsModel(){ TechName="Ro_Ct_BldgBarracks1", MainGroup=UnitGroupConstants.Barracks, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitSpearman1", MainGroup=UnitGroupConstants.Infantry, MainRole=UnitGroupConstants.Spearman, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitLegionary1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitEques1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgAuxiliaCamp1", MainGroup=UnitGroupConstants.ArcheryRange, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitSlinger1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitBowman1", MainGroup=UnitGroupConstants.Archer, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitHorseman1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgOfficerTent1", MainGroup=UnitGroupConstants.Stables, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitDecurion1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitCenturion1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitAquilifer1", MainGroup=UnitGroupConstants.Infantry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitPrimusPilus1", MainGroup=UnitGroupConstants.Cavalry, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgSiegeWorkshop1", MainGroup=UnitGroupConstants.SiegeWorkshop, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitBatteringRam1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.BatteringRam, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitScorpio1", MainGroup=UnitGroupConstants.Siege, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitOnager1", MainGroup=UnitGroupConstants.Siege, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgFortress1", MainGroup=UnitGroupConstants.Fortress, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitPalintonon1", MainGroup=UnitGroupConstants.Siege, MainRole=UnitGroupConstants.Palintonon, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgStorehouse1", MainGroup=UnitGroupConstants.Storehouse, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_BldgFarm1", MainGroup=UnitGroupConstants.Farm, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_BldgDock1", MainGroup=UnitGroupConstants.Dock, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitFishingBoat1", MainGroup=UnitGroupConstants.FishingBoat, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitMerchantTransport1", MainGroup=UnitGroupConstants.MerchantTransport, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitLiburnian1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitEnneris1", MainGroup=UnitGroupConstants.Ship, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgHouse1", MainGroup=UnitGroupConstants.House, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_BldgMarket1", MainGroup=UnitGroupConstants.Market, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitCaravan1", MainGroup=UnitGroupConstants.Caravan, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgTownCenter1", MainGroup=UnitGroupConstants.TownCenter, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitVillager1", MainGroup=UnitGroupConstants.Villager, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_UnitEngineer1", MainGroup=UnitGroupConstants.Unit, Exception=true, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgMillarium1", MainGroup=UnitGroupConstants.Building, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_BldgWonder1", MainGroup=UnitGroupConstants.Wonder, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_BldgArmory1", MainGroup=UnitGroupConstants.Armory, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_BldgForum1", MainGroup=UnitGroupConstants.Academy, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitClinicus1", MainGroup=UnitGroupConstants.Priest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgTemplum1", MainGroup=UnitGroupConstants.Temple, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitPriest1", MainGroup=UnitGroupConstants.Priest, MainRole=OptionalUnitGroupConstants.ConvertingPriest, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgWatchPost1", MainGroup=UnitGroupConstants.WatchPost, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_UnitScout1", MainGroup=UnitGroupConstants.Scout, Category=EnumPermissionCategory.Unit },
        new PermissionsModel(){ TechName="Ro_Ct_BldgGuardTower1", MainGroup=UnitGroupConstants.GuardTower, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="Ro_Ct_BldgWall1", MainGroup=UnitGroupConstants.Wall, Category=EnumPermissionCategory.Building },
        new PermissionsModel(){ TechName="RomanCapAge3", PreviousAge=2, Category=EnumPermissionCategory.AgeUpTech },
        new PermissionsModel(){ TechName="RomanCapAge4", PreviousAge=3, Category=EnumPermissionCategory.AgeUpTech }
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
            Templum,
            Forum,
            Castellum,
            Market,
            Armory,
            Praetorium,
            AuxiliaCamp,
            Wonder,
            Storehouse,
            SiegeWorkshop,
            Millarium
        ];
    }
    public static BasicList<string> GetOfficers()
    {
        return
        [
            Aquilifer,
            Decurion,
            PrimusPilus,
            Centurion
        ];
    }
    public static BasicList<string> GetAllExceptWalls()
    {
        return
        [
            House,
            Fortress,
            TownCenter,
            Castellum,
            AuxiliaCamp,
            Praetorium,
            SiegeWorkshop,
            Armory,
            Farm,
            Storehouse,
            Forum,
            Market,
            Templum,
            GuardTower,
            Dock,
            WatchPost,
            Wonder,
            Villager,
            Engineer,
            Clinicus,
            Caravan,
            FishingBoat,
            MerchantTransport,
            Liburnian,
            Enneris,
            Spearman,
            Legionary,
            Eques,
            BalearicSlinger,
            CretanBowman,
            GallicHorseman,
            Aquilifer,
            Centurion,
            Decurion,
            PrimusPilus,
            BatteringRam,
            Scorpio,
            Onager,
            Palintonon,
            Pontifex,
            Scout,
            Millarium
        ];
    }
}