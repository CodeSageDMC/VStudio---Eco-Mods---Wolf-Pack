using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Items;
using Eco.Gameplay.Modules;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Mods.TechTree;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAssemblyLine
{
    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]
    [RequireComponent(typeof(LinkComponent))]
    [RequireComponent(typeof(CraftingComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(PluginModulesComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomContainment]
    [RequireRoomVolume(25)]
    [RequireRoomMaterialTier(2.8f, typeof(AdvancedCookingLavishReqTalent), typeof(AdvancedCookingFrugalReqTalent))]
    public partial class FoodAssemblyLineObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(FoodAssemblyLineItem);
        public override LocString DisplayName => Localizer.DoStr("Food AssemblyLine");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<MinimapComponent>().SetCategory(Localizer.DoStr("Crafting"));
            this.GetComponent<HousingComponent>().HomeValue = FoodAssemblyLineItem.homeValue;
            this.ModsPostInitialize();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Food Assembly Line")]
    [Ecopedia("Work Stations", "Researching", createAsSubPage: true)]
    [AllowPluginModules(Tags = new[] { "ModernUpgrade" }, ItemTypes = new[] { typeof(CuttingEdgeCookingUpgradeItem) })] //noloc
    public partial class FoodAssemblyLineItem : WorldObjectItem<FoodAssemblyLineObject>, IPersistentData
    {
        public override LocString DisplayDescription => Localizer.DoStr("A Machine For Molecular Food.");


        public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = 0
                    | DirectionAxisFlags.Down
                ;
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            Category = HousingConfig.GetRoomCategory("Kitchen"),
            HouseValue = 3,
            TypeForRoomLimit = Localizer.DoStr("Cooking"),
            DiminishingReturnPercent = 0.3f
        };

        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)] public object PersistentData { get; set; }
    }

    /// <summary>
    /// <para>Server side recipe definition for "FoodAssemblyLine".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(ElectronicsSkill), 1)]
    [Ecopedia("Work Stations", "Craft Tables", subPageName: "FoodAssemblyLine Item")]
    public partial class FoodAssemblyLineRecipe : RecipeFamily
    {
        public FoodAssemblyLineRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FoodAssemblyLine",  //noloc
                displayName: Localizer.DoStr("Electronics Assembly"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(SteelPlateItem), 20, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),
                    new IngredientElement(typeof(BasicCircuitItem), 4, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<FoodAssemblyLineItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(1000, typeof(ElectronicsSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(FoodAssemblyLineRecipe), 10, typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Food Assembly Line"), typeof(FoodAssemblyLineRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(RoboticAssemblyLineObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
