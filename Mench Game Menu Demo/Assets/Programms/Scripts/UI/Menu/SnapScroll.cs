using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI; 

namespace Menu
{
    /// <summary>
    /// کلاس صفحه کشیدنی که برای عوض کردن صفحه با کشیدن دست اجام میشه
    /// </summary>
    public class SnapScroll : MonoBehaviour
    {
        [SerializeField]
        private RectTransform List;//لیستی که محتواها زیر مجموعه اون میشن
        [SerializeField]
        private RectTransform Center; //نقطه مرکزی که میخوایم صفحه از اون جا شروع به محاسبه فاصله صفحه هات بکنه
        [SerializeField]
        private ScrollRectElite Scrollrect;

        /// <summary>
        /// سرعت حرکت جا به جایی بین صفحه ها
        /// </summary>
        public float ScrollSpeed = 10;//سرعت جا به جایی صفحه ها
        public uint TargetContentIndex;
        /// <summary>
        /// فاصله هر محتوا نسبت به هم
        /// </summary>
        public uint ContentDistance = 100; //سایز به پیکسل

        RectTransform[] Contents; // محتوا ها

        /// <summary>
        /// مشخص میکند که ایا کار بر دارد صفحه را میکشد یا خیر
        /// </summary>
        bool isDragging;
        uint ContentsSize;

        float[] ContentDistancs;
        float DistancebetweenToContents;

        void OnEnable()
        {
            Refresh();
        }
        void Update()
        {
            if (IsDragging())
            {
                getContentsDistanc();
                GetTargetIndext();
            }
            else
            {
                MoveToContent(TargetContentIndex);
            }
        }

        void GetContent()
        {
            for (int i = 0; i < ContentsSize; i++)
            {
                Contents[i] = List.transform.GetChild(i).gameObject.GetComponent<RectTransform>();
            }
        }
        void SetDistancToContents(uint D)
        {
            for (int i = 1; i < Contents.Length; i++)
            {
                float X = Contents[i - 1].anchoredPosition.x + D;
                Contents[i].anchoredPosition = new Vector2(X, Contents[i].anchoredPosition.y);
            }
        }
        void getContentsDistanc()
        {
            for (int i = 0; i < ContentsSize; i++)
            {
                float x = Center.transform.position.x - Contents[i].transform.position.x;
                ContentDistancs[i] = Mathf.Abs(x);
            }
        }
        void GetTargetIndext()
        {
            float minDistance = Mathf.Min(ContentDistancs);

            for (int i = 0; i < ContentsSize; i++)
            {
                if (ContentDistancs[i] == minDistance)
                {
                    TargetContentIndex = (uint)i;
                }
            }
        }
        /// <summary>
        /// به پنلی با یک اندیس حرکت میکند و اسکرول میشود
        /// </summary>
        /// <param name="Index">اندیس پنل</param>
        void MoveToContent(uint Index)
        {
            if (Index+1 <= ContentDistancs.Length)
            {
                float targetX = 0.0f;
                float x = 0.0f;

                targetX = -(DistancebetweenToContents * Index);
                x = List.anchoredPosition.x;

                if ((int)x != (int)targetX)
                {
                    Vector2 TargetPos = new Vector2(Mathf.Lerp(x, targetX, Time.deltaTime * ScrollSpeed), List.anchoredPosition.y);
                    List.anchoredPosition = TargetPos;
                }
            }
        }

        bool IsDragging()
        {
            return Scrollrect.IsDragging ;
        }

        public void SetTargetContent(uint index)
        {
            TargetContentIndex = index;
        }
        public void Refresh()
        {
            ContentsSize = (uint)List.transform.childCount;
            Contents = new RectTransform[ContentsSize];
            ContentDistancs = new float[ContentsSize];

            GetContent();
            SetDistancToContents(ContentDistance);

            try
            {
                DistancebetweenToContents = (Contents[1].anchoredPosition.x - Contents[0].anchoredPosition.x);
            }
            catch
            {
            }

        }
    }
}
