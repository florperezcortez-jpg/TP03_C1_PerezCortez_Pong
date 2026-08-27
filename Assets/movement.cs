using UnityEngine;

public class movement : MonoBehaviour
{
    private SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Ready To Move!");
      void awake()
        {
            sr = GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5f; 
        float step = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.up * step);
        if (Input.GetKey (KeyCode.S))
            transform.Translate (Vector2.down * step);
        if (Input.GetKey (KeyCode.A))
            transform.Translate (Vector2.left * step);
        if (Input.GetKey (KeyCode.D))
            transform.Translate (Vector2.right * step);

        if (Input.GetKeyDown(KeyCode.Q))
            transform.Rotate(Vector2.left * 10);
        if (Input.GetKeyDown(KeyCode.E))
            transform.Rotate(Vector2.right * 10);

        if (Input.GetKeyUp(KeyCode.R))
        {
            float r = Random.value;
            float g = Random.value;
            float b = Random.value;
            sr.color = new Color (r, g, b);
        }
    }
}
