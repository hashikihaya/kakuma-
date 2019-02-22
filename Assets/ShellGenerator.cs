using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellGenerator : MonoBehaviour {

    public GameObject ShellPrefab;
    private float timecount;

    void Update () {

        //球の連射の間隔時間
        timecount += 0.5f;
        //マウス長押しで連射
        if (Input.GetMouseButton(0))
        {
            if (timecount % 5 == 0)
            {
                GameObject Shell = Instantiate(ShellPrefab) as GameObject;

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 worldDir = ray.direction;
                Shell.GetComponent<ShotShell>().Shoot(worldDir.normalized * 2000);
            }
        }
    }
}
