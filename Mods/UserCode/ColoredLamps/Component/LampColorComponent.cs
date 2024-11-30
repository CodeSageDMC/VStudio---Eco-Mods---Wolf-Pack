namespace Eco.Mods.TechTree
{
    using Eco.Core.Controller;
    using Eco.Core.Utils;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Networking;
    using Eco.Shared.Serialization;
    using System.ComponentModel;

    [Serialized]
    public class ColorLampData : IController, INotifyPropertyChanged, IClearRequestHandler
    {
        #region IController
        public event PropertyChangedEventHandler PropertyChanged;
        int controllerID;
        public ref int ControllerID => ref this.controllerID;
        #endregion

        [Serialized, SyncToView] public ColorLamp Color { get; set; }
        [Serialized, SyncToView] public string Name { get; set; }

        public ColorLampData()
        {
        }

        public ColorLampData(ColorLamp color, string name)
        {
            Color = color;
            Name = name;
        }

        public Result TryHandleClearRequest(Player player)
        {
            Color = ColorLamp.Yellow;
            return Result.Succeeded;
        }
    }

    [Eco]
    public enum ColorLamp
    {
        Yellow,
        Red,
        Grey,
        Cyan,
        Green,
        Pink,
        Orange,
        LiteBlue,
        LiteOrange,
        LitePink,
        LiteRed
    }

    [Serialized, AutogenClass, LocDisplayName("Color Lamp"), HasIcon, GuestHidden]
    public partial class LampColorComponent : WorldObjectComponent, INotifyPropertyChanged, IPersistentData
    {
        public override bool Enabled => true;
        private ColorLampObject _lampParent { get; set; }
        private ColorLampData _colorData { get; set; }
        private ColorLamp _currentColorLamp { get; set; }

        [Eco, ClientInterfaceProperty, GuestHidden]
        [Serialized, SyncToView]
        public ColorLamp CurrentColorLamp
        {
            get => _currentColorLamp;

            set
            {
                if (value == _currentColorLamp) return;
                _currentColorLamp = value;
                this.Changed(nameof(CurrentColorLamp));
            }
        }

        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Global, flags: TTFlags.ForceInstantUpdate)]
        public object PersistentData
        {
            get => _colorData;
            set
            {
                _colorData = value as ColorLampData ?? new ColorLampData(ColorLamp.Yellow, ColorLamp.Yellow.GetName());
                CurrentColorLamp = _colorData.Color;
                this.Changed(nameof(CurrentColorLamp));
            }
        }

        public override void Initialize()
        {
            base.Initialize();

            _colorData ??= new ColorLampData(CurrentColorLamp, CurrentColorLamp.GetName());
            CurrentColorLamp = _colorData.Color;
            this.Changed(nameof(CurrentColorLamp));

            try
            {
                _lampParent = (ColorLampObject)Parent;
                _lampParent.ChangeColor(_colorData.Color);
            }
            catch
            {
            }
        }

        [RPC, Autogen, GuestHidden]
        public void SetColor(Player player)
        {
            if (_lampParent != null)
            {
                _colorData = new ColorLampData(CurrentColorLamp, CurrentColorLamp.GetName());
                _lampParent.ChangeColor(_colorData.Color);
                PersistentData = _colorData;
            }
        }
    }
}
