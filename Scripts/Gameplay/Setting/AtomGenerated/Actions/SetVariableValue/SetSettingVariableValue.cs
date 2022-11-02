using Core.Gameplay.Setting.AtomGenerated.Constants;
using Core.Gameplay.Setting.AtomGenerated.Events;
using Core.Gameplay.Setting.AtomGenerated.Functions;
using Core.Gameplay.Setting.AtomGenerated.Pairs;
using Core.Gameplay.Setting.AtomGenerated.References;
using Core.Gameplay.Setting.AtomGenerated.VariableInstancers;
using Core.Gameplay.Setting.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Core.Gameplay.Setting.AtomGenerated.Actions.SetVariableValue
{
    /// <summary>
    ///     Set variable value Action of type `Setting`. Inherits from `SetVariableValue&lt;Setting, SettingPair,
    ///     SettingVariable, SettingConstant, SettingReference, SettingEvent, SettingPairEvent, SettingVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Setting", fileName = "SetSettingVariableValue")]
    public sealed class SetSettingVariableValue : SetVariableValue<
        Setting,
        SettingPair,
        SettingVariable,
        SettingConstant,
        SettingReference,
        SettingEvent,
        SettingPairEvent,
        SettingSettingFunction,
        SettingVariableInstancer>
    {
    }
}