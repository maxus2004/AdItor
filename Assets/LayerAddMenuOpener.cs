using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class LayerAddMenuOpener : MonoBehaviour{

    public InputActionProperty openMenuAction;
    public GameObject menu;

    private GameObject openedMenu = null;
    void Start(){
        
    }

    void OnEnable(){
        openMenuAction.action.Enable();
    }

    void Update(){
        if (openMenuAction.action.WasPressedThisFrame()){
            if(openedMenu == null){
                openedMenu = Instantiate(menu,Camera.main.transform.position,Camera.main.transform.rotation);
            }
            else{
                Destroy(openedMenu);
                openedMenu = null;
            }
        }
    }
}
