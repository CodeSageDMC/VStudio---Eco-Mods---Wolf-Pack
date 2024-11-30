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
    [LocDisplayName("BBQ Rib")]
    [LocDescription("I want my baby back, baby back. Chili YAH!")]
    //tags
    [Tag("Food")]
    //weight in grams food items ~100
    [Weight(75)]
    //stack size default is 100
    [MaxStackSize(100)]
    [Currency]
    [Ecopedia("Food", "Campfire Cooking", createAsSubPage: true)]
    public partial class BBQRibItem : FoodItem
    {
        //insert the plural version of the item
        public override LocString DisplayNamePlural => Localizer.DoStr("BBQ Rib");
        //Nutrition Elements
        public override Nutrients Nutrition => new Nutrients() { Carbs = 7, Fat = 21, Protein = 18, Vitamins = 9 };
        //Calories of Food
        public override float Calories => 1500;
        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 6)]
    public partial class BBQRibRecipe : RecipeFamily
    {
        public BBQRibRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "BBQ Rib",  //noloc
                Localizer.DoStr("BBQ Rib"),
                new List<IngredientElement>
                {
                                
                    new IngredientElement(typeof(PreparedMeatItem), 4,              typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                    new IngredientElement(typeof(TomatoSauceItem), 2, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                    new IngredientElement(typeof(SugarItem), 4,                     typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),

                },//noloc
                new List<CraftingElement>
                {
                    new CraftingElement<BBQRibItem>(2)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(CampfireCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(BBQRibRecipe), 5, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("BBQ Rib"), typeof(BBQRibRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CharcoalgrillBaseObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }



}