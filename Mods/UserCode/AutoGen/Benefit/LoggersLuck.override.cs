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
    /// <para>Server side talent definition for "LoggersLuck".</para>
    /// <para>More information about Talent objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Skills.Talent.html</para>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    /// </summary>
    public partial class LoggersLuckTalent : Talent
    {
        public override bool Base => true;
    }

    /// <summary>
    /// <para>Server side talent group definition for "LoggersLuck".</para>
    /// <para>More information about TalentGroup objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Skills.TalentGroup.html</para>
    /// </summary>
    [Serialized]
    [LocDisplayName("Loggers Luck: Logging")]
    [LocDescription("[WIP - No functionality yet]Every hit has a chance of destroying tree stumps and splitting trunks immediately.")]
    public partial class LoggingLoggersLuckTalentGroup : TalentGroup
    {
        public LoggingLoggersLuckTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(LoggingLoggersLuckTalent),
            };
            this.OwningSkill = typeof(LoggingSkill);
            
        }
    }

    [Serialized]
    public partial class LoggingLoggersLuckTalent : LoggersLuckTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(LoggingLoggersLuckTalentGroup); } }
        public LoggingLoggersLuckTalent()
        {
            this.Value = 0.1f;
        }
    }
}
