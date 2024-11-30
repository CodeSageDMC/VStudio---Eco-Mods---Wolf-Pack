// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x Output

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Shared.Networking;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.Core.Utils;
	using Eco.Gameplay.Components.Storage;
    using static Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(ElectronicsSkill), 7)]	// 5
    [Ecopedia("Crafted Objects", "Power Generation", subPageName: "Wind Turbine Item Small Bulk")]
    public partial class WindTurbineBulkRecipe : RecipeFamily
    {
        public WindTurbineBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WindTurbineSmallBulk",  //noloc
                displayName: Localizer.DoStr("Wind Turbine Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelPlateItem), 8f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),			// 8 x 10
                    new IngredientElement(typeof(SteelGearboxItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),			// 4 x 10
                    new IngredientElement(typeof(AdvancedCircuitItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),	// 4 x 10
                    new IngredientElement(typeof(ServoItem), 8f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),			// 8 x 10
                    new IngredientElement(typeof(LubricantItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),			// 8 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WindTurbineItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 15f*BulkRecipeSettings.SmallBulkMultiplier; // 15 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(1200f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill));	// 1200 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WindTurbineBulkRecipe), start: 20f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));	// 20 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Wind Turbine Small Bulk"), recipeType: typeof(WindTurbineBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RoboticAssemblyLineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
