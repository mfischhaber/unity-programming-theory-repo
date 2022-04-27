using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    private bool jumpBackward;
    
    // POLYMORPHISM
    public override void Jump()
    {
        float amountForward = jumpBackward ? 2 : -2;
        Vector3 onlyForward = new Vector3(0, 0, amountForward * 125);

        SelfRigidbody.AddForce(onlyForward);
        
        jumpBackward = !jumpBackward;
    }
}