using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreDirector : MonoBehaviour
{
    public int score;

    TextMeshProUGUI scoreText;

    Player miss;

    TextMeshProUGUI missText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        miss = GameObject.Find("Player").GetComponent<Player>();

        missText = GetComponent <TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score + " " + "Miss:" + miss.missCount;

        if (miss.missCount > 2)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
