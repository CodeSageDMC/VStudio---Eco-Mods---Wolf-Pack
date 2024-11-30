// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from VehicleTemplate.tt />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Controller;
    using Eco.Core.Items;
    using Eco.Core.Utils;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
	using Eco.Gameplay.Components.Storage;
    using Eco.Gameplay.Components.VehicleModules;
    using Eco.Gameplay.GameActions;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Systems.Exhaustion;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Math;
    using Eco.Shared.Networking;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.Items;
    using static Eco.Gameplay.Components.PartsComponent;

    [Serialized]
    [LocDisplayName("Steam Tractor")]
    [LocDescription("A tractor powered through steam.")]
    [IconGroup("World Object Minimap")]
    [Weight(150000)]
    [Tag("Excavation")]
    [AirPollution(0.05f)]
    [Ecopedia("Crafted Objects", "Vehicles", createAsSubPage: true)]
    public partial class SteamTractorItem : WorldObjectItem<SteamTractorObject>, IPersistentData
    {
        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)] public object PersistentData { get; set; }
    }

    /// <summary>
    /// <para>Server side recipe definition for "SteamTractor".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(MechanicsSkill), 2)]
    [Ecopedia("Crafted Objects", "Vehicles", subPageName: "Steam Tractor Item")]
    public partial class SteamTractorRecipe : RecipeFamily
    {
        public SteamTractorRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SteamTractor",  //noloc
                displayName: Localizer.DoStr("Steam Tractor"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronPlateItem), 12, typeof(MechanicsSkill)),
                    new IngredientElement(typeof(IronPipeItem), 8, typeof(MechanicsSkill)),
                    new IngredientElement(typeof(ScrewsItem), 24, typeof(MechanicsSkill)),
                    new IngredientElement(typeof(LeatherHideItem), 20, typeof(MechanicsSkill)),
                    new IngredientElement("Lumber", 30, typeof(MechanicsSkill)), //noloc
                    new IngredientElement(typeof(PortableSteamEngineItem), 1, true),
                    new IngredientElement(typeof(IronWheelItem), 4, true),
                    new IngredientElement(typeof(IronAxleItem), 2, true),
                    new IngredientElement(typeof(LightBulbItem), 2, true),
                    new IngredientElement(typeof(LubricantItem), 2, true),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<SteamTractorItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 25; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(1000, typeof(MechanicsSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SteamTractorRecipe), start: 10, skillType: typeof(MechanicsSkill));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Steam Tractor"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Steam Tractor"), recipeType: typeof(SteamTractorRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(AssemblyLineObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [RequireComponent(typeof(StandaloneAuthComponent))]
    [RequireComponent(typeof(PaintableComponent))]
    [RequireComponent(typeof(FuelSupplyComponent))]
    [RequireComponent(typeof(FuelConsumptionComponent))]
    [RequireComponent(typeof(MovableLinkComponent))]
    [RequireComponent(typeof(AirPollutionComponent))]
    [RequireComponent(typeof(VehicleComponent))]
    [RequireComponent(typeof(CustomTextComponent))]
    [RequireComponent(typeof(ModularVehicleComponent))]
    [RequireComponent(typeof(MinimapComponent))]           
    [RequireComponent(typeof(PartsComponent))]
    [RepairRequiresSkill(typeof(MechanicsSkill), 2)]
    [ExhaustableUnlessOverridenVehicle]
    [Ecopedia("Crafted Objects", "Vehicles", subPageName: "SteamTractor Item")]
    public partial class SteamTractorObject : PhysicsWorldObject, IRepresentsItem
    {
        static SteamTractorObject()
        {
            WorldObject.AddOccupancy<SteamTractorObject>(new List<BlockOccupancy>(0));
        }
        public override TableTextureMode TableTexture => TableTextureMode.Metal;
        public override bool PlacesBlocks            => false;
        public override LocString DisplayName { get { return Localizer.DoStr("Steam Tractor"); } }
        public Type RepresentedItemType { get { return typeof(SteamTractorItem); } }

        private static string[] fuelTagList = new string[]
        {
            "Burnable Fuel",
        };
        private SteamTractorObject() { }
        private static readonly Type[] SegmentTypeList = Array.Empty<Type>();
        private static readonly Type[] AttachmentTypeList = new Type[]
        {
            typeof(SteamTractorPlowItem),
            typeof(SteamTractorHarvesterItem),
            typeof(SteamTractorSowerItem),
            typeof(SteamTractorScoopItem),
        };
        protected override void Initialize()
        {
            this.ModsPreInitialize();
            base.Initialize();         
            this.GetComponent<CustomTextComponent>().Initialize(200);
            this.GetComponent<FuelSupplyComponent>().Initialize(2, fuelTagList);
            this.GetComponent<FuelConsumptionComponent>().Initialize(225);
            this.GetComponent<AirPollutionComponent>().Initialize(0.05f);
            this.GetComponent<VehicleComponent>().HumanPowered(2);
            this.GetComponent<ModularVehicleComponent>().Initialize(0, 1, SegmentTypeList, AttachmentTypeList);
            this.GetComponent<MinimapComponent>().InitAsMovable();
            this.GetComponent<MinimapComponent>().SetCategory(Localizer.DoStr("Vehicles"));
            this.GetComponent<VehicleComponent>().Initialize(12, 1);
            this.GetComponent<VehicleToolComponent>().Initialize(12, 25000000,
            100, 200, 0, true, VehicleUtilities.GetInventoryRestriction(this));
            this.GetComponent<VehicleComponent>().FailDriveMsg = Localizer.Do($"You are too hungry to drive {this.DisplayName}!");
            this.ModsPostInitialize();
                        {
                this.GetComponent<PartsComponent>().Config(() => LocString.Empty, new PartInfo[]
                {
                                        new() { TypeName = nameof(PortableSteamEngineItem), Quantity = 1},
                                        new() { TypeName = nameof(IronWheelItem), Quantity = 2},
                                        new() { TypeName = nameof(LightBulbItem), Quantity = 1},
                                        new() { TypeName = nameof(LubricantItem), Quantity = 1},
                                    });
            }
        }

        /// <summary>Hook for mods to customize before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize after initialization.</summary>
        partial void ModsPostInitialize();
    }
}
