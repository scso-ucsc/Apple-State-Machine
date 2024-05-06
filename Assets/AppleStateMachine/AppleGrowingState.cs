using UnityEngine;

public class AppleGrowingState : AppleBaseState
{
    Vector3 growthSpeed = new Vector3(0.5f, 0.5f, 0.5f);
    Vector3 startScale = new Vector3(2f, 2f, 2f);
    Vector3 endScale = new Vector3(6f, 6f, 6f);
    
    public override void EnterState(AppleStateManager apple)
    {
       apple.transform.localScale = startScale;
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if (apple.transform.localScale.x < endScale.x){
            apple.transform.localScale += growthSpeed * Time.deltaTime;
        } else {
            apple.SwitchState(apple.WholeState);
        }
    }
}
