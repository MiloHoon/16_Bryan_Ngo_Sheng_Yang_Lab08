using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private float yLimit = 3.9f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);

        if (transform.position.y < -yLimit)
        {
            transform.position = new Vector3(transform.position.x, -yLimit, transform.position.z);
        }
        else if (transform.position.y > yLimit)
        {
            transform.position = new Vector3(transform.position.x, yLimit, transform.position.z);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}