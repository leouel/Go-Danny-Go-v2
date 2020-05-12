using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
      //  private Rigidbody2D myBody;
      public static int redrumCounter=0;

    public Transform bottom_Collision;

    public LayerMask playerLayer;
    private Vector3 moveDirection=Vector3.up;
    private Vector3 originPosition;

    void Awake(){
     //           myBody=GetComponent<Rigidbody2D>();

        }

    // Start is called before the first frame update
    void Start()
    {
        //originPosition=transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       // CheckForCollision();
    }

   void OnCollisionEnter2D(Collision2D target) {
     //   print("Collision");
     if(target.gameObject.tag=="Player")
            { Destroy(gameObject);
            }
     /*
     if(target.gameObject.tag == REDRUM.R_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.E_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.D_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.R2_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.U_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.M_TAG){ ++redrumCounter;}
     */
        }
/*
    void OnTriggerEnter2D(Collider2D target) {
     //   print("Collision");
     if(target.gameObject.tag=="Player")
            { Destroy(target.gameObject);
            }
     if(target.gameObject.tag == REDRUM.R_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.E_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.D_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.R2_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.U_TAG){ ++redrumCounter;}
     if(target.gameObject.tag==REDRUM.M_TAG){ ++redrumCounter;}
        }
    */
    /*
     void CheckForCollision ()
     {
       RaycastHit2D hit= Physics2D.Raycast(bottom_Collision.position, Vector2.down, 0.1f,playerLayer);

        if(hit){
        //if (hit.collider.gameObject.tag=="Block"){
            Destroy(hit.collider.gameObject);
       // }
        }
     }*/
}
