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
    [LocDisplayName("Focused Workflow: AnimalHusbandry")]
    [LocDescription("Doubles the speed of related tables when alone.")]
    public partial class AnimalHusbandryFocusedWorkflowTalentGroup : TalentGroup
    {

        public AnimalHusbandryFocusedWorkflowTalentGroup()
        {
            Talents = new Type[]
            {
            
            typeof(AnimalHusbandryFocusedSpeedTalent), 
            
            
            };
            this.OwningSkill = typeof(AnimalHusbandrySkill);
            this.Level = 3;
        }
    }

    
    [Serialized]
    public partial class AnimalHusbandryFocusedSpeedTalent : FocusedWorkflowTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(AnimalHusbandryFocusedWorkflowTalentGroup); } }
        public AnimalHusbandryFocusedSpeedTalent()
        {
            this.Value = 0.5f;
        }
    }
    
}