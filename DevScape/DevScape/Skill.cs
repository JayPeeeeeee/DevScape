using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    public abstract class Skill
    {
        private int rating;
        public int Rating
        {
            get
            {
                return rating;
            }
            private set
            {
                if((value >= 0) && (value <= 100))
                {
                    rating = value;
                }
                else
                {
                    if(value > 100)
                    {
                        rating = 100;
                    }
                    else
                    {
                        rating = 0;
                    }
                }
            }
        }

        public double Stars
        {
            get
            {
                return (int)((Rating / 5.0 + 0.5)) / 4.0;
            }
            private set
            {
                if((value >= 0) && (value <= 5))
                {
                    Rating = (int)((value / 0.25) + 0.5) * 5;
                }
                else
                {
                    if(value > 5)
                    {
                        Rating = 100;
                    }
                    else
                    {
                        Rating = 0;
                    }
                }
            }
        }

        public Skill(int rating)
        {
            Rating = rating;
        }

        public Skill(double stars)
        {
            Stars = stars;
        }

        public void Upgrade(int rate)
        {
            Rating = Rating + rate;
        }

        public void Upgrade(double stars)
        {
            Rating = Rating + (int)(stars * 20);
            //this.Stars = this.Stars + stars;
        }

        public void Downgrade(int rate)
        {
            Rating = Rating - rate;
        }

        public void Downgrade(double stars)
        {
            Rating = Rating - (int)(stars * 20);
            //this.Stars = this.Stars - stars;
        }

        public override string ToString()
        {
            return string.Format("Rating: {0}/100\nStars: {1}", Rating, Stars);
        }
    }
}
