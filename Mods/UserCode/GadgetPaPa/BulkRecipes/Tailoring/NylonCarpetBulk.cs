// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// 

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

    [RequiresSkill(typeof(TailoringSkill), 6)]		// 4
    [Ecopedia("Blocks", "Building Materials", subPageName: "Nylon Carpet Bulk Item")]
    public partial class NylonCarpetBulkRecipe : RecipeFamily
    {
        public NylonCarpetBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "NylonCarpetBulk",  //noloc
                displayName: Localizer.DoStr("Nylon Carpet Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement(typeof(NylonFabricItem), 75, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),	// 3 x 25
                    new IngredientElement("WoodBoard", 100, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)), //noloc		// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<NylonCarpetItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 37.5f;	// 1.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(4500, typeof(TailoringSkill));	// 180 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(NylonCarpetBulkRecipe), start: 16f, skillType: typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));	// 0.64 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Nylon Carpet Bulk"), recipeType: typeof(NylonCarpetBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AdvancedTailoringTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
