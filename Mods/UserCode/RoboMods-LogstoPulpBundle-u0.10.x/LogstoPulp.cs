namespace Eco.Robo.LogstoPulpMod
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Gameplay.Pipes;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Mods.TechTree;
    using Eco.Gameplay.Items.Recipes;

    [RequiresSkill(typeof(CarpentrySkill), 1)]
    public partial class LogstoPulpRecipeLVL1 : RecipeFamily
    {
        public LogstoPulpRecipeLVL1()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Logs to Wood Pulp",  //noloc
                Localizer.DoStr("Logs to Wood Pulp (LVL1)"),
                new List<IngredientElement>
                {
                    new IngredientElement("Wood", 1), //noloc
                },
                new List<CraftingElement>
                {
                    new CraftingElement<WoodPulpItem>(10)
                    //new CraftingElement<OUTPUT>(OUTPUT COUNT)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(15);
            this.CraftMinutes = CreateCraftTimeValue(1f);
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Logs to Wood Pulp (LVL1)"), typeof(LogstoPulpRecipeLVL1));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(CarpentryTableObject), this);
        }
        
        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
    [RequiresSkill(typeof(CarpentrySkill), 3)]
    public partial class LogstoPulpRecipeLVL2 : RecipeFamily
    {
        public LogstoPulpRecipeLVL2()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Logs to Wood Pulp",  //noloc
                Localizer.DoStr("Logs to Wood Pulp (LVL2)"),
                new List<IngredientElement>
                {
                    new IngredientElement("Wood", 1), //noloc
                },
                new List<CraftingElement>
                {
                    new CraftingElement<WoodPulpItem>(20)
                    //new CraftingElement<OUTPUT>(OUTPUT COUNT)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(15);
            this.CraftMinutes = CreateCraftTimeValue(.5f);
            this.ModsPreInitialize();
            //the next line names the name of the recipe on the craft bench
            this.Initialize(Localizer.DoStr("Logs to Wood Pulp (LVL2)"), typeof(LogstoPulpRecipeLVL2));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(SawmillObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

}