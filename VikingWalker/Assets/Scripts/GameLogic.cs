using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public Text woodCraft;

    private void Update()
    {
        woodCraft.text = PlayerPrefs.GetInt("wood").ToString();
    }
}
