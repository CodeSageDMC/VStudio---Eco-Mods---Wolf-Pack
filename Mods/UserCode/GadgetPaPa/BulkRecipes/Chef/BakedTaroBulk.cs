// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Small Bulk 10x 2x output

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
    using Eco.Shared.Time;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(BakingSkill), 3)]  // 1
    [Ecopedia("Food", "Baking", subPageName: "Baked Taro Small BulkItem")]
    public partial class BakedTaroBulkRecipe : RecipeFamily
    {
        public BakedTaroBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BakedTaroSmallBulk",  //noloc
                displayName: Localizer.DoStr("Baked Taro Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(TaroRootItem), 40, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),  // 4 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BakedTaroItem>(20)  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(BakingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BakedTaroBulkRecipe), start: 20, skillType: typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));  // 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Baked Taro Small Bulk"), recipeType: typeof(BakedTaroBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BakeryOvenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}