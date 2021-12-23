using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerVerTwo : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 5,-7);
    private Vector3 offset2 = new Vector3(0, 2, 1);
    private Vector3 camPos;
    private bool camKey = true;

    // Start is called before the first frame update
    void Start()
    {
        camPos = offset1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            camKey = !camKey;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + camPos;

        if (camKey)
        {
            camPos = offset1;
        } else if (!camKey)
        {
            camPos = offset2;
        }
    }

}
