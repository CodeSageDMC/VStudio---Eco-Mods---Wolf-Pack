// Copyright (c) Strange Loop Games. All rights reserved.
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
    using static Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue;
    using Eco.Gameplay.Items.Recipes;

    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(LinkComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(PublicStorageComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(WardrobeComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomContainment]
    [RequireRoomVolume(12)]
    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Kitchen", subPageName: "Limestone right corner cabinet Item")]
    public partial class LimestoneRightCornerCabinetObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(LimestoneRightCornerCabinetItem);
        public override LocString DisplayName => Localizer.DoStr("Limestone right corner cabinet");
        public override TableTextureMode TableTexture => TableTextureMode.Wood;

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<HousingComponent>().HomeValue = LimestoneRightCornerCabinetItem.homeValue;
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.Initialize(16);
            storage.Storage.AddInvRestriction(new NotCarriedRestriction()); // can't store block or large items
            this.ModsPostInitialize();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Limestone right corner cabinet")]
    [LocDescription("A Limestone right corner cabinet to hold items and match the kitchen set.")]
    [Ecopedia("Housing Objects", "Kitchen", createAsSubPage: true)]
    [Tag("Housing")]
    [Weight(2000)] // Defines how heavy LimestoneRightCornerCabinet is.
	[MaxStackSize(200)]
    public partial class LimestoneRightCornerCabinetItem : WorldObjectItem<LimestoneRightCornerCabinetObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext( 0  | DirectionAxisFlags.Down , WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName                              = typeof(LimestoneRightCornerCabinetObject).UILink(),
            Category                                = HousingConfig.GetRoomCategory("Kitchen"),
            BaseValue                               = 5,
            TypeForRoomLimit                        = Localizer.DoStr("Cabinet"),
            DiminishingReturnMultiplier                = 0.5f
            
        };

    }

    /// <summary>
    /// <para>Server side recipe definition for "LimestoneRightCornerCabinet".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>

    [RequiresSkill(typeof(CarpentrySkill), 5)]
    [Ecopedia("Housing Objects", "Kitchen", subPageName: "Limestone right corner cabinet Item")]
    public partial class LimestoneRightCornerCabinetRecipe : RecipeFamily
    {
        public LimestoneRightCornerCabinetRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Limestonerightcornercabinet",  //noloc
                displayName: Localizer.DoStr("Limestone right corner cabinet"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {

                    new IngredientElement(typeof(NailItem), 18, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement("Lumber" , 10, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement("WoodBoard" , 16, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement(typeof(LimestoneRightCornerCabinetTopItem), 1, true),
                    
                    
                    


                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<LimestoneRightCornerCabinetItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 20; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor

            this.LaborInCalories = CreateLaborInCaloriesValue(180, typeof(CarpentrySkill));

            // Defines our crafting time for the recipe

            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(LimestoneRightCornerCabinetRecipe), start: 4, skillType: typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Limestone right corner cabinet"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Limestone right corner cabinet"), recipeType: typeof(LimestoneRightCornerCabinetRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.

            CraftingComponent.AddRecipe(tableType: typeof(SawmillObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
