// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output

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

    [RequiresSkill(typeof(MechanicsSkill), 4)]	// 2
    [Ecopedia("Items", "Products", subPageName: "Servo Item Small Bulk")]
    public partial class ServoBulkRecipe : RecipeFamily
    {
        public ServoBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ServoSmallBulk",  //noloc
                displayName: Localizer.DoStr("Servo Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BasicCircuitItem), 2f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 2 x 10
                    new IngredientElement(typeof(FiberglassItem), 5f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 5 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ServoItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2f*BulkRecipeSettings.SmallBulkMultiplier; // 2 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(60f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill));	// 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ServoBulkRecipe), start: 3f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));	// 3 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Servo Small Bulk"), recipeType: typeof(ServoBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectricMachinistTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}