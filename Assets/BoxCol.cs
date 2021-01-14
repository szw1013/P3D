using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//进入生成
public class BoxCol : MonoBehaviour
{
    public Transform BoxPrb;
    public Transform mPlayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Instantiate(BoxPrb,mPlayer.transform.position+mPlayer.forward*1,BoxPrb.rotation).gameObject.SetActive(true);
        }
    }
}
