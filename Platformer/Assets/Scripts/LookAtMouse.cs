using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
  Rigidbody player;
  int groundMask;
  void Start()
  {
    player = GetComponent<Rigidbody>();
    groundMask = LayerMask.GetMask("Ground");
  }

  // Update is called once per frame
  void Update()
  {
    Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if (Physics.Raycast(camRay, out hit, Mathf.Infinity, groundMask))
    {
      //Debug.Log("Mouse ray!");
      Vector3 look = hit.point - player.transform.position;
      look.y = 0;
      Quaternion newLook = Quaternion.LookRotation(look);
      player.MoveRotation(newLook);
    }
  }
}
