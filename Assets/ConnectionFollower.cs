using UnityEngine;

public class ConnectionFollower : MonoBehaviour{

    public float scale;
    private Transform source;
    private Transform destination;
    private Transform t;

    void Start()
    {
        t = GetComponent<Transform>();
        destination = t.parent.GetChild(0).transform;
        source = destination.parent;
    }

    void Update()
    {
        t.position = (source.position+destination.position)/2;
        t.localScale = new Vector3(t.localScale.x,Vector3.Distance(source.position,destination.position)*scale,t.localScale.z);
        if(destination.position-source.position != Vector3.zero){
            t.rotation = Quaternion.LookRotation(destination.position-source.position);
            t.Rotate(new Vector3(90,0,0));
        }
    }
}
