using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AssetLoader<T>
{
    public void LoadScene(string name)
    {
        LogDisplay.Instance.AddToLog($"Trying to load scene: {name}");

        Addressables.LoadSceneAsync(name).Completed += op =>
        {
            LogDisplay.Instance.AddToLog($"Scene {name} loaded successfully: {op.Status}");
        };
    }

    public async Task<T> LoadAsync(string assetAddress)
    {
        LogDisplay.Instance.AddToLog($"Trying to load asset: {assetAddress}");

        AsyncOperationHandle<T> handle = Addressables.LoadAssetAsync<T>(assetAddress);
        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            LogDisplay.Instance.AddToLog($"Asset {assetAddress} loaded successfully");
        }
        else
        {
            LogDisplay.Instance.AddToLog($"Failed to load asset: {assetAddress}");
        }

        return handle.Result;
    }
}