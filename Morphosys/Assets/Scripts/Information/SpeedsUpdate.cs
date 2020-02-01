using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class SpeedsUpdate : MonoBehaviour
{
    public Rigidbody2D Target;
    
    void Update()
    {
        GetComponent<Text>().text = Target.velocity.ToHudString();
    }
}
