using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class Page3FlyoutMenuItem
    {
        public Page3FlyoutMenuItem()
        {
            TargetType = typeof(Page3FlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}