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

    [RequiresSkill(typeof(TailoringSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Linen Fabric Item Small Bulk")]
    public partial class LinenFabricBulkRecipe : RecipeFamily
    {
        public LinenFabricBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "LinenFabricSmallBulk",  //noloc
                displayName: Localizer.DoStr("Linen Fabric Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LinenYarnItem), 40, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),	// 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<LinenFabricItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1000, typeof(TailoringSkill));		// 100 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(LinenFabricBulkRecipe), start: 10, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Linen Fabric Small Bulk"), recipeType: typeof(LinenFabricBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(LoomObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
    
    [RequiresSkill(typeof(TailoringSkill), 3)]	// 1
    public partial class WeaveLinenFabricBulkRecipe : RecipeFamily
    {
        public WeaveLinenFabricBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WeaveLinenFabricBulk",  //noloc
                displayName: Localizer.DoStr("Weave Linen Fabric Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LinenYarnItem), 100, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<LinenFabricItem>(150),	// 2 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2000, typeof(TailoringSkill));	// 80 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WeaveLinenFabricBulkRecipe), start: 25, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));	// 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Weave Linen Fabric Bulk"), recipeType: typeof(WeaveLinenFabricBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AutomaticLoomObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}