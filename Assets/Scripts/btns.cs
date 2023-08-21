using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OyunaBasla()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
        {
        Application.Quit();

    }
    public void GeriDon()
    {
        SceneManager.LoadScene(0);

    }
}
