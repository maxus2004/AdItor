using UnityEngine;

public class LayerSettings : MonoBehaviour{
    void Start(){
        
    }

    public void DeleteLayer()
    {
        Destroy(transform.parent.parent.gameObject);
    }
    void Update(){
        if (Vector3.Distance(Camera.main.transform.position, transform.position) < 1.5f){
            GetComponent<Canvas>().enabled = true;
        }
        else{
            GetComponent<Canvas>().enabled = false;
        }
    }
}
