using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : AbstractController
{
    [SerializeField] StartScreen startScreen;

    void Awake()
    {
        SubscribeToEvents();
    }

    void SubscribeToEvents()
    {
        startScreen.ButtonSceneA.onClick.AddListener(LoadSceneA);
        startScreen.ButtonSceneB.onClick.AddListener(LoadSceneB);
    }

    void LoadSceneA() => assetLoader.LoadScene(AssetsName.sceneA);

    void LoadSceneB() => assetLoader.LoadScene(AssetsName.sceneB);
}