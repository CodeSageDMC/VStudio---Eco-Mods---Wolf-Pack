// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10 x with 2x output

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
    [Ecopedia("Items", "Products", subPageName: "Valve Item Small Bulk")]
    public partial class ValveBulkRecipe : RecipeFamily
    {
        public ValveBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ValveSmallBulk",  //noloc
                displayName: Localizer.DoStr("Valve Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelPipeItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 4 x 10
                    new IngredientElement(typeof(SteelPlateItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 4 x 10
                    new IngredientElement(typeof(SteelGearboxItem), 1f*BulkRecipeSettings.SmallBulkMultiplier, true),	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ValveItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4f*BulkRecipeSettings.SmallBulkMultiplier; // 4 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(60f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill));	// 60 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ValveBulkRecipe), start: 3f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));	// 3 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Valve Small Bulk"), recipeType: typeof(ValveBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ElectricMachinistTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}