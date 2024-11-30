// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x 1.5x output

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
    [Ecopedia("Items", "Products", subPageName: "Wooden Gear Bulk Item")]
    public partial class WoodenGearBulkRecipe : RecipeFamily
    {
        public WoodenGearBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WoodenGearTinyBulk",  //noloc
                displayName: Localizer.DoStr("Wooden Gear Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("HewnLog", 4f*BulkRecipeSettings.TinyBulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)), // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodenGearItem>(1f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkOutput)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.TinyBulkMultiplier; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(40f*BulkRecipeSettings.TinyBulkMultiplier, typeof(BasicEngineeringSkill));  // 40 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WoodenGearBulkRecipe), start: 2f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkCraft, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));  // 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Wooden Gear Tiny Bulk"), recipeType: typeof(WoodenGearBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}