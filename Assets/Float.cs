using UnityEngine;
using System.Collections;

public class Float : MonoBehaviour
{
    public bool isFloatingUp;
    public bool isFloatingDown;

    public float floatSpeed;

    public void Update()
    {
        if (isFloatingUp)
        {
            FloatUp();
        }

        if (isFloatingDown)
        {
            if (transform.position.y >=0)
            {
                FloatDown();
            }
        }
    }
    public void FloatUp()
    {
        transform.Translate(Vector3.up * Time.deltaTime / floatSpeed, 0);
    }

    public void FloatDown()
    {
        transform.Translate(Vector3.down * Time.deltaTime / floatSpeed, 0);
    }
}
