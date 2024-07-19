using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScripts : MonoBehaviour
{
    [SerializeField] GameObject _item;

    // Start is called before the first frame update
    void Start()
    {
        int itemCount = 5;

     for(int i = 0; i<=itemCount; i++ )
        {
            SpawinItem();
        }
        
    }

    // Update is called once per frame
   void SpawinItem()
    {
        Instantiate(_item, new Vector2(Random.Range(5.5f, -5.5f), Random.Range(3.5f, -3.5f)), Quaternion.identity);
    }
}
