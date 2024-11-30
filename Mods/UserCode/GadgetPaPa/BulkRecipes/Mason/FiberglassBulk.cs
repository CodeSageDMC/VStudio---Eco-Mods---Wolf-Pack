// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// 

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
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

        
    [RequiresSkill(typeof(GlassworkingSkill), 3)]  // 1
    [Ecopedia("Items", "Products", subPageName: "Fiberglass Bulk Item")]
    public partial class FiberglassBulkRecipe : RecipeFamily
    {
        public FiberglassBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Fiberglass Bulk",  //noloc
                displayName: Localizer.DoStr("Fiberglass Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PlasticItem), 100, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),	// 4 x 25
                    new IngredientElement(typeof(GlassItem), 50, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),		// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FiberglassItem>(75),  // 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; 	// 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2250, typeof(GlassworkingSkill));	// 90 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FiberglassBulkRecipe), start: 50, skillType: typeof(GlassworkingSkill), typeof(GlassworkingFocusedSpeedTalent), typeof(GlassworkingParallelSpeedTalent));	// 2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Fiberglass Bulk"), recipeType: typeof(FiberglassBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectronicsAssemblyObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}