﻿namespace OpenTabletDriver.Plugin.Platform.Keyboard
{
    public interface IVirtualKeyboard
    {
        void Press(string key);
        void Release(string key);
    }
}