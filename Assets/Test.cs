using System.Collections;
using System.Collections.Generic;
//��L�f�[�^�i�[�^�Ɋւ���錾
//���LUnity�Ɋւ���@�\�𗘗p���邽�߂̐錾
using UnityEngine;

//�N���X���i�����Test�j�A�X�N���v�g���ƃN���X���͓���B
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    //Start:�ŏ��̈�x�̂ݎ��s
    void Start()
    {

        //�y�ۑ�:�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă��������z
        int[] array = { 8,19,58,168,401 };

        //�y�ۑ�:for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă��������z
        for (int plus = 0; plus < 5; plus++)
        {
            Debug.Log(array[plus]);
        }

        Debug.Log("--------------��������ʃv���O����---------------");
        //�y�ۑ�:for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă��������z
        for (int minus = 4; minus >= 0; minus--)
        {
            Debug.Log(array[minus]);
        } 
    }

    // Update is called once per frame
   //Update�F���t���[��(FPS)���ƂɎ��s
    void Update()
    {
        
    }
}
