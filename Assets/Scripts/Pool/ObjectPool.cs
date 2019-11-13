using UnityEngine;

namespace Pool
{
    public class ObjectPool : BasePool<GameObject>
    {
        public ObjectPool(int maxSize) 
            : base(maxSize)
        {
            
        }
    }
}