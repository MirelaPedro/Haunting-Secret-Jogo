using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caveira : MonoBehaviour
{

    public GameObject caveira;
    // Start is called before the first frame update
    void Start()
    {
        caveira.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Item pego!");

            caveira.gameObject.SetActive(true);

        }
    }
}
