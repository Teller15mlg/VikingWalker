using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    void Update()
    {
        float currentspeed = GetComponentInParent<CharacterController>().velocity.magnitude;
        GetComponent<Animator>().SetFloat("Speed", currentspeed);
        float random = Mathf.Sin(Time.time);
        GetComponent<Animator>().SetFloat("Randomizer", random);
    }
}
