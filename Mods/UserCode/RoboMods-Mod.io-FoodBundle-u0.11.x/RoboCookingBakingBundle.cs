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
    using Eco.Core.Plugins.Interfaces;


    #region ModRegistration
    public class RoboCookingBakingMod : IModInit
    {
        public static ModRegistration Register() => new()
        {
            ModName = "Mr. Roboto Cooking and Baking Mod",
            ModDescription = "Adds 8 new baking recipes and 11 new cooking recipes.  Mod brings additional value to fish, tomato, and milling recipes.",
            ModDisplayName = "Robo Expanded Food Mod",
        };
    }
    #endregion
}