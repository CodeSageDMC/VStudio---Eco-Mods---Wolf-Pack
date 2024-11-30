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
    [LocDisplayName("Alpha OG Joint")] // Defines the localized name of the item.
    [Weight(125)] // Defines how heavy the OgKushJoint is.
    [Crop] // Defines this item as a crop item
    [Tag("Drugs")]
    [Ecopedia("Food", "Produce", createAsSubPage: true)]
    [LocDescription("This is Alpha OG.  The wolves respect your smell.")] //The tooltip description for the food item.
    public partial class OgKushJointItem : FoodItem
    {


        /// <summary>The amount of calories awarded for eating the food item.</summary>
        public override float Calories => -500;
        /// <summary>The nutritional value of the food item.</summary>
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 0, Protein = 0, Vitamins = 0 };

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(65);
    }




    public partial class OgKushJointRecipe : RecipeFamily
    {
        public OgKushJointRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "OgKushJoint",  //noloc
                displayName: Localizer.DoStr("Roll Alpha OG Joints"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(OgKushBagItem), 1, true),
                    new IngredientElement(typeof(PapersItem), 20, true),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<OgKushJointItem>(20),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.

            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(400);

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(OgKushJointRecipe), start: 10f, skillType: typeof(FarmingSkill), typeof(FarmingFocusedSpeedTalent), typeof(FarmingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "OgKushJoint"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Roll Alpha OG Joints"), recipeType: typeof(OgKushJointRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(WorkbenchObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}


