using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // 弾プレハブ
    public GameObject bulletPrefab;

    // 弾生成間隔
    float attackCoolTime;

    // プレイヤーの位置の取得
    float playerX;
    float playerY;

    // 撃破数のカウント
    public int count = 0;

    // 倒せなかった数のカウント
    public int missCount;

    float speed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        // プレイヤーの位置の取得
        playerX = this.transform.position.x;
        playerY = this.transform.position.y;

        // 上矢印キーが押されたら
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // 上方向に移動する
            this.transform.Translate(0.0f, speed, 0.0f);

            float playerY_temp = this.transform.position.y;
            if (playerY_temp > 5)
            {
                transform.position = new Vector3(-5.0f, -5.0f, 0.0f);
            }
        }

        // 下矢印キーが押されたら
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // 下方向に移動する
            this.transform.Translate(0.0f, -speed, 0.0f);

            float playerY_temp = this.transform.position.y;
            if (playerY_temp < -5)
            {
                transform.position = new Vector3(-5.0f, 5.0f, 0.0f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Aが押されたら
        if (Input.GetKeyDown(KeyCode.A))
        {
            // 弾を生成
            GameObject bullet = Instantiate(bulletPrefab);

            // 生成する座標の指定
            bullet.transform.position = new Vector3(playerX, playerY, 0.0f);
        }
    }
}