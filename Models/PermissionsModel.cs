namespace AOEOCivilizationLibrary.Models;
internal class PermissionsModel
{
    public string TechName { get; set; } = "";
    public string MainGroup { get; set; } = "";
    public string MainRole { get; set; } = "";
    public EnumPermissionCategory Category { get; set; } = EnumPermissionCategory.Unit;
    public bool Exception { get; set; }
    public int? PreviousAge { get; set; }
}