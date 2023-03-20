using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform parent;
    public bool isPickedUp = false;
    private Animator anim;


    void Start(){
        this.anim = gameObject.GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
       if (Input.GetMouseButtonDown(0) && isPickedUp)
       {
            anim.enabled = true;
            this.anim.Play("SwordSwing");
       }
    }

    void OnMouseDown(){
        Debug.Log("clicked");

        isPickedUp = true;       
        
        
        this.transform.SetParent(parent);
        this.isPickedUp = true;
        
        this.transform.localPosition = new Vector3(0.4f,0,0);
        this.transform.localEulerAngles = new Vector3(0, 90, 45);
    }
}
