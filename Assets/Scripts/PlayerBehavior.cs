using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    //Attributes
    [SerializeField] private float speed;
    [SerializeField] private int health;
    [SerializeField] private float damage;
    [SerializeField] private float range;
    [SerializeField] private float attackSpeed;


    private GameObject playerProperties;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerProperties = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        PlayerAttack(range,attackSpeed);
    }

    void PlayerMovement()
    {   

        if (Input.GetKey(KeyCode.W))
        {
            playerProperties.transform.position = playerProperties.transform.position + new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerProperties.transform.position = playerProperties.transform.position + new Vector3(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerProperties.transform.position = playerProperties.transform.position + new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerProperties.transform.position = playerProperties.transform.position + new Vector3(speed, 0, 0);
        }
    }

    void PlayerAttack(float range, float attackSpeed)
    {

    }
}
