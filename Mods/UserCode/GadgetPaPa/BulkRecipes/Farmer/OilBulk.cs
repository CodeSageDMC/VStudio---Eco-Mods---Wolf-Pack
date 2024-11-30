// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 10x with 2x output,   Oil, Cotton Seed Oil & Sunflower Oil 

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(MillingSkill), 3)]	// 1
    [Ecopedia("Food", "Ingredients", subPageName: "Oil Item Small Bulk")]
    public partial class OilBulkRecipe : RecipeFamily
    {
        public OilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "OilSmallBulk",  //noloc
                displayName: Localizer.DoStr("Oil Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CerealGermItem), 80, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 8 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OilItem>(20)	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(MillingSkill));	// 15 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(OilBulkRecipe), start: 10, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Oil Small Bulk"), recipeType: typeof(OilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 6)]	// 4
    public partial class CottonseedOilBulkRecipe : RecipeFamily
    {
        public CottonseedOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CottonseedOilSmallBulk",  //noloc
                displayName: Localizer.DoStr("Cottonseed Oil Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CottonSeedItem), 160, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 16 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OilItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(400, typeof(MillingSkill));	// 40 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CottonseedOilBulkRecipe), start: 10, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Cottonseed Oil Small Bulk"), recipeType: typeof(CottonseedOilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 6)]	// 4
    public partial class SunflowerOilBulkRecipe : RecipeFamily
    {
        public SunflowerOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SunflowerOilSmallBulk",  //noloc
                displayName: Localizer.DoStr("Sunflower Oil Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SunflowerSeedItem), 160, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 16 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OilItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 0.5f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(MillingSkill));	// 20 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SunflowerOilBulkRecipe), start: 10, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Sunflower Oil Small Bulk"), recipeType: typeof(SunflowerOilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 6)]	// 4
    public partial class FishOilBulkRecipe : RecipeFamily
    {
        public FishOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FishOilSmallBulk",  //noloc
                displayName: Localizer.DoStr("Fish Oil Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawFishItem), 60, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),	// 6 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OilItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; // 0.5 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(MillingSkill));	// 20 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FishOilBulkRecipe), start: 10, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));	// 1 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Fish Oil Small Bulk"), recipeType: typeof(FishOilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(MillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

	// Bulk Industrial Mill Recipes below
    [RequiresSkill(typeof(MillingSkill), 3)]  // 1
    public partial class ProcessedOilBulkRecipe : RecipeFamily
    {
        public ProcessedOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedOilBulk",  //noloc
                displayName: Localizer.DoStr("Processed Oil Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CerealGermItem), 625, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 25 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OilItem>(300),  // 4 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1875, typeof(MillingSkill));  // 75 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedOilBulkRecipe), start: 12.5f, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 0.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Oil Bulk"), recipeType: typeof(ProcessedOilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 6)]  // 4
    public partial class ProcessedCottonseedOilBulkRecipe : RecipeFamily
    {
        public ProcessedCottonseedOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedCottonseedOilBulk",  //noloc
                displayName: Localizer.DoStr("Processed Cottonseed Oil Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CottonSeedItem), 325, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 13 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OilItem>(75),  // 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1875, typeof(MillingSkill));  // 75 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedCottonseedOilBulkRecipe), start: 12.5f, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 0.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Cottonseed Oil Bulk"), recipeType: typeof(ProcessedCottonseedOilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 6)]  // 4
    public partial class ProcessedSunflowerOilBulkRecipe : RecipeFamily
    {
        public ProcessedSunflowerOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedSunflowerOilBulk",  //noloc
                displayName: Localizer.DoStr("Processed Sunflower Oil Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SunflowerSeedItem), 300, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 12 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OilItem>(75),  // 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(MillingSkill));  // 100 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedSunflowerOilBulkRecipe), start: 25, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 1 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Sunflower Oil Bulk"), recipeType: typeof(ProcessedSunflowerOilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(MillingSkill), 6)]  // 4
    public partial class ProcessedFishOilBulkRecipe : RecipeFamily
    {
        public ProcessedFishOilBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ProcessedFishOilBulk",  //noloc
                displayName: Localizer.DoStr("Processed Fish Oil Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawFishItem), 125, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),  // 5 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<OilItem>(75),  // 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f; // 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(1875, typeof(MillingSkill));  // 75 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ProcessedFishOilBulkRecipe), start: 12.5f, skillType: typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));  // 0.5 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Processed Fish Oil Bulk"), recipeType: typeof(ProcessedFishOilBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(IndustrialMillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}