﻿namespace Eco.Mods.TechTree
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
    [LocDisplayName("Nachos")]
    [LocDescription("Na-CHO-Cheese!")]
    //tags
    [Tag("Food")]
    //weight in grams food items ~100
    [Weight(75)]
    //stack size default is 100
    [MaxStackSize(100)]
    [Currency]
    [Ecopedia("Food", "Baking", createAsSubPage: true)]
    public partial class NachosItem : FoodItem
    {
        //insert the plural version of the item
        public override LocString DisplayNamePlural => Localizer.DoStr("Nachos");
        //Nutrition Elements
        public override Nutrients Nutrition => new Nutrients() { Carbs = 23, Fat = 12, Protein = 7, Vitamins = 7 };
        //Calories of Food
        public override float Calories => 1000;
        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }

    [RequiresSkill(typeof(BakingSkill), 6)]
    public partial class NachosRecipe : RecipeFamily
    {
        public NachosRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Nachos",  //noloc
                Localizer.DoStr("Nachos"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(CornmealItem), 2,                               typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(tag: "Oil", 1,                                         typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(typeof(GroundBeefItem), 2,                           typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(typeof(CheeseItem), 2,                               typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                    new IngredientElement(typeof(JalapenoItem), 1,                               typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),


                },//noloc
                new List<CraftingElement>
                {
                    new CraftingElement<NachosItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(BakingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(NachosRecipe), 5, typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Nachos"), typeof(NachosRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();

    }



}