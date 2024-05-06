using UnityEngine;

public class AppleStateManager : MonoBehaviour
{

    AppleBaseState currentState;

    public AppleGrowingState GrowingState = new AppleGrowingState();
    public AppleWholeState WholeState = new AppleWholeState();
    public AppleRottenState RottenState = new AppleRottenState();

    public AppleAngelState AngelState = new AppleAngelState(); //AngelState is the name of the state variable

    // Start is called before the first frame update
    void Start()
    {
        currentState = GrowingState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(AppleBaseState state){
        currentState = state;
        state.EnterState(this);
    }
}
