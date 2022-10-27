using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender3 : MonoBehaviour
{
    void OnTriigerStay2D(Collider2D otherCollider)
    {
        Attacker attacker = otherCollider.GetComponent<Attacker>();

        if (attacker)
        {
            // Animation
        }
    }
}
