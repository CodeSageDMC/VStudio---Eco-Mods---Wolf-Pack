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
    [LocDisplayName("Glass of Wine")]
    [LocDescription("Wine taster, will work for free.")]
    //tags
    [Tag("Food")]
    //weight in grams food items ~100
    [Weight(25)]
    //stack size default is 100
    [MaxStackSize(100)]
    [Currency]
    [Ecopedia("Food", "Mixology", createAsSubPage: true)]
    public partial class WineItem : FoodItem
    {
        //insert the plural version of the item
        public override LocString DisplayNamePlural => Localizer.DoStr("Glass of Wine");
        //Nutrition Elements
        public override Nutrients Nutrition => new Nutrients() { Carbs = 9, Fat = 0, Protein = 1, Vitamins = 4 };
        //Calories of Food
        public override float Calories => 300;
        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }

    [RequiresSkill(typeof(MixologySkill), 3)]
    public partial class WineRecipe : RecipeFamily
    {
        public WineRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Wine",  //noloc
                Localizer.DoStr("Glass of Wine"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(BottledWineItem), 1, typeof(MixologySkill), typeof(MixologyLavishResourcesTalent)),
                    new IngredientElement(typeof(CocktailGlassItem), 10, typeof(MixologySkill), typeof(MixologyLavishResourcesTalent)),



                },//noloc
                new List<CraftingElement>
                {
                    new CraftingElement<WineItem>(10)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(10, typeof(MixologySkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(WineRecipe), 1f, typeof(MixologySkill), typeof(MixologyFocusedSpeedTalent), typeof(MixologyParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Glass of Wine"), typeof(WineRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(DrinksBarObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }


}