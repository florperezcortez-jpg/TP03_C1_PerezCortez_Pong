 using UnityEngine;

public class movementcircle : MonoBehaviour
{
    private SpriteRenderer sr;
    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //velocidad
      
        float step = speed * Time.deltaTime;

        //asignar movimientos
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector2.up * step);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector2.down * step);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector2.left * step);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector2.right * step);

        //rotacion
        if (Input.GetKeyDown(KeyCode.Q))
            transform.Rotate(Vector2.left * 10);
        if (Input.GetKeyDown(KeyCode.E))
            transform.Rotate(Vector2.right * 10);

        //color
        if (Input.GetKeyUp(KeyCode.R))
        {
            float r = Random.value;
            float g = Random.value;
            float b = Random.value;
            sr.color = new Color(r, g, b);
        }
    }
}

