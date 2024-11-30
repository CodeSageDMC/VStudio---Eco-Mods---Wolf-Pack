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

    [RequiresModule(typeof(MachinistTableObject))]
    [RequiresSkill(typeof(MechanicsSkill), 3)]	// 1
    [Ecopedia("Items", "Products", subPageName: "Gearbox Item Small Bulk")]
    public partial class GearboxBulkRecipe : RecipeFamily
    {
        public GearboxBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "GearboxBulk",  //noloc
                displayName: Localizer.DoStr("Gearbox Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 2f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 2 x 10
                    new IngredientElement(typeof(IronGearItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),	// 4 x 10
                    new IngredientElement(typeof(LubricantItem), 1f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GearboxItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2f*BulkRecipeSettings.SmallBulkMultiplier; // 2 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(45f*BulkRecipeSettings.SmallBulkMultiplier, typeof(MechanicsSkill));	// 45 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(GearboxBulkRecipe), start: 1.5f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));	// 1.5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Gearbox Small Bulk"), recipeType: typeof(GearboxBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ShaperObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}