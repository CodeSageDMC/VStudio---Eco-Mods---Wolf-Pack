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
    [Ecopedia("Food", "Baking", subPageName: "Baked Meat Small Bulk Item")]
    public partial class BakedMeatBulkRecipe : RecipeFamily
    {
        public BakedMeatBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BakedMeatSmallBulk",  //noloc
                displayName: Localizer.DoStr("Baked Meat Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawMeatItem), 20, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),  // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BakedMeatItem>(20)  // 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10; // 1 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(BakingSkill));  // 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BakedMeatBulkRecipe), start: 20, skillType: typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));  // 2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Baked Meat Small Bulk"), recipeType: typeof(BakedMeatBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BakeryOvenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}