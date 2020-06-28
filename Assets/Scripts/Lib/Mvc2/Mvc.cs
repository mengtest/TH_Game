using UnityEngine;

namespace Mvc2
{
    public class Mvc
    {
        //现在修改mvc为通过Controller关联所有的View以及Model
        //现在更加希望Model是一个lua对象，
        //view就是一个Mono
        //Controller就是一个普通的类
        
        //通过Controller、Model、GameObject创建一个View
        public IMvcView Create(IMvcController controller, IMvcModel model, GameObject go)
        {
            
            return null;
        }
    }
}