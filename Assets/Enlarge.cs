using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enlarge : MonoBehaviour
{
    [SerializeField] float Range;
    bool enlarge;
    [SerializeField]float Max,Min;

    // Start is called before the first frame update
    void Start()
    {
        enlarge=true;
        Range = 0.01f;
        Max= 5f;
        Min = 1f;

    }
    // Update is called once per frame
    void Update()
    {
        float x = transform.localScale.x;
        float y= transform.localScale.y;
        float z= transform.localScale.z;
        if(transform.localScale.x<=Max && enlarge&&Max>Min){
            transform.localScale = new Vector3(x+Mathf.Abs(Range),y+Mathf.Abs(Range),z);
            if(transform.localScale.x>=Max)
            enlarge=false;
        }
       else if(transform.localScale.x >=Min && !enlarge&&Max>Min) {
            transform.localScale = new Vector3(x-Mathf.Abs(Range),y-Mathf.Abs(Range),z);
            if(transform.localScale.x <= Min)
             enlarge=true;
        }
    }
}