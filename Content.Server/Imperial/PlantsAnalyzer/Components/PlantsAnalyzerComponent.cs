using Robust.Shared.Audio;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server.Imperial.PlantsAnalyzer.Components;

[RegisterComponent, AutoGenerateComponentPause]
[Access(typeof(PlantsAnalyzerSystem))]
public sealed partial class PlantsAnalyzerComponent : Component
{

    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer))]
    [AutoPausedField]
    public TimeSpan NextUpdate = TimeSpan.Zero;

    [DataField]
    public TimeSpan UpdateInterval = TimeSpan.FromSeconds(1);

    [DataField]
    public TimeSpan ScanDelay = TimeSpan.FromSeconds(0.8);

    [DataField]
    public EntityUid? ScannedEntity;

    [DataField]
    public float MaxScanRange = 2.5f;

    [DataField]
    public SoundSpecifier? ScanningBeginSound;

    [DataField]
    public SoundSpecifier ScanningEndSound = new SoundPathSpecifier("/Audio/Items/Medical/healthscanner.ogg");

    [DataField]
    public bool Silent;
}
