using UnityEngine;

namespace tom
{
    /// <summary>
    /// 學習列舉   Enumerator
    /// </summary>
    public class LearnEunm : MonoBehaviour
    {
        /// 1.定義列舉類容
        /// 2.定義欄位列舉
        /// 選項1 選項2 選項3
        public enum Season
        {
            Spring,Summer,Fall,Winter  
        }
        public Season season;

        public Season season1 = Season.Summer;
    }
}
