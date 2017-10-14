using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    class CargoPlane {

        public CargoPlane(int planeNumber, string company, int mileagePerTank, int seatCapacity, int weightLbsCapacity) {
            this.PlaneNumber = new PrimaryKey(planeNumber);
            this.Company = company;
            this.MileagePerTank = mileagePerTank;
            this.SeatCapacity = seatCapacity;
            this.WeightLbsCapacity = weightLbsCapacity;
        }

        public PrimaryKey PlaneNumber {
            get; set;
        }

        public string Company {
            get; set;
        }

        public int MileagePerTank {
            get; set;
        }

        public int SeatCapacity {
            get; set;
        }

        public int WeightLbsCapacity {
            get; set;
        }
    }
}
