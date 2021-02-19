using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationForward : MonoBehaviour

{
    float speed = 100.0f;
    public Transform doorOne;
    public Transform doorTwo;
    private bool doorsShouldOpen = false;
    private bool doorsHaveOpened = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (doorsShouldOpen && !doorsHaveOpened)
        {
            doorOne.Rotate(Vector3.back * speed * Time.deltaTime);
            doorTwo.Rotate(Vector3.forward * speed * Time.deltaTime);
            if (doorTwo.rotation.eulerAngles.y >= 87.5 || doorOne.rotation.eulerAngles.y <= 272.5)
            {
                doorsHaveOpened = true;
                doorsShouldOpen = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorsShouldOpen = true;
        }
    }
}
