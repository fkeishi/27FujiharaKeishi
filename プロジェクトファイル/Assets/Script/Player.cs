using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // �e�v���n�u
    public GameObject bulletPrefab;

    // �e�����Ԋu
    float attackCoolTime;

    // �v���C���[�̈ʒu�̎擾
    float playerX;
    float playerY;

    // ���j���̃J�E���g
    public int count = 0;

    // �|���Ȃ��������̃J�E���g
    public int missCount;

    float speed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        // �v���C���[�̈ʒu�̎擾
        playerX = this.transform.position.x;
        playerY = this.transform.position.y;

        // ����L�[�������ꂽ��
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // ������Ɉړ�����
            this.transform.Translate(0.0f, speed, 0.0f);

            float playerY_temp = this.transform.position.y;
            if (playerY_temp > 5)
            {
                transform.position = new Vector3(-5.0f, -5.0f, 0.0f);
            }
        }

        // �����L�[�������ꂽ��
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // �������Ɉړ�����
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
        // A�������ꂽ��
        if (Input.GetKeyDown(KeyCode.A))
        {
            // �e�𐶐�
            GameObject bullet = Instantiate(bulletPrefab);

            // ����������W�̎w��
            bullet.transform.position = new Vector3(playerX, playerY, 0.0f);
        }
    }
}