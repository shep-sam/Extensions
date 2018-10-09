using UnityEngine;

namespace Extensions
{
    public static class SpriteExtension
    {
        public static Vector2 GetPivot(this Sprite sprite)
        {
            var pivot = sprite.pivot;
            var size = sprite.textureRect.size;

            return new Vector2(pivot.x / size.x, pivot.y / size.y);
        } 
    }
}
