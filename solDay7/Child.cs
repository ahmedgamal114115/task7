using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solDay7
{
    public class Child:Parent
    {
        public Child()
        {

        }
        private int z;

		public int Z
		{
			get { return z; }
			set { z = value; }
		}
		public Child(int x,int y,int z):base(x,y) 
		{
			this.z = z; 		
		}


		//public new int product(int x, int y)
		//{
		//	return x * y * z;
		//}
		public override int product(int x, int y)
		{
			return 2 * x * y;
		}
        public override string ToString()
        {
            return $"x = {X} , y = {Y} , z = {Z}";
        }


    }
}
