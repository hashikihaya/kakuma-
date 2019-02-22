using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dmuraseisei : MonoBehaviour {

    public GameObject Cube;

    private void Start()
    {
        //D村が生成される大きさをランダムに設定
        transform.localScale = new Vector3(Random.Range(1f, 5), Random.Range(1f, 20), Random.Range(1f, 5));
    }
}
