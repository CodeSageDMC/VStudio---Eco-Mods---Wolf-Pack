// HydroTab Trees

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
    public partial class GiantCactusFruitLogRecipe : RecipeFamily
    {
        public GiantCactusFruitLogRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Giant Cactus Fruit",  //noloc
                Localizer.DoStr("Harvest Giant Cactus Fruit from Saguaro Logs"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(SaguaroRibItem), 2, typeof(LoggingSkill)),
                },
                new List<CraftingElement>
                {
					new CraftingElement<GiantCactusFruitItem>(3),
               });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(LoggingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(GiantCactusFruitLogRecipe), 15.0f, typeof(LoggingSkill), typeof(LoggingToolEfficiencyTalent), typeof(LoggingToolStrengthTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr(" Giant Cactus Fruit"), typeof(GiantCactusFruitLogRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(FarmersTableObject), this);
			
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
