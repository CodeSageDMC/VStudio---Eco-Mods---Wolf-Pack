namespace Eco.Mods.TechTree
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using System;
    using System.Collections.Generic;

    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(PowerGridComponent))]
    [RequireComponent(typeof(PowerConsumptionComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [Tag("Usable")]
    public partial class SoftWallLampObject : ColorLampObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(SoftWallLampItem);
        public override LocString DisplayName => Localizer.DoStr("Soft Wall Lamp");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            base.Initialize();
            this.GetComponent<PowerConsumptionComponent>().Initialize(60);
            this.GetComponent<PowerGridComponent>().Initialize(10, new ElectricPower());
            this.GetComponent<HousingComponent>().HomeValue = SoftWallLampItem.homeValue;
            this.ModsPostInitialize();
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Soft Wall Lamp")]
    [LocDescription("A wall lamp that requires electricity to light.")]
    [Tag("Housing")]
    [Weight(500)]
    public partial class SoftWallLampItem : WorldObjectItem<SoftWallLampObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Backward, WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName = typeof(SoftWallLampObject).UILink(),
            Category = HousingConfig.GetRoomCategory("Lighting"),
            BaseValue = 2.5f,
            TypeForRoomLimit = Localizer.DoStr("Lights"),
            DiminishingReturnMultiplier = 0.7f
        };

        [NewTooltip(CacheAs.SubType, 7)] public static LocString PowerConsumptionTooltip() => Localizer.Do($"Consumes: {Text.Info(60)}w of {new ElectricPower().Name} power.");
    }

    [RequiresSkill(typeof(GlassworkingSkill), 3)]
    public partial class SoftWallLampRecipe : RecipeFamily
    {
        public SoftWallLampRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SoftWallLamp",  //noloc
                displayName: Localizer.DoStr("Soft Wall Lamp"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GlassItem), 11, typeof(GlassworkingSkill), typeof(GlassworkingLavishResourcesTalent)),
                    new IngredientElement(typeof(LightBulbItem), 1),
                    new IngredientElement(typeof(IronBarItem), 3, true),
                    new IngredientElement(typeof(WhitePowderItem), 11, true),
                    new IngredientElement(typeof(IronOxideItem), 5, true),
                    new IngredientElement(typeof(BluePowderItem), 2, true),
                    new IngredientElement(typeof(YellowPowderItem), 1, true),
                    new IngredientElement(typeof(CharcoalPowderItem), 1, true),
                    new IngredientElement(typeof(CopperHydroxideItem), 1, true),
                    new IngredientElement(typeof(MagentaPowderItem), 1, true),
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<SoftWallLampItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3.5f;

            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(GlassworkingSkill));

            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SoftWallLampRecipe), start: 2f, skillType: typeof(GlassworkingSkill), typeof(GlassworkingFocusedSpeedTalent), typeof(GlassworkingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Soft Wall Lamp"), recipeType: typeof(SoftWallLampRecipe));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(GlassworksObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
