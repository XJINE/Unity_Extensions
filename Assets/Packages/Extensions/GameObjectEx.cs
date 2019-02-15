using UnityEngine;

public static class GameObjectEx
{
    #region Field

    private static int NameIdColor;

    #endregion Field

    #region Constructor

    static GameObjectEx()
    {
        GameObjectEx.NameIdColor = Shader.PropertyToID("_Color");
    }

    #endregion Constructor

    #region Extension

    public static void RemoveComponent<T>(this GameObject gameObject) where T : Component
    {
        GameObject.Destroy(gameObject.GetComponent<T>());
    }

    public static void RemoveAllComponent(this GameObject gameObject)
    {
        Component[] components = gameObject.GetComponents<Component>();

        for (int i = 0; i < components.Length; i++)
        {
            GameObject.Destroy(components[i]);
        }
    }

    public static void SetColor(this GameObject gameObject, Color color)
    {
        MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();

        Renderer renderer = gameObject.GetComponent<Renderer>();

        renderer.GetPropertyBlock(materialPropertyBlock);

        materialPropertyBlock.SetColor(GameObjectEx.NameIdColor, color);

        renderer.SetPropertyBlock(materialPropertyBlock);
    }

    #endregion Extension
}