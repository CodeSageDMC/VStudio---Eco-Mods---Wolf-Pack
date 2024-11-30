// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x with 1.5x Output

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

        
    [RequiresSkill(typeof(BasicEngineeringSkill), 3)]  // 1
    [Ecopedia("Items", "Products", subPageName: "Wooden Wheel Tiny Bulk Item")]
    public partial class WoodenWheelBulkRecipe : RecipeFamily
    {
        public WoodenWheelBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WoodenWheelTinyBulk",  //noloc
                displayName: Localizer.DoStr("Wooden Wheel Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("HewnLog", 4f*BulkRecipeSettings.TinyBulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)), // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodenWheelItem>(1f*BulkRecipeSettings.TinyBulkMultiplier)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.TinyBulkMultiplier; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(40f*BulkRecipeSettings.TinyBulkMultiplier, typeof(BasicEngineeringSkill));  // 40 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WoodenWheelBulkRecipe), start: 2f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkCraft, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));  // 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Wooden Wheel Tiny Bulk"), recipeType: typeof(WoodenWheelBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(WainwrightTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}