using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public Transform player;
    void Update()
    {
        float v=-1*player.position.x;
        scoreText.text = v.ToString("0");
    }
}
