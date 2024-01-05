﻿namespace Broken_WinRT.Code.Utilities.Services.Settings;

public interface ILocalSettingsService
{
    Task<T?> ReadSettingAsync<T>(string key);

    Task SaveSettingAsync<T>(string key, T value);
}
