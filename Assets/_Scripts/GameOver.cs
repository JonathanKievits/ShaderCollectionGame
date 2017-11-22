using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    private Score scrptScore;

    private void Start()
    {
        scrptScore = GetComponent<Score>();
    }

    private void Update()
    {
        if (scrptScore.getScore <= 0)
            SceneManager.LoadScene(1);
    }
}
