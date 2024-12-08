﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

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

    [Serialized]
    [LocDisplayName("Parallel Processing: AnimalHusbandry")]
    [LocDescription("Increases the crafting speed of identical tables when they share a room by 20 percent.")]
    public partial class AnimalHusbandryParallelProcessingTalentGroup : TalentGroup
    {

        public AnimalHusbandryParallelProcessingTalentGroup()
        {
            Talents = new Type[]
            {
            
            typeof(AnimalHusbandryParallelSpeedTalent), 
            
            
            };
            this.OwningSkill = typeof(AnimalHusbandrySkill);
            this.Level = 3;
        }
    }

    
    [Serialized]
    public partial class AnimalHusbandryParallelSpeedTalent : ParallelProcessingTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(AnimalHusbandryParallelProcessingTalentGroup); } }
        public AnimalHusbandryParallelSpeedTalent()
        {
            this.Value = 0.8f;
        }
    }
    
}
