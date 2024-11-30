﻿
// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from BenefitTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;

    /// <summary>
    /// <para>Server side talent definition for "ToolEfficiency".</para>
    /// <para>More information about Talent objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Skills.Talent.html</para>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    /// </summary>
    public partial class ToolEfficiencyTalent : Talent
    {
        public override bool Base => true;
    }

    /// <summary>
    /// <para>Server side talent group definition for "ToolEfficiency".</para>
    /// <para>More information about TalentGroup objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Skills.TalentGroup.html</para>
    /// </summary>
    [Serialized]
    [LocDisplayName("Tool Efficiency: Logging")]
    [LocDescription("Lowers the calorie cost of using related tool by 20 percent.")]
    public partial class LoggingToolEfficiencyTalentGroup : TalentGroup
    {
        public LoggingToolEfficiencyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(LoggingToolEfficiencyTalent),
            };
            this.OwningSkill = typeof(LoggingSkill);
            this.Level = 3;
        }
    }

    [Serialized]
    public partial class LoggingToolEfficiencyTalent : ToolEfficiencyTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(LoggingToolEfficiencyTalentGroup); } }
        public LoggingToolEfficiencyTalent()
        {
            this.Value = 0.8f;
        }
    }

    /// <summary>
    /// <para>Server side talent group definition for "ToolEfficiency".</para>
    /// <para>More information about TalentGroup objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Skills.TalentGroup.html</para>
    /// </summary>
    [Serialized]
    [LocDisplayName("Tool Efficiency: Mining")]
    [LocDescription("Lowers the calorie cost of using related tool by 20 percent.")]
    public partial class MiningToolEfficiencyTalentGroup : TalentGroup
    {
        public MiningToolEfficiencyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MiningToolEfficiencyTalent),
            };
            this.OwningSkill = typeof(MiningSkill);
            this.Level = 3;
        }
    }

    [Serialized]
    public partial class MiningToolEfficiencyTalent : ToolEfficiencyTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(MiningToolEfficiencyTalentGroup); } }
        public MiningToolEfficiencyTalent()
        {
            this.Value = 0.8f;
        }
    }

    /// <summary>
    /// <para>Server side talent group definition for "ToolEfficiency".</para>
    /// <para>More information about TalentGroup objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Skills.TalentGroup.html</para>
    /// </summary>
    [Serialized]
    [LocDisplayName("Tool Efficiency: Gathering")]
    [LocDescription("Lowers the calorie cost of using related tool by 20 percent.")]
    public partial class GatheringToolEfficiencyTalentGroup : TalentGroup
    {
        public GatheringToolEfficiencyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(GatheringToolEfficiencyTalent),
            };
            this.OwningSkill = typeof(GatheringSkill);
            this.Level = 3;
        }
    }

    [Serialized]
    public partial class GatheringToolEfficiencyTalent : ToolEfficiencyTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(GatheringToolEfficiencyTalentGroup); } }
        public GatheringToolEfficiencyTalent()
        {
            this.Value = 0.8f;
        }
    }
}
