// Farmers Table Tree Seeds

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using System.ComponentModel;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(LoggingSkill), 1)]
    public partial class CedarSeedRecipe : RecipeFamily
    {
        public CedarSeedRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CedarSeed",  //noloc
                displayName: Localizer.DoStr("Cedar Seed"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CedarLogItem), 1, typeof(LoggingSkill)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CedarSeedItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(25, typeof(LoggingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CedarSeedRecipe), start: 0.5f, skillType: typeof(LoggingSkill), typeof(LoggingToolEfficiencyTalent), typeof(LoggingToolStrengthTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr(" Cedar Seed"), recipeType: typeof(CedarSeedRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FarmersTableObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
