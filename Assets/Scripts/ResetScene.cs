using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -30 || Input.GetKeyDown(KeyCode.Space))
        {
            Reset();
        }
    }

    void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
