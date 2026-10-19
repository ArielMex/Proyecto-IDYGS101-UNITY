using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;
    private CambioColor scriptColor;

    void Start()
    {
        scriptColor = GetComponent<CambioColor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            scriptColor.CambiarColor(Color.red);
        }

        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            scriptColor.CambiarColor(Color.blue);
        }

        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            scriptColor.CambiarColor(Color.green);
        }

        if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            scriptColor.CambiarColor(Color.yellow);
        }
    }
}