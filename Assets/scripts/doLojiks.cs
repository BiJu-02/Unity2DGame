using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class doLojiks : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;

    //[ContextMenu("inc score")]
    public void addScore()
    {
        score++;
        scoreText.text = score.ToString();
        if (score > 3) { SceneManager.LoadScene("level2"); }
    }

}
