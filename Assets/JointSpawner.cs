using UnityEngine;
using System.Collections.Generic;

public class JointSpawner : MonoBehaviour{

    public GameObject destinationPrefab;
    private List<Collider> currentCollisions = new List<Collider>();
    private Transform t;
    void Start(){
        t = GetComponent<Transform>();
        Instantiate(destinationPrefab, t.position, t.rotation, t);
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "OutputJointDestination") {
            currentCollisions.Add(other);
            while(currentCollisions.Count >= 2)
            {
                Destroy(currentCollisions[0].transform.parent.gameObject);
                currentCollisions.RemoveAt(0);
            }
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "OutputJointDestination") {
            currentCollisions.Remove(other);
            if(currentCollisions.Count == 0)
            {
                Instantiate(destinationPrefab, t.position, t.rotation, t);
            }
        }
    }
}
