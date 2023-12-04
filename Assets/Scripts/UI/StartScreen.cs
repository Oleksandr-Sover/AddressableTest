using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    [SerializeField] Button buttonSceneA;
    [SerializeField] Button buttonSceneB;

    public Button ButtonSceneA { get => buttonSceneA; }
    public Button ButtonSceneB { get => buttonSceneB; }
}
