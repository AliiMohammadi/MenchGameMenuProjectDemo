using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Menu
{
    /// <summary>
    /// کلاس اسکرول رکت سفارشی که جهت رفع مشکل لیست عمودی داخل یک پنل وجود داشت , تشکیل شد
    /// </summary>
    public class ScrollRectElite : ScrollRect
    {
        public ScrollRect parentScroll;
        public bool IsDragging;
        bool routeToParent;

        public override void OnBeginDrag(PointerEventData eventData)
        {
            if (!horizontal && Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y) * 1.5f)
                routeToParent = true;
            else if (!vertical && Mathf.Abs(eventData.delta.x) < Mathf.Abs(eventData.delta.y))
                routeToParent = true;
            else
                routeToParent = false;

            if (routeToParent)
            {
                parentScroll.OnBeginDrag(eventData);//اسکرول اصلی
            }
            else
                base.OnBeginDrag(eventData);//اسکرول پنل

            IsDragging = true;
        }
        public override void OnDrag(PointerEventData eventData)
        {

            if (routeToParent)
            {
                parentScroll.OnDrag(eventData);//اسکرول اصلی
            }
            else
                base.OnDrag(eventData);//اسکرول پنل
        }
        public override void OnEndDrag(PointerEventData eventData)
        {

            if (routeToParent)
            {
                parentScroll.OnEndDrag(eventData);//اسکرول اصلی
            }
            else
                base.OnEndDrag(eventData);//اسکرول پنل

            IsDragging = false;

        }
    }
}
