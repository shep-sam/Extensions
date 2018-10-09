
using UnityEngine;

namespace Extensions
{
    public static class TransformExtension
    {
        public static void ResetTransform(this Transform transform)
        {
            transform.position      = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale    = Vector3.one;
        }

        public static void SetChildLayers(this Transform transform, string layerName, bool recursive = false)
        {
            var layer = LayerMask.NameToLayer(layerName);
            SetChildLayersHelper(transform, layer, recursive);
        }

        public static void SetChildLayersHelper(Transform transform, int layer, bool recursive = false)
        {
            foreach (Transform child in transform)
            {
                child.gameObject.layer = layer;

                if (recursive)
                {
                    SetChildLayersHelper(child, layer, recursive);
                }
            }
        }
    }
}
