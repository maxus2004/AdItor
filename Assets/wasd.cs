using UnityEngine;
using UnityEngine.InputSystem;

public class wasd : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    public float qeSpeed;

    private float yaw = 0.0f, pitch = 0.0f, roll = 0.0f;
    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update(){
        var keyboard = Keyboard.current;
        var mouse = Mouse.current;

        Transform t = GetComponent<Transform>();

        yaw += mouse.delta.x.ReadValue() * rotateSpeed;
        pitch -= mouse.delta.y.ReadValue() * rotateSpeed;

        if (keyboard.qKey.isPressed) roll += qeSpeed * Time.deltaTime;
        if (keyboard.eKey.isPressed) roll -= qeSpeed * Time.deltaTime;

        transform.eulerAngles = new Vector3(0, yaw, 0);
        Camera.main.transform.eulerAngles = new Vector3(pitch, yaw, roll);

        if (keyboard.aKey.isPressed) t.Translate(Vector3.left * speed * Time.deltaTime);
        if (keyboard.dKey.isPressed) t.Translate(Vector3.right * speed * Time.deltaTime);
        if (keyboard.wKey.isPressed) t.Translate(Vector3.forward * speed * Time.deltaTime);
        if (keyboard.sKey.isPressed) t.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
