﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from WorldObjectTemplate.tt />

namespace Eco.Mods.TechTree
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
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
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
    using Eco.Shared.Networking;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.Core.Utils;
	using Eco.Gameplay.Components.Storage;
    using Eco.Gameplay.Items.Recipes;

    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(CustomTextComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [Tag("Usable")]
    [Ecopedia("Crafted Objects", "Signs", subPageName: "Large Hanging Spruce Sign Item")]
            public partial class LargeHangingSpruceSignObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(LargeHangingSpruceSignItem);
        public override LocString DisplayName => Localizer.DoStr("Large Hanging Spruce Sign");
        public override TableTextureMode TableTexture => TableTextureMode.Wood;

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<CustomTextComponent>().Initialize(700);
            this.ModsPostInitialize();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Large Hanging Spruce Sign")]
    [LocDescription("A large sign for all of your larger text needs!")]
    [Ecopedia("Crafted Objects", "Signs", createAsSubPage: true)]
    [Weight(2000)] // Defines how heavy LargeHangingSpruceSign is.
            public partial class LargeHangingSpruceSignItem : WorldObjectItem<LargeHangingSpruceSignObject>, IPersistentData
    {

        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)] public object PersistentData { get; set; }
    }

    /// <summary>
    /// <para>Server side recipe definition for "LargeHangingSpruceSign".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(CarpentrySkill), 3)]
    [ForceCreateView]
    [Ecopedia("Crafted Objects", "Signs", subPageName: "Large Hanging Spruce Sign Item")]
    public partial class LargeHangingSpruceSignRecipe : Recipe
    {
        public LargeHangingSpruceSignRecipe()
        {
            this.Init(
                name: "LargeHangingSpruceSign",  //noloc
                displayName: Localizer.DoStr("Large Hanging Spruce Sign"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SpruceLogItem), 10, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement("WoodBoard", 5, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), //noloc
                    new IngredientElement("HewnLog", 4, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<LargeHangingSpruceSignItem>()
                });
            // Perform post initialization steps for user mods and initialize our recipe instance as a tag product with the crafting system
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CarpentryTableObject), typeof(LargeHangingWoodSignRecipe), this);
        }


        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
