using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayBox : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�{�b�N�X�̃v���n�u��ݒ�")]
    private GameObject boxPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �ݒ肵��playerPrefab�Ɠ������O(�����"PlayerSphere")��GameObject��T���Ď擾
        GameObject boxObj = GameObject.Find(boxPrefab.name);

        // playerObj�����݂��Ă��Ȃ��ꍇ
        if (boxObj == null)
        {
            // playerPrefab����V����GameObject���쐬
            GameObject newBoxObj = Instantiate(boxPrefab);

            // �V�����쐬����GameObject�̖��O���Đݒ�(�����"PlayerSphere"�ƂȂ�)
            newBoxObj.name = boxPrefab.name;
            // �������Ŗ��O���Đݒ肵�Ȃ��ꍇ�A�����Ō��܂閼�O�́A"PlayerSphere(Clone)"�ƂȂ邽��
            //   13�s�ڂŒT���Ă���"PlayerSphere"���i���Ɍ�����Ȃ����ƂɂȂ�Aplayer�������ɐ��Y�����
            //   �ǂ��������Ƃ��́A22�s�ڂ��R�����g�A�E�g���ăQ�[�������s����΂킩��܂��B
        }
    }
}
