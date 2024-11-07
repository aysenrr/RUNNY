using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScore : MonoBehaviour
{
    public void Retry()
    {
        Score.totalScore = 0;
        SceneManager.LoadScene(1);
    }
}
