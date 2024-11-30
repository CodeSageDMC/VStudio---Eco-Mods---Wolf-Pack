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
    /// <para>Server side recipe definition for "CompositeFirLumber".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(CompositesSkill), 1)]
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Fir Lumber Item")]
    public partial class CompositeFirLumberRecipe : Recipe
    {
        public CompositeFirLumberRecipe()
        {
            this.Init(
                name: "CompositeFirLumber",  //noloc
                displayName: Localizer.DoStr("Composite Fir Lumber"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FirLogItem), 1, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),
                    new IngredientElement(typeof(PlasticItem), 1, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),
                    new IngredientElement(typeof(EpoxyItem), 1, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),
                    new IngredientElement("WoodBoard", 4, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeFirLumberItem>()
                });
            // Perform post initialization steps for user mods and initialize our recipe instance as a tag product with the crafting system
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberRecipe), this);
        }


        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [Solid, Wall, Constructed]
    [BlockTier(5)]
    [RequiresSkill(typeof(CompositesSkill), 1)]
        public partial class CompositeFirLumberBlock :
        Block
        , IRepresentsItem
    {
        public virtual Type RepresentedItemType { get { return typeof(CompositeFirLumberItem); } }
    }

    [Serialized]
    [LocDisplayName("Composite Fir Lumber")]
    [LocDescription("A composite lumber made from a combination of wood and plastic.")]
    [MaxStackSize(20)]
    [Weight(10000)]
    [Ecopedia("Blocks", "Building Materials", createAsSubPage: true)]
    [Tag("CompositeLumber")]
    [Tag("SoftwoodLumber")]
    [Tag("Constructable")]
    [Tier(5)]
    public partial class CompositeFirLumberItem :
 
    BlockItem<CompositeFirLumberBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Composite Fir Lumber"); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
            typeof(CompositeFirLumberStacked1Block),
            typeof(CompositeFirLumberStacked2Block),
            typeof(CompositeFirLumberStacked3Block),
            typeof(CompositeFirLumberStacked4Block)
        };
        
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Tag("CompositeLumber")]
    [Tag("SoftwoodLumber")]
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class CompositeFirLumberStacked1Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("CompositeLumber")]
    [Tag("SoftwoodLumber")]
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class CompositeFirLumberStacked2Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("CompositeLumber")]
    [Tag("SoftwoodLumber")]
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class CompositeFirLumberStacked3Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("CompositeLumber")]
    [Tag("SoftwoodLumber")]
    [Tag("Constructable")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid,Wall] public class CompositeFirLumberStacked4Block : PickupableBlock, IWaterLoggedBlock { } //Only a wall if it's all 4 CompositeFirLumber
}
