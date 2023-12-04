using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AController : AbstractController
{
    async void Start()
    {
        await LoadAndInstallAssetAsync(AssetsName.cube);
    }
}
