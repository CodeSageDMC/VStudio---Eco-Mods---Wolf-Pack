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
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Serialization;
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;

    public partial class RoadExtOrangeDiagonal4RAFormType : FormType
    {
        public override string Name => "RoadExtOrangeDiagonal4RA";
        public override LocString DisplayName => Localizer.DoStr("Orange Diagonal-4-right A");
        public override LocString DisplayDescription => Localizer.DoStr("Orange Diagonal-4-right A");
        public override Type GroupType => typeof(RoadExtOrangeLineMarkingsFormGroup);
        public override int SortOrder => 41;
        public override int MinTier => 1;
    }
    public partial class RoadExtOrangeDiagonal4RBFormType : FormType
    {
        public override string Name => "RoadExtOrangeDiagonal4RB";
        public override LocString DisplayName => Localizer.DoStr("Orange Diagonal-4-right B");
        public override LocString DisplayDescription => Localizer.DoStr("Orange Diagonal-4-right B");
        public override Type GroupType => typeof(RoadExtOrangeLineMarkingsFormGroup);
        public override int SortOrder => 42;
        public override int MinTier => 1;
    }
    public partial class RoadExtOrangeDiagonal4RCornerFormType : FormType
    {
        public override string Name => "RoadExtOrangeDiagonal4RCorner";
        public override LocString DisplayName => Localizer.DoStr("Orange Diagonal-4-right Corner");
        public override LocString DisplayDescription => Localizer.DoStr("Orange Diagonal-4-right Corner");
        public override Type GroupType => typeof(RoadExtOrangeLineMarkingsFormGroup);
        public override int SortOrder => 43;
        public override int MinTier => 1;
    }
    public partial class RoadExtOrangeDiagonal4REndFormType : FormType
    {
        public override string Name => "RoadExtOrangeDiagonal4REnd";
        public override LocString DisplayName => Localizer.DoStr("Orange Diagonal-4-right End");
        public override LocString DisplayDescription => Localizer.DoStr("Orange Diagonal-4-right End");
        public override Type GroupType => typeof(RoadExtOrangeLineMarkingsFormGroup);
        public override int SortOrder => 44;
        public override int MinTier => 1;
    }
    public partial class RoadExtOrangeDiagonal4RModLineFormType : FormType
    {
        public override string Name => "RoadExtOrangeDiagonal4RModLine";
        public override LocString DisplayName => Localizer.DoStr("Orange Diagonal-4-right Modified Line");
        public override LocString DisplayDescription => Localizer.DoStr("Orange Diagonal-4-right Modified Line");
        public override Type GroupType => typeof(RoadExtOrangeLineMarkingsFormGroup);
        public override int SortOrder => 45;
        public override int MinTier => 1;
    }
}
