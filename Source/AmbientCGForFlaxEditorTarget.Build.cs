using Flax.Build;

public class AmbientCGForFlaxEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("AmbientCGForFlax");
    }
}
