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
    [LocDisplayName("Fruit Pie")]
    [LocDescription("A fruit pie. Just for you!")]
    //tags
    [Tag("Food")]
    //weight in grams food items ~100
    [Weight(75)]
    //stack size default is 100
    [MaxStackSize(100)]
    [Currency]
    [Ecopedia("Food", "Baking", createAsSubPage: true)]
    public partial class FruitPieItem : FoodItem
    {
        //insert the plural version of the item
        public override LocString DisplayNamePlural => Localizer.DoStr("Fruit Pie");
        //Nutrition Elements
        public override Nutrients Nutrition => new Nutrients() { Carbs = 13, Fat = 10, Protein = 5, Vitamins = 16 };
        //Calories of Food
        public override float Calories => 1300;
        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }

    [RequiresSkill(typeof(BakingSkill), 4)]
    public partial class FruitPieRecipe : RecipeFamily
    {
        public FruitPieRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Fruit Pie",  //noloc
                Localizer.DoStr("Fruit Pie"),
                new List<IngredientElement>
                {
                    new IngredientElement(tag: "Fruit", 10,                  typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(typeof(SugarItem), 3,             typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(typeof(FlourItem), 3,             typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(tag: "Fat", 2,                    typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(typeof(SaltItem), 1,             typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),





                },//noloc
                new List<CraftingElement>
                {
                    new CraftingElement<FruitPieItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(BakingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(FruitPieRecipe), 2, typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Fruit Pie"), typeof(FruitPieRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}