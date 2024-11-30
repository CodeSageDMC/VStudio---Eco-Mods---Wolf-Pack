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
    /// <para>Server side recipe definition for "AshlarSandstone".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(AdvancedMasonrySkill), 1)]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Ashlar Sandstone Item")]
    public partial class AshlarSandstoneRecipe : RecipeFamily
    {
        public AshlarSandstoneRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AshlarSandstone",  //noloc
                displayName: Localizer.DoStr("Ashlar Sandstone"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SandstoneItem), 20, typeof(AdvancedMasonrySkill), typeof(AdvancedMasonryLavishResourcesTalent)),
                    new IngredientElement(typeof(CementItem), 6, typeof(AdvancedMasonrySkill), typeof(AdvancedMasonryLavishResourcesTalent)),
                    new IngredientElement(typeof(SteelBarItem), 1, typeof(AdvancedMasonrySkill), typeof(AdvancedMasonryLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<AshlarSandstoneItem>(2),
                    new CraftingElement<CrushedSandstoneItem>(typeof(AdvancedMasonrySkill), 2, typeof(AdvancedMasonryLavishResourcesTalent)),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1.5f; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(180, typeof(AdvancedMasonrySkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AshlarSandstoneRecipe), start: 0.64f, skillType: typeof(AdvancedMasonrySkill), typeof(AdvancedMasonryFocusedSpeedTalent), typeof(AdvancedMasonryParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Ashlar Sandstone"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Ashlar Sandstone"), recipeType: typeof(AshlarSandstoneRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(AdvancedMasonryTableObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [Solid, Wall, Constructed,BuildRoomMaterialOption]
    [BlockTier(5)]
    [RequiresSkill(typeof(AdvancedMasonrySkill), 1)]
        public partial class AshlarSandstoneBlock :
        Block
        , IRepresentsItem
    {
        public virtual Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }

    [Serialized]
    [LocDisplayName("Ashlar Sandstone")]
    [LocDescription("Ashlar is finely cut stone made by an expert mason. Ashlar stone is an especially decorative building material that comes in a variety of styles based on the type of rock used.")]
    [MaxStackSize(20)]
    [Weight(10000)]
    [Ecopedia("Blocks", "Building Materials", createAsSubPage: true)]
    [Tag("AshlarStone")]
    [Tag("Constructable")]
    [Tier(5)]
    public partial class AshlarSandstoneItem :
 
    BlockItem<AshlarSandstoneBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Ashlar Sandstone"); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
            typeof(AshlarSandstoneStacked1Block),
            typeof(AshlarSandstoneStacked2Block),
            typeof(AshlarSandstoneStacked3Block),
            typeof(AshlarSandstoneStacked4Block)
        };
        
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Tag("AshlarStone")]
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class AshlarSandstoneStacked1Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("AshlarStone")]
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class AshlarSandstoneStacked2Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("AshlarStone")]
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class AshlarSandstoneStacked3Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("AshlarStone")]
    [Tag("Constructable")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid,Wall] public class AshlarSandstoneStacked4Block : PickupableBlock, IWaterLoggedBlock { } //Only a wall if it's all 4 AshlarSandstone
}
