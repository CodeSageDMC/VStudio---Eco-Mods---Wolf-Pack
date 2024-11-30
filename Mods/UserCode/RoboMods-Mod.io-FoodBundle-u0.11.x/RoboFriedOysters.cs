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
    [LocDisplayName("Fried Oysters")]
    [LocDescription("Fried Oysters, on the half clam shell.")]
    //tags
    [Tag("Food")]
    //weight in grams food items ~100
    [Weight(50)]
    //stack size default is 100
    [MaxStackSize(100)]
    [Currency]
    [Ecopedia("Food", "Campfire Cooking", createAsSubPage: true)]
    public partial class FriedOystersItem : FoodItem
    {
        //insert the plural version of the item
        public override LocString DisplayNamePlural => Localizer.DoStr("Fried Oysters");
        //Nutrition Elements
        public override Nutrients Nutrition => new Nutrients() { Carbs = 10, Fat = 12, Protein = 9, Vitamins = 3 };
        //Calories of Food
        public override float Calories => 750;
        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 3)]
    public partial class FriedOystersRecipe : RecipeFamily
    {
        public FriedOystersRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Fried Oysters",  //noloc
                Localizer.DoStr("Fried Oysters"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(ClamItem), 2,                                   typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                    new IngredientElement(tag: "Fat", 1,                                         typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),

                },//noloc
                new List<CraftingElement>
                {
                    new CraftingElement<FriedOystersItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(25, typeof(CampfireCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(FriedOystersRecipe), 3, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Fried Oysters"), typeof(FriedOystersRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }


}