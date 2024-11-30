// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 25x with 3x output 

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

    [RequiresSkill(typeof(GlassworkingSkill), 4)]	// 2
    [Ecopedia("Items", "Products", subPageName: "Light Bulb Item Bulk")]
    public partial class LightBulbBulkRecipe : RecipeFamily
    {
        public LightBulbBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "LightBulbBulk",  //noloc
                displayName: Localizer.DoStr("Light BulbBulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GlassItem), 50, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),			// 2 x 25
                    new IngredientElement(typeof(CopperWiringItem), 150, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),	// 6 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<LightBulbItem>(75)	// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 50; // 2 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1500, typeof(GlassworkingSkill));	// 60 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(LightBulbBulkRecipe), start: 50, skillType: typeof(GlassworkingSkill), typeof(GlassworkingFocusedSpeedTalent), typeof(GlassworkingParallelSpeedTalent));	// 2 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Light Bulb Bulk"), recipeType: typeof(LightBulbBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(GlassworksObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}