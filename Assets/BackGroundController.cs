using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    //�X�N���[�����x
    private float scrollSpeed = -1;
    //�w�i�I���ʒu
    private float deadLine = -16;
    //�w�i�J�n�ʒu
    private float startLine = 15.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�w�i���ړ�����
        transform.Translate(this.scrollSpeed * Time.deltaTime, 0, 0);

        //��ʊO�ɂł����ʉE�[�Ɉړ�����
        if(transform.position.x < this.deadLine)
        {
            transform.position = new Vector2(this.startLine, 0);
        }
    }
}
