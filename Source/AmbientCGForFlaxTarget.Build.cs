using Flax.Build;

public class AmbientCGForFlaxTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("AmbientCGForFlax");
    }
}
