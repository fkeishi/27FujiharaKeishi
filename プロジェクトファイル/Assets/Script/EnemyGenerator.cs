using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // �G�v���n�u
    public GameObject enemyPrefab;

    // �G�����Ԋu
    float interval;

    // ���Ԍo��
    float time = 0.0f;
    float time2 = 0.0f;

    // �o���ʒu�̎w��
    // Y���W�̍Œ�ʒu
    float yMinPosition = -5.0f;
    // Y���W�̍ō��ʒu
    float yMaxPosition = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // �����Ԋu
        interval = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // ���Ԍv��
        time += Time.deltaTime;
        time2 += Time.deltaTime;

        // �o�ߎ��Ԃ������Ԋu�ɒB�����Ƃ�
        if (time > interval)
        {
            // Enemy�𐶐�����
            GameObject enemy = Instantiate(enemyPrefab);

            // ����������W�̎w��
            enemy.transform.position = GetRandomPosition();

            // ���Ԃ̍Čv��
            time = 0.0f;
        }

        // ��莞�Ԍo�߂�����
        if (time2 > 7)
        {
            interval = 1.25f;
        }

        // ��莞�Ԍo�߂�����
        if (time2 > 12)
        {
            interval = 1.0f;
        }

        // ��莞�Ԍo�߂�����
        if (time2 > 20)
        {
            interval = 0.75f;
        }

        // ��莞�Ԍo�߂�����
        if (time2 > 27)
        {
            interval = 0.5f;
        }
    }

    // �����_���Ȉʒu�ɐ�������֐�
    private Vector3 GetRandomPosition()
    {
        float y = Random.Range(yMinPosition, yMaxPosition);

        return new Vector3(10,y,0);
    }
}
