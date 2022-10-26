using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_term_ver1._0
{
    internal class GlobalVar
    {
        public static List<List<string>> G_member_SignUp = new List<List<string>> ();
        public static int G_user_permission = 1;//member = 1, clerk = 2 
        public static Hashtable G_user_info = new Hashtable();//登入者身分
        //public static int G_puffprice;
        public static ArrayList G_puff = new ArrayList ();
        
    }
}
