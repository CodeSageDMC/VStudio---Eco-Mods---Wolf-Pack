// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// 

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
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Core.Controller;
    using Eco.Gameplay.Settlements.ClaimStakes;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Pipes;


    // Carpentry Table recipe 10x with 2x the output 
    [RequiresSkill(typeof(LoggingSkill), 3)]		// 1
    [Ecopedia("Items", "Products", subPageName: "Board Bulk Small Item")]
    public partial class BoardBulkRecipe : RecipeFamily
    {
        public BoardBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BoardSmallBulk",  //noloc
                displayName: Localizer.DoStr("Board Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 10, typeof(LoggingSkill)), //noloc	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BoardItem>(20)		// 1 x 10 x 2 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 6f;	// 0.6 x 10
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(LoggingSkill));	// 25 x 10
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BoardBulkRecipe), start: 2f, skillType: typeof(LoggingSkill)); 	// 0.2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Board Small Bulk"), recipeType: typeof(BoardBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(LoggingSkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Items", "Products", subPageName: "Hardwood Board Bulk Small Item")]
    public partial class HardwoodBoardBulkRecipe : Recipe
    {
        public HardwoodBoardBulkRecipe()
        {
            this.Init(
                name: "HardwoodBoardSmallBulk",  //noloc
                displayName: Localizer.DoStr("Hardwood Board Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Hardwood", 10, typeof(LoggingSkill)), //noloc	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HardwoodBoardItem>(20)		// 1 x 10 x 2 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CarpentryTableObject), typeof(BoardBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(LoggingSkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Items", "Products", subPageName: "Softwood Board Bulk Item")]
    public partial class SoftwoodBoardBulkRecipe : Recipe
    {
        public SoftwoodBoardBulkRecipe()
        {
            this.Init(
                name: "SoftwoodBoardBulk",  //noloc
                displayName: Localizer.DoStr("Softwood Board Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Softwood", 10, typeof(LoggingSkill)), //noloc	// 1 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SoftwoodBoardItem>(20)		// 1 x 10 x 2 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CarpentryTableObject), typeof(BoardBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    // Sawmill recipe 25x with 3x the output
	[RequiresSkill(typeof(LoggingSkill), 3)]		// 1
    public partial class SawBoardsBulkRecipe : RecipeFamily
    {
        public SawBoardsBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SawBoardsBulk",  //noloc
                displayName: Localizer.DoStr("Saw Boards Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 50, typeof(LoggingSkill)), //noloc	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BoardItem>(225),		// 3 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12.5f;	// 0.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(LoggingSkill));	// 20 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SawBoardsBulkRecipe), start: 4f, skillType: typeof(LoggingSkill));	// .16 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Saw Boards Bulk"), recipeType: typeof(SawBoardsBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SawmillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(LoggingSkill), 3)]		// 1
    [ForceCreateView]
    public partial class SawHardwoodBoardsBulkRecipe : Recipe
    {
        public SawHardwoodBoardsBulkRecipe()
        {
            this.Init(
                name: "SawHardwoodBoardsBulk",  //noloc
                displayName: Localizer.DoStr("Saw Hardwood BoardsBulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Hardwood", 50, typeof(LoggingSkill)), //noloc	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HardwoodBoardItem>(225),		// 3 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(SawmillObject), typeof(SawBoardsBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(LoggingSkill), 3)]		// 1
    [ForceCreateView]
    public partial class SawSoftwoodBoardsBulkRecipe : Recipe
    {
        public SawSoftwoodBoardsBulkRecipe()
        {
            this.Init(
                name: "SawSoftwoodBoardsBulk",  //noloc
                displayName: Localizer.DoStr("Saw Softwood Boards Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Softwood", 50, typeof(LoggingSkill)), //noloc	// 2 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SoftwoodBoardItem>(225),		// 3 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(SawmillObject), typeof(SawBoardsBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(LoggingSkill), 7)]	// 5
    public partial class ParticleBoardsBulkRecipe : RecipeFamily
    {
        public ParticleBoardsBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ParticleBoardsBulk",  //noloc
                displayName: Localizer.DoStr("Particle Boards Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(WoodPulpItem), 125,typeof(LoggingSkill)),	// 5 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BoardItem>(75),	// 1 x 25 x 3
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2.5f; // 0.1 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(500,typeof(LoggingSkill));	// 20 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ParticleBoardsBulkRecipe), start: 4.0f, skillType: typeof(LoggingSkill));	// 0.16 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Particle Boards Bulk"), recipeType: typeof(ParticleBoardsBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SawmillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }


	// Workbench Boards
    public partial class BoardsBulkRecipe : RecipeFamily
    {
        public BoardsBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BoardsSmallBulk",  //noloc
                displayName: Localizer.DoStr("Boards Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 20,typeof(Skill)), // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BoardItem>(20),	// 1 x 10 x 2
                });
            this.Recipes = new List<Recipe> { recipe };
            this.LaborInCalories = CreateLaborInCaloriesValue(400);	// 40 x 10
            this.CraftMinutes = CreateCraftTimeValue(2.0f);	// 0.2 x 10
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Boards Small Bulk"), recipeType: typeof(BoardsBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(WorkbenchObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [ForceCreateView]
    public partial class HardwoodBoardsBulkRecipe : Recipe
    {
        public HardwoodBoardsBulkRecipe()
        {
            this.Init(
                name: "HardwoodBoardsSmallBulk",  //noloc
                displayName: Localizer.DoStr("Hardwood Boards Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Hardwood", 20,typeof(Skill)), // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HardwoodBoardItem>(20),	// 1 x 10 x 2
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(WorkbenchObject), typeof(BoardsBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [ForceCreateView]
    public partial class SoftwoodBoardsBulkRecipe : Recipe
    {
        public SoftwoodBoardsBulkRecipe()
        {
            this.Init(
                name: "SoftwoodBoardsSmallBulk",  //noloc
                displayName: Localizer.DoStr("Softwood Boards Small Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Softwood", 20,typeof(Skill)), // 2 x 10
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SoftwoodBoardItem>(20),	// 1 x 10 x 2
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(WorkbenchObject), typeof(BoardsBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}
