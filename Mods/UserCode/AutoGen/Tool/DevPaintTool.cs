using Eco.Gameplay.Components;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items.Internal;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.World.Color;
using System.ComponentModel;

[Serialized]
[LocDisplayName("Dev Paint Tool")]
[LocDescription("Paint tool! It paints with some developer features.")]
[Category("Hidden")]
public class DevPaintToolItem : PaintToolItem, IAoeToolItem
{
    public override bool PaintBlock(Player player, InteractionTarget target, byte coat)
    {
        if (!target.BlockPosition.HasValue) return false;

        // For dev tool ignore laws and auth, so we just directly paint blocks
        var coatedColor = player.User.Avatar.ToolState.SelectedColor.WithAlpha(coat);
        BlockColorManager.Obj.SetColor(target.BlockPosition.Value, coatedColor);
        return true;
    }

    public override bool PaintWorldObject(Player player, InteractionTarget target, WorldObject worldObj, int channel, byte coat)
    {
        var paintable = worldObj?.GetComponent<PaintableComponent>();
        if (paintable == null) return false;

        var color = player.User.Avatar.ToolState.SelectedColor.WithAlpha(coat);
        paintable.SetColor(channel, color);
        return true;
    }

    public override bool ClearPaintWorldObject(Player player, InteractionTarget target, WorldObject worldObj, int channel)
    {
        var paintable = worldObj?.GetComponent<PaintableComponent>();
        if (paintable == null) return false;

        return paintable.ClearColor(channel);
    }

    public override bool ClearPaint(Player player, InteractionTarget target)
    {
        // For dev tool ignore laws and auth, so we just directly clear colors
        return target.BlockPosition.HasValue && BlockColorManager.Obj.ClearColor(target.BlockPosition.Value);
    }

    public AreaOfEffectMode AreaOfEffectMode => areaOfEffectMode;
    static readonly AreaOfEffectMode areaOfEffectMode = AOEFactory.Make("MultiBlock", true, "-2,0,0;-1,0,0;0,0,0;1,0,0;2,0,0;" +
                                                                                            "-2,0,1;-1,0,1;0,0,1;1,0,1;2,0,1;" +
                                                                                            "-2,0,2;-1,0,2;0,0,2;1,0,2;2,0,2;" +
                                                                                            "-2,0,3;-1,0,3;0,0,3;1,0,3;2,0,3;" +
                                                                                            "-2,0,4;-1,0,4;0,0,4;1,0,4;2,0,4", 0, 0, 0); //-1,0,0 = 1 block left, 0,1,0 = 1 block up, 0,0,1 = 1 block deep



}
