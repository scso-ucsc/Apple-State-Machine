using UnityEngine;

public class AppleRottenState : AppleBaseState
{
    Color brown = new Color(0.325f, 0.15f, 0.075f, 1f);
    private float decayCounter;
    public override void EnterState(AppleStateManager apple)
    {
        Renderer renderer = apple.GetComponent<Renderer>();
        renderer.materials[1].color = brown;
        decayCounter = 0f;
    }

    public override void UpdateState(AppleStateManager apple)
    {
        decayCounter += Time.deltaTime;
        if (decayCounter > 5.0f){ //Switch to Angel State after 5 seconds
            apple.SwitchState(apple.AngelState);
        }
    }

}
