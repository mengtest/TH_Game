using UnityEngine;

namespace Mvc2
{
    //纯视图接口，需要通过一个gameObject才能够生成这个的实例对象
    //所以是无法直接创建IMvcView的
    public interface IMvcView
    {
        IMvcView CreateWithGameObject(GameObject go);
    }
}