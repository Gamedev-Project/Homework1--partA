using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public bool Disappear;
    
    // Start is called before the first frame update
    void Start()
    {
      Disappear=false;
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer render=gameObject.GetComponentInChildren<SpriteRenderer>();
       
       if(Input.GetMouseButtonDown(0)){
      
       // child.gameObject.SetActive(false);
       if(render.enabled==false){
       render.enabled=true;
       }
       else 
        render.enabled=false;
       
       }
       
    }
}
