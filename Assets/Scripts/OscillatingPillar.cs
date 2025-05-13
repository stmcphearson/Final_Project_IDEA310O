using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class OscillatingPillar : MonoBehaviour
{

    public float speed = 1.0f;

    public Vector3 start;
    public Vector3 des;

    private float fraction = 0;

    public bool oscillate = false;
    public bool disappear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fraction < 1 && oscillate)
        {
            fraction += speed * Time.deltaTime;
            transform.position = Vector3.Lerp(start, des, fraction);
        } else if (oscillate)
        {
            var oldStart = start;
            var oldDes = des;
            start = oldDes;
            des = oldStart;
            fraction = 0;
        } else if (disappear)
        {
            gameObject.SetActive(false);
        }
    }
}
