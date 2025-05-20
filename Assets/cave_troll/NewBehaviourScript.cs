 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Animator an;

    public GameObject ga,ga1;
    void Start()
    {
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            an.SetBool("a",true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            an.SetBool("b", true);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            an.SetBool("a", false);
            an.SetBool("b", false);
            an.SetBool("r", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ga.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ga1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            an.SetBool("r", true);

        }


    }
}
