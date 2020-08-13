using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("MoveHorizontal"), Input.GetAxis("MoveVertical"), 0.0f);

        if (Input.GetButton("Fire"))
        {
            Debug.Log("Fire!!!");
        }

        if (Input.GetKey(KeyCode.Joystick1Button5))
        {
            animator.SetFloat("Horizontal", movement.x * 0.4f);
            animator.SetFloat("Vertical", movement.y * 0.4f);
            animator.SetFloat("Magnitude", movement.magnitude * 0.4f);
            transform.position += movement * Time.deltaTime * 0.55f;
        } else
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Magnitude", movement.magnitude);
            transform.position += movement * Time.deltaTime;
        }
    }
}
