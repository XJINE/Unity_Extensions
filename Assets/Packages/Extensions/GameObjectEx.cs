using UnityEngine;

public static class GameObjectEx
{
    public static void RemoveComponent<T>(this GameObject self) where T : Component
    {
        GameObject.Destroy(self.GetComponent<T>());
    }

    public static void RemoveAllComponent(this GameObject self)
    {
        Component[] components = self.GetComponents<Component>();

        for (int i = 0; i < components.Length; i++)
        {
            GameObject.Destroy(components[i]);
        }
    }

    public static void SetColor(this GameObject self, Color color)
    {
        MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();

        Renderer renderer = self.GetComponent<Renderer>();

        renderer.GetPropertyBlock(materialPropertyBlock);

        materialPropertyBlock.SetColor("_Color", color);

        renderer.SetPropertyBlock(materialPropertyBlock);
    }
}