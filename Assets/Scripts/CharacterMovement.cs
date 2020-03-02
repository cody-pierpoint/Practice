using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{

    public class CharacterMovement : MonoBehaviour
    {
        #region Variables
       
        [Header("Movement Variables")]
        public float speed;
        private Rigidbody RB;




        #endregion
        // Start is called before the first frame update
        void Start()
        {
            RB = GetComponent<Rigidbody>();
            
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);

            RB.AddForce(movement * speed);
        }


    }

}
