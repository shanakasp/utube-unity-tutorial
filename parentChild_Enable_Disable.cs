using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript2 : MonoBehaviour
{
    [SerializeField] GameObject _squareParent;
    [SerializeField] GameObject _square;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Debug.Log(_squareParent.activeSelf);
            _squareParent.SetActive(false);
            Debug.Log(_squareParent.activeSelf);
            Debug.Log(_square.activeInHierarchy);

        }

    }
}
