// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 25x with 3x output

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
    [Ecopedia("Housing Objects", "Lighting", subPageName: "Modern Street Light Item Bulk")]
    public partial class ModernStreetLightBulkRecipe : RecipeFamily
    {
        public ModernStreetLightBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ModernStreetLightBulk",  //noloc
                displayName: Localizer.DoStr("Modern Street Light Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelPlateItem), 6f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),		// 6 x 25
                    new IngredientElement(typeof(PlasticItem), 4f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),			// 4 x 25
                    new IngredientElement(typeof(CopperWiringItem), 6f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),		// 6 x 25
                    new IngredientElement(typeof(LightBulbItem), 1f*BulkRecipeSettings.BulkMultiplier, true),		// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ModernStreetLightItem>(1f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkOutput)	// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f*BulkRecipeSettings.BulkMultiplier; // 5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(120f*BulkRecipeSettings.BulkMultiplier, typeof(ElectronicsSkill));	// 120 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ModernStreetLightBulkRecipe), start: 6f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkCraft, skillType: typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));	// 6 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Modern Street Light Bulk"), recipeType: typeof(ModernStreetLightBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RoboticAssemblyLineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
