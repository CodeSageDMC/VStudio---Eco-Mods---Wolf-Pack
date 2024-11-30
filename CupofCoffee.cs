﻿
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

    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Cup of Coffee")] // Defines the localized name of the item.
    [Weight(350)] // Defines how heavy the CupofCoffee is.
    [Ecopedia("Food", "Mixology", createAsSubPage: true)]
    [LocDescription("Coffee beans grounded with a blender.  oh the anticipation.")] //The tooltip description for the food item.
    public partial class CupofCoffeeItem : FoodItem
    {


        /// <summary>The amount of calories awarded for eating the food item.</summary>
        public override float Calories => 700;
        /// <summary>The nutritional value of the food item.</summary>
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 0, Protein = 2, Vitamins = 0 };

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(50);
    }


    /// <summary>
    /// <para>Server side recipe definition for "CupofCoffee".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(MixologySkill), 1)]
    [Ecopedia("Food", "Mixology", subPageName: "Cup of Coffee Item")]
    public partial class CupofCoffeeRecipe : RecipeFamily
    {
        public CupofCoffeeRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BrewCoffee",  //noloc
                displayName: Localizer.DoStr("Brew Coffee"),

            // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
            // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                         new IngredientElement(typeof(CupofCoffeeItem), 3, typeof(MixologySkill), typeof(MixologyLavishResourcesTalent)),
                         new IngredientElement(typeof(BrewFilterItem), 1, true),
                         new IngredientElement(typeof(EmptyPaperCupItem), 8, true),
                         new IngredientElement(typeof(CreamerItem), 2, typeof(MixologySkill), typeof(MixologyLavishResourcesTalent)),
                         new IngredientElement(typeof(SugarItem), 5, typeof(MixologySkill), typeof(MixologyLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<CupofCoffeeItem>(8)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.

            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(MixologySkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CupofCoffeeRecipe), start: 5f, skillType: typeof(MixologySkill), typeof(MixologyFocusedSpeedTalent), typeof(MixologyParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Cup of Coffee"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Brew Coffee"), recipeType: typeof(CupofCoffeeRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(MixologyObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }


}