using Flax.Build;

public class PhysicsFeaturesTourTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("PhysicsFeaturesTour");
    }
}
