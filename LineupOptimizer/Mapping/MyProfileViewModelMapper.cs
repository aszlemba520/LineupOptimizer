using LineupOptimizer.Mvc.Models.MyProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineupOptimizer.Mapping
{
    public static class MyProfileViewModelMapper
    {
        public static MyProfileViewModel Build()
        {
            return new MyProfileViewModel();
        }

    }
}
