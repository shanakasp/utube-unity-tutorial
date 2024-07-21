using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript2 : MonoBehaviour
{
    [SerializeField] Transform target;

    Vector2 lastRotation;
   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target.position - transform.position;
       if(lastRotation != direction)
        {
            transform.rotation = Quaternion.FromToRotation(new Vector3(0, 1, 0), direction);
            Debug.Log("test");
        }
        lastRotation = direction;
    }
}
