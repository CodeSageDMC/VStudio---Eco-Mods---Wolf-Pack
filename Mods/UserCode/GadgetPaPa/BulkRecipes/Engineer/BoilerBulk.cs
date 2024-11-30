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

    [RequiresModule(typeof(ShaperObject))]
    [RequiresSkill(typeof(MechanicsSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Boiler Item Small Bulk")]
    public partial class BoilerSBulkRecipe : RecipeFamily
    {
        public BoilerSBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BoilerSmallBulk",  //noloc
                displayName: Localizer.DoStr("Boiler Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronPlateItem), 15f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 15 x 10
                    new IngredientElement(typeof(ScrewsItem), 10f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),		// 10 x 10
                    new IngredientElement(typeof(CopperPlateItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BoilerItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3f*BulkRecipeSettings.SmallBulkMultiplier; // 3 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(180f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill));		// 180 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BoilerSBulkRecipe), start: 2f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));	// 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Boiler Small Bulk"), recipeType: typeof(BoilerSBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MachinistTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}