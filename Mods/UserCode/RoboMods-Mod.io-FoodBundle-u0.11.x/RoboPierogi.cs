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
    [LocDisplayName("Pierogi")]
    [LocDescription("Grandma's Polish Perogies and Sausage, YUM!")]
    //tags
    [Tag("Food")]
    //weight in grams food items ~100
    [Weight(75)]
    //stack size default is 100
    [MaxStackSize(100)]
    [Currency]
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    public partial class PierogiItem : FoodItem
    {
        //insert the plural version of the item
        public override LocString DisplayNamePlural => Localizer.DoStr("Pierogi");
        //Nutrition Elements
        public override Nutrients Nutrition => new Nutrients() { Carbs = 13, Fat = 10, Protein = 5, Vitamins = 16 };
        //Calories of Food
        public override float Calories => 1300;
        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }

    [RequiresSkill(typeof(CookingSkill), 3)]
    public partial class PierogiRecipe : RecipeFamily
    {
        public PierogiRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Pierogi",  //noloc
                Localizer.DoStr("Pierogi"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(FlourItem), 2,                                  typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(tag: "Oil", 1,                                         typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(CharredSausageItem), 4,                         typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(PotatoItem), 4,                               typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(CheeseItem), 2,                               typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),


                },//noloc
                new List<CraftingElement>
                {
                    new CraftingElement<PierogiItem>(4)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(35, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(PierogiRecipe), 4, typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Pierogi"), typeof(PierogiRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CastIronStoveObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();

    }


}