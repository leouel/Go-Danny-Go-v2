using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REDRUM : MonoBehaviour
{
    public GameObject redrumPrefab = null;


    public static string R_TAG = "R";
    public static string E_TAG = "E";
    public static string D_TAG = "D";
    public static string R2_TAG = "R2";
    public static string U_TAG = "U";
    public static string M_TAG = "M";


    // Start is called before the first frame update
    void Start()
    {

        Instantiate(redrumPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
