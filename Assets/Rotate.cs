using UnityEngine; 
using System.Collections; 
 
public class Rotate : MonoBehaviour { 

    public float degreesPerSec = 100f; 
    public bool ClockWise=false;
    void Start() { 
    } 
 
    void Update() { 
        float rotAmount;
        if(ClockWise){
        rotAmount = degreesPerSec * Time.deltaTime*-1; 
        }
        else{
        rotAmount = degreesPerSec * Time.deltaTime;
        }
        float curRot = transform.localRotation.eulerAngles.z; 
        transform.localRotation = Quaternion.Euler(new Vector3(0,0,curRot+rotAmount)); 
    } 
 
}
