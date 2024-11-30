// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Hewn Log Recipe 25x 3x Output

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
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.SharedTypes;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.World.Water;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;


	// Hewn Logs on the Carpentry Table 
    [RequiresSkill(typeof(LoggingSkill), 3)]	// 1
    public partial class HewnLogsBulkRecipe : RecipeFamily
    {
        public HewnLogsBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "HewnLogsBulk",  //noloc
                displayName: Localizer.DoStr("Hewn Logs Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(DowelItem), 50,typeof(LoggingSkill)),	// 2 x 25
                    new IngredientElement("Wood", 50, typeof(LoggingSkill)), //noloc	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HewnLogItem>(75),	// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f;	// 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(LoggingSkill));	// 20 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(HewnLogsBulkRecipe), start: 4f, skillType: typeof(LoggingSkill));	// 0.16 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Hewn Logs Bulk"), recipeType: typeof(HewnLogsBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(LoggingSkill), 3)]	// 1
    [ForceCreateView]
    public partial class HewnHardwoodBulkRecipe : Recipe
    {
        public HewnHardwoodBulkRecipe()
        {
            this.Init(
                name: "HewnHardwoodBulk",  //noloc
                displayName: Localizer.DoStr("Hewn Hardwood Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(DowelItem), 50,typeof(LoggingSkill)),	// 2 x 25
                    new IngredientElement("Hardwood", 50, typeof(LoggingSkill)), //noloc	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HardwoodHewnLogItem>(75),	// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CarpentryTableObject), typeof(HewnLogsBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(LoggingSkill), 3)]	// 1
    [ForceCreateView]
    public partial class HewnSoftwoodBulkRecipe : Recipe
    {
        public HewnSoftwoodBulkRecipe()
        {
            this.Init(
                name: "HewnSoftwoodBulk",  //noloc
                displayName: Localizer.DoStr("Hewn Softwood Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(DowelItem), 50,typeof(LoggingSkill)),	// 2 x 25
                    new IngredientElement("Softwood", 50, typeof(LoggingSkill)), //noloc	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SoftwoodHewnLogItem>(75),	// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CarpentryTableObject), typeof(HewnLogsBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}
