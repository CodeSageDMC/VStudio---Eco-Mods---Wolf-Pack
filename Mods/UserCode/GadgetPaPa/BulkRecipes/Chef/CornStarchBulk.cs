// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Bulk Recipe 25x 3x output

namespace Eco.Mods.TechTree
{
    using System.ComponentModel;
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

    [RequiresSkill(typeof(BiochemistSkill), 1)]  // 1
    [Ecopedia("Food", "Ingredients", subPageName: "Corn Starch Bulk Item")]
    public partial class CornStarchBulkRecipe : RecipeFamily
    {
        public CornStarchBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CornStarchBulk",  //noloc
                displayName: Localizer.DoStr("Corn Starch Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CornItem), 250, typeof(BiochemistSkill), typeof(BiochemistLavishResourcesTalent)),  // 10 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CornStarchItem>(75)  // 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // 1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(375, typeof(BiochemistSkill));  // 15 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CornStarchBulkRecipe), start: 200, skillType: typeof(BiochemistSkill), typeof(BiochemistFocusedSpeedTalent), typeof(BiochemistParallelSpeedTalent));  // 8 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Corn Starch Bulk"), recipeType: typeof(CornStarchBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ChemicalLaboratoryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}