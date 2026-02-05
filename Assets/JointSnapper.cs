using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class JointSnapper : MonoBehaviour{

    public float retractSpeed;

    private Transform src;
    private Transform dst;
    private XRGrabInteractable grabInteractable;
    private Transform t;

    void Start(){
        t = GetComponent<Transform>();
        src = t.parent;
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "InputJoint"){
            dst = other.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "InputJoint"){
            dst = null;
        }
    }
    void Update(){
        if(dst != null){
            t.position = dst.position;
        }else if(!grabInteractable.isSelected){
            t.position += (src.position-t.position)*retractSpeed*Time.deltaTime;
        }
    }
}
