using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleAngelState : AppleBaseState //Signifies state for state machine
{
    private Rigidbody rb;
    private Renderer appleRenderer;
    private Color finalColour;

    //EnterState is the function called upon entering this state
    public override void EnterState(AppleStateManager apple) //Apple is the GameObject but of AppleStateManager type
    {
        finalColour = Color.white;
        appleRenderer = apple.GetComponent<Renderer>();

        appleRenderer.materials[0].color = finalColour; //Changing colour of apple to white
        appleRenderer.materials[1].color = new Color(1.0f, 1.0f, 1.0f, 0f);

        rb = apple.GetComponent<Rigidbody>();
        rb.useGravity = false; //Deactivating Gravity
    }

    public override void UpdateState(AppleStateManager apple)
    {
        rb.AddForce(Vector3.up * Time.deltaTime, ForceMode.Impulse); //Send apple upwards
        
        if(apple.transform.position.y >= 2){ //Deactivating apple upon reaching a height of 2
            apple.gameObject.SetActive(false);
        }
    }
}
