using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class LogDisplay : Singleton<LogDisplay>
{
    [SerializeField] TextMeshProUGUI console;

    StringBuilder stringBuilder = new();

    public void AddToLog (string log)
    {
        stringBuilder.AppendLine(log);
        console.text = stringBuilder.ToString();
    }
}