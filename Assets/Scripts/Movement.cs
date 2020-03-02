using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Basic_Movement
{
public class Movement : MonoBehaviour
{
    #region Variables

    [Header("Physics")]

    public float speed = 10f;


    #endregion
    // Start is called before the first frame update
    void Start()
    {

    }
    #region set movement

    private void FixedUpdate()
    {
        Vector3 targetLocation = new Vector3(-40, 0, 0);
        Vector3 playerLocation = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.MoveTowards(playerLocation, new Vector3(10000, 0), speed * Time.deltaTime);

        if (playerLocation.x >= 100f)
        {
            speed = 0;
        }
        #endregion
    }
}

#region Comments/failed code
//(Vector3.MoveTowards(playerLocation, new Vector3(-50, 0), speed * Time.deltaTime));

// while (playerLocation.x == 39f);

/* if (Vector3.Distance(playerLocation,targetLocation) <0.001f)
 {
     targetLocation.x *= -1.0f;
 }
 */
/* if (Input.GetKey(KeyCode.L))
{
    transform.position = Vector3.MoveTowards(playerLocation, new Vector3(-41, 0), speed * Time.deltaTime);
}
*/
/* if(playerLocation.x == 40f)
{
    Vector3.MoveTowards(transform.position, new Vector3(-100, 0), speed * Time.deltaTime);
}
*/
//transform.forward(transform.position * speed * Time.deltaTime, 0);



//  transform.position = new Vector3(10.0f, transform.position.y, transform.position.z);
//new Vector3(transform.position.x * speed * Time.deltaTime, 0);

//transform.position.x += playerLocation;

//Vector3 playerLocation;
//  Vector3 playerposition;
//  gameObject.transform.position += playerposition;
// transform.position = playerposition;
// gameObject.transform.position = Vector3.MoveTowards(playerposition,new Vector3(1000,0,0),transform.position.x * speed * Time.deltaTime);
//public Vector3 target;
#endregion
}
