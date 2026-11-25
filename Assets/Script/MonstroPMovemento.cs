using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class MonstroPMovemento : MonoBehaviour
{
    public GameObject player;
    public float speed = 4f;
    public SpriteRenderer spriteRenderer;


    public void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.transform.position - transform.position).normalized;

            transform.position =  Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

            if (direction.x >= 0.0f) transform.localScale = new Vector3(-8.0f, 8.0f, 8.0f);

            else transform.localScale = new Vector3(8.0f, 8.0f, 8.0f);

            float distance = Mathf.Abs(player.transform.position.x - transform.position.x);
            
        }
    }
}
