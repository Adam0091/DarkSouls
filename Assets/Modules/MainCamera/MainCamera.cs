using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform followTransform;

    void Start()
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y + 2.843f, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y + 2.843f, this.transform.position.z);
    }
}
