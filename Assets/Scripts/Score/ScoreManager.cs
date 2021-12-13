using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Level;

public class ScoreManager : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;

    //private int _direction = LevelManager.random
    void Update()
    {
        /*if (LevelManager.randomDirection == 0)
        {
            ScoreText.text = Player.position.x.ToString("0");
        }
        else*/
        {
            ScoreText.text = Player.position.z.ToString("0");
        }
        Debug.Log(Player.position.z);
    }
}
