using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private TextMesh nameText;

    protected Rigidbody SelfRigidbody;
    protected float jumpForce = 500f;

    private bool isOnPlane;
    private int nameLimit = 6;

    // ENCAPSULATION
    private string m_Name;
    public string Name
    {
        get => m_Name;
        set => m_Name = value.Substring(0, nameLimit);
    }

    void Start()
    {
        SelfRigidbody = GetComponent<Rigidbody>();

        SetNameText(m_Name);
    }
    void Update()
    {
        if (isOnPlane && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    // ABSTRACTION
    public virtual void Jump()
    {
        SelfRigidbody.AddForce(Vector3.up * jumpForce);
    }


    // ABSTRACTION
    private void SetNameText(string value)
    {
        nameText.text = value;
    }
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            isOnPlane = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            isOnPlane = false;
        }
    }
}
