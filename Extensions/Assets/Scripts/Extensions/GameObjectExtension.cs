using UnityEngine;

namespace Extensions
{
    public static class GameObjectExtension
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
        }

        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() != null;
        }

        public static void SetParent(this GameObject gameObject, GameObject parent)
        {
            gameObject.transform.parent = parent.transform;
        }

        public static void SafeDestroy(this GameObject gameObject)
        {
            if (gameObject != null)
                Object.Destroy(gameObject);
            else
                Debug.LogWarning("GameObjectExtension | SafeDestroy: GameObject == NULL");
            
        }
    }
}
