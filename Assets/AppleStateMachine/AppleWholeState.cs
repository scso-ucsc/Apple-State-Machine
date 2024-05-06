using UnityEngine;

public class AppleWholeState : AppleBaseState
{
    Rigidbody rigidbody;
    float rottenCounter = 0f;
    float timeToRot = 5f;

    public override void EnterState(AppleStateManager apple)
    {
        rigidbody = apple.GetComponent<Rigidbody>();
        rigidbody.useGravity = true;
        rottenCounter = 0;
    }

    public override void UpdateState(AppleStateManager apple)
    {
        rottenCounter += Time.deltaTime;
        if (rottenCounter > timeToRot){
            apple.SwitchState(apple.RottenState);
        }
    }
}
