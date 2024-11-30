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

    [RequiresSkill(typeof(FarmingSkill), 4)]	// 2
    [Ecopedia("Items", "Products", subPageName: "Flax Fiber Item Bulk")]
    public partial class FlaxFiberBulkRecipe : RecipeFamily
    {
        public FlaxFiberBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FlaxFiberBulk",  //noloc
                displayName: Localizer.DoStr("Flax Fiber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FlaxStemItem), 75, typeof(FarmingSkill)),	// 3 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FlaxFiberItem>(75),			// 1 x 25 x 3
                    new CraftingElement<PlantFibersItem>(18.75f),		// 0.25 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f; // Defines how much experience is gained when crafted.		// 0.2 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(875, typeof(FarmingSkill));	// 35 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FlaxFiberBulkRecipe), start: 25, skillType: typeof(FarmingSkill));	// 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Flax Fiber Bulk"), recipeType: typeof(FlaxFiberBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FiberScutchingStationObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}