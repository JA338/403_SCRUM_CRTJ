using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Mediator
    {
        public bool sharedValue = false;
        public Mediator()
        {
            sharedValue = false;
        }

        public bool GetSharedValue()
        {
            return sharedValue;
        }

        public void SetSharedValue(bool value)
        {
            sharedValue = value;
        }
    }

}