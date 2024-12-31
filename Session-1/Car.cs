using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1
{
    internal class Car
    {
        #region Attributes
        private int id;
        private int speed;
        private string model;
        #endregion

        #region Properties
        public int Id
        {
            get { return Id; }
            set { id = value; }
        }

        public int Speed
        {
            get { return Speed; }
            set { speed = value; }
        }
        public string Model
        {
            get { return Model; }
            set { model = value; }
        }
        #endregion

        public Car(int id,int speed,string model):this(id,speed)
        {
            Model = model;
        }
        public Car(int id,int speed):this(id)
        {
            Speed = speed;
        }public Car(int id)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $"Id:{Id} :: Speed:{Speed} :: Model: {Model}";
        }
    }
}
