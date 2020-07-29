using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_App
{

    public class HomeMasterPageMasterMenuItem
    {
        public HomeMasterPageMasterMenuItem()
        {
            TargetType = typeof(HomeMasterPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}