namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Objects;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Networking;
    using Eco.Shared.Serialization;
    using System.ComponentModel;

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(LampColorComponent))]
    public abstract class ColorLampObject : WorldObject, INotifyPropertyChanged
    {

        [Serialized] private bool _ColorYellow = false;
        [Serialized] private bool _ColorRed = false;
        [Serialized] private bool _ColorGrey = false;
        [Serialized] private bool _ColorCyan = false;
        [Serialized] private bool _ColorGreen = false;
        [Serialized] private bool _ColorPink = false;
        [Serialized] private bool _ColorOrange = false;
        [Serialized] private bool _ColorLiteBlue = false;
        [Serialized] private bool _ColorLiteOrange = false;
        [Serialized] private bool _ColorLitePink = false;
        [Serialized] private bool _ColorLiteRed = false;

        private OnOffComponent _onOff;
        private LampColorComponent _lampColor;
        private ColorLamp _currentColorLamp;
        private bool _isActive = true;

        class LampMultiColorMessagesContainer : OnOffComponent.IOnOffMessagesContainer
        {
            public LocString TurnOnMessage => Localizer.DoStr("Off");
            public LocString TurnOffMessage => Localizer.DoStr("On");
            public LocString TurnedOnMessage => Localizer.DoStr("Off");
            public LocString TurnedOffMessage => Localizer.DoStr("On");
            public LocString NotAuthedMessage => Localizer.DoStr("You are not authorized to On/Off this lamp.");
            public LocString InvalidStatusMessage => Localizer.DoStr("This lamp has an invalid status and cannot ineract.");
        }

        static LampMultiColorMessagesContainer msgContainer = new LampMultiColorMessagesContainer();

        public event PropertyChangedEventHandler PropertyChanged;

        protected override void Initialize()
        {
            base.Initialize();

            _lampColor = this.GetComponent<LampColorComponent>();
            _lampColor.Initialize();
            _currentColorLamp = _lampColor.CurrentColorLamp;

            _onOff = this.GetComponent<OnOffComponent>();
            _onOff.Setup(null, AccessType.ConsumerAccess, true, msgContainer);
            _onOff.On = _isActive;

            this.ChangeColor(_currentColorLamp);
            this.SetAnimatedState("Active", _isActive);
        }

        public override void Tick()
        {
            base.Tick();

            if (_isActive != this.operating)
            {
                _isActive = this.operating;
                _onOff.On = _isActive;
                this.SetAnimatedState("Active", _isActive);
            }
        }

        public void ChangeColor(ColorLamp color)
        {
            UpdateColor(_currentColorLamp, false);
            _currentColorLamp = color;
            UpdateColor(_currentColorLamp, true);
        }

        private void UpdateColor(ColorLamp colorLamp, bool value)
        {
            switch (colorLamp)
            {
                case ColorLamp.Yellow: this.SetAnimatedState("ColorYellow", value); break;
                case ColorLamp.Red: this.SetAnimatedState("ColorRed", value); break;
                case ColorLamp.Grey: this.SetAnimatedState("ColorGrey", value); break;
                case ColorLamp.Cyan: this.SetAnimatedState("ColorCyan", value); break;
                case ColorLamp.Green: this.SetAnimatedState("ColorGreen", value); break;
                case ColorLamp.Pink: this.SetAnimatedState("ColorPink", value); break;
                case ColorLamp.Orange: this.SetAnimatedState("ColorOrange", value); break;
                case ColorLamp.LiteBlue: this.SetAnimatedState("ColorLiteBlue", value); break;
                case ColorLamp.LiteOrange: this.SetAnimatedState("ColorLiteOrange", value); break;
                case ColorLamp.LitePink: this.SetAnimatedState("ColorLitePink", value); break;
                case ColorLamp.LiteRed: this.SetAnimatedState("ColorLiteRed", value); break;
            }
        }

        public override void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer)
        {
            bsonObj["Active"] = _onOff.On;
            bsonObj["ColorYellow"] = _ColorYellow;
            bsonObj["ColorRed"] = _ColorRed;
            bsonObj["ColorGrey"] = _ColorGrey;
            bsonObj["ColorCyan"] = _ColorCyan;
            bsonObj["ColorGreen"] = _ColorGreen;
            bsonObj["ColorPink"] = _ColorPink;
            bsonObj["ColorOrange"] = _ColorOrange;
            bsonObj["ColorLiteBlue"] = _ColorLiteBlue;
            bsonObj["ColorLiteOrange"] = _ColorLiteOrange;
            bsonObj["ColorLitePink"] = _ColorLitePink;
            bsonObj["ColorLiteRed"] = _ColorLiteRed;
            base.SendInitialState(bsonObj, viewer);
        }
    }
}
