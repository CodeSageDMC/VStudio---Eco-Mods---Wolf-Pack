namespace Eco.Mods.TechTree
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.Time;
    using Eco.Core.Controller;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Lemon Gelato Bud")] // Defines the localized name of the item.
    [Weight(125)] // Defines how heavy the AdirondackGoldBud is.
    [Crop] // Defines this item as a crop item
    [Tag("Drugs")]
    [Ecopedia("Food", "Produce", createAsSubPage: true)]
    [LocDescription("Lemon Gelato Bud gathered from the plant and consumable but could they be used for more...")] //The tooltip description for the food item.
    public partial class AdirondackGoldBudItem : FoodItem
    {


        /// <summary>The amount of calories awarded for eating the food item.</summary>
        public override float Calories => 30;
        /// <summary>The nutritional value of the food item.</summary>
        public override Nutrients Nutrition => new Nutrients() { Carbs = 1, Fat = 1, Protein = 0, Vitamins = 1 };

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }



    [RequiresSkill(typeof(FarmingSkill), 3)]
    public partial class AdirondackGoldBudRecipe : RecipeFamily
    {
        public AdirondackGoldBudRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AdirondackGoldBud",  //noloc
                displayName: Localizer.DoStr("Grow Lemon Gelato, Trim the Bud"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CompostFertilizerItem), 1, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)),
                    new IngredientElement(typeof(ScissorsItem), 1, true),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<AdirondackGoldBudItem>(10),
                    new CraftingElement<ScissorsItem>(1),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.

            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(400, typeof(FarmingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AdirondackGoldBudRecipe), start: 20f, skillType: typeof(FarmingSkill), typeof(FarmingFocusedSpeedTalent), typeof(FarmingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "AdirondackGoldBud"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Grow Lemon Gelato, Trim the Bud"), recipeType: typeof(AdirondackGoldBudRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(AdirondackGoldObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}


