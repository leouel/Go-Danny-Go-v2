using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maze : MonoBehaviour
{
  public GameObject redrumPrefab = null;

    // Start is called before the first frame update
    void Start()
    {
        //if(Block.redrumCounter==6){
        Instantiate(redrumPrefab, transform.position, Quaternion.identity);
    } //}

    /*
    void OnCollisionEnter2D(Collision2D target) {
     //   print("Collision");
     if(target.gameObject.tag=="Player")
{
            UnityEngine.SceneManagement.SceneManager.LoadScene("MazeLevel");
            }
            */
     //}
}
