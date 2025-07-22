using UnityEngine;

public class WASD : MonoBehaviour
{
    
    
        public float moveSpeed = 5f;

        void Update()
        {
            float h = Input.GetAxis("Horizontal"); // A(-1) ©¨ D(+1)
            float v = Input.GetAxis("Vertical");   // S(-1) «ª W(+1)

            Vector3 move = new Vector3(v, 0,h ); // x•ûŒü‚Æz•ûŒü
            transform.Translate(move * moveSpeed * Time.deltaTime);
        }
    

}
