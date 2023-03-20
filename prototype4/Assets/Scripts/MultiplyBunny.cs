using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplyBunny : MonoBehaviour
{
    public GameObject bunnyPrefab;
    public static int count = 1;
    public GameObject deathScreen;
    public GameObject winScreen;
    private IEnumerator coroutine;
    public GameObject sword;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        coroutine = MultiplyBunnyCoroutine();
        StartCoroutine(coroutine);
    }

    IEnumerator MultiplyBunnyCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        if(MultiplyBunny.count <= 700){
            yield return new WaitForSeconds(5);
            Vector3 newPosition = new Vector3(transform.position.x + Random.Range(-1f, 1f), transform.position.y, transform.position.z + Random.Range(-1f, 1f));
            Instantiate(bunnyPrefab, newPosition, transform.rotation);
            MultiplyBunny.count++;
            Debug.Log(MultiplyBunny.count);
            coroutine = MultiplyBunnyCoroutine();
            StartCoroutine(coroutine);
        }

        if(MultiplyBunny.count == 700 && deathScreen != null){
           deathScreen.active = true;
        }
        
    }

    void OnMouseDown(){
        if(sword.GetComponent<PickUp>().isPickedUp){
            StopCoroutine(coroutine);
            MultiplyBunny.count--;

            if(MultiplyBunny.count == 0){
                winScreen.active = true;
            }

            Destroy(this);
        }
    }
}
