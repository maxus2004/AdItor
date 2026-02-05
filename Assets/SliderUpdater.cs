using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpdater : MonoBehaviour{
    
    void Start(){
        
    }

    public void updateValue(){
        transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = ""+((int)GetComponent<Slider>().value);
    }
    void Update(){
        
    }
}
