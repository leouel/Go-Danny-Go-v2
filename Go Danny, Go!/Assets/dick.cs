using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dick : MonoBehaviour
{
    public GameObject redrumPrefab=null;

    // Start is called before the first frame update
    void Start()
    {
        //if(Block.redrumCounter==6){
        Instantiate(redrumPrefab, transform.position, Quaternion.identity);
    } //}
}
