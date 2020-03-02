using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    #region Variables
    public class Pathfinder : MonoBehaviour
    {
        #region Variables
        [Header("Waypoint Variables")]
        public int CurrentWaypoint;
        public GameObject[] Waypoint1;

        [Header("Movement Variables")]
        public float speed;
        #endregion


        #endregion
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        #region Waypoints
        void Update()
        {
            if (CurrentWaypoint >= Waypoint1.Length)
            {
                CurrentWaypoint = 0;
            }

            transform.position = Vector3.MoveTowards(transform.position, Waypoint1[CurrentWaypoint].transform.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, Waypoint1[CurrentWaypoint].transform.position) < 0.01f) ;
            {
                CurrentWaypoint = CurrentWaypoint + 1;
            }
        }
        #endregion
    }

}
