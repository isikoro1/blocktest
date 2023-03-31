using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarManager : MonoBehaviour
{
    public float barSpeed = 12f;

    public float maxX = 10f; // x座標の最大値
    public float minX = -10f; // x座標の最小値
    public float maxY = 5f; // y座標の最大値
    public float minY = -5f; // y座標の最小値

    // Update is called once per frame
    void FixedUpdate()
    {

        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x, 0, 0) * Time.deltaTime * barSpeed;
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, y, 0) * Time.deltaTime * barSpeed;

        


    }
}
