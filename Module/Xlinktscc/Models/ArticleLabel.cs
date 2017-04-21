using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xlinktscc.Models
{
    public class ArticleLabel
    {
        private List<string> lableList;

        public ArticleLabel()
        {
            lableList = new List<string>();
        }

        public void AddLabel(string label)
        {
            string newlabel = label;
            lableList.Add(newlabel);
        }

        /// <summary>
        /// 清空标签列表
        /// </summary>
        public void  ReleaseLabelList()
        {
            if (lableList!=null && lableList.Count>0)
            {
                for (int i = 0; i < lableList.Count; i++)
                {
                    lableList.RemoveAt(i);
                }
                
            }
            else
            {
                if (lableList==null)
                {
                    lableList = new List<string>();
                }
            }

        }
    }
}