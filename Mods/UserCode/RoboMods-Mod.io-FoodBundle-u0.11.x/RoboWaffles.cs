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




    [Serialized]
    [LocDisplayName("Waffles")]
    [LocDescription("DAD! Make me BLUEBERRY Waffles!")]
    //tags
    [Tag("Food")]
    //weight in grams food items ~100
    [Weight(75)]
    //stack size default is 100
    [MaxStackSize(100)]
    [Currency]
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    public partial class WafflesItem : FoodItem
    {
        //insert the plural version of the item
        public override LocString DisplayNamePlural => Localizer.DoStr("Waffles");
        //Nutrition Elements
        public override Nutrients Nutrition => new Nutrients() { Carbs = 18, Fat = 11, Protein = 5, Vitamins = 4 };
        //Calories of Food
        public override float Calories => 1000;
        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }

    [RequiresSkill(typeof(CookingSkill), 2)]
    public partial class WafflesRecipe : RecipeFamily
    {
        public WafflesRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Waffles",  //noloc
                Localizer.DoStr("Waffles"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(FlourItem), 4,                                   typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(tag: "Fat", 1,                                          typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(HuckleberriesItem), 2,                           typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(SugarItem), 2,                                   typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),


                },//noloc
                new List<CraftingElement>
                {
                    new CraftingElement<WafflesItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(WafflesRecipe), 4, typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Waffles"), typeof(WafflesRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CastIronSkilletObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();

    }
}