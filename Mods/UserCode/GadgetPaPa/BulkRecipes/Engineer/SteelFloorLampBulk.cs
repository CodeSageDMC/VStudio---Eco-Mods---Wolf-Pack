// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Small Bulk recipe 10x 2x output 

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

    [RequiresSkill(typeof(ElectronicsSkill), 4)]	// 2
    [Ecopedia("Housing Objects", "Lighting", subPageName: "Steel Floor Lamp Item Small Bulk")]
    public partial class SteelFloorLampBulkRecipe : RecipeFamily
    {
        public SteelFloorLampBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteelFloorLampSmallBulk",  //noloc
                displayName: Localizer.DoStr("Steel Floor Lamp Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelBarItem), 8f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),		// 8 x 10
                    new IngredientElement(typeof(PlasticItem), 6f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),		// 6 x 10
                    new IngredientElement(typeof(CopperWiringItem), 5f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),	// 5 x 10
                    new IngredientElement(typeof(LightBulbItem), 1f*BulkRecipeSettings.SmallBulkMultiplier, true),	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteelFloorLampItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f*BulkRecipeSettings.SmallBulkMultiplier; // 5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(120f*BulkRecipeSettings.SmallBulkMultiplier, typeof(ElectronicsSkill));	// 120 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteelFloorLampBulkRecipe), start: 4f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));	// 4 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steel Floor Lamp Small Bulk"), recipeType: typeof(SteelFloorLampBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(RoboticAssemblyLineObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
