using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace _64QAM
{
    public class MyComplex
    {
        public MyComplex()
        {

        }
        public MyComplex(double real, double imagine, byte point)
        {
            Real_ = real;
            Imagine_ = imagine;
            Phase_ = Math.Atan(Imagine_ / Real_);
            Madnitude_ = Math.Sqrt(Math.Pow(Real_, 2) + Math.Pow(Imagine_, 2));
            point_ = point;
            if (Real_ < 0 && Imagine_ > 0) //2
            {
                Phase_ += Math.PI ;
            }
            if (Real_ < 0 && Imagine_ < 0)  //3
            {
                Phase_ -= Math.PI;
            }
            //if (Real_ > 0 && Imagine_ < 0) //4
            //{
            //    Phase_ += Math.PI * 1.5;
            //}
        }

        private double Real_;
        private double Imagine_;
        private double Phase_;
        private double Madnitude_;
        byte point_;

        public double Real
        {
            get
            {
                return Real_;
            }
            set
            {
                Real_ = value;
                var faza1 = Math.Atan(Imagine_ / Real_);
                Madnitude_ = Math.Sqrt(Math.Pow(Real_, 2) + Math.Pow(Imagine_, 2));
                if (value > 0)   //1 4
                {
                    Phase_ = faza1;
                }
                else  // 2 3
                {
                    Phase_ = Math.PI + faza1;
                }
            }
        }
        public double Imagine
        {
            get
            {
                return Imagine_;
            }
            set
            {
                Imagine_ = value;
                var faza1 = Math.Atan(Imagine_ / Real_);
                Madnitude_ = Math.Sqrt(Math.Pow(Real_, 2) + Math.Pow(Imagine_, 2));
                if (Real_ > 0)   //1 4
                {
                    Phase_ = faza1;
                }
                else  // 2 3
                {
                    Phase_ = Math.PI + faza1;
                }
            }
        }
        public double Phase
        {
            get
            {
                return Phase_;
            }
            set
            {
                Phase_ = value;
                Console.WriteLine("P: R=" + Real_ + " I=" + Imagine_ + " P=" + Phase_);
                Imagine_ = Madnitude_ * Math.Sin(Phase_);
                Real_ = Madnitude_ * Math.Cos(Phase_);
               
              
        
            Console.WriteLine("W: R=" + Real_ + " I=" + Imagine_ + " P="+Phase_);

            }


        }
        public double modul { get { return Madnitude_; } }
    }
}
