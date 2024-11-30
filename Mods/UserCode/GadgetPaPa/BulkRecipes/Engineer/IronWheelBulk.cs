// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Tiny Bulk Recipe 10x with 1.5x output

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

        
    [RequiresSkill(typeof(BasicEngineeringSkill), 5)]  // 3
    [Ecopedia("Items", "Products", subPageName: "Iron Wheel Tiny Bulk Item")]
    public partial class IronWheelBulkRecipe : RecipeFamily
    {
        public IronWheelBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronWheelTinyBulk",  //noloc
                displayName: Localizer.DoStr("Iron Wheel Tiny Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 6f*BulkRecipeSettings.TinyBulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),  // 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<IronWheelItem>(1f*BulkRecipeSettings.TinyBulkMultiplier)  // 1 x 10 x 1.5
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f*BulkRecipeSettings.TinyBulkMultiplier; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(100f*BulkRecipeSettings.TinyBulkMultiplier, typeof(BasicEngineeringSkill));  // 100 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronWheelBulkRecipe), start: 2f*BulkRecipeSettings.TinyBulkMultiplier*BulkRecipeSettings.TinyBulkCraft, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));  // 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Iron Wheel Tiny Bulk"), recipeType: typeof(IronWheelBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(WainwrightTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}