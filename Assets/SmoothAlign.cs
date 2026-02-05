using UnityEngine;

public class SmoothAlign : MonoBehaviour{
    
    private Rigidbody rb;
    private Transform t;

    void Start(){
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }

    void FixedUpdate(){
        float x_torque = -t.rotation.eulerAngles.x;
        float z_torque = -t.rotation.eulerAngles.z;
        if(x_torque < -180) x_torque += 360;
        if(z_torque < -180) z_torque += 360;

        x_torque*=5;
        z_torque*=5;

        if(x_torque > 100) x_torque = 100;
        if(z_torque > 100) z_torque = 100;
        if(x_torque < -100) x_torque = -100;
        if(z_torque < -100) z_torque = -100;
        rb.AddRelativeTorque(new Vector3(x_torque, 0, z_torque) * Time.fixedDeltaTime);

        if(t.position.y < 0.5f) t.position = new Vector3(t.position.x, 0.5f, t.position.z);
    }
}
