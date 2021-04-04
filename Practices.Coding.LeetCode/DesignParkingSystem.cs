using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class DesignParkingSystem
    {
        /***
         * 
         * https://leetcode.com/problems/design-parking-system/submissions/
         * 
         * 
         */
        internal class ParkingSystem
        {

            int _bigcarslots = 0;
            int _mediumcarslots = 0;
            int _smallcarslots = 0;

            public ParkingSystem(int big, int medium, int small)
            {

                _bigcarslots = big;
                _mediumcarslots = medium;
                _smallcarslots = small;
            }

            public bool AddCar(int carType)
            {

                switch (carType)
                {
                    case 1:
                        if (_bigcarslots == 0)
                            return false;
                        else
                        {
                            _bigcarslots--;
                            return true;
                        }
                        break;
                    case 2:
                        if (_mediumcarslots == 0)
                            return false;
                        else
                        {
                            _mediumcarslots--;
                            return true;
                        }
                        break;
                    case 3:
                        if (_smallcarslots == 0)
                            return false;
                        else
                        {
                            _smallcarslots--;
                            return true;
                        }
                        break;
                    default:
                        return false;
                        break;
                }

                return false;
            }
        }

        /**
         * Your ParkingSystem object will be instantiated and called as such:
         * ParkingSystem obj = new ParkingSystem(big, medium, small);
         * bool param_1 = obj.AddCar(carType);
         */
    }
}
