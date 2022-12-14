#if UNITY_2019_1_OR_NEWER
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Events;
using Enpiech.Core.Runtime.Gameplay.Setting.AtomGenerated.Pairs;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.Core.Editor.Gameplay.Setting.AtomGenerated.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `SettingPair`. Inherits from `AtomEventEditor&lt;SettingPair, SettingPairEvent&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SettingPairEvent))]
    public sealed class SettingPairEventEditor : AtomEventEditor<SettingPair, SettingPairEvent>
    {
    }
}
#endif