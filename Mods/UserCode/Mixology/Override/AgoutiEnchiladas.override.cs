﻿// Copyright (c) Strange Loop Games. All rights reserved.
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
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;



    public partial class AgoutiEnchiladasRecipe
    {


		partial void ModsPreInitialize()
        	{
           		  var product = new Recipe(
              		  "Agouti Enchiladas",
                Localizer.DoStr("Agouti Enchiladas"),
                new IngredientElement[]
                
                {
                    new IngredientElement(typeof(CornmealItem), 4, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                    new IngredientElement(typeof(PapayaItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                    new IngredientElement(typeof(SunCheeseItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                    new IngredientElement(typeof(PrimeCutItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                    new IngredientElement(typeof(TomatoSauceItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                },
new CraftingElement<AgoutiEnchiladasItem>()
);

	

this.Recipes = new List<Recipe> { product };


 
    }
}

}

