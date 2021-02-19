using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBack : MonoBehaviour

{
    float speed = 70.0f;
    public Transform doorOne;
    public Transform doorTwo;
    private bool doorsShouldClose = false;
    private bool doorsHaveClosed = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (doorsShouldClose && !doorsHaveClosed)
        {
            doorOne.Rotate(Vector3.forward * speed * Time.deltaTime);
            doorTwo.Rotate(Vector3.back * speed * Time.deltaTime);
            if (doorTwo.rotation.eulerAngles.y <= 2.5 || doorOne.rotation.eulerAngles.y >= 357.5)
            {
                doorsHaveClosed = true;
                doorsShouldClose = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorsShouldClose = true;
        }
    }
}
