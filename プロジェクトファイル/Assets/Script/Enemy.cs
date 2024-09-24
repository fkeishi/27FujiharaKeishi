using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;

public class Enemy : MonoBehaviour
{
    Vector3 targetPosition = new Vector3(-10,0,0);

    int damage = 1;

    int hp = 4;

    Player destoryCount;
    Player missCount;

    public AudioClip sound;

    ScoreDirector score;

    float speed = -0.025f;

    // Start is called before the first frame update
    void Start()
    {
        destoryCount = GameObject.Find("Player").GetComponent<Player>();
        missCount = GameObject.Find("Player").GetComponent<Player> ();

        score = GameObject.Find("Score").GetComponent<ScoreDirector>();
    }

    private void FixedUpdate()
    {
        this.transform.Translate(speed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 0)
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(sound,transform.position);
            destoryCount.count++;
            score.score += 500;
        }

        if (this.transform.position.x < -11)
        {
            Destroy(gameObject);
            missCount.missCount += 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hp = hp - damage;
    }
}