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
    [LocDisplayName("Dango")]
    [LocDescription("Tricolor Dango, drink with green tea.")]
    //tags
    [Tag("Food")]
    //weight in grams food items ~100
    [Weight(50)]
    //stack size default is 100
    [MaxStackSize(100)]
    [Currency]
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    public partial class DangoItem : FoodItem
    {
        //insert the plural version of the item
        public override LocString DisplayNamePlural => Localizer.DoStr("Dango");
        //Nutrition Elements
        public override Nutrients Nutrition => new Nutrients() { Carbs = 24, Fat = 5, Protein = 2, Vitamins = 2 };
        //Calories of Food
        public override float Calories => 600;
        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }

    [RequiresSkill(typeof(CookingSkill), 3)]
    public partial class DangoRecipe : RecipeFamily
    {
        public DangoRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Dango",  //noloc
                Localizer.DoStr("Dango"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(RiceFlourItem), 4,                        typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(SugarItem), 2,                            typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(BeanPasteItem), 2,                        typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),

                },//noloc
                new List<CraftingElement>
                {
                    new CraftingElement<DangoItem>(8)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(10, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(DangoRecipe), 2, typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Dango"), typeof(DangoRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CastIronStoveObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }




}