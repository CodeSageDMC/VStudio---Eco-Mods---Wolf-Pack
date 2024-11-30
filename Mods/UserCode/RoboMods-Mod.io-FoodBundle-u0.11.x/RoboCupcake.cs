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
    [LocDisplayName("Cupcake")]
    [LocDescription("Happy Birthday, CUPCAKES!  With sprinkles!")]
    //tags
    [Tag("Food")]
    //weight in grams food items ~100
    [Weight(75)]
    //stack size default is 100
    [MaxStackSize(100)]
    [Currency]
    [Ecopedia("Food", "Baking", createAsSubPage: true)]
    public partial class CupcakeItem : FoodItem
    {
        //insert the plural version of the item
        public override LocString DisplayNamePlural => Localizer.DoStr("Cupcake");
        //Nutrition Elements
        public override Nutrients Nutrition => new Nutrients() { Carbs = 18, Fat = 15, Protein = 3, Vitamins = 5 };
        //Calories of Food
        public override float Calories => 750;
        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }

    [RequiresSkill(typeof(BakingSkill), 2)]
    public partial class CupcakeRecipe : RecipeFamily
    {
        public CupcakeRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Cupcake",  //noloc
                Localizer.DoStr("Cupcake"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(FlourItem), 15,                     typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(typeof(SugarItem), 10,                     typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(typeof(MilkItem), 1,                     typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(tag: "Fruit", 15,                          typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(tag: "Fat", 3,                            typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),


                },//noloc
                new List<CraftingElement>
                {
                    new CraftingElement<CupcakeItem>(8),
                    new CraftingElement<GlassJarItem>(1),
                    new CraftingElement<LidItem>(1),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(15, typeof(BakingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(CupcakeRecipe), 3, typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Cupcake"), typeof(CupcakeRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, 
        /// but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();

    }

}