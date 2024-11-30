// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output

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
    [Ecopedia("Housing Objects", "Lighting", subPageName: "Modern Double Street Light Item Small Bulk")]
    public partial class ModernDoubleStreetLightSBulkRecipe : RecipeFamily
    {
        public ModernDoubleStreetLightSBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ModernDoubleStreetLightSBulk",  //noloc
                displayName: Localizer.DoStr("Modern Double Street Light Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelPlateItem), 8f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),		// 8 x 10
                    new IngredientElement(typeof(PlasticItem), 5f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),			// 5 x 10
                    new IngredientElement(typeof(CopperWiringItem), 10f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),	// 10 x 10
                    new IngredientElement(typeof(LightBulbItem), 2f*BulkRecipeSettings.SmallBulkMultiplier, true),		// 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ModernDoubleStreetLightItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f*BulkRecipeSettings.SmallBulkMultiplier; // 5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(140f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill));	// 140 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ModernDoubleStreetLightSBulkRecipe), start: 6f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));	// 6 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Modern Double Street Light Small Bulk"), recipeType: typeof(ModernDoubleStreetLightSBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RoboticAssemblyLineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
