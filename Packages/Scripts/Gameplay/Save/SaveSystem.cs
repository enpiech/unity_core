﻿using Core.Gameplay.Setting.AtomGenerated.Events;
using Cysharp.Threading.Tasks;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Core.Gameplay.Save
{
    [CreateAssetMenu(fileName = "SaveSystem", menuName = "Game/SaveSystem")]
    public class SaveSystem : DescriptionBaseSO
    {
        [Header("Config")]
        [SerializeField]
        private string _saveFileName = "save.cricket";

        [SerializeField]
        private string _backupSaveFileName = "save.cricket.bak";

        [Header("Listening to")]
        [SerializeField]
        private SettingEvent _onSavingSetting = default!;

        [SerializeField]
        private VoidEvent _onLoadingSavedSetting = default!;

        [Header("Broadcasting on")]
        [SerializeField]
        private SettingEvent _onSavedSettingLoaded = default!;

        private readonly Save _saveData = new();

        private void OnEnable()
        {
            _onSavingSetting.Register(OnSavingSetting);
            _onLoadingSavedSetting.Register(OnLoadingSavedSetting);
        }

        private void OnDisable()
        {
            _onSavingSetting.Unregister(OnSavingSetting);
            _onLoadingSavedSetting.Unregister(OnLoadingSavedSetting);
        }

        private void OnLoadingSavedSetting()
        {
            if (LoadSaveDataFromDisk())
            {
                _onSavedSettingLoaded.Raise(_saveData.Setting);
            }
        }

        private void OnSavingSetting(Setting.Setting setting)
        {
            SaveDataToDisk(setting);
        }

        public bool LoadSaveDataFromDisk()
        {
            if (!FileManager.LoadFromFile(_saveFileName, out var json) || string.IsNullOrEmpty(json))
            {
                return false;
            }

            _saveData.LoadFromJson(json);
            return true;
        }

        private void SaveDataToDisk(Setting.Setting setting)
        {
            if (!FileManager.MoveFile(_saveFileName, _backupSaveFileName))
            {
                return;
            }

            _saveData.Setting = setting;
            if (FileManager.WriteToFile(_saveFileName, _saveData.ToJson()))
            {
                Debug.Log($"Save successful {_saveFileName}");
            }
        }

        public void SetNewGameData()
        {
            FileManager.WriteToFile(_saveFileName, string.Empty);

            SaveDataToDisk(new Setting.Setting());
        }

        public void WriteEmptySaveFile()
        {
            FileManager.WriteToFile(_saveFileName, string.Empty);
        }

        public async UniTaskVoid LoadSavedInventory()
        {
        }

        public void LoadSavedQuestLineStatus()
        {
        }
    }
}