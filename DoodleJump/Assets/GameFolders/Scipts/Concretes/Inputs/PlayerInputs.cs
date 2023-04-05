using UnityEngine;

namespace DoodleJump.Inputs
{
    public class PlayerInputs : MonoBehaviour
    {

        public float Direction { get; private set; }
        public bool Shoot { get; private set; }
        
        private void Update()
        {
            Direction = Input.GetAxis("Horizontal");
            Shoot = Input.GetKeyDown(KeyCode.Space);
        }
    }
}

