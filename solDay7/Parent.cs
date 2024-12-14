using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solDay7
{
    public class Parent
    {
        #region arrirbute
        private int x;
        private int y;
        #endregion

        #region property
        public int X
        {
            get { return x; }
            set { x = value; }
        }


        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        #endregion

        #region constructor
        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        } 
        public Parent()
        {

        }
        #endregion

        public virtual int product(int x,int y)
        {
            return x * y;
        }

        public override string ToString()
        {
            return $"x = {X} , y = {Y}";
        }




    }
}
