using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSample : MonoBehaviour
{
    private GameObject player;   //�v���C���[���i�[�p
    private Vector3 offset;      //���΋����擾�p
    // Start is called before the first frame update
    void Start()
    {
        //unitychan�̏����擾
        this.player = GameObject.Find("Player");

        // MainCamera(�������g)��player�Ƃ̑��΋��������߂�
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //�V�����g�����X�t�H�[���̒l��������
        transform.position = player.transform.position + offset;

        //���V�t�g��������Ă��鎞
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //���j�e�B�����𒆐S��-5f�x��]
            transform.RotateAround(player.transform.position, Vector3.up, -0.5f);
        }
        //�E�V�t�g��������Ă��鎞
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //���j�e�B�����𒆐S��5f�x��]
            transform.RotateAround(player.transform.position, Vector3.up, 0.5f);
        }
    }
}
