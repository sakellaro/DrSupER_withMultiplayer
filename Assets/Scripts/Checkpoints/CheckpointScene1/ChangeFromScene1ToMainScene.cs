using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeFromScene1ToMainScene : MonoBehaviour
{
    private float distance;

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, GameObject.Find("Capsule").transform.position);
        Debug.Log(distance);
        if (distance < 1.5f)
        {
            LoadA("Scene");
        }
    }
    public void LoadA(string scene_name)
    {
        Debug.Log("sceneName to load:" + scene_name);
        SceneManager.LoadScene(scene_name);
    }
}
