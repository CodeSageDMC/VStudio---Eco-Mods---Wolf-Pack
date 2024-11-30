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
    /// <para>Server side recipe definition for "CottonCarpet".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(TailoringSkill), 4)]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Cotton Carpet Item")]
    public partial class CottonCarpetRecipe : RecipeFamily
    {
        public CottonCarpetRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CottonCarpet",  //noloc
                displayName: Localizer.DoStr("Cotton Carpet"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(EpoxyItem), 1, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),
                    new IngredientElement(typeof(CottonFabricItem), 3, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),
                    new IngredientElement("WoodBoard", 4, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<CottonCarpetItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1.5f; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(180, typeof(TailoringSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CottonCarpetRecipe), start: 0.64f, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Cotton Carpet"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Cotton Carpet"), recipeType: typeof(CottonCarpetRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(AdvancedTailoringTableObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [Solid, Wall, Constructed,BuildRoomMaterialOption]
    [BlockTier(5)]
    [RequiresSkill(typeof(TailoringSkill), 4)]
        public partial class CottonCarpetBlock :
        Block
        , IRepresentsItem
    {
        public virtual Type RepresentedItemType { get { return typeof(CottonCarpetItem); } }
    }

    [Serialized]
    [LocDisplayName("Cotton Carpet")]
    [LocDescription("A woven cotton floor covering attached to a lumber backing.")]
    [MaxStackSize(20)]
    [Weight(10000)]
    [Ecopedia("Blocks", "Building Materials", createAsSubPage: true)]
    [Tag("Constructable")]
    [Tier(5)]
    public partial class CottonCarpetItem :
 
    BlockItem<CottonCarpetBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Cotton Carpet"); } }


        private static Type[] blockTypes = new Type[] {
            typeof(CottonCarpetStacked1Block),
            typeof(CottonCarpetStacked2Block),
            typeof(CottonCarpetStacked3Block),
            typeof(CottonCarpetStacked4Block)
        };
        
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class CottonCarpetStacked1Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class CottonCarpetStacked2Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class CottonCarpetStacked3Block : PickupableBlock, IWaterLoggedBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid,Wall] public class CottonCarpetStacked4Block : PickupableBlock, IWaterLoggedBlock { } //Only a wall if it's all 4 CottonCarpet
}
