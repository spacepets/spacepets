using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Movement : MonoBehaviour
{

    Animator petAnimator;
    private GameObject pet;

    // Start is called before the first frame update
    void Start()
    {
        pet = GameObject.Find("animal_people_wolf_1");
        petAnimator = GetComponent<Animator>();

        float run = 1.0f;
        
        petAnimator.SetFloat("vertical", run);
    }

    // Update is called once per frame
    void Update()
    {
        pet.transform.Rotate(0.0f, 0.2f, 0.0f, Space.Self);
    }
}
