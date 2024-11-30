// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
namespace Eco.Mods.TechTree
{
	using System.ComponentModel;
	using Eco.Core.Controller;
    using Eco.Core.Items;
	using Eco.Gameplay.DynamicValues;
	using Eco.Gameplay.Items;
	using Eco.Gameplay.Interactions.Interactors;
	using Eco.Gameplay.Players;
	using Eco.Gameplay.Systems.TextLinks;
	using Eco.Gameplay.Placement;
	using Eco.Gameplay.GameActions;
	using Eco.Shared.Localization;
	using Eco.Shared.Serialization;
	using Eco.Shared.Items;
	using Eco.Shared.SharedTypes;
	using Eco.Shared.Utils;
	using Eco.Shared.Math;
	using Eco.World.Blocks;
	using World = Eco.World.World;

	[Serialized]
    [LocDisplayName("Hammer")]
    [LocDescription("Used to construct buildings and pickup manmade objects.")]
    [Category("Hidden")]
    public abstract class HammerItem : BuildingToolItem
    {
        static IDynamicValue tier = new ConstantValue(0);
        static IDynamicValue caloriesBurn = new ConstantValue(1);
        private static IDynamicValue skilledRepairCost = new ConstantValue(1);
        
        public override IDynamicValue SkilledRepairCost             { get { return skilledRepairCost; } }
        [SyncToView] public override IDynamicValue Tier             => base.Tier; // tool tier, overriden to have SyncToView only for hammer
        public override IDynamicValue CaloriesBurn                  { get { return caloriesBurn; } }
        
        public override bool IsValidForInteraction(Item item)
        {
            var blockItem = item as BlockItem;
            return !(item is LogItem) && blockItem != null && Block.Is<Constructed>(blockItem.OriginType);
        }

        // Updated interaction method for quick removal with the E key
        [Interaction(InteractionTrigger.InteractKey, tags: "Constructable", canHoldToTrigger: TriBool.True, animationDriven: false)]
        public bool RemoveFastwithE(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target)
        {
            // Fallback if not enough room in carrying stack
            var carry = player.User.Carrying;
            if (MaxTake > 0 && carry.Quantity >= MaxTake)
            {
                player.ErrorLoc($"Can't dig while carrying {player.User.Carrying.UILink()}.");
                return false;
            }

            // Use "Constructable" as a string and fix the argument type
            var anyOtherBlocks = this.TryCreateMultiblockContext(
                out var otherContext,
                target,
                player,
                tagsTargetable: "Constructable",
                mustHaveTags: BlockTags.NonPlant.SingleItemAsEnumerable(),
                applyXPSkill: true
            );

            if (anyOtherBlocks)
            {
                using var pack = new GameActionPack();

                // Destroy all targeted blocks
                pack.DeleteBlock(otherContext, player?.User.Inventory);

                return pack.TryPerform(player.User).Success;
            }

            return false;
        }
    }
}
