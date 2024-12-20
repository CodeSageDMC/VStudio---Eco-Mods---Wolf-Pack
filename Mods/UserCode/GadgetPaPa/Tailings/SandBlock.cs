﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Shared.SharedTypes;   // Added Line
    using Eco.World.Water;   // Added Line
    using Eco.Core.Controller;   // Added Line
    using Eco.Gameplay.Items.Recipes;   // Added Line

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
    [RequiresSkill(typeof(PotterySkill), 1)]      
    public partial class Sand1 : RecipeFamily
    {
        public Sand1()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Sand",
                    Localizer.DoStr("Sand"),
                    new IngredientElement[]
                    {
                //    new IngredientElement(typeof(DirtItem), 12, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)), 
                    new IngredientElement(typeof(DirtItem), 2, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)), 
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SandItem>(2),   // 1
                    }
                )
            };
        //    this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(PotterySkill)); 
            this.LaborInCalories = CreateLaborInCaloriesValue(10, typeof(PotterySkill)); 
            this.ExperienceOnCraft = 1;  
        //    this.CraftMinutes = CreateCraftTimeValue(typeof(Sand1), 0.5f, typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));     
            this.CraftMinutes = CreateCraftTimeValue(typeof(Sand1), 0.25f, typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));     
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Sand"), typeof(Sand1));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(typeof(KilnObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
