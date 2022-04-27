using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
    private bool jumpForward;
    
    // POLYMORPHISM
    public override void Jump()
    {
        float amountForward = jumpForward ? 1 : -1;
        Vector3 forwardAndUp = new Vector3(0, 1 * jumpForce, amountForward * 75);
        
        SelfRigidbody.AddForce(forwardAndUp);

        jumpForward = !jumpForward;
    }
}
