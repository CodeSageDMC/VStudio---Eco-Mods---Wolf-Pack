#pragma warning disable IDE0005
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
#pragma warning restore IDE0005

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Eco.Mods.TechTree
{
    [Serialized]
    [LocDisplayName("Biochemist")]
    [LocDescription(
        "The Biochemist gets recipes to make Biodiesel, Plastic, Rubber, Epoxy, and Nylon. Biochemists create sustainable hydrocarbon products with no impact on the environment."
    )]
    [Ecopedia("Professions", "Scientist", createAsSubPage: true)]
    [RequiresSkill(typeof(ScientistSkill), 0), Tag("Scientist Specialty"), Tier(4)]
    [Tag("Specialty")]
    [Tag("Teachable")]
    public partial class BiochemistSkill : Skill
    {
        public override void OnLevelUp(User user)
        {
            _ = user.Skillset.AddExperience(
                typeof(SelfImprovementSkill),
                20,
                Localizer.DoStr("for leveling up another specialization.")
            );
        }

        public static MultiplicativeStrategy MultiplicativeStrategy =
            new(
                new float[]
                {
                    1,
                    1 - 0.2f,
                    1 - 0.25f,
                    1 - 0.3f,
                    1 - 0.35f,
                    1 - 0.4f,
                    1 - 0.45f,
                    1 - 0.5f,
                }
            );
        public override MultiplicativeStrategy MultiStrategy => MultiplicativeStrategy;

        public static AdditiveStrategy AdditiveStrategy =
            new(new float[] { 0, 0.5f, 0.55f, 0.6f, 0.65f, 0.7f, 0.75f, 0.8f });
        public override AdditiveStrategy AddStrategy => AdditiveStrategy;
        public override int MaxLevel => 7;
        public override int Tier => 4;
    }

    [Serialized]
    [Weight(1000)]
    [LocDisplayName("Biochemist Skill Book")]
    [Ecopedia("Items", "Skill Books", createAsSubPage: true)]
    public partial class BiochemistSkillBook : SkillBook<BiochemistSkill, BiochemistSkillScroll> { }

    [Serialized]
    [Weight(100)]
    [LocDisplayName("Biochemist Skill Scroll")]
    public partial class BiochemistSkillScroll
        : SkillScroll<BiochemistSkill, BiochemistSkillBook> { }

    [RequiresSkill(typeof(FarmingSkill), 1)]
    [Ecopedia("Professions", "Scientist", subPageName: "Biochemist Skill Book Item")]
    public partial class BiochemistSkillBookRecipe : RecipeFamily
    {
        public BiochemistSkillBookRecipe()
        {
            Recipe recipe = new();
            recipe.Init(
                name: "Biochemist",
                displayName: Localizer.DoStr("Biochemist Skill Book"),
                ingredients: new List<IngredientElement>
                {
                    new(typeof(CulinaryResearchPaperAdvancedItem), 10, typeof(FarmingSkill)),
                    new(typeof(AgricultureResearchPaperAdvancedItem), 10, typeof(FarmingSkill)),
                    new(typeof(EngineeringResearchPaperModernItem), 10, typeof(FarmingSkill)),
                    new(typeof(AgricultureResearchPaperModernItem), 10, typeof(FarmingSkill)),
                    new("Basic Research", 30, typeof(FarmingSkill)),
                    new("Advanced Research", 20, typeof(FarmingSkill)),
                },
                items: new List<CraftingElement> { new CraftingElement<BiochemistSkillBook>() }
            );
            Recipes = new List<Recipe> { recipe };
            LaborInCalories = CreateLaborInCaloriesValue(600, typeof(FarmingSkill));
            CraftMinutes = CreateCraftTimeValue(
                beneficiary: typeof(BiochemistSkillBookRecipe),
                start: 15,
                skillType: typeof(FarmingSkill)
            );
            Initialize(
                displayText: Localizer.DoStr("Biochemist Skill Book"),
                recipeType: typeof(BiochemistSkillBookRecipe)
            );
            CraftingComponent.AddRecipe(tableType: typeof(LaboratoryObject), recipe: this);
        }
    }
}