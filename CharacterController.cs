using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
   [SerializeField] private PhotonView view;
   [SerializeField] private Rigidbody rigid;
    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetKey(KeyCode.D))
            {
                rigid.AddForce(1000*Time.deltaTime,0,0);
            } 
            if (Input.GetKey(KeyCode.A))
            {
                rigid.AddForce(-1000*Time.deltaTime,0,0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                rigid.AddForce(0,0,1000*Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rigid.AddForce(0,0,-1000*Time.deltaTime);
            }
        }
    }
}
