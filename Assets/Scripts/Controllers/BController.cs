using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BController : AbstractController
{
    async void Start()
    {
        await LoadAndInstallAssetAsync(AssetsName.sphere);
    }
}