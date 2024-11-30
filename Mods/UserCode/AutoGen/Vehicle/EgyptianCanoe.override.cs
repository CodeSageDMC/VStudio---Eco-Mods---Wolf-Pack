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

    [Serialized]
    [LocDisplayName("Egyptian Canoe")]
    [LocDescription("Small Canoe for hauling minimal loads.")]
    [IconGroup("World Object Minimap")]
    [Weight(10000)]
    [WaterPlaceable]
    [Ecopedia("Crafted Objects", "Vehicles", createAsSubPage: true)]
    public partial class EgyptianCanoeItem : WorldObjectItem<EgyptianCanoeObject>, IPersistentData
    {
        public float InteractDistance => DefaultInteractDistance.WaterPlacement;
        public bool ShouldHighlight(Type block) => false;
        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)] public object PersistentData { get; set; }
    }

    /// <summary>
    /// <para>Server side recipe definition for "EgyptianCanoe".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [ForceCreateView]
    [Ecopedia("Crafted Objects", "Vehicles", subPageName: "Egyptian Canoe Item")]
    public partial class EgyptianCanoeRecipe : Recipe
    {
        public EgyptianCanoeRecipe()
        {
            this.Init(
                name: "EgyptianCanoe",  //noloc
                displayName: Localizer.DoStr("Egyptian Canoe"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 14,typeof(Skill)), //noloc
                    new IngredientElement("WoodBoard", 2,typeof(Skill)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<EgyptianCanoeItem>()
                });
            // Perform post initialization steps for user mods and initialize our recipe instance as a tag product with the crafting system
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(WorkbenchObject), typeof(SmallCanoeRecipe), this);
        }


        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [RequireComponent(typeof(StandaloneAuthComponent))]
    [RequireComponent(typeof(PublicStorageComponent))]
    [RequireComponent(typeof(TailingsReportComponent))]
    [RequireComponent(typeof(MovableLinkComponent))]
    [RequireComponent(typeof(VehicleComponent))]
    [RequireComponent(typeof(BoatComponent))]
    [RequireComponent(typeof(ModularStockpileComponent))]
    [RequireComponent(typeof(MinimapComponent))]           
    [Ecopedia("Crafted Objects", "Vehicles", subPageName: "EgyptianCanoe Item")]
    public partial class EgyptianCanoeObject : PhysicsWorldObject, IRepresentsItem
    {
        static EgyptianCanoeObject()
        {
            WorldObject.AddOccupancy<EgyptianCanoeObject>(new List<BlockOccupancy>(0));
        }
        public override float InteractDistance => DefaultInteractDistance.WaterPlacement;
        public override TableTextureMode TableTexture => TableTextureMode.Wood;
        public override bool PlacesBlocks            => false;
        public override LocString DisplayName { get { return Localizer.DoStr("Egyptian Canoe"); } }
        public Type RepresentedItemType { get { return typeof(EgyptianCanoeItem); } }

        private EgyptianCanoeObject() { }
        protected override void Initialize()
        {
            this.ModsPreInitialize();
            base.Initialize();         
            this.GetComponent<VehicleComponent>().HumanPowered(0.5f);
            this.GetComponent<StockpileComponent>().Initialize(new Vector3i(2,2,2));
            this.GetComponent<PublicStorageComponent>().Initialize(3, 4000000);
            this.GetComponent<MinimapComponent>().InitAsMovable();
            this.GetComponent<MinimapComponent>().SetCategory(Localizer.DoStr("Vehicles"));
            this.GetComponent<VehicleComponent>().Initialize(10, 1,1, null, true);
            this.GetComponent<BoatComponent>().Size = BoatComponent.BoatSize.Small;
            this.GetComponent<VehicleComponent>().FailDriveMsg = Localizer.Do($"You are too hungry to drive {this.DisplayName}!");
            this.ModsPostInitialize();
                    }

        /// <summary>Hook for mods to customize before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize after initialization.</summary>
        partial void ModsPostInitialize();
    }
}
