﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 25x with 3x output  & 10x with 2x Output

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

    [RequiresSkill(typeof(BasicEngineeringSkill), 3)]	// 1
    [Ecopedia("Crafted Objects", "Power Generation", subPageName: "Windmill Item Small Bulk")]
    public partial class WindmillSBulkRecipe : RecipeFamily
    {
        public WindmillSBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WindmillSmallBulk",  //noloc
                displayName: Localizer.DoStr("Windmill Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LinenFabricItem), 12f*BulkRecipeSettings.SmallBulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),	// 12 x 10
                    new IngredientElement(typeof(LubricantItem), 4f*BulkRecipeSettings.SmallBulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),  // 1 x 10
                    new IngredientElement("HewnLog", 15f*BulkRecipeSettings.SmallBulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)), //noloc			// 15 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<WindmillItem>(1f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkOutput)		// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 8f*BulkRecipeSettings.SmallBulkMultiplier; // 8 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(180f*BulkRecipeSettings.SmallBulkMultiplier, typeof(BasicEngineeringSkill));	// 180 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WindmillSBulkRecipe), start: 5f*BulkRecipeSettings.SmallBulkMultiplier*BulkRecipeSettings.SmallBulkCraft, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));	// 5 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Windmill Small Bulk"), recipeType: typeof(WindmillSBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(BasicEngineeringSkill), 4)]	// 1
    [Ecopedia("Crafted Objects", "Power Generation", subPageName: "Windmill Item Bulk")]
    public partial class WindmillBulkRecipe : RecipeFamily
    {
        public WindmillBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WindmillBulk",  //noloc
                displayName: Localizer.DoStr("Windmill Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LinenFabricItem), 12f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),	// 12 x 25
                    new IngredientElement(typeof(LubricantItem), 4f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),  // 1 x 25
                    new IngredientElement("HewnLog", 15f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)), //noloc			// 15 x 25
				},
                items: new List<CraftingElement>
                {
                    new CraftingElement<WindmillItem>(1f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkOutput)		// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 8f*BulkRecipeSettings.BulkMultiplier; // 8 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(180f*BulkRecipeSettings.BulkMultiplier, typeof(BasicEngineeringSkill));	// 180 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(WindmillBulkRecipe), start: 5f*BulkRecipeSettings.BulkMultiplier*BulkRecipeSettings.BulkCraft, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));	// 5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Windmill Bulk"), recipeType: typeof(WindmillBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
