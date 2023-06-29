using UnityEngine;

public class ChangeColors : MonoBehaviour
{
   private MeshRenderer _mesh;
   private void Awake() {
    _mesh = GetComponent<MeshRenderer>();
   }
   private void Update() {
    if(Input.GetKeyDown(KeyCode.G))
    _mesh.material.color = Color.blue;
    if(Input.GetKeyDown(KeyCode.Y))
    _mesh.material.color = Color.grey;
    if(Input.GetKeyDown(KeyCode.N))
    _mesh.material.color = Color.red;
    
    }
}
