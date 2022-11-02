#if UNITY_2019_1_OR_NEWER
using Core.Gameplay.Setting.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Core.Gameplay.Setting.AtomGenerated.Editor.AtomDrawers.Events
{
    /// <summary>
    ///     Event property drawer of type `Setting`. Inherits from `AtomDrawer&lt;SettingEvent&gt;`. Only availble in
    ///     `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SettingEvent))]
    public class SettingEventDrawer : AtomDrawer<SettingEvent>
    {
    }
}
#endif