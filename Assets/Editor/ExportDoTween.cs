using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using FairyGUI;

namespace Editor
{
    public static class ExportDoTween
    {
        [LuaCallCSharp]
        [CSharpCallLua]
        [ReflectionUse]
        public static List<Type> dotween_lua_call_cs_list = new List<Type>()
        {
            typeof(DG.Tweening.AutoPlay),
            typeof(DG.Tweening.AxisConstraint),
            typeof(DG.Tweening.Ease),
            typeof(DG.Tweening.LogBehaviour),
            typeof(DG.Tweening.LoopType),
            typeof(DG.Tweening.PathMode),
            typeof(DG.Tweening.PathType),
            typeof(DG.Tweening.RotateMode),
            typeof(DG.Tweening.ScrambleMode),
            typeof(DG.Tweening.TweenType),
            typeof(DG.Tweening.UpdateType),
            typeof(DG.Tweening.DOTweenModuleUI),
            typeof(DG.Tweening.DOTween),
            typeof(DG.Tweening.DOVirtual),
            typeof(DG.Tweening.EaseFactory),
            typeof(DG.Tweening.Tweener),
            typeof(DG.Tweening.Tween),
            typeof(DG.Tweening.Sequence),
            typeof(DG.Tweening.TweenParams),
            typeof(DG.Tweening.Core.ABSSequentiable),
            // typeof(DG.Tweening.Tweener)
            typeof(DG.Tweening.Core.TweenerCore<Vector3, Vector3, DG.Tweening.Plugins.Options.VectorOptions>),

            typeof(DG.Tweening.TweenCallback),
            typeof(DG.Tweening.TweenExtensions),
            typeof(DG.Tweening.TweenSettingsExtensions),
            typeof(DG.Tweening.ShortcutExtensions),
            typeof(DG.Tweening.Core.Extensions),
            // typeof(DG.Tweening.CustomPlugins.PureQuaternionPlugin),
            
            // typeof()
            // typeof(DG.Tweening.ShortcutExtensions43),
            // typeof(DG.Tweening.ShortcutExtensions46),
            // typeof(DG.Tweening.ShortcutExtensions50),
   
            //dotween pro 的功能
            //typeof(DG.Tweening.DOTweenPath),
            //typeof(DG.Tweening.DOTweenVisualManager),
            
            (typeof(EventContext)),
            (typeof(EventDispatcher)),
            (typeof(EventListener)),
            (typeof(InputEvent)),
            (typeof(DisplayObject)),
            (typeof(Container)),
            (typeof(Stage)),
            (typeof(Controller)),
            (typeof(GObject)),
            (typeof(GGraph)),
            (typeof(GGroup)),
            (typeof(GImage)),
            (typeof(GLoader)),
//            (typeof(PlayState)),
            (typeof(GMovieClip)),
            (typeof(TextFormat)),
            (typeof(GTextField)),
            (typeof(GRichTextField)),
            (typeof(GTextInput)),
            (typeof(GComponent)),
            (typeof(GList)),
            (typeof(GRoot)),
            (typeof(GLabel)),
            (typeof(GButton)),
            (typeof(GComboBox)),
            (typeof(GProgressBar)),
            (typeof(GSlider)),
            (typeof(PopupMenu)),
            (typeof(ScrollPane)),
            (typeof(Transition)),
            (typeof(UIPackage)),
            (typeof(Window)),
            (typeof(GObjectPool)),
            (typeof(Relations)),
            (typeof(RelationType)),
        };
    }
}