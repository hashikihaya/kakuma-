using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    int count;
    void Start()
    {
        count = GameObject.FindGameObjectsWithTag("Dmura").Length;
    }

    public GameDirector(int count)
    {
        this.count = count;
    }

    public void DmuraBreak() {
        if (count == 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
