
// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from FoodTemplate.tt/>

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

    /// <summary>
    /// <para>
    /// Server side food item definition for the "OnionRings" item. 
    /// This object inherits the FoodItem base class to allow for consumption mechanics.
    /// </para>
    /// <para>More information about FoodItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.FoodItem.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [MaxStackSize(300)]
    [LocDisplayName("Onion Rings")] // Defines the localized name of the item.
    [Weight(1)] // Defines how heavy the OnionRings is.
    [Ecopedia("Food","Campfire", createAsSubPage: true)]
    [LocDescription("Just some Classic Onion Rings")] //The tooltip description for the food item.
    public partial class OnionRingsItem : FoodItem
    {


        /// <summary>The amount of calories awarded for eating the food item.</summary>
        public override float Calories                  => 500;
        /// <summary>The nutritional value of the food item.</summary>
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 7, Fat = 12, Protein = 8, Vitamins = 3};

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife            => (float)TimeUtil.HoursToSeconds(72);
    }


    /// <summary>
    /// <para>Server side recipe definition for "OnionRings".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(CookingSkill), 3)]
    [Ecopedia("Food","Campfire", subPageName: "Onion Rings Item")]
    public partial class OnionRingsRecipe : RecipeFamily
    {
        public OnionRingsRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "OnionRings",  //noloc
                displayName: Localizer.DoStr("Onion Rings"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(OnionItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(TallowItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    
                    
                    
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<OnionRingsItem>(1),
                    
                    
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(CookingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(OnionRingsRecipe), start: 1, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Onion Rings"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Onion Rings"), recipeType: typeof(OnionRingsRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(CastIronSkilletObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}