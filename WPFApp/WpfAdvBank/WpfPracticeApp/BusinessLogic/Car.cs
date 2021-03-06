using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfPracticeApp.BusinessLogic
{
    public class Car : Notifier
    {
        private double speed;
        private Color mainColor;

        public double Speed {
            get { return speed; }
            set 
            {
                if (value > 350) speed = 350;
                else speed = value;
                OnPropertyChanged("Speed"); // 속성 값 변경을 알려줌
            }
        }  

        
        public Color MainColor {
            get { return mainColor; }
            set 
            {
                mainColor = value;
                OnPropertyChanged("MainColor");
            } 
        }

        public Human Driver { get; set; }
    }

    public class Human
    {
        public string Name { get; set; }
        public bool HasDriveLicense { get; set; }
    }
}
