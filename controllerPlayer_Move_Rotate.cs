using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScripts : MonoBehaviour
{
    [SerializeField] GameObject _item;
    float _moveSpeed = 10f;
    float _rotateSpeed = 100f;

    // Start is called before the first frame update
    void Update()
    {
     
        if(Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector2(0f, _moveSpeed)*Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f,0f, _rotateSpeed) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, -_rotateSpeed) * Time.deltaTime, Space.Self);
        }


    }

    // Update is called once per frame

}
