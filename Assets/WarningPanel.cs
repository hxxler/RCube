using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningPanel : MonoBehaviour
{
    private const string FirstTimeKey = "FirstTime";

    private void Start()
    {
        bool isFirstTime = PlayerPrefs.GetInt(FirstTimeKey, 1) == 1;
        if (isFirstTime)
        {
            // Показать панель
            gameObject.SetActive(true);
            // Установить флаг, что игра запущена в первый раз
            PlayerPrefs.SetInt(FirstTimeKey, 0);
        }
        else
        {
            // Скрыть панель
            gameObject.SetActive(false);
        }
    }

    public void RemovePanel()
    {
        // Скрыть панель
        gameObject.SetActive(false);
    }
}
