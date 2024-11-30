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
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.SharedTypes;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.World.Water;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

	//  Composite Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		// 1
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Lumber Bulk Item")]
    public partial class CompositeLumberBulkRecipe : RecipeFamily
    {
        public CompositeLumberBulkRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CompositeLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement("Wood", 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc		// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeLumberItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 37.5f;	// 1.5 x 25
            this.LaborInCalories = CreateLaborInCaloriesValue(3000, typeof(CompositesSkill));	// 120 x 25
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CompositeLumberBulkRecipe), start: 16f, skillType: typeof(CompositesSkill), typeof(CompositesFocusedSpeedTalent), typeof(CompositesParallelSpeedTalent));	// 0.64 x 25
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Composite Lumber Bulk"), recipeType: typeof(CompositeLumberBulkRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AdvancedCarpentryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
	
	//  Composite Birch Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Birch Lumber Bulk Item")]
    public partial class CompositeBirchLumberBulkRecipe : Recipe
    {
        public CompositeBirchLumberBulkRecipe()
        {
            this.Init(
                name: "CompositeBirchLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Birch Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BirchLogItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeBirchLumberItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	//  Composite Cedar Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		 // 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Cedar Lumber Bulk Item")]
    public partial class CompositeCedarLumberBulkRecipe : Recipe
    {
        public CompositeCedarLumberBulkRecipe()
        {
            this.Init(
                name: "CompositeCedarLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Cedar Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CedarLogItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeCedarLumberItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	//  Composite Ceiba Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Ceiba Lumber Bulk Item")]
    public partial class CompositeCeibaLumberBulkRecipe : Recipe
    {
        public CompositeCeibaLumberBulkRecipe()
        {
            this.Init(
                name: "CompositeCeibaLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Ceiba Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CeibaLogItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeCeibaLumberItem>(75)	// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	//  Composite Fir Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Fir Lumber Bulk Item")]
    public partial class CompositeFirLumberBulkRecipe : Recipe
    {
        public CompositeFirLumberBulkRecipe()
        {
            this.Init(
                name: "CompositeFirLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Fir Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(FirLogItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeFirLumberItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	//  Composite Joshua Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Joshua Lumber Bulk Item")]
    public partial class CompositeJoshuaLumberBulkRecipe : Recipe
    {
        public CompositeJoshuaLumberBulkRecipe()
        {
            this.Init(
                name: "CompositeJoshuaLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Joshua Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(JoshuaLogItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeJoshuaLumberItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	//  Composite Oak Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		 // 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Oak Lumber Bulk Item")]
    public partial class CompositeOakLumberBulkRecipe : Recipe
    {
        public CompositeOakLumberBulkRecipe()
        {
            this.Init(
                name: "CompositeOakLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Oak Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(OakLogItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeOakLumberItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	//  Composite Palm Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		 // 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Palm Lumber Bulk Item")]
    public partial class CompositePalmLumberBulkRecipe : Recipe
    {
        public CompositePalmLumberBulkRecipe()
        {
            this.Init(
                name: "CompositePalmLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Palm Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PalmLogItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc	// 1 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositePalmLumberItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	//  Composite Redwood Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Redwood Lumber Bulk Item")]
    public partial class CompositeRedwoodLumberBulkRecipe : Recipe
    {
        public CompositeRedwoodLumberBulkRecipe()
        {
            this.Init(
                name: "CompositeRedwoodLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Redwood Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RedwoodLogItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25	
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),			// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc		// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeRedwoodLumberItem>(75)	// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	//  Composite Saguaro Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		// 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Saguaro Lumber Bulk Item")]
    public partial class CompositeSaguaroLumberBulkRecipe : Recipe
    {
        public CompositeSaguaroLumberBulkRecipe()
        {
            this.Init(
                name: "CompositeSaguaroLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Saguaro Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SaguaroRibItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),			// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc		// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeSaguaroLumberItem>(75)		// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

	//  Composite Spruce Lumber in Bulk
    [RequiresSkill(typeof(CompositesSkill), 3)]		 // 1
    [ForceCreateView]
    [Ecopedia("Blocks", "Building Materials", subPageName: "Composite Spruce Lumber Bulk Item")]
    public partial class CompositeSpruceLumberBulkRecipe : Recipe
    {
        public CompositeSpruceLumberBulkRecipe()
        {
            this.Init(
                name: "CompositeSpruceLumberBulk",  //noloc
                displayName: Localizer.DoStr("Composite Spruce Lumber Bulk"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SpruceLogItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(PlasticItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),	// 1 x 25
                    new IngredientElement(typeof(EpoxyItem), 25, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),		// 1 x 25
                    new IngredientElement("WoodBoard", 100, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), //noloc	// 4 x 25
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CompositeSpruceLumberItem>(75)	// 1 x 25 x 3 Boosted
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBulkRecipe), this);
        }
        partial void ModsPostInitialize();
    }

}
