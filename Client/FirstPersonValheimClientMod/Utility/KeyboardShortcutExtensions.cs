using System.Linq;
using BepInEx.Configuration;
using UnityEngine;

namespace Loki.Mods.Utility {
    public static class KeyboardShortcutExtensions {
        
        /// <summary>
        /// Returns whether the given KeyboardShortcut is active (key = down this frame)
        /// </summary>
        public static bool IsDown(KeyboardShortcut value) {
            if (!Input.GetKeyDown(value.MainKey)) return false;
            return value.Modifiers == null || value.Modifiers.All(Input.GetKey);
        }
        
    }
}