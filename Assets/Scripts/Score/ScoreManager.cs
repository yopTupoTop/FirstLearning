using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Level;

public class ScoreManager : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    void Update()
    {
        if (LevelManager.lastDirection == 0)
        {
            ScoreText.text = Player.position.x.ToString("0");
            Debug.Log(Player.position.x);
        }
        else
        {
            ScoreText.text = Player.position.z.ToString("0");
            Debug.Log(Player.position.z);
        }
        
    }
}
