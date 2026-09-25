using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    void Update()
    {
        Vector3 viewportPos = Camera.main.WorldToViewportPoint(transform.position);

        // margem de folga pra garantir que já saiu totalmente
        if (viewportPos.y < -0.2f || viewportPos.y > 1.2f ||
            viewportPos.x < -0.2f || viewportPos.x > 1.2f)
        {
            Destroy(gameObject);
        }
    }
}