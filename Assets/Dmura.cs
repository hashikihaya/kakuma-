using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Dmura : MonoBehaviour {


    //プレハブを変数に代入
    public GameObject cube;
    private void Start()
    {

        // 100個ランダムな場所にD村を生成する
        for (int i = 0; i < 150; i++)
        {
            // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
            GameObject cub = Instantiate(cube) as GameObject;
            // ランダムな場所に配置する
            cube.transform.position = new Vector3(Random.Range(-40, 40), Random.Range(5, 2), Random.Range(-40, 40));
        }

    }

     public static int d = 0;
    

    
    void OnCollisionEnter(Collision other)
    {
        
        
            
            if (d <= 149)
            {
                //球に当たったらD村消滅
                if (other.gameObject.tag == "Shell")
                {
                    Destroy(gameObject);
                    d += 1;
                }
            } 
    }
    
    void Update()
    {
        if (d == 150)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
