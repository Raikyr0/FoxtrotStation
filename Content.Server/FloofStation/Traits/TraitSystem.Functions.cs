using Content.Shared.Traits;
using JetBrains.Annotations;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.Manager;
using Content.Server.Body.Systems;
using Content.Server.Body.Components;
using Content.Shared.Body.Components;
using Content.Shared.Body.Prototypes;
using Content.Shared.HeightAdjust;
using System.Linq;

namespace Content.Server.FloofStation.Traits;

// Scales/modifies the size of the character using the Floofstation modified heightAdjustSystem function SetScale
public sealed partial class TraitSetScale : TraitFunction 
{
    [DataField]
    public float scale;
    
    public override void OnPlayerSpawn(EntityUid uid,
        IComponentFactory factory,
        IEntityManager entityManager,
        ISerializationManager serializationManager)
    { 
        entityManager.System<HeightAdjustSystem>().SetScale(uid, scale, restricted: false);
    }
}
