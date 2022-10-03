using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC5
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_money = new int[19]
            {

            };

            int[,] ia_2DArr = new int[3, 3]
            {
                {7,8,9 },
                {1,4,3 },
                {2,5,6 },
            };

            mt_GetMost(ia_2DArr, ia_money);

            int mt_GetMost(int[,] ia_2DArr, int[,] ia_money)
            {
                int i_maxmoney = 0;
                int i_maxsum = 0;

                for (int i_Row)
            }
        }
    }
}