using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public abstract class AbstractController : MonoBehaviour
{
    protected AssetLoader<GameObject> assetLoader = new();

    protected async Task LoadAndInstallAssetAsync(string name)
    {
        var asset = await assetLoader.LoadAsync(name);
        Instantiate(asset);
    }
}