using UnityEngine;
using TMPro;

public class Cat : Animal
{
    public TextMeshProUGUI soundText;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody rigid;
    private bool isGrounded = true;
    private void InitAnimal()
    {
        AnimalName = "Cat";
        Sound = "Meow";
    }
    
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        InitAnimal();
    }

    
    protected override void Jump()
    {
        rigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnMouseDown()
    {
        soundText.text = Talk();

        if (isGrounded)
        {
            Jump();
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        soundText.text = "";
    }
}
