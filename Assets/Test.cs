using System.Collections;
using System.Collections.Generic;
//��L�f�[�^�i�[�^�Ɋւ���錾
//���LUnity�Ɋւ���@�\�𗘗p���邽�߂̐錾
using UnityEngine;



public class Boss
{
    //�y���W�ۑ�:Lesson4�ō쐬����Boss�N���X�����Ƃɍ쐬���Ă��������z
    //�y���W�ۑ�1:int�^�̕ϐ�mp��錾���A53�ŏ��������Ă���������1�z
    private int mp;    //mp�c��(�錾�̂�)
    private int cost = 5;   //mp�����(�Œ�l)

    //�y���W�ۑ�2:mp������Ė��@�U��������Magic�֐�������Ă��������z
    public void Magic()
    {
        //�y���W�ۑ�3:Magic�֐�����mp��5�ȏ�̏ꍇ��5���炵(�ȍ~�ȗ�)�z
        for (int mp =�@53 ; mp > 0 ; mp -= cost) �@//��1�����l53��ݒ�Bmp��cost�̏����for���Ŕ��ʁimp�����l53�Ə���5�ł����10�񃋁[�v����j
        {
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");  //mp��cost�������Ă�ۂɕ\��(�c�ʂ���)
        }
        Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");  //mp��cost��������Ă�ۂɕ\��(�c�ʂȂ�)
    }

}


    //�N���X���i�����Test�j�A�X�N���v�g���ƃN���X���͓���B
    public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    //Start:�ŏ��̈�x�̂ݎ��s
    void Start()
    {

        //�y�ۑ�1:�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă��������z
        int[] array = { 8, 19, 58, 168, 401 };

        //�y�ۑ�2:for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă��������z
        for (int plus = 0; plus < 5; plus++)
        {
            Debug.Log(array[plus]);
        }

        Debug.Log("--------------��������ʃv���O����---------------");
        //�y�ۑ�3:for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă��������z
        for (int minus = 4; minus >= 0; minus--)
        {
            Debug.Log(array[minus]);
        }

        Debug.Log("--------------��������ʃv���O����---------------");
        //�y���W�ۑ�4:Magic�֐����Ăяo���āA���@���g���Ă��������z
        Boss bossmp = new Boss();

        //�y���W�ۑ�5:Magic�֐���10��g������ɁA�����Magic�֐����Ăяo����(�ȍ~�ȗ�)�z
        bossmp.Magic();

    }

    // Update is called once per frame
    //Update�F���t���[��(FPS)���ƂɎ��s
    void Update()
    {
        
    }
}

