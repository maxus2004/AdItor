using UnityEngine;

public class LayerAdder : MonoBehaviour{

    public GameObject inputLayer;
    public GameObject outputLayer;
    public GameObject convoluteLayer;
    public GameObject poolingLayer;
    public GameObject denseLayer;
    public GameObject dropoutLayer;
    public GameObject recurrentLayer;
    void Start(){
        
    }

    void Update(){
        
    }

    public void CreateInputLayer()
    {
        Transform t = GetComponent<Transform>();
        Instantiate(inputLayer,t.position,t.rotation);
        Destroy(t.parent.gameObject);
    }
    public void CreateOutputLayer()
    {
        Transform t = GetComponent<Transform>();
        Instantiate(outputLayer,t.position,t.rotation);
        Destroy(t.parent.gameObject);
    }
    public void CreateRecurrentLayer()
    {
        Transform t = GetComponent<Transform>();
        Instantiate(recurrentLayer,t.position,t.rotation);
        Destroy(t.parent.gameObject);
    }
    public void CreateConvoluteLayer()
    {
        Transform t = GetComponent<Transform>();
        Instantiate(convoluteLayer,t.position,t.rotation);
        Destroy(t.parent.gameObject);
    }
    public void CreateDenseLayer()
    {
        Transform t = GetComponent<Transform>();
        Instantiate(denseLayer,t.position,t.rotation);
        Destroy(t.parent.gameObject);
    }
    public void CreateDropoutLayer()
    {
        Transform t = GetComponent<Transform>();
        Instantiate(dropoutLayer,t.position,t.rotation);
        Destroy(t.parent.gameObject);
    }
    public void CreatePoolingLayer()
    {
        Transform t = GetComponent<Transform>();
        Instantiate(poolingLayer,t.position,t.rotation);
        Destroy(t.parent.gameObject);
    }
}
