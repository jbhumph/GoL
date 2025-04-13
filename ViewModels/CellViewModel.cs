using ReactiveUI;

namespace GoL.ViewModels;

public class CellViewModel : ReactiveObject
{
    private bool _isAlive;
    public bool IsAlive
    {
        get => _isAlive;
        set => this.RaiseAndSetIfChanged(ref _isAlive, value);
    }
}