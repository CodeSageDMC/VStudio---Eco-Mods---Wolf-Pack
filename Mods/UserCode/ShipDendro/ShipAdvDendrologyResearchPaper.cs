
namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(ShipwrightSkill), 1)]
    public partial class DendrologyResearchPaperAdvancedHullRecipe : RecipeFamily
    {
        public DendrologyResearchPaperAdvancedHullRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "DendrologyResearchPaperAdvancedHull",  //noloc
                displayName: Localizer.DoStr("Dendrology Research Paper Advanced Hull"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(WoodenHullPlanksItem), 6, typeof(ShipwrightSkill), typeof(ShipwrightLavishResourcesTalent)),
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<DendrologyResearchPaperAdvancedItem>(1),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 6; 
            
            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(ShipwrightSkill));

            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DendrologyResearchPaperAdvancedHullRecipe), start: 1, skillType: typeof(ShipwrightSkill), typeof(ShipwrightFocusedSpeedTalent), typeof(ShipwrightParallelSpeedTalent));

            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Dendrology Research Paper Advanced Hull"), recipeType: typeof(DendrologyResearchPaperAdvancedHullRecipe));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(ResearchTableObject), recipe: this);
        }

        partial void ModsPreInitialize();

        partial void ModsPostInitialize();
    }
}
