namespace AOEOCivilizationLibrary.Components;
public partial class ChooseCivComponent
{
    public static Func<BasicList<CivilizationBasicModel>, BasicList<CivilizationBasicModel>>? FilterAction { get; set; }
    [Inject]
    private IChooseCivViewModel? DataContext { get; set; }
    [Inject]
    public ICivilizationContext? CivilizationContext { get; set; } // i think this is the default.  if not, then i need to rethink this.
    [Parameter]
    public EventCallback<CivilizationBasicModel> ChoseCiv { get; set; }
    private readonly AutoCompleteStyleModel _autos = new();
    protected override async Task OnInitializedAsync()
    {
        _combo = null;
        _autos.Width = "90vw";
        _autos.Height = "50vh";
        await DataContext!.InitAsync();
        if (FilterAction is not null)
        {
            DataContext.Civilizations = FilterAction.Invoke(DataContext.Civilizations);
        }
    }
    private ComboBoxGenericList<CivilizationBasicModel>? _combo;
    private bool _focused;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (_focused == false && _combo is not null)
        {
            _focused = true;
            await _combo.TextReference!.Value.FocusAsync();
        }
    }
    private async Task OnComboEnterAsync()
    {
        CivilizationBasicModel? civ = DataContext!.CivilizationChosen ?? throw new CustomBasicException("Did not choose civ.  Rethink");
        DataContext.CivilizationChosen = null; //i think.
        if (civ == null)
        {
            throw new CustomBasicException("Cannot reset to null.  Rethink");
        }
        CivilizationContext!.CurrentCivilization = civ; //i think.
        await ChoseCiv.InvokeAsync(civ);
    }
}