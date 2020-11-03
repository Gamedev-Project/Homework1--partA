using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    [Tooltip("start the movment")]
      [SerializeField]
      float Speed, Range;
    // Start is called before the first frame update
    void Start()
    {
    Range=1;
    Speed=1;
       transform.position =new Vector3(transform.position.x,transform.position.y,transform.position.z);
    }

    // Update is called once per frame
    void Update(){
        float y = Mathf.Sin(Time.time*Speed);
        float x= transform.position.x;
        float z= transform.position.z;
        transform.position = new Vector3(x,y*Range,z);
    }
}
