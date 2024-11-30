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

    public partial class RoadExtWhiteDiagonal4LAFormType : FormType
    {
        public override string Name => "RoadExtWhiteDiagonal4LA";
        public override LocString DisplayName => Localizer.DoStr("White Diagonal-4-left A");
        public override LocString DisplayDescription => Localizer.DoStr("White Diagonal-4-left A");
        public override Type GroupType => typeof(RoadExtWhiteLineMarkingsFormGroup);
        public override int SortOrder => 31;
        public override int MinTier => 1;
    }
    public partial class RoadExtWhiteDiagonal4LBFormType : FormType
    {
        public override string Name => "RoadExtWhiteDiagonal4LB";
        public override LocString DisplayName => Localizer.DoStr("White Diagonal-4-left B");
        public override LocString DisplayDescription => Localizer.DoStr("White Diagonal-4-left B");
        public override Type GroupType => typeof(RoadExtWhiteLineMarkingsFormGroup);
        public override int SortOrder => 32;
        public override int MinTier => 1;
    }
    public partial class RoadExtWhiteDiagonal4LCornerFormType : FormType
    {
        public override string Name => "RoadExtWhiteDiagonal4LCorner";
        public override LocString DisplayName => Localizer.DoStr("White Diagonal-4-left Corner");
        public override LocString DisplayDescription => Localizer.DoStr("White Diagonal-4-left Corner");
        public override Type GroupType => typeof(RoadExtWhiteLineMarkingsFormGroup);
        public override int SortOrder => 33;
        public override int MinTier => 1;
    }
    public partial class RoadExtWhiteDiagonal4LEndFormType : FormType
    {
        public override string Name => "RoadExtWhiteDiagonal4LEnd";
        public override LocString DisplayName => Localizer.DoStr("White Diagonal-4-left End");
        public override LocString DisplayDescription => Localizer.DoStr("White Diagonal-4-left End");
        public override Type GroupType => typeof(RoadExtWhiteLineMarkingsFormGroup);
        public override int SortOrder => 34;
        public override int MinTier => 1;
    }
    public partial class RoadExtWhiteDiagonal4LModLineFormType : FormType
    {
        public override string Name => "RoadExtWhiteDiagonal4LModLine";
        public override LocString DisplayName => Localizer.DoStr("White Diagonal-4-left Modified Line");
        public override LocString DisplayDescription => Localizer.DoStr("White Diagonal-4-left Modified Line");
        public override Type GroupType => typeof(RoadExtWhiteLineMarkingsFormGroup);
        public override int SortOrder => 35;
        public override int MinTier => 1;
    }
}
