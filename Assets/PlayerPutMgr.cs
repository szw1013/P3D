using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//拾取物体控制
public class PlayerPutMgr : MonoBehaviour
{
    public Transform PutObj;

    public float Dir=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PutObj==null)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Ray ray=new Ray(transform.position,transform.forward);
                RaycastHit hit;

                if (Physics.Raycast(ray,out hit,20, 1 << LayerMask.NameToLayer("Box")))
                {
                    PutObj = hit.transform;
                  //  PutObj.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
        else
        {
            PutObj.position = transform.position + transform.forward * Dir;
            if (Input.GetKeyDown(KeyCode.F))
            {
              //  PutObj.GetComponent<Rigidbody>().isKinematic = false;
                PutObj.GetComponent<Rigidbody>().velocity=(transform.forward*9);
                PutObj = null;
            }
        }
    }
}
