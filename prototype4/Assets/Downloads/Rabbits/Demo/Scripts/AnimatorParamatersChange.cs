using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiveRabbitsDemo
{
    public class AnimatorParamatersChange : MonoBehaviour
    {

        private Animator m_animator;
        public GameObject sword;
        public float degreesPerSecond = 20;
        private bool isRunning = false;
        
        // Use this for initialization
        void Start()
        {
            m_animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if(isRunning){
             transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
            }
        }

        void OnMouseDown(){
            if(sword.GetComponent<PickUp>().isPickedUp){
                m_animator.SetInteger("AnimIndex", 2);
                m_animator.SetTrigger("Next");
                isRunning = false;
                Destroy(this);
            } else {
                m_animator.SetInteger("AnimIndex", 1);
                m_animator.SetTrigger("Next");
                isRunning = true;
            }
        }

    }
}
