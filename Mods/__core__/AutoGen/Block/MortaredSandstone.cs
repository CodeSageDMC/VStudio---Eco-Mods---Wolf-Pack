﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from BlockTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.SharedTypes;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.World.Water;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Shared.Graphics;
    using Eco.World.Color;

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>

    /// <summary>
    /// <para>Server side recipe definition for "MortaredSandstone".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(MasonrySkill), 1)]
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Mortared Sandstone Item")]
    public partial class MortaredSandstoneRecipe : Recipe
    {
        public MortaredSandstoneRecipe()
        {
            this.Init(
                name: "MortaredSandstone",  //noloc
                displayName: Localizer.DoStr("Mortared Sandstone"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SandstoneItem), 4, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),
                    new IngredientElement(typeof(MortarItem), 1, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<MortaredSandstoneItem>()
                });
            // Perform post initialization steps for user mods and initialize our recipe instance as a tag product with the crafting system
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(MasonryTableObject), typeof(MortaredStoneRecipe), this);
        }


        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [Solid, Wall, Constructed,BuildRoomMaterialOption]
    [BlockTier(2)]
    [RequiresSkill(typeof(MasonrySkill), 1)]
        public partial class MortaredSandstoneBlock :
        Block
        , IRepresentsItem
    {
        public virtual Type RepresentedItemType { get { return typeof(MortaredSandstoneItem); } }
    }

    [Serialized]
    [LocDisplayName("Mortared Sandstone")]
    [LocDescription("Used to create tough but rudimentary buildings.")]
    [MaxStackSize(15)]
    [Weight(10000)]
    [Ecopedia("Blocks", "Building Materials", createAsSubPage: true)]
    [Tag("MortaredStone")]
    [Tag("Constructable")]
    [Tier(2)]
    public partial class MortaredSandstoneItem :
 
    BlockItem<MortaredSandstoneBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Mortared Sandstone"); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
            typeof(MortaredSandstoneStacked1Block),
            typeof(MortaredSandstoneStacked2Block),
            typeof(MortaredSandstoneStacked3Block)
        };
        
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Tag("MortaredStone")]
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class MortaredSandstoneStacked1Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("MortaredStone")]
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class MortaredSandstoneStacked2Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("MortaredStone")]
    [Tag("Constructable")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid,Wall] public class MortaredSandstoneStacked3Block : PickupableBlock, IWaterLoggedBlock { } //Only a wall if it's all 4 MortaredSandstone
}