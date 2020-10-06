using UnityEngine;

public class CharacterController1 : MonoBehaviour
{
    private CharacterController m_Controller;
    public float jumpHeight = 1f;
    public float Speed = 1f;

    void Awake()
    {
        m_Controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        float HorizontalM = Input.GetAxisRaw("Horizontal");
        float VerticalM = Input.GetAxisRaw("Vertical");
        bool jumpbut = Input.GetButtonDown("Jump");

        Vector3 moveD = (HorizontalM * transform.forward * Speed);
        m_Controller.Move(moveD);

        if(jumpbut == true)
        {
            moveD += (jumpHeight * transform.up * 1);
        }
    }
}
