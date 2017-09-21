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
        public MyComplex(double real, double imagine)
        {
            Real_ = real;
            Imagine_ = imagine;
            Phase_ = Math.Atan(Math.Abs(Imagine_) / Math.Abs(Real_));
            Madnitude_ = Math.Sqrt(Math.Pow(Real_, 2) + Math.Pow(Imagine_, 2));
            if (Real_ < 0 && Imagine_ > 0) //2
            {
                Phase_ += Math.PI / 2;
            }
            if (Real_ < 0 && Imagine_ < 0)  //3
            {
                Phase_ += Math.PI;
            }
            if (Real_ > 0 && Imagine_ < 0) //4
            {
                Phase_ += Math.PI * 1.5;
            }
        }

        private double Real_;
        private double Imagine_;
        private double Phase_;
        private double Madnitude_;

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
                Imagine_ = Madnitude_ * Math.Sin(Phase_);
                Real_ = Madnitude_ * Math.Cos(Phase_);


                //if (Phase_ > Math.PI / 2 && Phase_ < Math.PI)  //2
                //{

                //    Real_ *= -1;
                //}
                //if (Phase_ > Math.PI && Phase_ < Math.PI * 1.5)  //3
                //{
                //    Imagine_ *= -1;
                //    Real_ *= -1;
                //}
                //if (Phase_ > Math.PI * 1.5 && Phase_ < Math.PI * 2) //4
                //{
                //    Imagine_ *= -1;

                //}

                //Phase_ = value;  
                //if(Phase_ > 0 && Phase_ < Math.PI/2)    //1
                //{
                //Imagine_ = Madnitude_ * Math.Sin(Phase_);
                //Real_ = Madnitude_ * Math.Cos(Phase_);  
                //}
                //if (Phase_ > Math.PI/2 && Phase_ < Math.PI )  //2
                //{
                //    Imagine_ = Madnitude_ * Math.Sin(Phase_- Math.PI / 2);
                //    Real_ = Madnitude_ * Math.Cos(Phase_- Math.PI / 2) * -1;
                //}
                //if (Phase_ > Math.PI && Phase_ < Math.PI * 1.5)  //3
                //{
                //    Imagine_ = Madnitude_ * Math.Sin(Phase_ - Math.PI) * -1;
                //    Real_ = Madnitude_ * Math.Cos(Phase_ - Math.PI) * -1;
                //}
                //if (Phase_ > Math.PI * 1.5 && Phase_ < Math.PI * 2) //4
                //{
                //    Imagine_ = Madnitude_ * Math.Sin(Phase_ - Math.PI * 1.5) *-1;
                //    Real_ = Madnitude_ * Math.Cos(Phase_ - Math.PI * 1.5);
                //}    
            }
        }
    }
}
