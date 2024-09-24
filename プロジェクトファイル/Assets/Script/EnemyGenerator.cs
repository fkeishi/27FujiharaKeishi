using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // 敵プレハブ
    public GameObject enemyPrefab;

    // 敵生成間隔
    float interval;

    // 時間経過
    float time = 0.0f;
    float time2 = 0.0f;

    // 出現位置の指定
    // Y座標の最低位置
    float yMinPosition = -5.0f;
    // Y座標の最高位置
    float yMaxPosition = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // 生成間隔
        interval = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // 時間計測
        time += Time.deltaTime;
        time2 += Time.deltaTime;

        // 経過時間が生成間隔に達したとき
        if (time > interval)
        {
            // Enemyを生成する
            GameObject enemy = Instantiate(enemyPrefab);

            // 生成する座標の指定
            enemy.transform.position = GetRandomPosition();

            // 時間の再計測
            time = 0.0f;
        }

        // 一定時間経過した時
        if (time2 > 7)
        {
            interval = 1.25f;
        }

        // 一定時間経過した時
        if (time2 > 12)
        {
            interval = 1.0f;
        }

        // 一定時間経過した時
        if (time2 > 20)
        {
            interval = 0.75f;
        }

        // 一定時間経過した時
        if (time2 > 27)
        {
            interval = 0.5f;
        }
    }

    // ランダムな位置に生成する関数
    private Vector3 GetRandomPosition()
    {
        float y = Random.Range(yMinPosition, yMaxPosition);

        return new Vector3(10,y,0);
    }
}
